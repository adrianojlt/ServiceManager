using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceManager
{
	public partial class ServiceForm : Form
	{

		private ServiceController[] services;

		// used to count services
		private int numTotalSrv, numRunningSrv, numStoppedSrv;

		public const string SEARCH_FILTER_ALL = "All";
		public const string SEARCH_FILTER_FULLNAME = "Full Name";
		public const string SEARCH_FILTER_SHORTNAME = "Short Name";

		private enum SearchByMode
		{
			all,
			fullName,
			shortName
		}

		private SearchByMode activeSearchBy;

		public ServiceForm()
		{
			InitializeComponent();
			init();
		}

		public void init()
		{

			this.loadServices();

			string[] columns = new string[3];
			columns[0] = SEARCH_FILTER_ALL;
			columns[1] = SEARCH_FILTER_FULLNAME;
			columns[2] = SEARCH_FILTER_SHORTNAME;
			//this.searchBy.Items.AddRange(columns);
			//this.searchBy.SelectedIndex = 0;

			activeSearchBy = SearchByMode.all;

			ToolTip toolTip = new ToolTip();
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ShowAlways = true;
			toolTip.SetToolTip(this.refreshButton, "Refresh List");
			toolTip.SetToolTip(this.lblBlueStatus, "All Services");
			toolTip.SetToolTip(this.lblGreenStatus, "Running Services");
			toolTip.SetToolTip(this.lblRedStatus, "Stopped Services");
			toolTip.SetToolTip(this.lblTotalSrv, "All Services");
			toolTip.SetToolTip(this.lblRunSrv, "Running Services");
			toolTip.SetToolTip(this.lblStoSrv, "Stopped Services");

		}

		private void loadServices()
		{
			this.services = ServiceController.GetServices();

			listServices.Items.Clear();

			numTotalSrv = numRunningSrv = numStoppedSrv = 0;

			foreach (var item in services)
			{
				ListViewItem listVitem = new ListViewItem(new string[] { item.ServiceName.ToString(), item.Status.ToString(), item.DisplayName });
				listVitem.Tag = item;
				listServices.Items.Add(listVitem);
				numTotalSrv++;

				if (item.Status.ToString().Equals("Running"))
					numRunningSrv++;

				if (item.Status.ToString().Equals("Stopped"))
					numStoppedSrv++;
			}

			lblTotalSrv.Text = Convert.ToString(numTotalSrv);
			lblRunSrv.Text = Convert.ToString(numRunningSrv);
			lblStoSrv.Text = Convert.ToString(numStoppedSrv);
		}

		public void tmp()
		{

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			this.searchFunction(txtSearch.Text);
		}

		private void searchFunction(string txt2search)
		{
			listServices.Items.Clear();

			foreach (ServiceController item in services)
			{
				if (txt2search.Equals(""))
				{
					ListViewItem listVitem = new ListViewItem(new string[] { item.ServiceName.ToString(), item.Status.ToString(), item.DisplayName });
					listVitem.Tag = item;
					listServices.Items.Add(listVitem);
				}
				else
				{
					switch (activeSearchBy)
					{
						case SearchByMode.all:

							if (item.DisplayName.ToUpper().Contains(txt2search.ToUpper()) || item.ServiceName.ToUpper().Contains(txt2search.ToUpper()))
							{
								ListViewItem listVitem = new ListViewItem(new string[] { item.ServiceName.ToString(), item.Status.ToString(), item.DisplayName });
								listVitem.Tag = item;
								listServices.Items.Add(listVitem);
							}
							break;
						case SearchByMode.fullName:

							if (item.DisplayName.ToUpper().Contains(txt2search.ToUpper()))
							{
								ListViewItem listVitem = new ListViewItem(new string[] { item.ServiceName.ToString(), item.Status.ToString(), item.DisplayName });
								listVitem.Tag = item;
								listServices.Items.Add(listVitem);
							}
							break;
						case SearchByMode.shortName:

							if (item.ServiceName.ToUpper().Contains(txt2search.ToUpper()))
							{
								ListViewItem listVitem = new ListViewItem(new string[] { item.ServiceName.ToString(), item.Status.ToString(), item.DisplayName });
								listVitem.Tag = item;
								listServices.Items.Add(listVitem);
							}
							break;
						default:

							break;
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.refreshServicesInTheList();
		}

		private void listServices_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point point = new Point(e.X, e.Y);
				listServices.PointToClient(point);

				// empty space selection ...
				if (listServices.SelectedItems.Count != 1) return;

				var selectedItem = listServices.SelectedItems[0];
				ServiceController service = selectedItem.Tag as ServiceController;

				switch (service.Status)
				{

					case ServiceControllerStatus.Running:
						if (service.CanPauseAndContinue)
						{
							menuPause.Enabled = true;
						}
						else
						{
							menuPause.Enabled = false;
						}
						menuPause.Enabled = true;
						if (service.CanStop)
						{
							menuStart.Enabled = true;
							menuRestart.Enabled = true;
						}
						else
						{
							menuStart.Enabled = false;
							menuRestart.Enabled = false;
						}
						menuPause.Text = "Pause";
						menuStart.Text = "Stop";
						break;

					case ServiceControllerStatus.Paused:
						if (service.CanPauseAndContinue)
							menuPause.Enabled = true;
						else
							menuPause.Enabled = false;
						menuStart.Enabled = false;
						menuRestart.Enabled = true;
						menuPause.Text = "Continue";
						menuStart.Text = "Start";
						break;

					case ServiceControllerStatus.Stopped:
						menuPause.Enabled = false;
						menuStart.Enabled = true;
						menuRestart.Enabled = false;
						menuStart.Text = "Start";
						break;

					case ServiceControllerStatus.StartPending:
						menuPause.Enabled = false;
						menuStart.Enabled = false;
						menuRestart.Enabled = false;
						break;

					case ServiceControllerStatus.PausePending:
						menuPause.Enabled = false;
						menuStart.Enabled = false;
						menuRestart.Enabled = false;
						break;

					case ServiceControllerStatus.StopPending:
						menuPause.Enabled = false;
						menuStart.Enabled = false;
						menuRestart.Enabled = false;
						break;

					case ServiceControllerStatus.ContinuePending:
						menuPause.Enabled = false;
						menuStart.Enabled = false;
						menuRestart.Enabled = false;
						break;

					default:
						break;
				}

				ctxMenu.Show(listServices, point);
			}
		}

		private void menuPause_Click(object sender, EventArgs e)
		{
			manageService(menuPause.Text);
		}

		private void menuStart_Click(object sender, EventArgs e)
		{
			manageService(menuStart.Text);
		}

		private void menuRestart_Click(object sender, EventArgs e)
		{
			manageService(menuRestart.Text);
		}

		private void manageService(string action)
		{
			var selectedItem = listServices.SelectedItems[0];
			ServiceController service = selectedItem.Tag as ServiceController;

			if (action.Equals("Start"))
			{
				try
				{
					service.Start();
					service.WaitForStatus(ServiceControllerStatus.Running);
					lblRunSrv.Text = Convert.ToString(++numRunningSrv);
					lblStoSrv.Text = Convert.ToString(--numStoppedSrv);
					refreshServicesInTheList();
				}
				catch (InvalidOperationException eInvalidOper)
				{
					MessageBox.Show(eInvalidOper.Message);
				}

				return;
			}

			if (action.Equals("Stop"))
			{
				if (!service.CanStop)
				{
					MessageBox.Show("cannot stop service!!!");
					return;
				}

				try
				{
					service.Stop();
					service.WaitForStatus(ServiceControllerStatus.Stopped);
					lblRunSrv.Text = Convert.ToString(--numRunningSrv);
					lblStoSrv.Text = Convert.ToString(++numStoppedSrv);
					refreshServicesInTheList();
				}
				catch (InvalidOperationException eInvalidOper)
				{
					MessageBox.Show(eInvalidOper.Message);
				}

				return;
			}

			if (action.Equals("Pause"))
			{
				if (!service.CanPauseAndContinue)
				{
					MessageBox.Show("cannot pause the service!!!");
					return;
				}

				try
				{
					service.Pause();
					service.WaitForStatus(ServiceControllerStatus.Paused);
					refreshServicesInTheList();
				}
				catch (InvalidOperationException eInvalidOper)
				{
					MessageBox.Show(eInvalidOper.Message);
				}

				return;
			}

			if (action.Equals("Continue"))
			{
				if (!service.CanPauseAndContinue)
				{
					MessageBox.Show("cannot pause the service!!!");
					return;
				}

				try
				{
					service.Continue();
					service.WaitForStatus(ServiceControllerStatus.Running);
					refreshServicesInTheList();
				}
				catch (InvalidOperationException eInvalidOper)
				{
					MessageBox.Show(eInvalidOper.Message);
				}

				return;
			}

			if (action.Equals("Restart"))
			{
				return;
			}
		}


		/// <summary>
		/// Refresh the state of all services in the list
		/// </summary>
		private void refreshServicesInTheList()
		{
			foreach (ListViewItem item in listServices.Items)
			{
				ServiceController service = item.Tag as ServiceController;
				listServices.Items.Remove(item); // ... try to avoid this later.
				service.Refresh();
				ListViewItem itemInTheList = new ListViewItem(new string[] { service.ServiceName.ToString(), service.Status.ToString(), service.DisplayName });
				itemInTheList.Tag = service;
				listServices.Items.Add(itemInTheList);
			}

			listServices.Refresh();
		}

		private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			refreshServicesInTheList();
		}
	}
}
