using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TicTacToe_Aprel07
{
    public partial class Form1 : Form
    {

        bool isFirstUserClicked, isSecondUserClicked;
        DialogResult dialogResult; //When User win
        public Form1()
        {
            InitializeComponent();
            
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag != null)
            {
                if (isFirstUserClicked == false)
                {
                    isFirstUserClicked = true;
                    isSecondUserClicked = false;
                    button.Text = "X";
                    button.Tag = null;
                    button.ForeColor = Color.DarkGreen;
                    button.Cursor = Cursors.Hand;
                    UserLabel2.ForeColor = Color.OrangeRed;
                    UserLabel1.ForeColor = Color.Black;
                }
                else if (isSecondUserClicked == false)
                {
                    isFirstUserClicked = false;
                    isSecondUserClicked = true;
                    button.Text = "O";
                    button.Tag = null;
                    button.ForeColor = Color.DarkRed;
                    button.Cursor = Cursors.Hand;
                    UserLabel1.ForeColor = Color.OrangeRed;
                    UserLabel2.ForeColor = Color.Black;
                }
                if (button1.Text != "" || button2.Text != "" || button3.Text != "")
                {
                    if (button1.Text == button2.Text && button2.Text == button3.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button4.Text != "" || button5.Text != "" || button6.Text != "")
                {
                    if (button4.Text == button5.Text && button5.Text == button6.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button7.Text != "" || button8.Text != "" || button9.Text != "")
                {
                    if (button7.Text == button8.Text && button8.Text == button9.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button1.Text != "" || button4.Text != "" || button7.Text != "")
                {
                    if (button1.Text == button4.Text && button4.Text == button7.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button2.Text != "" || button5.Text != "" || button8.Text != "")
                {
                    if (button2.Text == button5.Text && button5.Text == button8.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button3.Text != "" || button6.Text != "" || button9.Text != "")
                {
                    if (button3.Text == button6.Text && button6.Text == button9.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button1.Text != "" || button5.Text != "" || button9.Text != "")
                {
                    if (button1.Text == button5.Text && button5.Text == button9.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (button3.Text != "" || button5.Text != "" || button7.Text != "")
                {
                    if (button3.Text == button5.Text && button5.Text == button7.Text)
                    {
                        if (isFirstUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User1 qazandi");
                        }
                        else if (isSecondUserClicked == true)
                        {
                            dialogResult = MessageBox.Show("User2 qazandi");
                        }
                    }
                }
                if (dialogResult == DialogResult.OK)
                {
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                    button1.Tag = 1;
                    button2.Tag = 2;
                    button3.Tag = 3;
                    button4.Tag = 4;
                    button5.Tag = 5;
                    button6.Tag = 6;
                    button7.Tag = 7;
                    button8.Tag = 8;
                    button9.Tag = 9;
                    isFirstUserClicked = false;
                    isSecondUserClicked = false;
                    dialogResult = DialogResult.None;
                }
                if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                    button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                    button7.Text != "" && button8.Text != "" && button9.Text != "" &&
                    button1.Text != "" && button4.Text != "" && button7.Text != "" &&
                    button2.Text != "" && button5.Text != "" && button8.Text != "" &&
                    button3.Text != "" && button6.Text != "" && button9.Text != "" &&
                    button1.Text != "" && button5.Text != "" && button9.Text != "" &&
                    button3.Text != "" && button5.Text != "" && button7.Text != "")
                {
                    dialogResult = MessageBox.Show("Oyun heç-heçə bitdi");
                }
            }
        }


    }
}
