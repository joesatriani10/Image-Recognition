using System.Drawing.Text;

namespace Image_Recognition
{
    public partial class Main : Form
    {
        private Button? _lastClicked;
        private readonly FolderSelection _folderSelectionForm = new FolderSelection()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };

        private readonly ResultsGrid _resultsGrid = new ResultsGrid()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };

        private readonly ResultsThumbnails _resultsThumbnails = new ResultsThumbnails()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };

        private readonly Settings _settings = new Settings()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };


        public Main()
        {
            InitializeComponent();

            // Set the first button to be selected

            GetSelected(btnFolderSelect);

            this.pnlFormLoader.Controls.Add(_folderSelectionForm);
            _folderSelectionForm.Show();

        }


        private void RefreshPnlNav()
        {
            if (_lastClicked != null)
            {
                pnlNav.Hide();
                pnlNav.Height = _lastClicked.Height;
                pnlNav.Top = _lastClicked.Top;
                pnlNav.Left = _lastClicked.Left;
                pnlNav.Show();
            }
        }

        private void GetSelected(Button? button)
        {
            _lastClicked = button;
            // Set buttons to normal color

            RestoreButtonColors();

            if (button != null)
            {
                button.BackColor = Color.FromArgb(81, 81, 81);
                button.ForeColor = Color.FromArgb(255, 131, 131);
            }


            // Set pnlNav to button
            RefreshPnlNav();
        }


        private void RestoreButtonColors()
        {
            SetButtonColors(btnFolderSelect);
            SetButtonColors(btnGrid);
            SetButtonColors(btnThumbnails);
            SetButtonColors(btnSettings);

        }

        private void SetButtonColors(Button button)
        {
            button.BackColor = Color.FromArgb(57, 57, 57);
            button.ForeColor = Color.Gainsboro;
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(_folderSelectionForm);
            _folderSelectionForm.Show();

            GetSelected(btnFolderSelect);
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(_resultsGrid);
            _resultsGrid.Show();

            GetSelected(btnGrid);
        }

        private void btnThumbnails_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(_resultsThumbnails);
            _resultsThumbnails.Show();

            GetSelected(btnThumbnails);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(_settings);
            _settings.Show();

            GetSelected(btnSettings);
        }
    }
}
