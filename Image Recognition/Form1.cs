namespace Image_Recognition
{
    public partial class Main : Form
    {
        private Button? _lastClicked;

        public Main()
        {
            InitializeComponent();

            // Set the first button to be selected
            GetPnlNav(btnFolderSelect);
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            
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

        private void GetPnlNav(Button? button)
        {
            _lastClicked = button;
            // Set buttons to normal color

            RestoreButtonColors();      

            if(button != null)
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

    }
}
