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
            btnSelect = new Button();
            lblDisplay = new Label();
            dgFiles = new DataGridView();
            pnlBack = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgFiles).BeginInit();
            pnlBack.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BackColor = Color.Gainsboro;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(675, 49);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(86, 30);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += button1_Click_1;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.White;
            lblDisplay.Location = new Point(18, 52);
            lblDisplay.MinimumSize = new Size(100, 30);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(170, 30);
            lblDisplay.TabIndex = 2;
            lblDisplay.Text = "Please select a folder";
            // 
            // dgFiles
            // 
            dgFiles.AllowUserToAddRows = false;
            dgFiles.AllowUserToDeleteRows = false;
            dgFiles.AllowUserToOrderColumns = true;
            dgFiles.AllowUserToResizeColumns = false;
            dgFiles.AllowUserToResizeRows = false;
            dgFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgFiles.BorderStyle = BorderStyle.None;
            dgFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgFiles.Location = new Point(30, 96);
            dgFiles.MultiSelect = false;
            dgFiles.Name = "dgFiles";
            dgFiles.ReadOnly = true;
            dgFiles.Size = new Size(740, 325);
            dgFiles.TabIndex = 3;
            // 
            // pnlBack
            // 
            pnlBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBack.BackColor = Color.Gray;
            pnlBack.Controls.Add(btnSelect);
            pnlBack.Controls.Add(lblDisplay);
            pnlBack.Location = new Point(12, 12);
            pnlBack.Name = "pnlBack";
            pnlBack.Size = new Size(776, 426);
            pnlBack.TabIndex = 0;
            // 
            // FolderSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(800, 450);
            Controls.Add(dgFiles);
            Controls.Add(pnlBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FolderSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FolderSelection";
            ((System.ComponentModel.ISupportInitialize)dgFiles).EndInit();
            pnlBack.ResumeLayout(false);
            pnlBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSelect;
        private Label lblDisplay;
        private DataGridView dgFiles;
        private Panel pnlBack;
    }
}