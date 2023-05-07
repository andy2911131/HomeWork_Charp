using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Form
{
    public partial class XoGame : Form
    {
        bool turn = true; //true=X turn; false=O turn       
        public XoGame()
        {
            InitializeComponent();
           
        }
        
        private void btn(object sender, EventArgs e)
        {
            Button button= (Button)sender;
            
            if (turn)
                button.Text = "O";
            else
                button.Text = "X";

            turn = !turn;
            button.Enabled = false;

            winneris();
        }

        //贏的條件
        private void winneris() 
        {
        bool winner = false;

            if (btn0.Text == btn1.Text && btn1.Text == btn2.Text && btn0.Text != "" && btn1.Text != "" && btn2.Text != "")
            {
                winner = true; 
            }
            else if (btn3.Text == btn4.Text && btn4.Text == btn5.Text && btn3.Text != "" && btn4.Text != "" && btn5.Text != "")
            {
                winner = true;
            }
            else if (btn6.Text == btn7.Text && btn7.Text == btn8.Text && btn6.Text != "" && btn7.Text != "" && btn8.Text != "")
            {
                winner = true;
            }
            else if (btn0.Text == btn3.Text && btn3.Text == btn6.Text && btn0.Text != "" && btn3.Text != "" && btn6.Text != "")
            {
                winner = true;
            }
            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "" && btn4.Text != "" && btn7.Text != "")
            {
                winner = true;
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "" && btn5.Text != "" && btn8.Text != "")
            {
                winner = true;
            }
            else if (btn0.Text == btn4.Text && btn4.Text == btn8.Text && btn0.Text != "" && btn4.Text != "" && btn8.Text != "")
            {
                winner = true;
            }
            else if (btn2.Text == btn4.Text && btn4.Text == btn6.Text && btn2.Text != "" && btn4.Text != "" && btn6.Text != "")
            {
                winner = true;
            }
            //平手
            else if(btn0.Text != "" && btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "")
            {
                
                MessageBox.Show("平手! 按下確定重新開始", "完局");
                Reset();
            }

            if (winner) 
            {
                string XO = "";
                if(turn)
                {
                    XO = "X手";
                }
                else
                {
                    XO = "O手";
                }
                
                MessageBox.Show("恭喜"+XO+"獲勝","完局");
                Reset();              
            }   
            
                                                                   
        }
        private void Reset()
        {
            turn = true;
            btn0.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
        }
            private void btnRest_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //關閉遊戲(ESC)和REST
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnExit_Click(sender, e);
            }
            if (e.KeyCode == Keys.R)
            {
                this.btnRest_Click(sender, e);
            }
        }

      
    }

    }
    

