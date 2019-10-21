namespace CM_Booked.Views
{
    partial class CM_Booked_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CM_Booked_View));
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.tabBookingPay = new System.Windows.Forms.TabPage();
            this.dgvBookingPay = new System.Windows.Forms.DataGridView();
            this.tabBookingExtra = new System.Windows.Forms.TabPage();
            this.dgvBookingExtra = new System.Windows.Forms.DataGridView();
            this.tabBookingAudit = new System.Windows.Forms.TabPage();
            this.dgvBookingAudit = new System.Windows.Forms.DataGridView();
            this.tabRsRcuse = new System.Windows.Forms.TabPage();
            this.dgvRsrcuse = new System.Windows.Forms.DataGridView();
            this.tabBookingClient = new System.Windows.Forms.TabPage();
            this.dgvBookingClient = new System.Windows.Forms.DataGridView();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.tabTrandet = new System.Windows.Forms.TabPage();
            this.dgvTrandet = new System.Windows.Forms.DataGridView();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labCurrentTask = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.labStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingPayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsRcuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trandetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tabViews = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.dgvSummery = new System.Windows.Forms.DataGridView();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbClientID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txbBookingID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txbRecipt = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tabPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.tabBookingPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPay)).BeginInit();
            this.tabBookingExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingExtra)).BeginInit();
            this.tabBookingAudit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingAudit)).BeginInit();
            this.tabRsRcuse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsrcuse)).BeginInit();
            this.tabBookingClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingClient)).BeginInit();
            this.tabTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.tabTrandet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrandet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tabViews.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummery)).BeginInit();
            this.tabBooking.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.dgvPayment);
            this.tabPayment.Location = new System.Drawing.Point(4, 29);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(922, 343);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "Payment";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.Location = new System.Drawing.Point(3, 3);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersWidth = 62;
            this.dgvPayment.Size = new System.Drawing.Size(916, 337);
            this.dgvPayment.TabIndex = 0;
            // 
            // tabBookingPay
            // 
            this.tabBookingPay.Controls.Add(this.dgvBookingPay);
            this.tabBookingPay.Location = new System.Drawing.Point(4, 29);
            this.tabBookingPay.Name = "tabBookingPay";
            this.tabBookingPay.Size = new System.Drawing.Size(922, 343);
            this.tabBookingPay.TabIndex = 2;
            this.tabBookingPay.Text = "Booking Pay";
            this.tabBookingPay.UseVisualStyleBackColor = true;
            // 
            // dgvBookingPay
            // 
            this.dgvBookingPay.AllowUserToAddRows = false;
            this.dgvBookingPay.AllowUserToDeleteRows = false;
            this.dgvBookingPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingPay.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingPay.Name = "dgvBookingPay";
            this.dgvBookingPay.ReadOnly = true;
            this.dgvBookingPay.RowHeadersWidth = 62;
            this.dgvBookingPay.Size = new System.Drawing.Size(922, 343);
            this.dgvBookingPay.TabIndex = 1;
            // 
            // tabBookingExtra
            // 
            this.tabBookingExtra.Controls.Add(this.dgvBookingExtra);
            this.tabBookingExtra.Location = new System.Drawing.Point(4, 29);
            this.tabBookingExtra.Name = "tabBookingExtra";
            this.tabBookingExtra.Size = new System.Drawing.Size(922, 343);
            this.tabBookingExtra.TabIndex = 3;
            this.tabBookingExtra.Text = "Booking Extra";
            this.tabBookingExtra.UseVisualStyleBackColor = true;
            // 
            // dgvBookingExtra
            // 
            this.dgvBookingExtra.AllowUserToAddRows = false;
            this.dgvBookingExtra.AllowUserToDeleteRows = false;
            this.dgvBookingExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingExtra.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingExtra.Name = "dgvBookingExtra";
            this.dgvBookingExtra.ReadOnly = true;
            this.dgvBookingExtra.RowHeadersWidth = 62;
            this.dgvBookingExtra.Size = new System.Drawing.Size(922, 343);
            this.dgvBookingExtra.TabIndex = 1;
            // 
            // tabBookingAudit
            // 
            this.tabBookingAudit.Controls.Add(this.dgvBookingAudit);
            this.tabBookingAudit.Location = new System.Drawing.Point(4, 29);
            this.tabBookingAudit.Name = "tabBookingAudit";
            this.tabBookingAudit.Size = new System.Drawing.Size(922, 343);
            this.tabBookingAudit.TabIndex = 4;
            this.tabBookingAudit.Text = "Booking Audit";
            this.tabBookingAudit.UseVisualStyleBackColor = true;
            // 
            // dgvBookingAudit
            // 
            this.dgvBookingAudit.AllowUserToAddRows = false;
            this.dgvBookingAudit.AllowUserToDeleteRows = false;
            this.dgvBookingAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingAudit.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingAudit.Name = "dgvBookingAudit";
            this.dgvBookingAudit.ReadOnly = true;
            this.dgvBookingAudit.RowHeadersWidth = 62;
            this.dgvBookingAudit.Size = new System.Drawing.Size(922, 343);
            this.dgvBookingAudit.TabIndex = 1;
            // 
            // tabRsRcuse
            // 
            this.tabRsRcuse.Controls.Add(this.dgvRsrcuse);
            this.tabRsRcuse.Location = new System.Drawing.Point(4, 29);
            this.tabRsRcuse.Name = "tabRsRcuse";
            this.tabRsRcuse.Size = new System.Drawing.Size(922, 343);
            this.tabRsRcuse.TabIndex = 5;
            this.tabRsRcuse.Text = "Rs Rcuse";
            this.tabRsRcuse.UseVisualStyleBackColor = true;
            // 
            // dgvRsrcuse
            // 
            this.dgvRsrcuse.AllowUserToAddRows = false;
            this.dgvRsrcuse.AllowUserToDeleteRows = false;
            this.dgvRsrcuse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRsrcuse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRsrcuse.Location = new System.Drawing.Point(0, 0);
            this.dgvRsrcuse.Name = "dgvRsrcuse";
            this.dgvRsrcuse.ReadOnly = true;
            this.dgvRsrcuse.RowHeadersWidth = 62;
            this.dgvRsrcuse.Size = new System.Drawing.Size(922, 343);
            this.dgvRsrcuse.TabIndex = 1;
            // 
            // tabBookingClient
            // 
            this.tabBookingClient.Controls.Add(this.dgvBookingClient);
            this.tabBookingClient.Location = new System.Drawing.Point(4, 29);
            this.tabBookingClient.Name = "tabBookingClient";
            this.tabBookingClient.Size = new System.Drawing.Size(922, 343);
            this.tabBookingClient.TabIndex = 6;
            this.tabBookingClient.Text = "Booking Client";
            this.tabBookingClient.UseVisualStyleBackColor = true;
            // 
            // dgvBookingClient
            // 
            this.dgvBookingClient.AllowUserToAddRows = false;
            this.dgvBookingClient.AllowUserToDeleteRows = false;
            this.dgvBookingClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingClient.Location = new System.Drawing.Point(0, 0);
            this.dgvBookingClient.Name = "dgvBookingClient";
            this.dgvBookingClient.ReadOnly = true;
            this.dgvBookingClient.RowHeadersWidth = 62;
            this.dgvBookingClient.Size = new System.Drawing.Size(922, 343);
            this.dgvBookingClient.TabIndex = 1;
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.dgvTransaction);
            this.tabTransaction.Location = new System.Drawing.Point(4, 29);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Size = new System.Drawing.Size(922, 343);
            this.tabTransaction.TabIndex = 7;
            this.tabTransaction.Text = "Transaction";
            this.tabTransaction.UseVisualStyleBackColor = true;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersWidth = 62;
            this.dgvTransaction.Size = new System.Drawing.Size(922, 343);
            this.dgvTransaction.TabIndex = 1;
            // 
            // tabTrandet
            // 
            this.tabTrandet.Controls.Add(this.dgvTrandet);
            this.tabTrandet.Location = new System.Drawing.Point(4, 29);
            this.tabTrandet.Name = "tabTrandet";
            this.tabTrandet.Size = new System.Drawing.Size(922, 343);
            this.tabTrandet.TabIndex = 8;
            this.tabTrandet.Text = "Trandet";
            this.tabTrandet.UseVisualStyleBackColor = true;
            // 
            // dgvTrandet
            // 
            this.dgvTrandet.AllowUserToAddRows = false;
            this.dgvTrandet.AllowUserToDeleteRows = false;
            this.dgvTrandet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrandet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrandet.Location = new System.Drawing.Point(0, 0);
            this.dgvTrandet.Name = "dgvTrandet";
            this.dgvTrandet.ReadOnly = true;
            this.dgvTrandet.RowHeadersWidth = 62;
            this.dgvTrandet.Size = new System.Drawing.Size(922, 343);
            this.dgvTrandet.TabIndex = 1;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooking.Location = new System.Drawing.Point(3, 3);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.Size = new System.Drawing.Size(916, 337);
            this.dgvBooking.TabIndex = 0;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.WorkerSupportsCancellation = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labCurrentTask,
            this.CurrentProgressBar,
            this.labStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1032, 32);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // labCurrentTask
            // 
            this.labCurrentTask.Name = "labCurrentTask";
            this.labCurrentTask.Size = new System.Drawing.Size(104, 25);
            this.labCurrentTask.Text = "current task";
            // 
            // CurrentProgressBar
            // 
            this.CurrentProgressBar.Name = "CurrentProgressBar";
            this.CurrentProgressBar.Size = new System.Drawing.Size(400, 24);
            // 
            // labStatus
            // 
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(61, 25);
            this.labStatus.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.MenuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1032, 33);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip2";
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "File";
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(58, 29);
            this.menuEdit.Text = "Edit";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuView});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(65, 29);
            this.MenuHelp.Text = "Help";
            // 
            // MenuView
            // 
            this.MenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.bookingPayToolStripMenuItem,
            this.bookingExtraToolStripMenuItem,
            this.bookingEditToolStripMenuItem,
            this.rsRcuseToolStripMenuItem,
            this.bookingClientToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.trandetToolStripMenuItem});
            this.MenuView.Name = "MenuView";
            this.MenuView.Size = new System.Drawing.Size(151, 34);
            this.MenuView.Text = "View";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.CheckOnClick = true;
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.CheckOnClick = true;
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.CheckOnClick = true;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // bookingPayToolStripMenuItem
            // 
            this.bookingPayToolStripMenuItem.CheckOnClick = true;
            this.bookingPayToolStripMenuItem.Name = "bookingPayToolStripMenuItem";
            this.bookingPayToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.bookingPayToolStripMenuItem.Text = "Booking Pay";
            // 
            // bookingExtraToolStripMenuItem
            // 
            this.bookingExtraToolStripMenuItem.CheckOnClick = true;
            this.bookingExtraToolStripMenuItem.Name = "bookingExtraToolStripMenuItem";
            this.bookingExtraToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.bookingExtraToolStripMenuItem.Text = "Booking Extra";
            // 
            // bookingEditToolStripMenuItem
            // 
            this.bookingEditToolStripMenuItem.CheckOnClick = true;
            this.bookingEditToolStripMenuItem.Name = "bookingEditToolStripMenuItem";
            this.bookingEditToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.bookingEditToolStripMenuItem.Text = "Booking Edit";
            // 
            // rsRcuseToolStripMenuItem
            // 
            this.rsRcuseToolStripMenuItem.CheckOnClick = true;
            this.rsRcuseToolStripMenuItem.Name = "rsRcuseToolStripMenuItem";
            this.rsRcuseToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.rsRcuseToolStripMenuItem.Text = "Rs Rcuse";
            // 
            // bookingClientToolStripMenuItem
            // 
            this.bookingClientToolStripMenuItem.CheckOnClick = true;
            this.bookingClientToolStripMenuItem.Name = "bookingClientToolStripMenuItem";
            this.bookingClientToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.bookingClientToolStripMenuItem.Text = "Booking Client";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.CheckOnClick = true;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // trandetToolStripMenuItem
            // 
            this.trandetToolStripMenuItem.CheckOnClick = true;
            this.trandetToolStripMenuItem.Name = "trandetToolStripMenuItem";
            this.trandetToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.trandetToolStripMenuItem.Text = "Trandet";
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tabViews);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1032, 534);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 33);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(1032, 600);
            this.toolStripContainer.TabIndex = 5;
            this.toolStripContainer.Text = "toolStripContainer2";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.tabSummary);
            this.tabViews.Controls.Add(this.tabBooking);
            this.tabViews.Controls.Add(this.tabPayment);
            this.tabViews.Controls.Add(this.tabBookingPay);
            this.tabViews.Controls.Add(this.tabBookingExtra);
            this.tabViews.Controls.Add(this.tabBookingAudit);
            this.tabViews.Controls.Add(this.tabRsRcuse);
            this.tabViews.Controls.Add(this.tabBookingClient);
            this.tabViews.Controls.Add(this.tabTransaction);
            this.tabViews.Controls.Add(this.tabTrandet);
            this.tabViews.Location = new System.Drawing.Point(47, 66);
            this.tabViews.Name = "tabViews";
            this.tabViews.SelectedIndex = 0;
            this.tabViews.Size = new System.Drawing.Size(930, 376);
            this.tabViews.TabIndex = 10;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.dgvSummery);
            this.tabSummary.Location = new System.Drawing.Point(4, 29);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Size = new System.Drawing.Size(922, 343);
            this.tabSummary.TabIndex = 9;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // dgvSummery
            // 
            this.dgvSummery.AllowUserToAddRows = false;
            this.dgvSummery.AllowUserToDeleteRows = false;
            this.dgvSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummery.Location = new System.Drawing.Point(0, 0);
            this.dgvSummery.Name = "dgvSummery";
            this.dgvSummery.ReadOnly = true;
            this.dgvSummery.RowHeadersWidth = 62;
            this.dgvSummery.Size = new System.Drawing.Size(922, 343);
            this.dgvSummery.TabIndex = 1;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.dgvBooking);
            this.tabBooking.Location = new System.Drawing.Point(4, 29);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(922, 343);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txbClientID,
            this.toolStripLabel2,
            this.txbBookingID,
            this.toolStripLabel3,
            this.txbRecipt,
            this.btnSearch,
            this.btnCancel,
            this.btnClear});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1032, 34);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 11;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 29);
            this.toolStripLabel1.Text = "Client ID";
            // 
            // txbClientID
            // 
            this.txbClientID.Items.AddRange(new object[] {
            "vana",
            "dotgf",
            "am"});
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.Size = new System.Drawing.Size(121, 34);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 29);
            this.toolStripLabel2.Text = "Booking ID";
            // 
            // txbBookingID
            // 
            this.txbBookingID.Name = "txbBookingID";
            this.txbBookingID.Size = new System.Drawing.Size(100, 34);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(103, 29);
            this.toolStripLabel3.Text = "Receipt No.";
            // 
            // txbRecipt
            // 
            this.txbRecipt.Name = "txbRecipt";
            this.txbRecipt.Size = new System.Drawing.Size(100, 34);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 29);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // CM_Booked_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 633);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStrip);
            this.Name = "CM_Booked_View";
            this.Text = "CM Booked";
            this.tabPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.tabBookingPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPay)).EndInit();
            this.tabBookingExtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingExtra)).EndInit();
            this.tabBookingAudit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingAudit)).EndInit();
            this.tabRsRcuse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRsrcuse)).EndInit();
            this.tabBookingClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingClient)).EndInit();
            this.tabTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.tabTrandet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrandet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tabViews.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummery)).EndInit();
            this.tabBooking.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.TabPage tabBookingPay;
        private System.Windows.Forms.DataGridView dgvBookingPay;
        private System.Windows.Forms.TabPage tabBookingExtra;
        private System.Windows.Forms.DataGridView dgvBookingExtra;
        private System.Windows.Forms.TabPage tabBookingAudit;
        private System.Windows.Forms.DataGridView dgvBookingAudit;
        private System.Windows.Forms.TabPage tabRsRcuse;
        private System.Windows.Forms.DataGridView dgvRsrcuse;
        private System.Windows.Forms.TabPage tabBookingClient;
        private System.Windows.Forms.DataGridView dgvBookingClient;
        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.TabPage tabTrandet;
        private System.Windows.Forms.DataGridView dgvTrandet;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labCurrentTask;
        private System.Windows.Forms.ToolStripProgressBar CurrentProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel labStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuView;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingPayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsRcuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trandetToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.TabControl tabViews;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.DataGridView dgvSummery;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox txbClientID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txbBookingID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txbRecipt;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnClear;
    }
}