using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_Recognition
{
    public partial class ResultsThumbnails : Form
    {
        public ResultsThumbnails()
        {
            InitializeComponent();
        }


        private void LoadImages()
        {
            listView1.Items.Clear();
            ImageList largeImageList = new ImageList();
            ImageList smallImageList = new ImageList();

            largeImageList.ImageSize = new Size(64, 64);
            smallImageList.ImageSize = new Size(32, 32);

            listView1.LargeImageList = largeImageList;
            listView1.SmallImageList = smallImageList;

            var files = SharedData.FolderFiles;

            // ImageIndex must be unique for each ListViewItem
            int imageIndex = 0; // Start with 0

            foreach (var file in files)
            {
                var imagePath = file.FilePath;

                if (File.Exists(imagePath))
                {
                    var image = Image.FromFile(imagePath);
                    largeImageList.Images.Add(image);
                    smallImageList.Images.Add(image);

                    var item = new ListViewItem(file.FileName, imageIndex); // Assign imageIndex!
                    item.SubItems.Add(file.FileExtension);
                    item.SubItems.Add(file.PredictionLabel);

                    listView1.Items.Add(item);
                    imageIndex++; // Increment for the next image
                }
            }
        }

        private void ResultsThumbnails_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadImages();
        }
    }
}