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

            var largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(128, 128);

            listView1.LargeImageList = largeImageList;

            var files = SharedData.FolderFiles;

            int imageIndex = 0; // Start with 0

            foreach (var file in files)
            {
                var imagePath = file.FilePath;

                if (File.Exists(imagePath))
                {
                    var image = Image.FromFile(imagePath);
                    largeImageList.Images.Add(image);

                    var item = new ListViewItem($"{file.PredictionLabel} {file.Score}", imageIndex); // Assign imageIndex!

                    if (file.PredictionLabel == "Cat")
                    {
                        item.ForeColor = Color.YellowGreen;
                    }
                    else if (file.PredictionLabel == "Dog")
                    {
                        item.ForeColor = Color.Red;
                    }

                    listView1.Items.Add(item);
                    imageIndex++; // Increment for the next image
                }
            }
        }

        private void ResultsThumbnails_Load(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadImages();
        }
    }
}