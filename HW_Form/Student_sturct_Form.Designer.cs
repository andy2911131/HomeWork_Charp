namespace HW_Form
{
    partial class Student_sturct_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textChinese = new System.Windows.Forms.TextBox();
            this.textEng = new System.Windows.Forms.TextBox();
            this.textMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaxMin = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(95, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(95, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(95, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(95, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(155, 114);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(112, 22);
            this.textName.TabIndex = 4;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textChinese
            // 
            this.textChinese.Location = new System.Drawing.Point(155, 153);
            this.textChinese.Name = "textChinese";
            this.textChinese.Size = new System.Drawing.Size(112, 22);
            this.textChinese.TabIndex = 5;
            this.textChinese.Text = "0";
            this.textChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textEng
            // 
            this.textEng.Location = new System.Drawing.Point(155, 189);
            this.textEng.Name = "textEng";
            this.textEng.Size = new System.Drawing.Size(112, 22);
            this.textEng.TabIndex = 6;
            this.textEng.Text = "0";
            this.textEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMath
            // 
            this.textMath.Location = new System.Drawing.Point(155, 220);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(112, 22);
            this.textMath.TabIndex = 7;
            this.textMath.Text = "0";
            this.textMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(188, 277);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 55);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaxMin);
            this.groupBox1.Controls.Add(this.labScore);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15F);
            this.groupBox1.Location = new System.Drawing.Point(435, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 295);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labelMaxMin
            // 
            this.labelMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMaxMin.Location = new System.Drawing.Point(7, 179);
            this.labelMaxMin.Name = "labelMaxMin";
            this.labelMaxMin.Size = new System.Drawing.Size(254, 101);
            this.labelMaxMin.TabIndex = 1;
            // 
            // labScore
            // 
            this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScore.Location = new System.Drawing.Point(7, 22);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(254, 146);
            this.labScore.TabIndex = 0;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(526, 357);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(176, 55);
            this.btnMaxMin.TabIndex = 11;
            this.btnMaxMin.Text = "最高分/最低分科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Student_sturct_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.textEng);
            this.Controls.Add(this.textChinese);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_sturct_Form";
            this.Text = "Student_sturct_Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textChinese;
        private System.Windows.Forms.TextBox textEng;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaxMin;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button btnMaxMin;
    }
}