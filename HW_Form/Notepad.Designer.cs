﻿namespace HW_Form
{
    partial class Notepad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.列印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gREENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新增NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開啟OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.列印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.複製CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼上PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.說明LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.toolStripSeparator,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.toolStripSeparator1,
            this.列印PToolStripMenuItem,
            this.預覽列印VToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啟OToolStripMenuItem.Text = "開啟(&O)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.儲存SToolStripMenuItem.Text = "儲存(&S)";
            this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 列印PToolStripMenuItem
            // 
            this.列印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripMenuItem.Image")));
            this.列印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            this.列印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.列印PToolStripMenuItem.Text = "列印(&P)";
            this.列印PToolStripMenuItem.Click += new System.EventHandler(this.列印PToolStripMenuItem_Click);
            // 
            // 預覽列印VToolStripMenuItem
            // 
            this.預覽列印VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("預覽列印VToolStripMenuItem.Image")));
            this.預覽列印VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
            this.預覽列印VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.預覽列印VToolStripMenuItem.Text = "預覽列印(&V)";
            this.預覽列印VToolStripMenuItem.Click += new System.EventHandler(this.預覽列印VToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.結束XToolStripMenuItem.Text = "結束(&X)";
            this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原UToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選AToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原UToolStripMenuItem
            // 
            this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            this.復原UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原UToolStripMenuItem.Text = "復原(&U)";
            this.復原UToolStripMenuItem.Click += new System.EventHandler(this.復原UToolStripMenuItem_Click);
            // 
            // 取消復原RToolStripMenuItem
            // 
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            this.取消復原RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.取消復原RToolStripMenuItem.Text = "取消復原(&R)";
            this.取消復原RToolStripMenuItem.Click += new System.EventHandler(this.取消復原RToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            this.剪下TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪下TToolStripMenuItem.Image")));
            this.剪下TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下TToolStripMenuItem.Text = "剪下(&T)";
            this.剪下TToolStripMenuItem.Click += new System.EventHandler(this.剪下TToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripMenuItem.Image")));
            this.複製CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.複製CToolStripMenuItem.Text = "複製(&C)";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripMenuItem.Image")));
            this.貼上PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上PToolStripMenuItem.Text = "貼上(&P)";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // 全選AToolStripMenuItem
            // 
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全選AToolStripMenuItem.Text = "全選(&A)";
            this.全選AToolStripMenuItem.Click += new System.EventHandler(this.全選AToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.自訂CToolStripMenuItem.Text = "自訂(&C)";
            this.自訂CToolStripMenuItem.Click += new System.EventHandler(this.自訂CToolStripMenuItem_Click);
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.選項OToolStripMenuItem.Text = "選項(&O)";
            this.選項OToolStripMenuItem.Click += new System.EventHandler(this.選項OToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem,
            this.字型VToolStripMenuItem,
            this.toUToolStripMenuItem,
            this.toLowerLToolStripMenuItem,
            this.自動換行ToolStripMenuItem,
            this.快選顏色ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.格式ToolStripMenuItem.Text = "格式(&M)";
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.顏色ToolStripMenuItem.Text = "顏色(C)";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // 字型VToolStripMenuItem
            // 
            this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
            this.字型VToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.字型VToolStripMenuItem.Text = "字型(V)";
            this.字型VToolStripMenuItem.Click += new System.EventHandler(this.字型VToolStripMenuItem_Click);
            // 
            // toUToolStripMenuItem
            // 
            this.toUToolStripMenuItem.Name = "toUToolStripMenuItem";
            this.toUToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toUToolStripMenuItem.Text = "To Upper(U)";
            this.toUToolStripMenuItem.Click += new System.EventHandler(this.toUToolStripMenuItem_Click);
            // 
            // toLowerLToolStripMenuItem
            // 
            this.toLowerLToolStripMenuItem.Name = "toLowerLToolStripMenuItem";
            this.toLowerLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toLowerLToolStripMenuItem.Text = "To Lower(L)";
            this.toLowerLToolStripMenuItem.Click += new System.EventHandler(this.toLowerLToolStripMenuItem_Click);
            // 
            // 自動換行ToolStripMenuItem
            // 
            this.自動換行ToolStripMenuItem.Name = "自動換行ToolStripMenuItem";
            this.自動換行ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.自動換行ToolStripMenuItem.Text = "自動換行";
            this.自動換行ToolStripMenuItem.Click += new System.EventHandler(this.自動換行ToolStripMenuItem_Click);
            // 
            // 快選顏色ToolStripMenuItem
            // 
            this.快選顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDToolStripMenuItem,
            this.gREENToolStripMenuItem,
            this.bLUEToolStripMenuItem,
            this.bLACKToolStripMenuItem});
            this.快選顏色ToolStripMenuItem.Name = "快選顏色ToolStripMenuItem";
            this.快選顏色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.快選顏色ToolStripMenuItem.Text = "快選顏色";
            // 
            // rEDToolStripMenuItem
            // 
            this.rEDToolStripMenuItem.Name = "rEDToolStripMenuItem";
            this.rEDToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.rEDToolStripMenuItem.Text = "RED";
            this.rEDToolStripMenuItem.Click += new System.EventHandler(this.rEDToolStripMenuItem_Click);
            // 
            // gREENToolStripMenuItem
            // 
            this.gREENToolStripMenuItem.Name = "gREENToolStripMenuItem";
            this.gREENToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gREENToolStripMenuItem.Text = "GREEN";
            this.gREENToolStripMenuItem.Click += new System.EventHandler(this.gREENToolStripMenuItem_Click);
            // 
            // bLUEToolStripMenuItem
            // 
            this.bLUEToolStripMenuItem.Name = "bLUEToolStripMenuItem";
            this.bLUEToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bLUEToolStripMenuItem.Text = "BLUE";
            this.bLUEToolStripMenuItem.Click += new System.EventHandler(this.bLUEToolStripMenuItem_Click);
            // 
            // bLACKToolStripMenuItem
            // 
            this.bLACKToolStripMenuItem.Name = "bLACKToolStripMenuItem";
            this.bLACKToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bLACKToolStripMenuItem.Text = "BLACK";
            this.bLACKToolStripMenuItem.Click += new System.EventHandler(this.bLACKToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem
            // 
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            this.內容CToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.內容CToolStripMenuItem.Text = "內容(&C)";
            this.內容CToolStripMenuItem.Click += new System.EventHandler(this.內容CToolStripMenuItem_Click);
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            this.索引IToolStripMenuItem.Click += new System.EventHandler(this.索引IToolStripMenuItem_Click);
            // 
            // 搜尋SToolStripMenuItem
            // 
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            this.搜尋SToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.搜尋SToolStripMenuItem.Text = "搜尋(&S)";
            this.搜尋SToolStripMenuItem.Click += new System.EventHandler(this.搜尋SToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.關於AToolStripMenuItem.Text = "關於(&A)...";
            this.關於AToolStripMenuItem.Click += new System.EventHandler(this.關於AToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripButton,
            this.開啟OToolStripButton,
            this.儲存SToolStripButton,
            this.列印PToolStripButton,
            this.toolStripSeparator6,
            this.剪下UToolStripButton,
            this.複製CToolStripButton,
            this.貼上PToolStripButton,
            this.toolStripSeparator7,
            this.說明LToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新增NToolStripButton
            // 
            this.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripButton.Image")));
            this.新增NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripButton.Name = "新增NToolStripButton";
            this.新增NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新增NToolStripButton.Text = "新增(&N)";
            this.新增NToolStripButton.Click += new System.EventHandler(this.新增NToolStripButton_Click);
            // 
            // 開啟OToolStripButton
            // 
            this.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripButton.Image")));
            this.開啟OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripButton.Name = "開啟OToolStripButton";
            this.開啟OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開啟OToolStripButton.Text = "開啟(&O)";
            this.開啟OToolStripButton.Click += new System.EventHandler(this.開啟OToolStripButton_Click);
            // 
            // 儲存SToolStripButton
            // 
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripButton.Image")));
            this.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            this.儲存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.儲存SToolStripButton.Text = "儲存(&S)";
            this.儲存SToolStripButton.Click += new System.EventHandler(this.儲存SToolStripButton_Click);
            // 
            // 列印PToolStripButton
            // 
            this.列印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.列印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripButton.Image")));
            this.列印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripButton.Name = "列印PToolStripButton";
            this.列印PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.列印PToolStripButton.Text = "列印(&P)";
            this.列印PToolStripButton.Click += new System.EventHandler(this.列印PToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // 剪下UToolStripButton
            // 
            this.剪下UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪下UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪下UToolStripButton.Image")));
            this.剪下UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下UToolStripButton.Name = "剪下UToolStripButton";
            this.剪下UToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.剪下UToolStripButton.Text = "剪下(&U)";
            this.剪下UToolStripButton.Click += new System.EventHandler(this.剪下UToolStripButton_Click);
            // 
            // 複製CToolStripButton
            // 
            this.複製CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.複製CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripButton.Image")));
            this.複製CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripButton.Name = "複製CToolStripButton";
            this.複製CToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.複製CToolStripButton.Text = "複製(&C)";
            this.複製CToolStripButton.Click += new System.EventHandler(this.複製CToolStripButton_Click);
            // 
            // 貼上PToolStripButton
            // 
            this.貼上PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼上PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripButton.Image")));
            this.貼上PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripButton.Name = "貼上PToolStripButton";
            this.貼上PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.貼上PToolStripButton.Text = "貼上(&P)";
            this.貼上PToolStripButton.Click += new System.EventHandler(this.貼上PToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // 說明LToolStripButton
            // 
            this.說明LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.說明LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("說明LToolStripButton.Image")));
            this.說明LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.說明LToolStripButton.Name = "說明LToolStripButton";
            this.說明LToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.說明LToolStripButton.Text = "說明(&L)";
            this.說明LToolStripButton.Click += new System.EventHandler(this.說明LToolStripButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 404);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(642, 31);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 12);
            this.labTime.TabIndex = 3;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新增NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開啟OToolStripButton;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 列印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton 剪下UToolStripButton;
        private System.Windows.Forms.ToolStripButton 複製CToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼上PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton 說明LToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動換行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gREENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLACKToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labTime;
        public System.Windows.Forms.Timer timer1;
    }
}