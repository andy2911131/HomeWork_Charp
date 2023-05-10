using HW_Form.Properties;
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
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
            Picture1_Show();
            Picture2_Show();
            Picture3_Show();
            Picture4_Show();
            Picture5_Show();
            Picture6_Show();
        }
        Bitmap bit;//保存圖像
        Bitmap bit2;
        Bitmap bit3;
        Bitmap bit4;
        Bitmap bit5;
        Bitmap bit6;
        private void Picture1_Show()
        {
            bit = new Bitmap(Resource1._8);//運行前，開個資源檔把圖片丟上去再取用。
            this.pictureBox1.Image = bit;           
        }

        private void Picture2_Show()
        {
            bit2 = new Bitmap(Resource1._1);
            this.pictureBox2.Image = bit2;
        }

        private void Picture3_Show()
        {
            bit3 = new Bitmap(Resource1._5);
            this.pictureBox3.Image = bit3;
        }

        private void Picture4_Show()
        {
            bit4 = new Bitmap(Resource1._4);
            this.pictureBox4.Image = bit4;
        }

        private void Picture5_Show()
        {
            bit5 = new Bitmap(Resource1._6);
            this.pictureBox5.Image = bit5;
        }

        private void Picture6_Show()
        {
            bit6 = new Bitmap(Resource1._7);
            this.pictureBox6.Image = bit6;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picture1 pcture1 = new picture1(bit);
            pcture1.Show();
            Picture1_Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picture2 picture2 = new picture2(bit2);
            picture2.Show();
            Picture2_Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picture3 picture3 = new picture3(bit3);
            picture3.Show();
            Picture3_Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picture4 picture4 = new picture4(bit4);
            picture4.Show();
            Picture4_Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picture5 picture5 = new picture5(bit5);
            picture5.Show();
            Picture5_Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picture6 picture6 = new picture6(bit6);
            picture6.Show();
            Picture6_Show();
        }
    }
}
