namespace DockForemanInterface
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.PanelBays = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBays = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRequest = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPartsView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtENotes = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEmpty = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAvalBays = new System.Windows.Forms.DataGridView();
            this.dtpEmptyTrailer = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmitEmpty = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAllRequests = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReportBrokenSeal = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DGVRequests = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cboDeparture = new System.Windows.Forms.ComboBox();
            this.dtpReturnTrailer = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReturnTrailer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSendBackNotes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTrailerinBays = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TrailerReportALL2 = new DockForemanInterface.TrailerReportALL();
            this.TrailerReportALL1 = new DockForemanInterface.TrailerReportALL();
            this.rEQUESTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentRequests = new DockForemanInterface.CurrentRequests();
            this.rEQUESTSTableAdapter = new DockForemanInterface.CurrentRequestsTableAdapters.REQUESTSTableAdapter();
            this.rEQUESTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TrailerMovementReport1 = new DockForemanInterface.TrailerMovementReport();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PanelBays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBays)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpty)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvalBays)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.btnAllRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailerinBays)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTSBindingSource1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.lblNotes);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.PanelBays);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvPartsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Component Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 467);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(205, 31);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_2);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(7, 335);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(10, 351);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(205, 110);
            this.txtNotes.TabIndex = 16;
            // 
            // PanelBays
            // 
            this.PanelBays.Controls.Add(this.btnLogOut);
            this.PanelBays.Controls.Add(this.lblEmpId);
            this.PanelBays.Controls.Add(this.txtQuantity);
            this.PanelBays.Controls.Add(this.lblQuantity);
            this.PanelBays.Controls.Add(this.label3);
            this.PanelBays.Controls.Add(this.dgvBays);
            this.PanelBays.Controls.Add(this.label5);
            this.PanelBays.Controls.Add(this.dtpRequest);
            this.PanelBays.Location = new System.Drawing.Point(222, 213);
            this.PanelBays.Name = "PanelBays";
            this.PanelBays.Size = new System.Drawing.Size(534, 285);
            this.PanelBays.TabIndex = 7;
            this.PanelBays.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(417, 254);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 28);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(394, 262);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(0, 13);
            this.lblEmpId.TabIndex = 21;
            this.lblEmpId.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(247, 256);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(192, 260);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Avaliable Bays";
            // 
            // dgvBays
            // 
            this.dgvBays.AllowUserToAddRows = false;
            this.dgvBays.AllowUserToDeleteRows = false;
            this.dgvBays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBays.EnableHeadersVisualStyles = false;
            this.dgvBays.Location = new System.Drawing.Point(3, 25);
            this.dgvBays.MultiSelect = false;
            this.dgvBays.Name = "dgvBays";
            this.dgvBays.ReadOnly = true;
            this.dgvBays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvBays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBays.ShowCellErrors = false;
            this.dgvBays.ShowCellToolTips = false;
            this.dgvBays.ShowEditingIcon = false;
            this.dgvBays.ShowRowErrors = false;
            this.dgvBays.Size = new System.Drawing.Size(528, 223);
            this.dgvBays.TabIndex = 18;
            this.dgvBays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time:";
            // 
            // dtpRequest
            // 
            this.dtpRequest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRequest.Location = new System.Drawing.Point(46, 256);
            this.dtpRequest.Name = "dtpRequest";
            this.dtpRequest.Size = new System.Drawing.Size(140, 20);
            this.dtpRequest.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSearchBy);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 42);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "All",
            "Component",
            "P.O No",
            "Trailer_ID"});
            this.cboSearchBy.Location = new System.Drawing.Point(72, 17);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(121, 21);
            this.cboSearchBy.TabIndex = 7;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(72, 44);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(121, 20);
            this.txtSearchValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // dgvPartsView
            // 
            this.dgvPartsView.AllowUserToAddRows = false;
            this.dgvPartsView.AllowUserToDeleteRows = false;
            this.dgvPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsView.Location = new System.Drawing.Point(4, 7);
            this.dgvPartsView.MultiSelect = false;
            this.dgvPartsView.Name = "dgvPartsView";
            this.dgvPartsView.ReadOnly = true;
            this.dgvPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartsView.Size = new System.Drawing.Size(756, 199);
            this.dgvPartsView.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtENotes);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dtpEmptyTrailer);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnSubmitEmpty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empty Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Notes:";
            // 
            // txtENotes
            // 
            this.txtENotes.Location = new System.Drawing.Point(171, 437);
            this.txtENotes.Name = "txtENotes";
            this.txtENotes.Size = new System.Drawing.Size(358, 56);
            this.txtENotes.TabIndex = 12;
            this.txtENotes.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEmpty);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 194);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Trailers";
            // 
            // dgvEmpty
            // 
            this.dgvEmpty.AllowUserToAddRows = false;
            this.dgvEmpty.AllowUserToDeleteRows = false;
            this.dgvEmpty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpty.Location = new System.Drawing.Point(3, 16);
            this.dgvEmpty.MultiSelect = false;
            this.dgvEmpty.Name = "dgvEmpty";
            this.dgvEmpty.ReadOnly = true;
            this.dgvEmpty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpty.Size = new System.Drawing.Size(379, 175);
            this.dgvEmpty.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAvalBays);
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 208);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Bays:";
            // 
            // dgvAvalBays
            // 
            this.dgvAvalBays.AllowUserToAddRows = false;
            this.dgvAvalBays.AllowUserToDeleteRows = false;
            this.dgvAvalBays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvalBays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvalBays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvalBays.Location = new System.Drawing.Point(3, 16);
            this.dgvAvalBays.MultiSelect = false;
            this.dgvAvalBays.Name = "dgvAvalBays";
            this.dgvAvalBays.ReadOnly = true;
            this.dgvAvalBays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvalBays.Size = new System.Drawing.Size(373, 189);
            this.dgvAvalBays.TabIndex = 6;
            // 
            // dtpEmptyTrailer
            // 
            this.dtpEmptyTrailer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEmptyTrailer.Location = new System.Drawing.Point(47, 437);
            this.dtpEmptyTrailer.Name = "dtpEmptyTrailer";
            this.dtpEmptyTrailer.Size = new System.Drawing.Size(118, 20);
            this.dtpEmptyTrailer.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time:";
            // 
            // btnSubmitEmpty
            // 
            this.btnSubmitEmpty.Location = new System.Drawing.Point(9, 463);
            this.btnSubmitEmpty.Name = "btnSubmitEmpty";
            this.btnSubmitEmpty.Size = new System.Drawing.Size(156, 30);
            this.btnSubmitEmpty.TabIndex = 3;
            this.btnSubmitEmpty.Text = "Submit";
            this.btnSubmitEmpty.UseVisualStyleBackColor = true;
            this.btnSubmitEmpty.Click += new System.EventHandler(this.btnSubmitEmpty_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAllRequests);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(994, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Requests Sent";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAllRequests
            // 
            this.btnAllRequests.Controls.Add(this.btnAccept);
            this.btnAllRequests.Controls.Add(this.btnRefresh);
            this.btnAllRequests.Controls.Add(this.btnReportBrokenSeal);
            this.btnAllRequests.Controls.Add(this.btnDelete);
            this.btnAllRequests.Controls.Add(this.DGVRequests);
            this.btnAllRequests.Location = new System.Drawing.Point(4, 4);
            this.btnAllRequests.Name = "btnAllRequests";
            this.btnAllRequests.Size = new System.Drawing.Size(752, 497);
            this.btnAllRequests.TabIndex = 0;
            this.btnAllRequests.TabStop = false;
            this.btnAllRequests.Text = "Requests";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(669, 438);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 53);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(463, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 53);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReportBrokenSeal
            // 
            this.btnReportBrokenSeal.Location = new System.Drawing.Point(214, 438);
            this.btnReportBrokenSeal.Name = "btnReportBrokenSeal";
            this.btnReportBrokenSeal.Size = new System.Drawing.Size(118, 53);
            this.btnReportBrokenSeal.TabIndex = 3;
            this.btnReportBrokenSeal.Text = "Report Broken Seal";
            this.btnReportBrokenSeal.UseVisualStyleBackColor = true;
            this.btnReportBrokenSeal.Click += new System.EventHandler(this.btnReportBrokenSeal_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DGVRequests
            // 
            this.DGVRequests.AllowUserToAddRows = false;
            this.DGVRequests.AllowUserToDeleteRows = false;
            this.DGVRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRequests.Location = new System.Drawing.Point(7, 20);
            this.DGVRequests.MultiSelect = false;
            this.DGVRequests.Name = "DGVRequests";
            this.DGVRequests.ReadOnly = true;
            this.DGVRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRequests.Size = new System.Drawing.Size(739, 412);
            this.DGVRequests.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cboDeparture);
            this.tabPage4.Controls.Add(this.dtpReturnTrailer);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnReturnTrailer);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtSendBackNotes);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dgvTrailerinBays);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(994, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Return Trailer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cboDeparture
            // 
            this.cboDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeparture.FormattingEnabled = true;
            this.cboDeparture.Items.AddRange(new object[] {
            "Return",
            "Departure"});
            this.cboDeparture.Location = new System.Drawing.Point(412, 150);
            this.cboDeparture.Name = "cboDeparture";
            this.cboDeparture.Size = new System.Drawing.Size(121, 21);
            this.cboDeparture.TabIndex = 19;
            // 
            // dtpReturnTrailer
            // 
            this.dtpReturnTrailer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpReturnTrailer.Location = new System.Drawing.Point(412, 19);
            this.dtpReturnTrailer.Name = "dtpReturnTrailer";
            this.dtpReturnTrailer.Size = new System.Drawing.Size(118, 20);
            this.dtpReturnTrailer.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Time:";
            // 
            // btnReturnTrailer
            // 
            this.btnReturnTrailer.Location = new System.Drawing.Point(412, 177);
            this.btnReturnTrailer.Name = "btnReturnTrailer";
            this.btnReturnTrailer.Size = new System.Drawing.Size(156, 30);
            this.btnReturnTrailer.TabIndex = 16;
            this.btnReturnTrailer.Text = "Submit";
            this.btnReturnTrailer.UseVisualStyleBackColor = true;
            this.btnReturnTrailer.Click += new System.EventHandler(this.btnReturnTrailer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Notes:";
            // 
            // txtSendBackNotes
            // 
            this.txtSendBackNotes.Location = new System.Drawing.Point(412, 53);
            this.txtSendBackNotes.Name = "txtSendBackNotes";
            this.txtSendBackNotes.Size = new System.Drawing.Size(344, 91);
            this.txtSendBackNotes.TabIndex = 14;
            this.txtSendBackNotes.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Filled Bays:";
            // 
            // dgvTrailerinBays
            // 
            this.dgvTrailerinBays.AllowUserToAddRows = false;
            this.dgvTrailerinBays.AllowUserToDeleteRows = false;
            this.dgvTrailerinBays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrailerinBays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrailerinBays.Location = new System.Drawing.Point(10, 19);
            this.dgvTrailerinBays.Name = "dgvTrailerinBays";
            this.dgvTrailerinBays.ReadOnly = true;
            this.dgvTrailerinBays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrailerinBays.Size = new System.Drawing.Size(352, 396);
            this.dgvTrailerinBays.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.crystalReportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(994, 500);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Trailer Retention Report";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.EnableToolTips = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.TrailerReportALL2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(988, 494);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rEQUESTSBindingSource
            // 
            this.rEQUESTSBindingSource.DataMember = "REQUESTS";
            this.rEQUESTSBindingSource.DataSource = this.currentRequests;
            // 
            // currentRequests
            // 
            this.currentRequests.DataSetName = "CurrentRequests";
            this.currentRequests.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEQUESTSTableAdapter
            // 
            this.rEQUESTSTableAdapter.ClearBeforeFill = true;
            // 
            // rEQUESTSBindingSource1
            // 
            this.rEQUESTSBindingSource1.DataMember = "REQUESTS";
            this.rEQUESTSBindingSource1.DataSource = this.currentRequests;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.crystalReportViewer2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(994, 500);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Trailer Movement Report";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.TrailerMovementReport1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(994, 500);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Foreman User Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PanelBays.ResumeLayout(false);
            this.PanelBays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvalBays)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.btnAllRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailerinBays)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTSBindingSource1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSubmitEmpty;
        private System.Windows.Forms.GroupBox btnAllRequests;
        private System.Windows.Forms.Button btnReportBrokenSeal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView DGVRequests;
        //private ItemName itemName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPartsView;
        private System.Windows.Forms.Panel PanelBays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpRequest;
        private CurrentRequests currentRequests;
        private System.Windows.Forms.BindingSource rEQUESTSBindingSource;
        private CurrentRequestsTableAdapters.REQUESTSTableAdapter rEQUESTSTableAdapter;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBays;
        private System.Windows.Forms.BindingSource rEQUESTSBindingSource1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dgvEmpty;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvAvalBays;
        private System.Windows.Forms.DateTimePicker dtpEmptyTrailer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtENotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvTrailerinBays;
        private System.Windows.Forms.DateTimePicker dtpReturnTrailer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReturnTrailer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtSendBackNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cboDeparture;
        private System.Windows.Forms.TabPage tabPage5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TrailerReportALL TrailerReportALL1;
        private TrailerReportALL TrailerReportALL2;
        private System.Windows.Forms.TabPage tabPage6;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private TrailerMovementReport TrailerMovementReport1;
        //private ItemNameTableAdapters.ITEMTableAdapter iTEMTableAdapter;
    }
}

