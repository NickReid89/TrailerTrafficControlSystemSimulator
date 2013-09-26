namespace DispatchersInterface
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.DGBOL = new System.Windows.Forms.DataGridView();
            this.panelBOL = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnArrived = new System.Windows.Forms.Button();
            this.btnArrivals = new System.Windows.Forms.Button();
            this.btnTrailerInfo = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnLeaving = new System.Windows.Forms.Button();
            this.lOCATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.location = new DispatchersInterface.Location();
            this.lOCATIONTableAdapter = new DispatchersInterface.LocationTableAdapters.LOCATIONTableAdapter();
            this.radNeeded = new System.Windows.Forms.RadioButton();
            this.radFinished = new System.Windows.Forms.RadioButton();
            this.radInProgress = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLotView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtDPNotes = new System.Windows.Forms.TextBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.grpDrivers = new System.Windows.Forms.GroupBox();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvPA = new System.Windows.Forms.DataGridView();
            this.btnCheckTrailers = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInProgress1 = new System.Windows.Forms.RadioButton();
            this.radAll1 = new System.Windows.Forms.RadioButton();
            this.radFinished1 = new System.Windows.Forms.RadioButton();
            this.radNeeded1 = new System.Windows.Forms.RadioButton();
            this.dgvAllDriverRequests = new System.Windows.Forms.DataGridView();
            this.TabRequest = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvFreeTrailers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGVDrivers = new System.Windows.Forms.DataGridView();
            this.btnTrailerMap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSTB = new System.Windows.Forms.DataGridView();
            this.btnBayView = new System.Windows.Forms.Button();
            this.btnLots = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGBOL)).BeginInit();
            this.panelBOL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.grpDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPA)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDriverRequests)).BeginInit();
            this.TabRequest.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeTrailers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 60);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // DGBOL
            // 
            this.DGBOL.AllowUserToAddRows = false;
            this.DGBOL.AllowUserToDeleteRows = false;
            this.DGBOL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGBOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBOL.Location = new System.Drawing.Point(3, 3);
            this.DGBOL.MultiSelect = false;
            this.DGBOL.Name = "DGBOL";
            this.DGBOL.ReadOnly = true;
            this.DGBOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGBOL.Size = new System.Drawing.Size(754, 423);
            this.DGBOL.TabIndex = 1;
            // 
            // panelBOL
            // 
            this.panelBOL.Controls.Add(this.groupBox1);
            this.panelBOL.Controls.Add(this.btnArrived);
            this.panelBOL.Controls.Add(this.DGBOL);
            this.panelBOL.Location = new System.Drawing.Point(93, 12);
            this.panelBOL.Name = "panelBOL";
            this.panelBOL.Size = new System.Drawing.Size(760, 529);
            this.panelBOL.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboSearch);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value:";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Trailer ID",
            "BOL NO",
            "PO NO",
            "ALL"});
            this.cboSearch.Location = new System.Drawing.Point(6, 19);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 59);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(121, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // btnArrived
            // 
            this.btnArrived.Location = new System.Drawing.Point(273, 432);
            this.btnArrived.Name = "btnArrived";
            this.btnArrived.Size = new System.Drawing.Size(75, 94);
            this.btnArrived.TabIndex = 3;
            this.btnArrived.Text = "Arrived";
            this.btnArrived.UseVisualStyleBackColor = true;
            this.btnArrived.Visible = false;
            this.btnArrived.Click += new System.EventHandler(this.btnArrived_Click);
            // 
            // btnArrivals
            // 
            this.btnArrivals.Location = new System.Drawing.Point(0, 16);
            this.btnArrivals.Name = "btnArrivals";
            this.btnArrivals.Size = new System.Drawing.Size(87, 41);
            this.btnArrivals.TabIndex = 3;
            this.btnArrivals.Text = "Arrivals";
            this.btnArrivals.UseVisualStyleBackColor = true;
            this.btnArrivals.Click += new System.EventHandler(this.btnArrivals_Click);
            // 
            // btnTrailerInfo
            // 
            this.btnTrailerInfo.Location = new System.Drawing.Point(0, 75);
            this.btnTrailerInfo.Name = "btnTrailerInfo";
            this.btnTrailerInfo.Size = new System.Drawing.Size(87, 41);
            this.btnTrailerInfo.TabIndex = 4;
            this.btnTrailerInfo.Text = "Reports";
            this.btnTrailerInfo.UseVisualStyleBackColor = true;
            this.btnTrailerInfo.Click += new System.EventHandler(this.btnTrailerInfo_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Location = new System.Drawing.Point(0, 138);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(87, 41);
            this.btnRequests.TabIndex = 5;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnLeaving
            // 
            this.btnLeaving.Location = new System.Drawing.Point(0, 205);
            this.btnLeaving.Name = "btnLeaving";
            this.btnLeaving.Size = new System.Drawing.Size(87, 41);
            this.btnLeaving.TabIndex = 6;
            this.btnLeaving.Text = "Leaving";
            this.btnLeaving.UseVisualStyleBackColor = true;
            // 
            // lOCATIONBindingSource
            // 
            this.lOCATIONBindingSource.DataMember = "LOCATION";
            this.lOCATIONBindingSource.DataSource = this.location;
            // 
            // location
            // 
            this.location.DataSetName = "Location";
            this.location.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCATIONTableAdapter
            // 
            this.lOCATIONTableAdapter.ClearBeforeFill = true;
            // 
            // radNeeded
            // 
            this.radNeeded.AutoSize = true;
            this.radNeeded.Location = new System.Drawing.Point(6, 35);
            this.radNeeded.Name = "radNeeded";
            this.radNeeded.Size = new System.Drawing.Size(63, 17);
            this.radNeeded.TabIndex = 0;
            this.radNeeded.TabStop = true;
            this.radNeeded.Text = "Needed";
            this.radNeeded.UseVisualStyleBackColor = true;
            // 
            // radFinished
            // 
            this.radFinished.AutoSize = true;
            this.radFinished.Location = new System.Drawing.Point(98, 35);
            this.radFinished.Name = "radFinished";
            this.radFinished.Size = new System.Drawing.Size(64, 17);
            this.radFinished.TabIndex = 1;
            this.radFinished.TabStop = true;
            this.radFinished.Text = "Finished";
            this.radFinished.UseVisualStyleBackColor = true;
            // 
            // radInProgress
            // 
            this.radInProgress.AutoSize = true;
            this.radInProgress.Location = new System.Drawing.Point(180, 35);
            this.radInProgress.Name = "radInProgress";
            this.radInProgress.Size = new System.Drawing.Size(78, 17);
            this.radInProgress.TabIndex = 2;
            this.radInProgress.TabStop = true;
            this.radInProgress.Text = "In Progress";
            this.radInProgress.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(272, 35);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 3;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLotView);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.txtDPNotes);
            this.tabPage2.Controls.Add(this.dgvRequests);
            this.tabPage2.Controls.Add(this.btnSubmitRequest);
            this.tabPage2.Controls.Add(this.grpDrivers);
            this.tabPage2.Controls.Add(this.dgvPA);
            this.tabPage2.Controls.Add(this.btnCheckTrailers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Request Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLotView
            // 
            this.btnLotView.Location = new System.Drawing.Point(190, 163);
            this.btnLotView.Name = "btnLotView";
            this.btnLotView.Size = new System.Drawing.Size(75, 35);
            this.btnLotView.TabIndex = 8;
            this.btnLotView.Text = "Lot View";
            this.btnLotView.UseVisualStyleBackColor = true;
            this.btnLotView.Click += new System.EventHandler(this.btnLotView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(108, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDPNotes
            // 
            this.txtDPNotes.Location = new System.Drawing.Point(404, 359);
            this.txtDPNotes.Multiline = true;
            this.txtDPNotes.Name = "txtDPNotes";
            this.txtDPNotes.Size = new System.Drawing.Size(184, 153);
            this.txtDPNotes.TabIndex = 6;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(9, 6);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersWidth = 60;
            this.dgvRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(740, 150);
            this.dgvRequests.TabIndex = 1;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(594, 474);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(75, 38);
            this.btnSubmitRequest.TabIndex = 5;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // grpDrivers
            // 
            this.grpDrivers.Controls.Add(this.dgvDriver);
            this.grpDrivers.Location = new System.Drawing.Point(9, 353);
            this.grpDrivers.Name = "grpDrivers";
            this.grpDrivers.Size = new System.Drawing.Size(389, 159);
            this.grpDrivers.TabIndex = 4;
            this.grpDrivers.TabStop = false;
            this.grpDrivers.Text = "Available Drivers";
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AllowUserToDeleteRows = false;
            this.dgvDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(6, 20);
            this.dgvDriver.MultiSelect = false;
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriver.Size = new System.Drawing.Size(377, 133);
            this.dgvDriver.TabIndex = 0;
            // 
            // dgvPA
            // 
            this.dgvPA.AllowUserToAddRows = false;
            this.dgvPA.AllowUserToDeleteRows = false;
            this.dgvPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPA.Location = new System.Drawing.Point(9, 205);
            this.dgvPA.MultiSelect = false;
            this.dgvPA.Name = "dgvPA";
            this.dgvPA.ReadOnly = true;
            this.dgvPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPA.Size = new System.Drawing.Size(740, 141);
            this.dgvPA.TabIndex = 3;
            // 
            // btnCheckTrailers
            // 
            this.btnCheckTrailers.Location = new System.Drawing.Point(9, 163);
            this.btnCheckTrailers.Name = "btnCheckTrailers";
            this.btnCheckTrailers.Size = new System.Drawing.Size(92, 35);
            this.btnCheckTrailers.TabIndex = 2;
            this.btnCheckTrailers.Text = "Check for Avaible Trailers";
            this.btnCheckTrailers.UseVisualStyleBackColor = true;
            this.btnCheckTrailers.Click += new System.EventHandler(this.btnCheckTrailers_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvAllDriverRequests);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radInProgress1);
            this.groupBox2.Controls.Add(this.radAll1);
            this.groupBox2.Controls.Add(this.radFinished1);
            this.groupBox2.Controls.Add(this.radNeeded1);
            this.groupBox2.Location = new System.Drawing.Point(9, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radInProgress1
            // 
            this.radInProgress1.AutoSize = true;
            this.radInProgress1.Location = new System.Drawing.Point(341, 19);
            this.radInProgress1.Name = "radInProgress1";
            this.radInProgress1.Size = new System.Drawing.Size(78, 17);
            this.radInProgress1.TabIndex = 3;
            this.radInProgress1.TabStop = true;
            this.radInProgress1.Text = "In Progress";
            this.radInProgress1.UseVisualStyleBackColor = true;
            this.radInProgress1.CheckedChanged += new System.EventHandler(this.radInProgress1_CheckedChanged);
            // 
            // radAll1
            // 
            this.radAll1.AutoSize = true;
            this.radAll1.Location = new System.Drawing.Point(250, 19);
            this.radAll1.Name = "radAll1";
            this.radAll1.Size = new System.Drawing.Size(36, 17);
            this.radAll1.TabIndex = 2;
            this.radAll1.TabStop = true;
            this.radAll1.Text = "All";
            this.radAll1.UseVisualStyleBackColor = true;
            this.radAll1.CheckedChanged += new System.EventHandler(this.radAll1_CheckedChanged);
            // 
            // radFinished1
            // 
            this.radFinished1.AutoSize = true;
            this.radFinished1.Location = new System.Drawing.Point(126, 19);
            this.radFinished1.Name = "radFinished1";
            this.radFinished1.Size = new System.Drawing.Size(64, 17);
            this.radFinished1.TabIndex = 1;
            this.radFinished1.TabStop = true;
            this.radFinished1.Text = "Finished";
            this.radFinished1.UseVisualStyleBackColor = true;
            this.radFinished1.CheckedChanged += new System.EventHandler(this.radFinished1_CheckedChanged);
            // 
            // radNeeded1
            // 
            this.radNeeded1.AutoSize = true;
            this.radNeeded1.Location = new System.Drawing.Point(7, 20);
            this.radNeeded1.Name = "radNeeded1";
            this.radNeeded1.Size = new System.Drawing.Size(63, 17);
            this.radNeeded1.TabIndex = 0;
            this.radNeeded1.TabStop = true;
            this.radNeeded1.Text = "Needed";
            this.radNeeded1.UseVisualStyleBackColor = true;
            this.radNeeded1.CheckedChanged += new System.EventHandler(this.radNeeded1_CheckedChanged);
            // 
            // dgvAllDriverRequests
            // 
            this.dgvAllDriverRequests.AllowUserToAddRows = false;
            this.dgvAllDriverRequests.AllowUserToDeleteRows = false;
            this.dgvAllDriverRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllDriverRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDriverRequests.Location = new System.Drawing.Point(9, 7);
            this.dgvAllDriverRequests.MultiSelect = false;
            this.dgvAllDriverRequests.Name = "dgvAllDriverRequests";
            this.dgvAllDriverRequests.ReadOnly = true;
            this.dgvAllDriverRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllDriverRequests.Size = new System.Drawing.Size(740, 420);
            this.dgvAllDriverRequests.TabIndex = 0;
            // 
            // TabRequest
            // 
            this.TabRequest.Controls.Add(this.tabPage2);
            this.TabRequest.Controls.Add(this.tabPage3);
            this.TabRequest.Controls.Add(this.tabPage1);
            this.TabRequest.Location = new System.Drawing.Point(93, 12);
            this.TabRequest.Name = "TabRequest";
            this.TabRequest.SelectedIndex = 0;
            this.TabRequest.Size = new System.Drawing.Size(769, 558);
            this.TabRequest.TabIndex = 7;
            this.TabRequest.Visible = false;
            this.TabRequest.SelectedIndexChanged += new System.EventHandler(this.TabRequest_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSubmit);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btnTrailerMap);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Request Returns";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(90, 495);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFreeTrailers);
            this.groupBox4.Location = new System.Drawing.Point(283, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 301);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Lot Locations:";
            // 
            // dgvFreeTrailers
            // 
            this.dgvFreeTrailers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFreeTrailers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFreeTrailers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFreeTrailers.Location = new System.Drawing.Point(3, 16);
            this.dgvFreeTrailers.MultiSelect = false;
            this.dgvFreeTrailers.Name = "dgvFreeTrailers";
            this.dgvFreeTrailers.ReadOnly = true;
            this.dgvFreeTrailers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFreeTrailers.Size = new System.Drawing.Size(194, 282);
            this.dgvFreeTrailers.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGVDrivers);
            this.groupBox3.Location = new System.Drawing.Point(6, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 301);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Drivers";
            // 
            // DGVDrivers
            // 
            this.DGVDrivers.AllowUserToAddRows = false;
            this.DGVDrivers.AllowUserToDeleteRows = false;
            this.DGVDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDrivers.Location = new System.Drawing.Point(3, 16);
            this.DGVDrivers.MultiSelect = false;
            this.DGVDrivers.Name = "DGVDrivers";
            this.DGVDrivers.ReadOnly = true;
            this.DGVDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDrivers.Size = new System.Drawing.Size(267, 282);
            this.DGVDrivers.TabIndex = 3;
            // 
            // btnTrailerMap
            // 
            this.btnTrailerMap.Location = new System.Drawing.Point(9, 495);
            this.btnTrailerMap.Name = "btnTrailerMap";
            this.btnTrailerMap.Size = new System.Drawing.Size(75, 23);
            this.btnTrailerMap.TabIndex = 2;
            this.btnTrailerMap.Text = "&Lot View";
            this.btnTrailerMap.UseVisualStyleBackColor = true;
            this.btnTrailerMap.Click += new System.EventHandler(this.btnTrailerMap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSTB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 178);
            this.panel1.TabIndex = 1;
            // 
            // dgvSTB
            // 
            this.dgvSTB.AllowUserToAddRows = false;
            this.dgvSTB.AllowUserToDeleteRows = false;
            this.dgvSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTB.Location = new System.Drawing.Point(3, 3);
            this.dgvSTB.MultiSelect = false;
            this.dgvSTB.Name = "dgvSTB";
            this.dgvSTB.ReadOnly = true;
            this.dgvSTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTB.Size = new System.Drawing.Size(747, 172);
            this.dgvSTB.TabIndex = 0;
            // 
            // btnBayView
            // 
            this.btnBayView.Location = new System.Drawing.Point(0, 272);
            this.btnBayView.Name = "btnBayView";
            this.btnBayView.Size = new System.Drawing.Size(87, 41);
            this.btnBayView.TabIndex = 8;
            this.btnBayView.Text = "Bay View";
            this.btnBayView.UseVisualStyleBackColor = true;
            this.btnBayView.Click += new System.EventHandler(this.btnBayView_Click);
            // 
            // btnLots
            // 
            this.btnLots.Location = new System.Drawing.Point(0, 332);
            this.btnLots.Name = "btnLots";
            this.btnLots.Size = new System.Drawing.Size(87, 41);
            this.btnLots.TabIndex = 9;
            this.btnLots.Text = "Lot View";
            this.btnLots.UseVisualStyleBackColor = true;
            this.btnLots.Click += new System.EventHandler(this.btnLots_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 553);
            this.Controls.Add(this.btnLots);
            this.Controls.Add(this.btnBayView);
            this.Controls.Add(this.btnLeaving);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.btnTrailerInfo);
            this.Controls.Add(this.btnArrivals);
            this.Controls.Add(this.TabRequest);
            this.Controls.Add(this.panelBOL);
            this.Name = "Form1";
            this.Text = "Dispatchers Interface";
            ((System.ComponentModel.ISupportInitialize)(this.DGBOL)).EndInit();
            this.panelBOL.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.grpDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPA)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDriverRequests)).EndInit();
            this.TabRequest.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeTrailers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DGBOL;
        private System.Windows.Forms.Panel panelBOL;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnArrived;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArrivals;
        private System.Windows.Forms.Button btnTrailerInfo;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnLeaving;
        private Location location;
        private System.Windows.Forms.BindingSource lOCATIONBindingSource;
        private LocationTableAdapters.LOCATIONTableAdapter lOCATIONTableAdapter;
        private System.Windows.Forms.RadioButton radNeeded;
        private System.Windows.Forms.RadioButton radFinished;
        private System.Windows.Forms.RadioButton radInProgress;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDPNotes;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.GroupBox grpDrivers;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvPA;
        private System.Windows.Forms.Button btnCheckTrailers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radInProgress1;
        private System.Windows.Forms.RadioButton radAll1;
        private System.Windows.Forms.RadioButton radFinished1;
        private System.Windows.Forms.RadioButton radNeeded1;
        private System.Windows.Forms.DataGridView dgvAllDriverRequests;
        private System.Windows.Forms.TabControl TabRequest;
        private System.Windows.Forms.Button btnLotView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSTB;
        private System.Windows.Forms.Button btnTrailerMap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGVDrivers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvFreeTrailers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBayView;
        private System.Windows.Forms.Button btnLots;
    }
}

