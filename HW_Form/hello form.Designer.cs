namespace HW_Form
{
    partial class hello_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hello_form));
            this.btnsayhi = new System.Windows.Forms.Button();
            this.CNAME = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textegname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textstar = new System.Windows.Forms.TextBox();
            this.btnsayhello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsayhi
            // 
            this.btnsayhi.Location = new System.Drawing.Point(677, 321);
            this.btnsayhi.Name = "btnsayhi";
            this.btnsayhi.Size = new System.Drawing.Size(75, 23);
            this.btnsayhi.TabIndex = 0;
            this.btnsayhi.Text = "sayhi";
            this.btnsayhi.UseVisualStyleBackColor = true;
            this.btnsayhi.Click += new System.EventHandler(this.btnsayhi_Click);
            // 
            // CNAME
            // 
            this.CNAME.AutoSize = true;
            this.CNAME.BackColor = System.Drawing.Color.Transparent;
            this.CNAME.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CNAME.Location = new System.Drawing.Point(204, 199);
            this.CNAME.Name = "CNAME";
            this.CNAME.Size = new System.Drawing.Size(110, 24);
            this.CNAME.TabIndex = 1;
            this.CNAME.Text = "中文名字";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtname.Location = new System.Drawing.Point(388, 187);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 36);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(195, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "English name";
            // 
            // textegname
            // 
            this.textegname.Font = new System.Drawing.Font("新細明體", 18F);
            this.textegname.Location = new System.Drawing.Point(388, 245);
            this.textegname.Name = "textegname";
            this.textegname.Size = new System.Drawing.Size(146, 36);
            this.textegname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(222, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "性     別";
            // 
            // textsex
            // 
            this.textsex.Font = new System.Drawing.Font("新細明體", 18F);
            this.textsex.Location = new System.Drawing.Point(388, 297);
            this.textsex.Name = "textsex";
            this.textsex.Size = new System.Drawing.Size(146, 36);
            this.textsex.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(222, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "星     座";
            // 
            // textstar
            // 
            this.textstar.Font = new System.Drawing.Font("新細明體", 18F);
            this.textstar.Location = new System.Drawing.Point(388, 349);
            this.textstar.Name = "textstar";
            this.textstar.Size = new System.Drawing.Size(146, 36);
            this.textstar.TabIndex = 8;
            // 
            // btnsayhello
            // 
            this.btnsayhello.Location = new System.Drawing.Point(677, 365);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(75, 23);
            this.btnsayhello.TabIndex = 9;
            this.btnsayhello.Text = "sayhello";
            this.btnsayhello.UseVisualStyleBackColor = true;
            this.btnsayhello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // hello_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsayhello);
            this.Controls.Add(this.textstar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textsex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textegname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.CNAME);
            this.Controls.Add(this.btnsayhi);
            this.DoubleBuffered = true;
            this.Name = "hello_form";
            this.Text = "hello_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayhi;
        private System.Windows.Forms.Label CNAME;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textegname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textstar;
        private System.Windows.Forms.Button btnsayhello;
    }
}