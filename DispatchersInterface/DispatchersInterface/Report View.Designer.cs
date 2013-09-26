namespace DispatchersInterface
{
    partial class Report_View
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
            this.btnRetention = new System.Windows.Forms.Button();
            this.btnTrLo = new System.Windows.Forms.Button();
            this.btnLotReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetention
            // 
            this.btnRetention.Location = new System.Drawing.Point(13, 13);
            this.btnRetention.Name = "btnRetention";
            this.btnRetention.Size = new System.Drawing.Size(117, 36);
            this.btnRetention.TabIndex = 0;
            this.btnRetention.Text = "Retention Report";
            this.btnRetention.UseVisualStyleBackColor = true;
            this.btnRetention.Click += new System.EventHandler(this.btnRetention_Click);
            // 
            // btnTrLo
            // 
            this.btnTrLo.Location = new System.Drawing.Point(13, 55);
            this.btnTrLo.Name = "btnTrLo";
            this.btnTrLo.Size = new System.Drawing.Size(117, 38);
            this.btnTrLo.TabIndex = 1;
            this.btnTrLo.Text = "Trailer Locations Report";
            this.btnTrLo.UseVisualStyleBackColor = true;
            this.btnTrLo.Click += new System.EventHandler(this.btnTrLo_Click);
            // 
            // btnLotReport
            // 
            this.btnLotReport.Location = new System.Drawing.Point(13, 100);
            this.btnLotReport.Name = "btnLotReport";
            this.btnLotReport.Size = new System.Drawing.Size(117, 37);
            this.btnLotReport.TabIndex = 2;
            this.btnLotReport.Text = "Trailers By Lot";
            this.btnLotReport.UseVisualStyleBackColor = true;
            this.btnLotReport.Click += new System.EventHandler(this.btnLotReport_Click);
            // 
            // Report_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 273);
            this.Controls.Add(this.btnLotReport);
            this.Controls.Add(this.btnTrLo);
            this.Controls.Add(this.btnRetention);
            this.Name = "Report_View";
            this.Text = "Report_View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetention;
        private System.Windows.Forms.Button btnTrLo;
        private System.Windows.Forms.Button btnLotReport;
    }
}