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
    public partial class hello_form : Form
    {

        public hello_form()
        {
            InitializeComponent();
        }

        private void btnsayhi_Click(object sender, EventArgs e)
        {
            string name1 = txtname.Text;
            string name2 = textegname.Text;
            string sex = textsex.Text;
            string star = textstar.Text;
            MessageBox.Show("Hi，我是" + name1 + ","
                + "\n英文名字是" + name2 + ","
                + "\n性別是" + sex + ","
                + "\n星座是" + star + ","
                + "\n很高興認識你！！");
        }

        private void btnsayhello_Click(object sender, EventArgs e)
        {
            string name1 = txtname.Text;
            string name2 = textegname.Text;
            string sex = textsex.Text;
            string star = textstar.Text;
            MessageBox.Show("Hello，我是" + name1 + ","
                + "\n英文名字是" + name2 + ","
                + "\n性別是" + sex + ","
                + "\n星座是" + star + ","
                + "\n很高興認識你！！");
        }
    }
}
