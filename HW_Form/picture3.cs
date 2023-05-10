using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class picture3 : Form
    {
        public delegate void ChangePictureHandler(Bitmap bit);
        public event ChangePictureHandler Form2_ChangePicture;
        private Bitmap BitImage;
        public picture3(Bitmap bit)
        {
            InitializeComponent();
            BitImage = bit;
            this.pictureBox1.Image = bit;
        }
    }
}
