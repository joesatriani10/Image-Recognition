namespace Image_Recognition
{
    partial class FolderSelection
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
            tbPath = new TextBox();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // tbPath
            // 
            tbPath.BorderStyle = BorderStyle.FixedSingle;
            tbPath.Location = new Point(27, 30);
            tbPath.MinimumSize = new Size(0, 30);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(642, 30);
            tbPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Gainsboro;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(684, 30);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 30);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += button1_Click_1;
            // 
            // FolderSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(tbPath);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FolderSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FolderSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPath;
        private Button btnSelect;
    }
}