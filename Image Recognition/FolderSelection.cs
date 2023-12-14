using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Recognition
{
    public partial class FolderSelection : Form
    {

        private string _browsePath = "";
        private DirectoryInfo? _dInfo = null;

        public FolderSelection()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var openFolder = new FolderBrowserDialog();
            openFolder.ShowDialog();
            if (string.IsNullOrEmpty(openFolder.SelectedPath))
            {
                MessageBox.Show(@"Please select a folder");

            }
            else
            {
                _browsePath = openFolder.SelectedPath;
                lblDisplay.Text = _browsePath;


                _dInfo = new DirectoryInfo(_browsePath);

                if (_dInfo.Exists)
                {
                    lblDisplay.Text = _dInfo.GetFiles().Length.ToString();
                }
                else
                {
                    MessageBox.Show(@"Looks like the folder doesn't exist", @"Folder doesn't exist");
                }
            }

        }
    }
}
