namespace HW_Form
{
    partial class Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lab_money = new System.Windows.Forms.Label();
            this.lab_year = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLoan = new System.Windows.Forms.TextBox();
            this.txetTime = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.downpayment = new System.Windows.Forms.TextBox();
            this.btnmonthlypay = new System.Windows.Forms.Button();
            this.btnallmoney = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_money
            // 
            this.Lab_money.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lab_money.Location = new System.Drawing.Point(146, 134);
            this.Lab_money.Name = "Lab_money";
            this.Lab_money.Size = new System.Drawing.Size(100, 23);
            this.Lab_money.TabIndex = 0;
            this.Lab_money.Text = "貸款金額";
            this.Lab_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_year
            // 
            this.lab_year.Font = new System.Drawing.Font("新細明體", 15F);
            this.lab_year.Location = new System.Drawing.Point(146, 184);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(100, 23);
            this.lab_year.TabIndex = 1;
            this.lab_year.Text = "期限(年)";
            this.lab_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(146, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "利率(%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(146, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "頭期款";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLoan
            // 
            this.textLoan.Font = new System.Drawing.Font("新細明體", 12F);
            this.textLoan.Location = new System.Drawing.Point(278, 130);
            this.textLoan.Name = "textLoan";
            this.textLoan.Size = new System.Drawing.Size(100, 27);
            this.textLoan.TabIndex = 4;
            this.textLoan.Text = "100000";
            this.textLoan.UseWaitCursor = true;
            // 
            // txetTime
            // 
            this.txetTime.Font = new System.Drawing.Font("新細明體", 12F);
            this.txetTime.Location = new System.Drawing.Point(278, 180);
            this.txetTime.Name = "txetTime";
            this.txetTime.Size = new System.Drawing.Size(100, 27);
            this.txetTime.TabIndex = 5;
            this.txetTime.Text = "2";
            this.txetTime.UseWaitCursor = true;
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("新細明體", 12F);
            this.rate.Location = new System.Drawing.Point(278, 233);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 27);
            this.rate.TabIndex = 6;
            this.rate.Text = "10";
            this.rate.UseWaitCursor = true;
            // 
            // downpayment
            // 
            this.downpayment.Font = new System.Drawing.Font("新細明體", 12F);
            this.downpayment.Location = new System.Drawing.Point(278, 279);
            this.downpayment.Name = "downpayment";
            this.downpayment.Size = new System.Drawing.Size(100, 27);
            this.downpayment.TabIndex = 7;
            this.downpayment.Text = "0";
            this.downpayment.UseWaitCursor = true;
            // 
            // btnmonthlypay
            // 
            this.btnmonthlypay.Location = new System.Drawing.Point(525, 118);
            this.btnmonthlypay.Name = "btnmonthlypay";
            this.btnmonthlypay.Size = new System.Drawing.Size(123, 49);
            this.btnmonthlypay.TabIndex = 8;
            this.btnmonthlypay.Text = "PMT(月付額)";
            this.btnmonthlypay.UseVisualStyleBackColor = true;
            this.btnmonthlypay.Click += new System.EventHandler(this.btnmonthlypay_Click);
            // 
            // btnallmoney
            // 
            this.btnallmoney.Location = new System.Drawing.Point(525, 195);
            this.btnallmoney.Name = "btnallmoney";
            this.btnallmoney.Size = new System.Drawing.Size(123, 49);
            this.btnallmoney.TabIndex = 9;
            this.btnallmoney.Text = "總付款";
            this.btnallmoney.UseVisualStyleBackColor = true;
            this.btnallmoney.Click += new System.EventHandler(this.btnallmoney_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnallmoney);
            this.Controls.Add(this.btnmonthlypay);
            this.Controls.Add(this.downpayment);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.txetTime);
            this.Controls.Add(this.textLoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.Lab_money);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_money;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txetTime;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox downpayment;
        private System.Windows.Forms.Button btnmonthlypay;
        private System.Windows.Forms.Button btnallmoney;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textLoan;
    }
}