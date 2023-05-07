using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class Student_sturct_Form : Form
    {
        public Student_sturct_Form()
        {
            InitializeComponent();
        }
        String Name ;       
        Double Ch   ;
        Double Eng;
        Double Math ;
        String Result;
        
        //取得資料
        private void btnSave_Click(object sender, EventArgs e)
        {
            Name = textName.Text;   
            try
            {
                Ch = double.Parse(textChinese.Text);
                Eng = double.Parse(textEng.Text);
                Math = double.Parse(textMath.Text);
            }
            catch (Exception) 
            {
                MessageBox.Show("請輸入正確的分數");
                textChinese.Clear();
                textEng.Clear();
                textMath.Clear();

            }
            Result = "姓名:" + Name + "\n國文:" + Ch + "\n英文" + Eng + "\n數學:" + Math;
            
        }

        //顯示內容
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            labScore.Text = Result;
        }
        //最高分最低分計算
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
           double[]score = new double[] {Ch, Eng, Math};
           string[] subject = new string[] { "國文", "英文", "數學"};
            string maxname = subject[0];
            string minname = subject[0];
            
            double max = score[0];
            double min = score[0];
            for (int i = 1 ; i < score.Length; i++) 
            {
                if (score[i] > max) 
                {
                    max = score[i];
                    maxname = subject[i];
                }
                if (score[i] < min) 
                {
                    min = score[i];
                    minname = subject[i];
                }
            } // end of for loop
            labelMaxMin.Text = "最高分是" + maxname + max + "\n最低分是" + minname + min;

            //string max;
            //string min;
            //if (score[0] == score.Max())
            //{
            //    max = "最高分是國文" + score.Max();
            //}
            //else if (score[1] == score.Max())
            //{
            //    max = "最高分是英文" + score.Max();
            //}
            //else
            //{
            //    max = "最高分是數學" + score.Max();
            //}


            //if (score[0] == score.Min())
            //{
            //    min = "最低分是國文" + score.Min();
            //}
            //else if (score[1] == score.Max())
            //{
            //    min = "最低分是英文" + score.Min();
            //}
            //else
            //{
            //    min = "最低分是數學" + score.Min();
            //}
            //labelMaxMin.Text = max + "\n" + min;
        }
        
    }
}
