namespace HW_Form
{
    partial class Pos
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
            this.labelmenu = new System.Windows.Forms.Label();
            this.labeltotalprice = new System.Windows.Forms.Label();
            this.labelpay = new System.Windows.Forms.Label();
            this.labellist = new System.Windows.Forms.Label();
            this.TextList = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncash = new System.Windows.Forms.Button();
            this.btncard = new System.Windows.Forms.Button();
            this.textTotalprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQQ = new System.Windows.Forms.Button();
            this.btnchisteak = new System.Windows.Forms.Button();
            this.btnwings = new System.Windows.Forms.Button();
            this.btncola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmenu
            // 
            this.labelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelmenu.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelmenu.Location = new System.Drawing.Point(24, 48);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(225, 256);
            this.labelmenu.TabIndex = 1;
            this.labelmenu.Text = "菜單Menu";
            // 
            // labeltotalprice
            // 
            this.labeltotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltotalprice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeltotalprice.Location = new System.Drawing.Point(286, 48);
            this.labeltotalprice.Name = "labeltotalprice";
            this.labeltotalprice.Size = new System.Drawing.Size(225, 86);
            this.labeltotalprice.TabIndex = 2;
            this.labeltotalprice.Text = "總金額Total Price";
            // 
            // labelpay
            // 
            this.labelpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpay.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelpay.Location = new System.Drawing.Point(286, 186);
            this.labelpay.Name = "labelpay";
            this.labelpay.Size = new System.Drawing.Size(225, 118);
            this.labelpay.TabIndex = 3;
            this.labelpay.Text = "付款方式";
            // 
            // labellist
            // 
            this.labellist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labellist.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labellist.Location = new System.Drawing.Point(542, 48);
            this.labellist.Name = "labellist";
            this.labellist.Size = new System.Drawing.Size(225, 256);
            this.labellist.TabIndex = 4;
            this.labellist.Text = "購物清單";
            // 
            // TextList
            // 
            this.TextList.BackColor = System.Drawing.Color.White;
            this.TextList.Font = new System.Drawing.Font("新細明體", 12F);
            this.TextList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextList.Location = new System.Drawing.Point(555, 71);
            this.TextList.Multiline = true;
            this.TextList.Name = "TextList";
            this.TextList.ReadOnly = true;
            this.TextList.Size = new System.Drawing.Size(197, 188);
            this.TextList.TabIndex = 5;
            this.TextList.Text = "尚未點餐";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(657, 265);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 34);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncash
            // 
            this.btncash.Location = new System.Drawing.Point(299, 235);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(95, 34);
            this.btncash.TabIndex = 7;
            this.btncash.Text = "現金";
            this.btncash.UseVisualStyleBackColor = true;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // btncard
            // 
            this.btncard.Location = new System.Drawing.Point(400, 235);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(95, 34);
            this.btncard.TabIndex = 8;
            this.btncard.Text = "信用卡";
            this.btncard.UseVisualStyleBackColor = true;
            this.btncard.Click += new System.EventHandler(this.btncard_Click);
            // 
            // textTotalprice
            // 
            this.textTotalprice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textTotalprice.ForeColor = System.Drawing.SystemColors.Info;
            this.textTotalprice.Location = new System.Drawing.Point(318, 89);
            this.textTotalprice.Multiline = true;
            this.textTotalprice.Name = "textTotalprice";
            this.textTotalprice.ReadOnly = true;
            this.textTotalprice.Size = new System.Drawing.Size(162, 28);
            this.textTotalprice.TabIndex = 9;
            this.textTotalprice.Text = " NT$0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "信用卡9折";
            // 
            // btnQQ
            // 
            this.btnQQ.BackgroundImage = global::HW_Form.Properties.Resources.images;
            this.btnQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQQ.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQQ.Location = new System.Drawing.Point(149, 186);
            this.btnQQ.Name = "btnQQ";
            this.btnQQ.Size = new System.Drawing.Size(75, 104);
            this.btnQQ.TabIndex = 14;
            this.btnQQ.Text = "QQ球 70元";
            this.btnQQ.UseVisualStyleBackColor = true;
            this.btnQQ.Click += new System.EventHandler(this.btnQQ_Click);
            // 
            // btnchisteak
            // 
            this.btnchisteak.BackgroundImage = global::HW_Form.Properties.Resources._1;
            this.btnchisteak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchisteak.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnchisteak.Location = new System.Drawing.Point(49, 186);
            this.btnchisteak.Name = "btnchisteak";
            this.btnchisteak.Size = new System.Drawing.Size(75, 104);
            this.btnchisteak.TabIndex = 13;
            this.btnchisteak.Text = "雞排 100元";
            this.btnchisteak.UseVisualStyleBackColor = true;
            this.btnchisteak.Click += new System.EventHandler(this.btnchisteak_Click);
            // 
            // btnwings
            // 
            this.btnwings.BackgroundImage = global::HW_Form.Properties.Resources.wings;
            this.btnwings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnwings.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnwings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnwings.Location = new System.Drawing.Point(149, 76);
            this.btnwings.Name = "btnwings";
            this.btnwings.Size = new System.Drawing.Size(75, 104);
            this.btnwings.TabIndex = 12;
            this.btnwings.Text = "雞翅 60元";
            this.btnwings.UseVisualStyleBackColor = true;
            this.btnwings.Click += new System.EventHandler(this.btnwings_Click);
            // 
            // btncola
            // 
            this.btncola.BackgroundImage = global::HW_Form.Properties.Resources.coca;
            this.btncola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncola.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncola.Location = new System.Drawing.Point(49, 76);
            this.btncola.Name = "btncola";
            this.btncola.Size = new System.Drawing.Size(75, 104);
            this.btncola.TabIndex = 11;
            this.btncola.Text = "快樂肥宅水 50元";
            this.btncola.UseVisualStyleBackColor = true;
            this.btncola.Click += new System.EventHandler(this.btncola_Click);
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQQ);
            this.Controls.Add(this.btnchisteak);
            this.Controls.Add(this.btnwings);
            this.Controls.Add(this.btncola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTotalprice);
            this.Controls.Add(this.btncard);
            this.Controls.Add(this.btncash);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.labellist);
            this.Controls.Add(this.labelpay);
            this.Controls.Add(this.labeltotalprice);
            this.Controls.Add(this.labelmenu);
            this.Name = "Pos";
            this.Text = "Pos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.Label labeltotalprice;
        private System.Windows.Forms.Label labelpay;
        private System.Windows.Forms.Label labellist;
        private System.Windows.Forms.TextBox TextList;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Button btncard;
        private System.Windows.Forms.TextBox textTotalprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnwings;
        private System.Windows.Forms.Button btnchisteak;
        private System.Windows.Forms.Button btnQQ;
        private System.Windows.Forms.Button btncola;
    }
}