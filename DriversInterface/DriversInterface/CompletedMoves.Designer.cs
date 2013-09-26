namespace DriversInterface
{
    partial class CompletedMoves
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
            this.dgvCompletedMoves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedMoves)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompletedMoves
            // 
            this.dgvCompletedMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompletedMoves.Location = new System.Drawing.Point(0, 0);
            this.dgvCompletedMoves.Name = "dgvCompletedMoves";
            this.dgvCompletedMoves.Size = new System.Drawing.Size(631, 273);
            this.dgvCompletedMoves.TabIndex = 0;
            // 
            // CompletedMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 273);
            this.Controls.Add(this.dgvCompletedMoves);
            this.Name = "CompletedMoves";
            this.Text = "CompletedMoves";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedMoves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompletedMoves;
    }
}