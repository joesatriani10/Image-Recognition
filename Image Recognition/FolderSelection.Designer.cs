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
            lblDisplay = new Label();
            dgFiles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgFiles).BeginInit();
            SuspendLayout();
            // 
            // tbPath
            // 
            tbPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPath.BorderStyle = BorderStyle.FixedSingle;
            tbPath.Location = new Point(27, 30);
            tbPath.MinimumSize = new Size(0, 30);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(642, 30);
            tbPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.ForeColor = Color.Gainsboro;
            lblDisplay.Location = new Point(27, 63);
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
            dgFiles.Location = new Point(27, 96);
            dgFiles.MultiSelect = false;
            dgFiles.Name = "dgFiles";
            dgFiles.ReadOnly = true;
            dgFiles.Size = new Size(732, 325);
            dgFiles.TabIndex = 3;
            // 
            // FolderSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(800, 450);
            Controls.Add(dgFiles);
            Controls.Add(lblDisplay);
            Controls.Add(btnSelect);
            Controls.Add(tbPath);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FolderSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FolderSelection";
            ((System.ComponentModel.ISupportInitialize)dgFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPath;
        private Button btnSelect;
        private Label lblDisplay;
        private DataGridView dgFiles;
    }
}