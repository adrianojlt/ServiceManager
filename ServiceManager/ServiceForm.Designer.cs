namespace ServiceManager
{
	partial class ServiceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.listServices = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblTotalSrv = new System.Windows.Forms.Label();
			this.lblRunSrv = new System.Windows.Forms.Label();
			this.lblStoSrv = new System.Windows.Forms.Label();
			this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRestart = new System.Windows.Forms.ToolStripMenuItem();
			this.lblBlueStatus = new System.Windows.Forms.Label();
			this.lblRedStatus = new System.Windows.Forms.Label();
			this.lblGreenStatus = new System.Windows.Forms.Label();
			this.refreshButton = new System.Windows.Forms.Button();
			this.ctxMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Location = new System.Drawing.Point(15, 12);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(651, 20);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// listServices
			// 
			this.listServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.listServices.FullRowSelect = true;
			this.listServices.Location = new System.Drawing.Point(15, 39);
			this.listServices.MultiSelect = false;
			this.listServices.Name = "listServices";
			this.listServices.Size = new System.Drawing.Size(651, 276);
			this.listServices.TabIndex = 4;
			this.listServices.UseCompatibleStateImageBehavior = false;
			this.listServices.View = System.Windows.Forms.View.Details;
			this.listServices.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listServices_MouseUp);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Tag = "1";
			this.columnHeader1.Text = "Short Name";
			this.columnHeader1.Width = 159;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Status";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 81;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Full Name";
			this.columnHeader3.Width = 300;
			// 
			// lblTotalSrv
			// 
			this.lblTotalSrv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotalSrv.AutoSize = true;
			this.lblTotalSrv.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalSrv.Location = new System.Drawing.Point(32, 329);
			this.lblTotalSrv.Name = "lblTotalSrv";
			this.lblTotalSrv.Size = new System.Drawing.Size(29, 17);
			this.lblTotalSrv.TabIndex = 9;
			this.lblTotalSrv.Text = "235";
			this.lblTotalSrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRunSrv
			// 
			this.lblRunSrv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblRunSrv.AutoSize = true;
			this.lblRunSrv.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRunSrv.Location = new System.Drawing.Point(87, 330);
			this.lblRunSrv.Name = "lblRunSrv";
			this.lblRunSrv.Size = new System.Drawing.Size(29, 17);
			this.lblRunSrv.TabIndex = 10;
			this.lblRunSrv.Text = "235";
			this.lblRunSrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblStoSrv
			// 
			this.lblStoSrv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblStoSrv.AutoSize = true;
			this.lblStoSrv.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStoSrv.Location = new System.Drawing.Point(142, 330);
			this.lblStoSrv.Name = "lblStoSrv";
			this.lblStoSrv.Size = new System.Drawing.Size(29, 17);
			this.lblStoSrv.TabIndex = 11;
			this.lblStoSrv.Text = "235";
			this.lblStoSrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ctxMenu
			// 
			this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPause,
            this.menuStart,
            this.menuRestart});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.Size = new System.Drawing.Size(111, 70);
			// 
			// menuPause
			// 
			this.menuPause.Name = "menuPause";
			this.menuPause.Size = new System.Drawing.Size(110, 22);
			this.menuPause.Text = "Pause";
			this.menuPause.Click += new System.EventHandler(this.menuPause_Click);
			// 
			// menuStart
			// 
			this.menuStart.Name = "menuStart";
			this.menuStart.Size = new System.Drawing.Size(110, 22);
			this.menuStart.Text = "Start";
			this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
			// 
			// menuRestart
			// 
			this.menuRestart.Name = "menuRestart";
			this.menuRestart.Size = new System.Drawing.Size(110, 22);
			this.menuRestart.Text = "Restart";
			this.menuRestart.Click += new System.EventHandler(this.menuRestart_Click);
			// 
			// lblBlueStatus
			// 
			this.lblBlueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblBlueStatus.AutoSize = true;
			this.lblBlueStatus.Image = global::ServiceManager.Properties.Resources.blueStatus;
			this.lblBlueStatus.Location = new System.Drawing.Point(12, 330);
			this.lblBlueStatus.MinimumSize = new System.Drawing.Size(14, 14);
			this.lblBlueStatus.Name = "lblBlueStatus";
			this.lblBlueStatus.Size = new System.Drawing.Size(14, 14);
			this.lblBlueStatus.TabIndex = 8;
			this.lblBlueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRedStatus
			// 
			this.lblRedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblRedStatus.AutoSize = true;
			this.lblRedStatus.Image = global::ServiceManager.Properties.Resources.redStatus;
			this.lblRedStatus.Location = new System.Drawing.Point(122, 330);
			this.lblRedStatus.MinimumSize = new System.Drawing.Size(14, 14);
			this.lblRedStatus.Name = "lblRedStatus";
			this.lblRedStatus.Size = new System.Drawing.Size(14, 14);
			this.lblRedStatus.TabIndex = 7;
			this.lblRedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGreenStatus
			// 
			this.lblGreenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblGreenStatus.AutoSize = true;
			this.lblGreenStatus.Image = global::ServiceManager.Properties.Resources.greenStatus1;
			this.lblGreenStatus.Location = new System.Drawing.Point(67, 330);
			this.lblGreenStatus.MinimumSize = new System.Drawing.Size(14, 14);
			this.lblGreenStatus.Name = "lblGreenStatus";
			this.lblGreenStatus.Size = new System.Drawing.Size(14, 14);
			this.lblGreenStatus.TabIndex = 6;
			this.lblGreenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
			this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.refreshButton.Location = new System.Drawing.Point(626, 321);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(40, 32);
			this.refreshButton.TabIndex = 5;
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// ServiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 359);
			this.Controls.Add(this.lblStoSrv);
			this.Controls.Add(this.lblRunSrv);
			this.Controls.Add(this.lblTotalSrv);
			this.Controls.Add(this.lblBlueStatus);
			this.Controls.Add(this.lblRedStatus);
			this.Controls.Add(this.lblGreenStatus);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.listServices);
			this.Controls.Add(this.txtSearch);
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "ServiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Services";
			this.ctxMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView listServices;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Label lblGreenStatus;
		private System.Windows.Forms.Label lblRedStatus;
		private System.Windows.Forms.Label lblBlueStatus;
		private System.Windows.Forms.Label lblTotalSrv;
		private System.Windows.Forms.Label lblRunSrv;
		private System.Windows.Forms.Label lblStoSrv;
		private System.Windows.Forms.ContextMenuStrip ctxMenu;
		private System.Windows.Forms.ToolStripMenuItem menuPause;
		private System.Windows.Forms.ToolStripMenuItem menuStart;
		private System.Windows.Forms.ToolStripMenuItem menuRestart;
	}
}