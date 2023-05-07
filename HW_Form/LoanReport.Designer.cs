namespace HW_Form
{
    partial class LoanReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_year = new System.Windows.Forms.Label();
            this.Lab_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportL = new System.Windows.Forms.TextBox();
            this.reportT = new System.Windows.Forms.TextBox();
            this.reportR = new System.Windows.Forms.TextBox();
            this.reportM = new System.Windows.Forms.TextBox();
            this.reportrall = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(171, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "月付款";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(171, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "利率(%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_year
            // 
            this.lab_year.Font = new System.Drawing.Font("新細明體", 15F);
            this.lab_year.Location = new System.Drawing.Point(171, 127);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(100, 23);
            this.lab_year.TabIndex = 5;
            this.lab_year.Text = "期限(年)";
            this.lab_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_money
            // 
            this.Lab_money.Font = new System.Drawing.Font("新細明體", 15F);
            this.Lab_money.Location = new System.Drawing.Point(171, 77);
            this.Lab_money.Name = "Lab_money";
            this.Lab_money.Size = new System.Drawing.Size(100, 23);
            this.Lab_money.TabIndex = 4;
            this.Lab_money.Text = "貸款金額";
            this.Lab_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(171, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "總付款";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportL
            // 
            this.reportL.Font = new System.Drawing.Font("新細明體", 12F);
            this.reportL.Location = new System.Drawing.Point(308, 73);
            this.reportL.Name = "reportL";
            this.reportL.ReadOnly = true;
            this.reportL.Size = new System.Drawing.Size(100, 27);
            this.reportL.TabIndex = 9;
            this.reportL.UseWaitCursor = true;
            // 
            // reportT
            // 
            this.reportT.Font = new System.Drawing.Font("新細明體", 12F);
            this.reportT.Location = new System.Drawing.Point(308, 123);
            this.reportT.Name = "reportT";
            this.reportT.ReadOnly = true;
            this.reportT.Size = new System.Drawing.Size(100, 27);
            this.reportT.TabIndex = 10;
            this.reportT.UseWaitCursor = true;
            // 
            // reportR
            // 
            this.reportR.Font = new System.Drawing.Font("新細明體", 12F);
            this.reportR.Location = new System.Drawing.Point(308, 176);
            this.reportR.Name = "reportR";
            this.reportR.ReadOnly = true;
            this.reportR.Size = new System.Drawing.Size(100, 27);
            this.reportR.TabIndex = 11;
            this.reportR.UseWaitCursor = true;
            // 
            // reportM
            // 
            this.reportM.Font = new System.Drawing.Font("新細明體", 12F);
            this.reportM.Location = new System.Drawing.Point(308, 222);
            this.reportM.Name = "reportM";
            this.reportM.ReadOnly = true;
            this.reportM.Size = new System.Drawing.Size(100, 27);
            this.reportM.TabIndex = 12;
            this.reportM.UseWaitCursor = true;
            // 
            // reportrall
            // 
            this.reportrall.Font = new System.Drawing.Font("新細明體", 12F);
            this.reportrall.Location = new System.Drawing.Point(308, 268);
            this.reportrall.Name = "reportrall";
            this.reportrall.ReadOnly = true;
            this.reportrall.Size = new System.Drawing.Size(100, 27);
            this.reportrall.TabIndex = 13;
            this.reportrall.UseWaitCursor = true;
            // 
            // LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportrall);
            this.Controls.Add(this.reportM);
            this.Controls.Add(this.reportR);
            this.Controls.Add(this.reportT);
            this.Controls.Add(this.reportL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.Lab_money);
            this.Name = "LoanReport";
            this.Text = "LoanReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label Lab_money;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox reportL;
        public System.Windows.Forms.TextBox reportT;
        public System.Windows.Forms.TextBox reportR;
        public System.Windows.Forms.TextBox reportM;
        public System.Windows.Forms.TextBox reportrall;
    }
}