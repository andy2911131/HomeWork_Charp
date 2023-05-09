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
    public partial class Screensaver : Form
    {
        public Screensaver()
        {
            InitializeComponent();
           
        }
        //關閉
        private void Screensaver_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Screensaver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

           
        //設定定時
        private void Screensaver_Load(object sender, EventArgs e)
        {   
            timer1.Interval= 400;
            timer1.Enabled= true;
        }

        //圖片動起來
        int x = 45;
        int y = 45;
        private void timer1_Tick(object sender, EventArgs e)
        {         
          pictureBox1.Left += x;
            pictureBox1.Top += y;
            if (pictureBox1.Top + pictureBox1.Height >= Screen.PrimaryScreen.WorkingArea.Height
                || pictureBox1.Top <= 0) 
            {
                y *= -1;
            }
            if (pictureBox1.Left + pictureBox1.Width >= Screen.PrimaryScreen.WorkingArea.Width
              || pictureBox1.Left <= 0) 
            {
                x *= -1;
            }

        }
    }
  

}
