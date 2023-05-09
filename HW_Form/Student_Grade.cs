using System;
using System.Collections;
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
    public partial class Student_Grade : Form
    {
        public Student_Grade()
        {
            InitializeComponent();
        }
        String Name;      
        int Ch =0;
        int Eng =0;
        int Math =0;
        double All;
        double Avg;
        String Result;

        List<string> NameList =new List<string>();
        List<int> ChList = new List<int>();
        List<int> EngList = new List<int>();
        List<int> MathList = new List<int>();
        List<double> MaxList = new List<double>();
        List<double> MinList = new List<double>();
        //輸入
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
                string personmin_s= subject[0]; //個人最低分的科目

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
                if (NameList.Count > 100) 
                {
                    MessageBox.Show("記憶空間已滿，請先清除資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                    btnRandom.Enabled = false;
                    btnRandom20.Enabled = false;
                }
            }
        }
        //隨機
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            Ch = random.Next(0,100);
            Eng= random.Next(0,100);   
            Math= random.Next(0,100);
           
            Name= (NameList.Count+1).ToString();
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
            if (NameList.Count > 100)
            {
                MessageBox.Show("記憶空間已滿，請先清除資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                btnRandom.Enabled = false;
                btnRandom20.Enabled = false;
            }
        }
        //隨機20
        private void btnRandom20_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int j = 0; j< 20; j++) 
            {               
                Ch = random.Next(0, 100);
                Eng = random.Next(0, 100);
                Math = random.Next(0, 100);

                Name = (NameList.Count + 1).ToString();
                NameList.Add(Name);
                ChList.Add(Ch);
                EngList.Add(Eng);
                MathList.Add(Math);

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
            }
            btnCount.Enabled = true;
            if (NameList.Count > 100)
            {
                MessageBox.Show("記憶空間已滿，請先清除資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                btnRandom.Enabled = false;
                btnRandom20.Enabled = false;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NameList.Clear();
            ChList.Clear();
            EngList.Clear();
            MathList.Clear();         
            listView.Items.Clear();
            textBox.Text = null;
            btnCount.Enabled = false;
            btnSave.Enabled = true;
            btnRandom.Enabled = true;
            btnRandom20.Enabled = true;


        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int chall = ChList.Sum();
            int engall = EngList.Sum();
            int mathall = MathList.Sum();
            double chavg =ChList.Average();
            double engavg = EngList.Average();
            double mathavg = MathList.Average();
            int chmax = ChList.Max();
            int engmax = EngList.Max();
            int mathmax = MathList.Max();
            int chmin = ChList.Min();
            int engmin = EngList.Min();
            int mathmin = MathList.Min();


            textBox.Text = $"總分{null,-8}{chall,-12}{engall,-12}{mathall}\r\n" +
                $"平均{null,-8}{chavg:0.00}{null,-5}{engavg:0.00}{null,-5}{mathavg:0.00}\r\n" +
                $"最高分{null,-8}{chmax,-12}{engmax,-12}{mathmax}\r\n" +
                $"最低分{null,-8}{chmin,-12}{engmin,-12}{mathmin}";
        }

    
    } }


