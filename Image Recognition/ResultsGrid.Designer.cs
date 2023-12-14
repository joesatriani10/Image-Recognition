namespace Image_Recognition
{
    partial class ResultsGrid
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pnlBack = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Results Grid";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(740, 325);
            dataGridView1.TabIndex = 1;
            // 
            // pnlBack
            // 
            pnlBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBack.BackColor = Color.Gray;
            pnlBack.Controls.Add(label1);
            pnlBack.Location = new Point(12, 12);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(776, 426);
            pnlBack.TabIndex = 2;
            // 
            // ResultsGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsGrid";
            Text = "ResultsGrid";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlBack.ResumeLayout(false);
            pnlBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel pnlBack;
    }
}