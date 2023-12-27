using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Recognition
{
    public partial class ImagePreview : Form
    {
        public ImagePreview()
        {
            InitializeComponent();
        }

        private void ImagePreview_KeyUp(object sender, KeyEventArgs e)
        {
            // Close when Escape key is released
            if (e.KeyData == Keys.Escape)
            {

                this.Close();

            }
        }
    }
}
