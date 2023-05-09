namespace HW_Form
{
    partial class Student_GradeList
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
            this.listView = new System.Windows.Forms.ListView();
            this.showName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.textEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.textCh = new System.Windows.Forms.TextBox();
            this.labCh = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textR1 = new System.Windows.Forms.TextBox();
            this.textR2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            showAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.listView.Location = new System.Drawing.Point(240, 23);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(395, 280);
            this.listView.TabIndex = 30;
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
            // showAll
            // 
            showAll.Text = "總分";
            showAll.Width = 45;
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
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(240, 316);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(395, 118);
            this.textBox.TabIndex = 29;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(47, 297);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(119, 37);
            this.btnClearAll.TabIndex = 27;
            this.btnClearAll.Text = "移除所有資料";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Enabled = false;
            this.btnCount.Location = new System.Drawing.Point(505, 405);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(119, 21);
            this.btnCount.TabIndex = 26;
            this.btnCount.Text = "各科統計";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 211);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 37);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "插入儲存資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "加入學生資料";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textMath
            // 
            this.textMath.Font = new System.Drawing.Font("新細明體", 15F);
            this.textMath.Location = new System.Drawing.Point(104, 128);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(76, 31);
            this.textMath.TabIndex = 23;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 15F);
            this.labMath.Location = new System.Drawing.Point(44, 134);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(54, 20);
            this.labMath.TabIndex = 22;
            this.labMath.Text = "數學:";
            // 
            // textEng
            // 
            this.textEng.Font = new System.Drawing.Font("新細明體", 15F);
            this.textEng.Location = new System.Drawing.Point(104, 91);
            this.textEng.Name = "textEng";
            this.textEng.Size = new System.Drawing.Size(76, 31);
            this.textEng.TabIndex = 21;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 15F);
            this.labEng.Location = new System.Drawing.Point(44, 97);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(54, 20);
            this.labEng.TabIndex = 20;
            this.labEng.Text = "英文:";
            // 
            // textCh
            // 
            this.textCh.Font = new System.Drawing.Font("新細明體", 15F);
            this.textCh.Location = new System.Drawing.Point(104, 54);
            this.textCh.Name = "textCh";
            this.textCh.Size = new System.Drawing.Size(76, 31);
            this.textCh.TabIndex = 19;
            // 
            // labCh
            // 
            this.labCh.AutoSize = true;
            this.labCh.Font = new System.Drawing.Font("新細明體", 15F);
            this.labCh.Location = new System.Drawing.Point(44, 60);
            this.labCh.Name = "labCh";
            this.labCh.Size = new System.Drawing.Size(54, 20);
            this.labCh.TabIndex = 18;
            this.labCh.Text = "國文:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("新細明體", 15F);
            this.textName.Location = new System.Drawing.Point(104, 17);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(76, 31);
            this.textName.TabIndex = 17;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 15F);
            this.labName.Location = new System.Drawing.Point(44, 23);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(54, 20);
            this.labName.TabIndex = 16;
            this.labName.Text = "姓名:";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(47, 254);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(119, 37);
            this.btnClear1.TabIndex = 31;
            this.btnClear1.Text = "移除資料";
            this.btnClear1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F);
            this.label5.Location = new System.Drawing.Point(45, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "搜尋國文成績範圍";
            // 
            // textR1
            // 
            this.textR1.Font = new System.Drawing.Font("新細明體", 15F);
            this.textR1.Location = new System.Drawing.Point(47, 366);
            this.textR1.Name = "textR1";
            this.textR1.Size = new System.Drawing.Size(51, 31);
            this.textR1.TabIndex = 33;
            // 
            // textR2
            // 
            this.textR2.Font = new System.Drawing.Font("新細明體", 15F);
            this.textR2.Location = new System.Drawing.Point(113, 366);
            this.textR2.Name = "textR2";
            this.textR2.Size = new System.Drawing.Size(51, 31);
            this.textR2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(100, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(47, 403);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 32);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "sersh";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Student_GradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textR2);
            this.Controls.Add(this.textR1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.textEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.textCh);
            this.Controls.Add(this.labCh);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.textBox);
            this.Name = "Student_GradeList";
            this.Text = "Student_GradeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader showName;
        private System.Windows.Forms.ColumnHeader showCh;
        private System.Windows.Forms.ColumnHeader showEng;
        private System.Windows.Forms.ColumnHeader showMath;
        private System.Windows.Forms.ColumnHeader showAvg;
        private System.Windows.Forms.ColumnHeader showMin;
        private System.Windows.Forms.ColumnHeader showMax;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox textEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox textCh;
        private System.Windows.Forms.Label labCh;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textR1;
        private System.Windows.Forms.TextBox textR2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
    }
}