namespace DriversInterface
{
    partial class frmDriverInterface
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
            this.btnStartBreak = new System.Windows.Forms.Button();
            this.btnSelectedTask = new System.Windows.Forms.Button();
            this.btnTrailerPickedup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelCurrRequest = new System.Windows.Forms.Panel();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.lblSealNum = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblTN = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboIssue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblLocTo = new System.Windows.Forms.Label();
            this.lblTrailerNo = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblSealNoText = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblReqDue = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.panelCurrRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartBreak
            // 
            this.btnStartBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBreak.Location = new System.Drawing.Point(13, 13);
            this.btnStartBreak.Name = "btnStartBreak";
            this.btnStartBreak.Size = new System.Drawing.Size(90, 58);
            this.btnStartBreak.TabIndex = 0;
            this.btnStartBreak.Text = "Start Break";
            this.btnStartBreak.UseVisualStyleBackColor = true;
            this.btnStartBreak.Click += new System.EventHandler(this.btnStartBreak_Click);
            // 
            // btnSelectedTask
            // 
            this.btnSelectedTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedTask.Location = new System.Drawing.Point(13, 79);
            this.btnSelectedTask.Name = "btnSelectedTask";
            this.btnSelectedTask.Size = new System.Drawing.Size(90, 58);
            this.btnSelectedTask.TabIndex = 1;
            this.btnSelectedTask.Text = "Start Selected Task";
            this.btnSelectedTask.UseVisualStyleBackColor = true;
            this.btnSelectedTask.Click += new System.EventHandler(this.btnSelectedTask_Click);
            // 
            // btnTrailerPickedup
            // 
            this.btnTrailerPickedup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailerPickedup.Location = new System.Drawing.Point(13, 141);
            this.btnTrailerPickedup.Name = "btnTrailerPickedup";
            this.btnTrailerPickedup.Size = new System.Drawing.Size(90, 58);
            this.btnTrailerPickedup.TabIndex = 2;
            this.btnTrailerPickedup.Text = "Trailer Picked Up";
            this.btnTrailerPickedup.UseVisualStyleBackColor = true;
            this.btnTrailerPickedup.Click += new System.EventHandler(this.btnTrailerPickedup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(13, 205);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 58);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Logout";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelCurrRequest
            // 
            this.panelCurrRequest.Controls.Add(this.dgvRequests);
            this.panelCurrRequest.Controls.Add(this.lblSealNum);
            this.panelCurrRequest.Controls.Add(this.lblTimeLeft);
            this.panelCurrRequest.Controls.Add(this.lblTN);
            this.panelCurrRequest.Controls.Add(this.lblTimer);
            this.panelCurrRequest.Controls.Add(this.btnReport);
            this.panelCurrRequest.Controls.Add(this.cboIssue);
            this.panelCurrRequest.Controls.Add(this.label8);
            this.panelCurrRequest.Controls.Add(this.lblNotes);
            this.panelCurrRequest.Controls.Add(this.lblLocTo);
            this.panelCurrRequest.Controls.Add(this.lblTrailerNo);
            this.panelCurrRequest.Controls.Add(this.lblLoc);
            this.panelCurrRequest.Controls.Add(this.lblSealNoText);
            this.panelCurrRequest.Controls.Add(this.lblTimeRemaining);
            this.panelCurrRequest.Controls.Add(this.lblReqDue);
            this.panelCurrRequest.Location = new System.Drawing.Point(110, 13);
            this.panelCurrRequest.Name = "panelCurrRequest";
            this.panelCurrRequest.Size = new System.Drawing.Size(972, 353);
            this.panelCurrRequest.TabIndex = 4;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 0);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(972, 353);
            this.dgvRequests.TabIndex = 0;
            // 
            // lblSealNum
            // 
            this.lblSealNum.AutoSize = true;
            this.lblSealNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSealNum.Location = new System.Drawing.Point(137, 78);
            this.lblSealNum.Name = "lblSealNum";
            this.lblSealNum.Size = new System.Drawing.Size(0, 16);
            this.lblSealNum.TabIndex = 15;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(143, 42);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 16);
            this.lblTimeLeft.TabIndex = 13;
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTN.Location = new System.Drawing.Point(127, 142);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(0, 16);
            this.lblTN.TabIndex = 12;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(143, 44);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 11;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(248, 275);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboIssue
            // 
            this.cboIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssue.FormattingEnabled = true;
            this.cboIssue.Items.AddRange(new object[] {
            "Broken Seal",
            "Mechanical Problems"});
            this.cboIssue.Location = new System.Drawing.Point(61, 276);
            this.cboIssue.Name = "cboIssue";
            this.cboIssue.Size = new System.Drawing.Size(181, 21);
            this.cboIssue.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Issue:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(3, 202);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(57, 16);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes: ";
            // 
            // lblLocTo
            // 
            this.lblLocTo.AutoSize = true;
            this.lblLocTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocTo.Location = new System.Drawing.Point(3, 172);
            this.lblLocTo.Name = "lblLocTo";
            this.lblLocTo.Size = new System.Drawing.Size(137, 16);
            this.lblLocTo.TabIndex = 5;
            this.lblLocTo.Text = "Delivery Location: ";
            // 
            // lblTrailerNo
            // 
            this.lblTrailerNo.AutoSize = true;
            this.lblTrailerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrailerNo.Location = new System.Drawing.Point(3, 142);
            this.lblTrailerNo.Name = "lblTrailerNo";
            this.lblTrailerNo.Size = new System.Drawing.Size(120, 16);
            this.lblTrailerNo.TabIndex = 4;
            this.lblTrailerNo.Text = "Trailer Number: ";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(3, 110);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(131, 16);
            this.lblLoc.TabIndex = 3;
            this.lblLoc.Text = "Pick-up Location: ";
            // 
            // lblSealNoText
            // 
            this.lblSealNoText.AutoSize = true;
            this.lblSealNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSealNoText.Location = new System.Drawing.Point(3, 78);
            this.lblSealNoText.Name = "lblSealNoText";
            this.lblSealNoText.Size = new System.Drawing.Size(106, 16);
            this.lblSealNoText.TabIndex = 2;
            this.lblSealNoText.Text = "Seal Number: ";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(3, 42);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(129, 16);
            this.lblTimeRemaining.TabIndex = 1;
            this.lblTimeRemaining.Text = "Time Remaining: ";
            // 
            // lblReqDue
            // 
            this.lblReqDue.AutoSize = true;
            this.lblReqDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqDue.Location = new System.Drawing.Point(3, 11);
            this.lblReqDue.Name = "lblReqDue";
            this.lblReqDue.Size = new System.Drawing.Size(159, 16);
            this.lblReqDue.TabIndex = 0;
            this.lblReqDue.Text = "Current Request Due: ";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Location = new System.Drawing.Point(13, 270);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(35, 13);
            this.lblEmp.TabIndex = 5;
            this.lblEmp.Text = "label1";
            this.lblEmp.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(13, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleted.Location = new System.Drawing.Point(12, 321);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(91, 45);
            this.btnCompleted.TabIndex = 7;
            this.btnCompleted.Text = "Completed Moves";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // frmDriverInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 394);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.panelCurrRequest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnTrailerPickedup);
            this.Controls.Add(this.btnSelectedTask);
            this.Controls.Add(this.btnStartBreak);
            this.Name = "frmDriverInterface";
            this.Text = "Driver Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCurrRequest.ResumeLayout(false);
            this.panelCurrRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartBreak;
        private System.Windows.Forms.Button btnSelectedTask;
        private System.Windows.Forms.Button btnTrailerPickedup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelCurrRequest;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cboIssue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblLocTo;
        private System.Windows.Forms.Label lblTrailerNo;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblSealNoText;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblReqDue;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblSealNum;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCompleted;
    }
}

