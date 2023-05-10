using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class homework : Form
    {

        public homework()
        {
            InitializeComponent();

        }

        //開啟時清空PANEL上的工具()
        private void Panel1Clear()
        {
            splitContainer2.Panel1.Controls.Clear();
        }
        private void btnhello_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            hello_form hello=new hello_form();
            hello.MdiParent = this;          
            hello.Parent = splitContainer2.Panel1;
            hello.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Loan loan = new Loan();
            loan.MdiParent = this;         
            loan.Parent = splitContainer2.Panel1;
            loan.Show();          

        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Pos pos = new Pos();
            pos.MdiParent = this;
            pos.Parent = splitContainer2.Panel1;
            pos.Show();
        }

        private void btnClac_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Clac clac = new Clac();
            clac.MdiParent = this;
            clac.Parent = splitContainer2.Panel1;
            clac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Student_sturct_Form student_Sturct_Form =new Student_sturct_Form();
            student_Sturct_Form.MdiParent=this;
            student_Sturct_Form.Parent = splitContainer2.Panel1;
            student_Sturct_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Student_Grade student_grade_Form =new Student_Grade();
            student_grade_Form.MdiParent = this;
            student_grade_Form.Parent = splitContainer2.Panel1;
            student_grade_Form.Show();
        }

        private void XoGame_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            XoGame xogame= new XoGame();
            xogame.MdiParent = this;
            xogame.Parent = splitContainer2.Panel1;
            xogame.Show();
        }     
   

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            ForDoWhile fordowhile = new ForDoWhile();
            fordowhile.MdiParent = this;
            fordowhile.Parent = splitContainer2.Panel1;
            fordowhile.Show();

        }

        

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            Notepad notepad = new Notepad();
            notepad.MdiParent = this;
            notepad.Parent = splitContainer2.Panel1;
            notepad.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel1Clear();
            Screensaver screensaver = new Screensaver();   
            screensaver.Show();
        }

        private void btnPv_Click(object sender, EventArgs e)
        {
            Panel1Clear();
            PictureViewer PV = new PictureViewer();
            PV.MdiParent = this;
            PV.Parent = splitContainer2.Panel1;
            PV.Show();
        }
    }
}
