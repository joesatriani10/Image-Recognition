using System.Drawing.Text;

namespace Image_Recognition
{
    public partial class Main : Form
    {
        private Font originalFont;
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

                pnlNav2.Hide();
                pnlNav2.Height = 2;
                pnlNav2.Width = _lastClicked.Width + 15;
                pnlNav2.Top = _lastClicked.Top + _lastClicked.Height - 2;
                pnlNav2.Left = _lastClicked.Left;


                pnlNav2.Show();
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
                button.ForeColor = Color.NavajoWhite;
                button.Font = new Font(button.Font.FontFamily, 10, button.Font.Style | FontStyle.Bold);
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
            button.Font = new Font(button.Font.FontFamily, 9, button.Font.Style | FontStyle.Regular);
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