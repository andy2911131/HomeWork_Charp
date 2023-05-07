using Microsoft.VisualBasic;
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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

         
        //計算月付額的方法(回傳：月付額) 
        public int calMonthlyPayment()
        {
            double L = Convert.ToDouble(textLoan.Text);
            double T = Convert.ToDouble(txetTime.Text) * 12;
            double R = Convert.ToDouble(rate.Text) / 100 / 12;
            double D = Convert.ToDouble(downpayment.Text);
            //月付額 = 本金 *[(1＋月利率)^ 月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            int X = Convert.ToInt32((L - D) * (Math.Pow((1 + R), T) * R)
                        / (Math.Pow((1 + R), T) - 1));
            return X;
        }

         //計算月數的方法(回傳：月數) 
        public double calLoanMonth()
        {
            double T = Convert.ToDouble(txetTime.Text) * 12;
            return T;
        }

        //月付額
        private void btnmonthlypay_Click(object sender, EventArgs e)
        {
            int X = calMonthlyPayment();

            MessageBox.Show("月付額:" + X);
        }
        //總付款
        private void btnallmoney_Click(object sender, EventArgs e)
        {
            double T = calLoanMonth();
            int X = calMonthlyPayment();

            MessageBox.Show("總付款:" + X * T );
        }
        //報告
        private void button2_Click(object sender, EventArgs e)
        {
            LoanReport report = new LoanReport();

            double T = calLoanMonth();
            int X = calMonthlyPayment();

            report.reportL.Text = textLoan.Text;
            report.reportT.Text = txetTime.Text;
            report.reportR.Text = rate.Text;
            report.reportM.Text = X.ToString();
            report.reportrall.Text =(X * T).ToString();       
            report.Show();
        }
    }
}
