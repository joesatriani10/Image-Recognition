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
using static System.Formats.Asn1.AsnWriter;

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


        private async void button1_Click_1(object sender, EventArgs e)
        {
            lblSelect.Visible = false;
            btnSelect.ForeColor = Color.Black;
            btnSelect.BackColor = Color.Gainsboro;

            var openFolder = new FolderBrowserDialog();
            openFolder.ShowDialog();
            if (string.IsNullOrEmpty(openFolder.SelectedPath))
            {
                MessageBox.Show(@"Please select a folder");
                lblDisplay.Text = @"Please select a folder";
                _browsePath = "";
                lblDisplay.ForeColor = Color.Gainsboro;
            }
            else
            {
                _browsePath = openFolder.SelectedPath;
                lblDisplay.Text = _browsePath;
                lblDisplay.ForeColor = Color.DarkGreen;

                _dInfo = new DirectoryInfo(_browsePath);

                if (_dInfo.Exists)
                {

                    var files = _dInfo.GetFiles();
                    foreach (var file in files)
                    {
                        // check if is jpg
                        if (file.Extension is ".jpg" or ".jpeg" or ".png")
                        {
                            SharedData.FolderFiles.Add(new FolderFile
                            {
                                FileName = file.Name,
                                FilePath = file.FullName,
                                FileExtension = file.Extension
                            });

                            SharedData.FileCount++;
                        }
                    }

                    lblFileCount.Text = $"{SharedData.FileCount} Images";

                    dgFiles.DataSource = null;
                    dgFiles.DataSource = SharedData.FolderFiles;

                    // Set the DataGridView control's border and Style.
                    dgFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgFiles.AllowUserToAddRows = false;
                    dgFiles.RowHeadersVisible = false;
                    this.dgFiles.Columns[2].Visible = false; //Hide the FileExtension column

                }
                else
                {
                    MessageBox.Show(@"Looks like the folder doesn't exist", @"Folder doesn't exist");
                    lblDisplay.Text = @"Please select a folder";
                    lblDisplay.ForeColor = Color.Gainsboro;
                }
            }

        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {


            //Load sample data
            var imageBytes = File.ReadAllBytes(@"C:\Users\Winchester\Downloads\Models\Other\Cat\400.jpg");
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            lblDisplay.Text = result.PredictedLabel;

        }
    }
}
