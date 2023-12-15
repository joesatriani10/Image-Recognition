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
        private List<FolderFile> _folderFile = new List<FolderFile>();

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

                    var files = _dInfo.GetFiles();
                    foreach (var file in files)
                    {
                        
                        _folderFile.Add(new FolderFile
                        {
                            FileName = file.Name, 
                            FilePath = file.FullName,
                            FileExtension = file.Extension
                        });
                    }

                    
                    dgFiles.DataSource = null; 
                    dgFiles.DataSource = _folderFile;

                    // Set the DataGridView control's border and Style.
                    dgFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgFiles.AllowUserToAddRows = false;
                    dgFiles.RowHeadersVisible = false;
                    this.dgFiles.Columns[2].Visible = false; //Hide the FileExtension column

                }
                else
                {
                    MessageBox.Show(@"Looks like the folder doesn't exist", @"Folder doesn't exist");
                }
            }

        }
    }
}
