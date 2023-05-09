using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW_Form
{
    public partial class Notepad : Form
    {
        string failepath = "";
        public Notepad()
        {
            InitializeComponent();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "textDocument|*.txt", ValidateNames = true, Multiselect = false })
        {
                if (ofd.ShowDialog() == DialogResult.OK) 
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName)) 
                    {
                    failepath=ofd.FileName;
                        Task<string> text =sr.ReadToEndAsync();
                        richTextBox1.Text = text.Result;
                    }
                }
        }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(failepath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Textdocument|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(failepath))
                {
                    {
                        sw.WriteLineAsync(richTextBox1.Text);
                    }
                }
                                           
                
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Textdocument|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLineAsync(richTextBox1.Text);
                    }
                }
            }
        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK) 
            {
            printDocument1.Print();
            }
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 自訂CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 選項OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
           
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void toUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToLower();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自動換行ToolStripMenuItem.Checked == true)
            {
                自動換行ToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else 
            {
                自動換行ToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor=Color.Red;
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void bLACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black ;
        }

        private void 內容CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 搜尋SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad_about about= new Notepad_about();
            about.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            新增NToolStripMenuItem_Click(sender, e);
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            開啟OToolStripMenuItem_Click(sender, e);
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            儲存SToolStripMenuItem_Click(sender, e);
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            列印PToolStripMenuItem_Click(sender, e);
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            剪下TToolStripMenuItem_Click(sender, e);
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            複製CToolStripMenuItem_Click(sender, e);
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            貼上PToolStripMenuItem_Click(sender, e);
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            關於AToolStripMenuItem_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString( );
        }
    }
}
