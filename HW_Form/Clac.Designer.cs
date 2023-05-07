namespace HW_Form
{
    partial class Clac
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
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(143, 120);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 22);
            this.textNum1.TabIndex = 0;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(143, 161);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 22);
            this.textNum2.TabIndex = 1;
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("新細明體", 15F);
            this.num1.Location = new System.Drawing.Point(37, 120);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 2;
            this.num1.Text = "Num1";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("新細明體", 15F);
            this.Num2.Location = new System.Drawing.Point(37, 157);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 23);
            this.Num2.TabIndex = 3;
            this.Num2.Text = "Num2";
            this.Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(62, 284);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 23);
            this.btnmultiply.TabIndex = 4;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(62, 246);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 23);
            this.btnplus.TabIndex = 5;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(143, 246);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 23);
            this.btnminus.TabIndex = 6;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(143, 284);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 23);
            this.btndivide.TabIndex = 7;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("新細明體", 15F);
            this.Answer.Location = new System.Drawing.Point(37, 201);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 23);
            this.Answer.TabIndex = 8;
            this.Answer.Text = "Answer";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(143, 202);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.ReadOnly = true;
            this.textAnswer.Size = new System.Drawing.Size(100, 22);
            this.textAnswer.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Clac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Name = "Clac";
            this.Text = "簡易計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Button btnClear;
    }
}