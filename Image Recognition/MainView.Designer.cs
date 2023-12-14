namespace Image_Recognition
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlFormLoader = new Panel();
            pnlMenu = new Panel();
            pnlNav = new Panel();
            btnSettings = new Button();
            btnThumbnails = new Button();
            btnGrid = new Button();
            btnFolderSelect = new Button();
            pnlUser = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlMenu.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormLoader.Location = new Point(232, 0);
            pnlFormLoader.Margin = new Padding(3, 2, 3, 2);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1138, 600);
            pnlFormLoader.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(57, 57, 57);
            pnlMenu.Controls.Add(pnlNav);
            pnlMenu.Controls.Add(btnSettings);
            pnlMenu.Controls.Add(btnThumbnails);
            pnlMenu.Controls.Add(btnGrid);
            pnlMenu.Controls.Add(btnFolderSelect);
            pnlMenu.Controls.Add(pnlUser);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 2, 3, 2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(233, 602);
            pnlMenu.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Gainsboro;
            pnlNav.Location = new Point(0, 108);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(4, 128);
            pnlNav.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Location = new Point(0, 547);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(233, 55);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnThumbnails
            // 
            btnThumbnails.Dock = DockStyle.Top;
            btnThumbnails.FlatAppearance.BorderSize = 0;
            btnThumbnails.FlatStyle = FlatStyle.Flat;
            btnThumbnails.ForeColor = Color.Gainsboro;
            btnThumbnails.Location = new Point(0, 210);
            btnThumbnails.Name = "btnThumbnails";
            btnThumbnails.Size = new Size(233, 55);
            btnThumbnails.TabIndex = 3;
            btnThumbnails.Text = "Results Thubnails";
            btnThumbnails.TextAlign = ContentAlignment.MiddleLeft;
            btnThumbnails.UseVisualStyleBackColor = true;
            btnThumbnails.Click += btnThumbnails_Click;
            // 
            // btnGrid
            // 
            btnGrid.Dock = DockStyle.Top;
            btnGrid.FlatAppearance.BorderSize = 0;
            btnGrid.FlatStyle = FlatStyle.Flat;
            btnGrid.ForeColor = Color.Gainsboro;
            btnGrid.Location = new Point(0, 155);
            btnGrid.Name = "btnGrid";
            btnGrid.Size = new Size(233, 55);
            btnGrid.TabIndex = 2;
            btnGrid.Text = "Results Grid";
            btnGrid.TextAlign = ContentAlignment.MiddleLeft;
            btnGrid.UseVisualStyleBackColor = true;
            btnGrid.Click += btnGrid_Click;
            // 
            // btnFolderSelect
            // 
            btnFolderSelect.Dock = DockStyle.Top;
            btnFolderSelect.FlatAppearance.BorderSize = 0;
            btnFolderSelect.FlatStyle = FlatStyle.Flat;
            btnFolderSelect.ForeColor = Color.Gainsboro;
            btnFolderSelect.Location = new Point(0, 100);
            btnFolderSelect.Name = "btnFolderSelect";
            btnFolderSelect.Size = new Size(233, 55);
            btnFolderSelect.TabIndex = 1;
            btnFolderSelect.Text = "Folder Selection";
            btnFolderSelect.TextAlign = ContentAlignment.MiddleLeft;
            btnFolderSelect.UseVisualStyleBackColor = true;
            btnFolderSelect.Click += btnFolderSelect_Click;
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.DimGray;
            pnlUser.Controls.Add(pictureBox1);
            pnlUser.Controls.Add(label2);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(0, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(233, 100);
            pnlUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 58);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 81, 81);
            ClientSize = new Size(1370, 602);
            Controls.Add(pnlMenu);
            Controls.Add(pnlFormLoader);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Recognition";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormLoader;
        private Panel pnlMenu;
        private Panel pnlUser;
        private Label label2;
        private Button btnFolderSelect;
        private Button btnThumbnails;
        private Button btnGrid;
        private Panel pnlNav;
        private Button btnSettings;
        private PictureBox pictureBox1;
    }
}
