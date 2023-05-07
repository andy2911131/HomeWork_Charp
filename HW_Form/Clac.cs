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
    public partial class Clac : Form
    {
        public Clac()
        {
            InitializeComponent();
        }
        
        double number1;
        double number2;
        double result = 0;
        //加法計算
        private void btnplus_Click(object sender, EventArgs e)
        {
            try
            {
                 number1 = Double.Parse(textNum1.Text);
                 number2 = Double.Parse(textNum2.Text);
               result = number1 + number2;
                textAnswer.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值");
            }
            }
        //減法計算
        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Double.Parse(textNum1.Text);
                number2 = Double.Parse(textNum2.Text);
                result = number1 - number2;
                textAnswer.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值");
            }
        }
        //乘法計算
        private void btnmultiply_Click(object sender, EventArgs e)
        {
            try
            {
                 number1 = Double.Parse(textNum1.Text);
                number2 = Double.Parse(textNum2.Text);
                result = number1 *number2;
                textAnswer.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值");
            }
        }
        //除法計算
        private void btndivide_Click(object sender, EventArgs e)
        {
            try
            {
                 number1 = Double.Parse(textNum1.Text);
                number2 = Double.Parse(textNum2.Text);
                result = number1 /number2;
                textAnswer.Text = result.ToString() ;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數值");
            }
        }
        //清除
        private void btnClear_Click(object sender, EventArgs e)
        {
           number1 =0;
           number2 = 0;
            textNum1.Text = number1.ToString();
            textNum2.Text = number2.ToString();
            textAnswer.Text = result. ToString();
        }
    }
    }

