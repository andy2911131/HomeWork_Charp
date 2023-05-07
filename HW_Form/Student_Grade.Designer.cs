namespace HW_Form
{
    partial class Student_Grade
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
            System.Windows.Forms.ColumnHeader showAll;
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.showName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            showAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // showAll
            // 
            showAll.Text = "總分";
            showAll.Width = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("新細明體", 15F);
            this.textName.Location = new System.Drawing.Point(117, 21);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(76, 31);
            this.textName.TabIndex = 1;
            // 
            // textCh
            // 
            this.textCh.Font = new System.Drawing.Font("新細明體", 15F);
            this.textCh.Location = new System.Drawing.Point(117, 58);
            this.textCh.Name = "textCh";
            this.textCh.Size = new System.Drawing.Size(76, 31);
            this.textCh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "國文:";
            // 
            // textEng
            // 
            this.textEng.Font = new System.Drawing.Font("新細明體", 15F);
            this.textEng.Location = new System.Drawing.Point(117, 95);
            this.textEng.Name = "textEng";
            this.textEng.Size = new System.Drawing.Size(76, 31);
            this.textEng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(57, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(57, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "數學:";
            // 
            // textMath
            // 
            this.textMath.Font = new System.Drawing.Font("新細明體", 15F);
            this.textMath.Location = new System.Drawing.Point(117, 132);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(76, 31);
            this.textMath.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "加入學生資料";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(61, 229);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(119, 37);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCount
            // 
            this.btnCount.Enabled = false;
            this.btnCount.Location = new System.Drawing.Point(61, 272);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(119, 37);
            this.btnCount.TabIndex = 10;
            this.btnCount.Text = "各科統計";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(61, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "重設所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom20
            // 
            this.btnRandom20.Location = new System.Drawing.Point(61, 393);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(119, 37);
            this.btnRandom20.TabIndex = 12;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(253, 320);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(395, 118);
            this.textBox.TabIndex = 13;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.showName,
            this.showCh,
            this.showEng,
            this.showMath,
            showAll,
            this.showAvg,
            this.showMin,
            this.showMax});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(253, 27);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(395, 280);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // showName
            // 
            this.showName.Text = "姓名";
            this.showName.Width = 50;
            // 
            // showCh
            // 
            this.showCh.Text = "國文";
            this.showCh.Width = 45;
            // 
            // showEng
            // 
            this.showEng.Text = "英文";
            this.showEng.Width = 45;
            // 
            // showMath
            // 
            this.showMath.Text = "數學";
            this.showMath.Width = 45;
            // 
            // showAvg
            // 
            this.showAvg.Text = "平均";
            this.showAvg.Width = 45;
            // 
            // showMin
            // 
            this.showMin.Text = "最低";
            this.showMin.Width = 55;
            // 
            // showMax
            // 
            this.showMax.Text = "最高";
            this.showMax.Width = 55;
            // 
            // Student_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Student_Grade";
            this.Text = "Student_Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader showName;
        private System.Windows.Forms.ColumnHeader showCh;
        private System.Windows.Forms.ColumnHeader showEng;
        private System.Windows.Forms.ColumnHeader showMath;
        private System.Windows.Forms.ColumnHeader showAvg;
        private System.Windows.Forms.ColumnHeader showMin;
        private System.Windows.Forms.ColumnHeader showMax;
    }
}