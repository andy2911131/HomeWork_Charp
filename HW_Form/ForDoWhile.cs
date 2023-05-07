using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_Form
{
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }
        //清除結果欄
        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果:";
        }
        //奇偶數
        private void brnOddEven_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(txtOddEven.Text);
                if (i % 2 == 0)
                {
                    labResult.Text = "輸入的數為" + txtOddEven.Text + "是偶數";
                }
                else
                {
                    labResult.Text = "輸入的數為" + txtOddEven.Text + "是奇數";
                }
            }
            catch
            {
                MessageBox.Show("請輸入整數");
            }
        }
        //陣列奇偶數的數量
        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnArry_OddEven_Click(object sender, EventArgs e)
        {
            int Odd = 0;
            int Even = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    Odd++;
                }
                else
                {
                    Even++;
                }

            }

            labResult.Text = "int陣列[ ] arr0711 [ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n奇數共 " + Odd + "個\n偶數共 " + Even + "個";
        }
        //陣列中最大最小值 out回傳
        void MaxMin(out int max, out int min)
        {
            max = arr0711[0];
            min = arr0711[0];
            for (int i = 1; i < arr0711.Length; i++)
            {
                if (arr0711[i] > max)
                {
                    max = arr0711[i];
                }
                if (arr0711[i] < min)
                {
                    min = arr0711[i];
                }
            }
        }
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int max = 0;
            int min = 0;
            MaxMin(out max, out min);
            labResult.Text = "int陣列[ ] arr0711 [ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 " + max+ "\n最小值為" + min;
        }


        string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

        //陣列中最長的名字
        private void btnArrNameMax_Click(object sender, EventArgs e)
        {
            int max = 0;
            string max_name = "";
            for (int i = 1; i < arr0711_Str.Length; i++)
            {
                if (arr0711_Str[i].Length > max)
                {
                    max = arr0711_Str[i].Length;
                    max_name = arr0711_Str[i];
                }
            }
            labResult.Text = "string陣列[ ]arr0711_Str [mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]\n最長的名字為:" + max_name + " ，共" + max + "字";
        }

        //樂透
        private void btnLotto_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] lotto = new int[49]; //將所有號碼(1~49)放入陣列loto中
            for (int i = 0; i <lotto.Length; i++)
            {
                lotto[i] = i + 1;
            }
            int[] x = new int[6]; //宣告要取多少個數字
            Random r = new Random();
            for (int j = 0; j <x.Length; j++)
            {
                int k = r.Next(1, 49); //隨機抓取一組數字放入x[]陣列中
                if (lotto[k] == 0) 
                { j--; }//如果數字為0，則重新產生亂數
                else
                {
                    x[j] = lotto[k]; //否則將亂數產生之數字放入x[]陣列中
                    result += x[j].ToString()+" " ;
                    lotto[k] = 0; //將以使用之數字以零取代
                    labResult.Text = "樂透號碼\n" + result;
                }
            }
        }

        //100的二進位
        private void btnBinary_Click(object sender, EventArgs e)
        {
            //Convert.ToString(dec, 2)
            labResult.Text = Convert.ToString(100, 2);
        }

        //聖誕樹
        private void btnTree_Click(object sender, EventArgs e)
        {
            try {
                int rows = int.Parse(txtRows.Text);
                string result = "";

                for (int i = 1; i <= rows; i++)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        result += "*";
                    }
                    result += "\r\n";
                }

                labResult.Text = result;
            }
            catch 
            {
                MessageBox.Show("請輸入數值");
            }
            }

        //九九乘法表
        private void btn9x9_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            for (int i = 1 ; i<10 ; i++) 
            {
                for( int j = 2 ; j<10 ; j++) 
                {
                    labResult.Text += string.Format("{0}x {1,3}={2,5} |\t\t\t", j, i, (j*i));
                }
                labResult.Text += "\n";
            }
        }

        //Swap
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;          
            labResult.Text = $"換位前n1={n1} , n2={n2}\n";
            Swap(ref n1, ref n2);
            labResult.Text += $"換位後n1={n1} , n2={n2}\n";
            
        }
        //陣列加總
        private void btnarrSum_Click(object sender, EventArgs e)
        {
            int sum = arr0711.Sum();
            labResult.Text = "int陣列[ ] arr0711 [ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n加總為 "+ sum;
        }

        //陣列最大值 
   
        private void btnarrMax_Click(object sender, EventArgs e)
        {
            int max02;
            int min02;
            MaxMin(out max02, out min02);

            labResult.Text = "int陣列[ ] arr0711 [ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 " + max02;
        }
        //陣列最小值
        private void btnMin_Click(object sender, EventArgs e)
        {
            int max02;
            int min02;
            MaxMin(out max02, out min02);

            labResult.Text = "int陣列[ ] arr0711 [ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最小值為 " + min02;
        }

        //搜尋字串陣列中有幾個人的名字有C和c
        private void btnArrC_Click(object sender, EventArgs e)
        {
            int count = 0;
            char ch = 'C';

            for(int i =0 ; i<arr0711_Str.Length ; i++) 
            {
                if (arr0711_Str[i].ToUpper().Contains(ch))
                {
                    count++;
                }
            }        
            labResult.Text = "string陣列[ ]arr0711_Str [mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]\n最C及c的名字共有:" + count +" 個";
        }
    }
}
