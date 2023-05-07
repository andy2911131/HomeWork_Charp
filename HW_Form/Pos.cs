using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }


        const int cola = 50, wings = 60, chisteak = 100, QQ = 70;
        int totalprice = 0;
        int cola_n = 0, wings_n = 0, chisteak_n = 0, QQ_n = 0;
     
        string colals, winsgls, chisteakls, qqls;

       //可樂按鈕
        private void btncola_Click(object sender, EventArgs e)
        {
            totalprice += cola;
            textTotalprice.Text = "NT$" + totalprice;
            
            cola_n++;
                colals = "快樂肥宅水*" + cola_n + "NT$" + (cola_n * cola) + "元\r\n";
            TextList.Text = colals +  winsgls   + chisteakls   + qqls  ;
        }
        //雞翅按鈕
        private void btnwings_Click(object sender, EventArgs e)
        {
            totalprice += wings;
            textTotalprice.Text = "NT$" + totalprice;
            wings_n++;
            
                winsgls = "雞翅*" + wings_n + "NT$" + (wings_n * wings) + "元\r\n";
            TextList.Text = colals  + winsgls  + chisteakls  + qqls ;
        }
        //雞排按鈕
        private void btnchisteak_Click(object sender, EventArgs e)
        {
            totalprice += chisteak;
            textTotalprice.Text = "NT$" + totalprice;
            chisteak_n++;          
            
                chisteakls = "雞排*" + chisteak_n + "NT$" +( chisteak_n * chisteak) + "元\r\n";
            TextList.Text = colals  + winsgls + chisteakls + qqls  ;
        }
        //QQ球按鈕
        private void btnQQ_Click(object sender, EventArgs e)
        {
            totalprice += QQ;
            textTotalprice.Text = "NT$" + totalprice;
            QQ_n++;
            qqls = "QQ球*" + QQ_n+ "NT$" +(QQ_n * QQ) + "元\r\n";
            TextList.Text = colals +   winsgls +   chisteakls + qqls ;
        }
        //清除按鈕
        private void btnclear_Click(object sender, EventArgs e)
        {
            textTotalprice.Text = "NT$"+0;
            TextList.Text = "尚未點餐";
            totalprice = 0;
            cola_n = 0;
            wings_n = 0;
            chisteak_n = 0;
            QQ_n = 0;
            colals = string.Empty;
            winsgls = string.Empty;
           chisteakls = string.Empty;
            qqls = string.Empty;

        }
        //現金按鈕
        private void btncash_Click(object sender, EventArgs e)
        {
            if (totalprice ==0)
            {
                MessageBox.Show("尚未點餐！", "尚未點餐", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("總金額:" + totalprice.ToString(), "確認付款", MessageBoxButtons.YesNoCancel);
            }
            }
        //信用卡按鈕
        private void btncard_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("尚未點餐！", "尚未點餐", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           else
                    {
                        MessageBox.Show("總金額:" + totalprice + "\n折扣後金額:" + 0.9 * totalprice,
                "確認付款", MessageBoxButtons.YesNoCancel);
            }
        }

    }
}
