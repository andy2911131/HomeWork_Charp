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
    public partial class Student_GradeList : Form
    {
        public Student_GradeList()
        {
            InitializeComponent();
        }
        String Name;
        int Ch = 0;
        int Eng = 0;
        int Math = 0;
        double All;
        double Avg;
        String Result;

        List<string> NameList = new List<string>();
        List<int> ChList = new List<int>();
        List<int> EngList = new List<int>();
        List<int> MathList = new List<int>();
        List<double> MaxList = new List<double>();
        List<double> MinList = new List<double>();


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textName.Text == string.Empty)
            {
                MessageBox.Show("請輸入姓名。", "請認真輸入", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textCh.Text == string.Empty)
            {
                MessageBox.Show("請輸入國文。", "請認真輸入！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textEng.Text == string.Empty)
            {
                MessageBox.Show("請輸入英文。", "請認真輸入！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textMath.Text == string.Empty)
            {
                MessageBox.Show("請輸入數學。", "請認真輸入！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Name = textName.Text;
                Ch = int.Parse(textCh.Text);
                Eng = int.Parse(textEng.Text);
                Math = int.Parse(textMath.Text);

                NameList.Add(Name);
                ChList.Add(Ch);
                EngList.Add(Eng);
                MathList.Add(Math);

                //秀出資料
                int[] score = new int[] { Ch, Eng, Math };
                string[] subject = new string[] { "國文", "英文", "數學" };
                string personmax_s = subject[0]; //個人最高分的科目
                string personmin_s = subject[0]; //個人最低分的科目

                int personmax = score[0];  //個人最高分
                int personmin = score[0]; //個人最低分
                for (int i = 1; i < score.Length; i++)
                {
                    if (score[i] > personmax)
                    {
                        personmax = score[i];
                        personmax_s = subject[i];
                    }
                    if (score[i] < personmin)
                    {
                        personmin = score[i];
                        personmin_s = subject[i];
                    }
                }

                string result_min = personmin_s + personmin; //個人最低分結果
                string result_max = personmax_s + personmax; //個人最高分結果

                ListViewItem item = new ListViewItem(Name);

                //秀出資料

                All = Ch + Eng + Math;
                Avg = All / 3;

                item.SubItems.Add(Ch.ToString());
                item.SubItems.Add(Eng.ToString());
                item.SubItems.Add(Math.ToString());
                item.SubItems.Add(All.ToString());
                item.SubItems.Add(Avg.ToString());
                item.SubItems.Add(result_min.ToString());
                item.SubItems.Add(result_max.ToString());
                listView.Items.Add(item);
                btnCount.Enabled = true;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
