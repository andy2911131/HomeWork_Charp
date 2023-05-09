namespace HW_Form
{
    partial class ForDoWhile
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
            this.Labnum = new System.Windows.Forms.Label();
            this.txtOddEven = new System.Windows.Forms.TextBox();
            this.brnOddEven = new System.Windows.Forms.Button();
            this.btnArry_OddEven = new System.Windows.Forms.Button();
            this.btnArrNameMax = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnArrC = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnarrSum = new System.Windows.Forms.Button();
            this.btnarrMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnLotto = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btn9x9 = new System.Windows.Forms.Button();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Labnum
            // 
            this.Labnum.AutoSize = true;
            this.Labnum.Font = new System.Drawing.Font("新細明體", 12F);
            this.Labnum.Location = new System.Drawing.Point(10, 9);
            this.Labnum.Name = "Labnum";
            this.Labnum.Size = new System.Drawing.Size(62, 16);
            this.Labnum.TabIndex = 0;
            this.Labnum.Text = "Number:";
            // 
            // txtOddEven
            // 
            this.txtOddEven.Location = new System.Drawing.Point(78, 6);
            this.txtOddEven.Name = "txtOddEven";
            this.txtOddEven.Size = new System.Drawing.Size(62, 22);
            this.txtOddEven.TabIndex = 1;
            // 
            // brnOddEven
            // 
            this.brnOddEven.Font = new System.Drawing.Font("新細明體", 10F);
            this.brnOddEven.Location = new System.Drawing.Point(13, 45);
            this.brnOddEven.Name = "brnOddEven";
            this.brnOddEven.Size = new System.Drawing.Size(127, 44);
            this.brnOddEven.TabIndex = 2;
            this.brnOddEven.Text = "輸入的數為奇數或偶數?";
            this.brnOddEven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnOddEven.UseVisualStyleBackColor = true;
            this.brnOddEven.Click += new System.EventHandler(this.brnOddEven_Click);
            // 
            // btnArry_OddEven
            // 
            this.btnArry_OddEven.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnArry_OddEven.Location = new System.Drawing.Point(146, 6);
            this.btnArry_OddEven.Name = "btnArry_OddEven";
            this.btnArry_OddEven.Size = new System.Drawing.Size(186, 33);
            this.btnArry_OddEven.TabIndex = 3;
            this.btnArry_OddEven.Text = "陣列arr0711[]統計奇偶數";
            this.btnArry_OddEven.UseVisualStyleBackColor = true;
            this.btnArry_OddEven.Click += new System.EventHandler(this.btnArry_OddEven_Click);
            // 
            // btnArrNameMax
            // 
            this.btnArrNameMax.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnArrNameMax.Location = new System.Drawing.Point(146, 45);
            this.btnArrNameMax.Name = "btnArrNameMax";
            this.btnArrNameMax.Size = new System.Drawing.Size(187, 33);
            this.btnArrNameMax.TabIndex = 4;
            this.btnArrNameMax.Text = "陣列arr0711_Str[]最長的名字";
            this.btnArrNameMax.UseVisualStyleBackColor = true;
            this.btnArrNameMax.Click += new System.EventHandler(this.btnArrNameMax_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnMaxMin.Location = new System.Drawing.Point(146, 84);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(187, 33);
            this.btnMaxMin.TabIndex = 5;
            this.btnMaxMin.Text = "陣列arr0711[]最大/小值";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnArrC
            // 
            this.btnArrC.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnArrC.Location = new System.Drawing.Point(13, 123);
            this.btnArrC.Name = "btnArrC";
            this.btnArrC.Size = new System.Drawing.Size(320, 33);
            this.btnArrC.TabIndex = 6;
            this.btnArrC.Text = "陣列arr0711_Str[]xue \"C\"OR\"c\"的字樣有幾個";
            this.btnArrC.UseVisualStyleBackColor = true;
            this.btnArrC.Click += new System.EventHandler(this.btnArrC_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 10F);
            this.button6.Location = new System.Drawing.Point(364, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "[10,10]二維陣列-邊1,內0";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 10F);
            this.button7.Location = new System.Drawing.Point(364, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 33);
            this.button7.TabIndex = 8;
            this.button7.Text = "[10,10]二維陣列-邊0,內1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 10F);
            this.button8.Location = new System.Drawing.Point(364, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 70);
            this.button8.TabIndex = 9;
            this.button8.Text = "[10,10]二維陣列\r\n101010\r\n010101\r\n............\r\n";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnSwap.Location = new System.Drawing.Point(572, 8);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(186, 33);
            this.btnSwap.TabIndex = 10;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnarrSum
            // 
            this.btnarrSum.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnarrSum.Location = new System.Drawing.Point(572, 47);
            this.btnarrSum.Name = "btnarrSum";
            this.btnarrSum.Size = new System.Drawing.Size(186, 33);
            this.btnarrSum.TabIndex = 11;
            this.btnarrSum.Text = "Sum(陣列arr0711[])";
            this.btnarrSum.UseVisualStyleBackColor = true;
            this.btnarrSum.Click += new System.EventHandler(this.btnarrSum_Click);
            // 
            // btnarrMax
            // 
            this.btnarrMax.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnarrMax.Location = new System.Drawing.Point(572, 86);
            this.btnarrMax.Name = "btnarrMax";
            this.btnarrMax.Size = new System.Drawing.Size(186, 33);
            this.btnarrMax.TabIndex = 12;
            this.btnarrMax.Text = "Max(陣列arr0711[])";
            this.btnarrMax.UseVisualStyleBackColor = true;
            this.btnarrMax.Click += new System.EventHandler(this.btnarrMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnMin.Location = new System.Drawing.Point(572, 123);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(186, 33);
            this.btnMin.TabIndex = 13;
            this.btnMin.Text = "Min(陣列arr0711[])";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(566, 162);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(62, 22);
            this.txtRows.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(520, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rows:";
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.SystemColors.Info;
            this.btnBinary.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnBinary.Location = new System.Drawing.Point(631, 162);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(127, 22);
            this.btnBinary.TabIndex = 16;
            this.btnBinary.Text = "100的二進位是?";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnLotto
            // 
            this.btnLotto.BackColor = System.Drawing.SystemColors.Info;
            this.btnLotto.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnLotto.Location = new System.Drawing.Point(631, 190);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(127, 22);
            this.btnLotto.TabIndex = 17;
            this.btnLotto.Text = "樂透int[]號碼不重複";
            this.btnLotto.UseVisualStyleBackColor = false;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.SystemColors.Info;
            this.btnTree.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnTree.Location = new System.Drawing.Point(523, 190);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(102, 22);
            this.btnTree.TabIndex = 18;
            this.btnTree.Text = "直角聖誕樹";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btn9x9
            // 
            this.btn9x9.BackColor = System.Drawing.SystemColors.Info;
            this.btn9x9.Font = new System.Drawing.Font("新細明體", 10F);
            this.btn9x9.Location = new System.Drawing.Point(523, 218);
            this.btn9x9.Name = "btn9x9";
            this.btn9x9.Size = new System.Drawing.Size(102, 22);
            this.btn9x9.TabIndex = 19;
            this.btn9x9.Text = "九九乘法表";
            this.btn9x9.UseVisualStyleBackColor = false;
            this.btn9x9.Click += new System.EventHandler(this.btn9x9_Click);
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(364, 165);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(62, 22);
            this.txtfrom.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(318, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "From:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(364, 193);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(62, 22);
            this.txtTo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(318, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "To:";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(364, 221);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(62, 22);
            this.txtStep.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(318, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Step:";
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.Info;
            this.btnFor.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnFor.Location = new System.Drawing.Point(432, 165);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(62, 22);
            this.btnFor.TabIndex = 26;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.Info;
            this.btnWhile.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnWhile.Location = new System.Drawing.Point(432, 193);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(62, 22);
            this.btnWhile.TabIndex = 27;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.button18_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.Info;
            this.btnDo.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnDo.Location = new System.Drawing.Point(432, 221);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(62, 22);
            this.btnDo.TabIndex = 28;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.button19_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnClear.Location = new System.Drawing.Point(111, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 44);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Result:";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.SystemColors.Info;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.labResult.Location = new System.Drawing.Point(12, 271);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(45, 20);
            this.labResult.TabIndex = 31;
            this.labResult.Text = "結果:";
            // 
            // ForDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn9x9);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnLotto);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnarrMax);
            this.Controls.Add(this.btnarrSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnArrC);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnArrNameMax);
            this.Controls.Add(this.btnArry_OddEven);
            this.Controls.Add(this.brnOddEven);
            this.Controls.Add(this.txtOddEven);
            this.Controls.Add(this.Labnum);
            this.Name = "ForDoWhile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labnum;
        private System.Windows.Forms.TextBox txtOddEven;
        private System.Windows.Forms.Button brnOddEven;
        private System.Windows.Forms.Button btnArry_OddEven;
        private System.Windows.Forms.Button btnArrNameMax;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnArrC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnarrSum;
        private System.Windows.Forms.Button btnarrMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btn9x9;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labResult;
    }
}