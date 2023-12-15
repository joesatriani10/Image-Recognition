namespace Image_Recognition
{
    partial class ResultsThumbnails
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
            pnlBack = new Panel();
            listView1 = new ListView();
            label1 = new Label();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBack
            // 
            pnlBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBack.BackColor = Color.Gray;
            pnlBack.Controls.Add(listView1);
            pnlBack.Controls.Add(label1);
            pnlBack.Location = new Point(12, 12);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(776, 426);
            pnlBack.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(18, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(740, 325);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 52);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Results Thumbnails";
            // 
            // ResultsThumbnails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsThumbnails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResultsThumbnails";
            pnlBack.ResumeLayout(false);
            pnlBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBack;
        private Label label1;
        private ListView listView1;
    }
}