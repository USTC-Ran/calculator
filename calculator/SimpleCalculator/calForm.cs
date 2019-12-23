﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class calForm : Form
    {
        CCalculator cal;
        SCalculator calSci;
        private bool oprUsed = false;
        public calForm()
        {
            InitializeComponent();
        }

        private void calForm_Load(object sender, EventArgs e)
        {
            displayText.Text = string.Empty;
            cal = new CCalculator();
            calSci = new SCalculator();
        }
        /// <summary>
        /// buttonBack Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked)
            {
                resultText.Text = cal.Back();
            }
            else
            {
                string str = displayText.Text;
                if (str.Length > 0)
                {
                    displayText.Text = str.Remove(str.Length - 1);
                }
            }
        }
        /// <summary>
        /// buttonClear Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayText.Text = cal.Clear();
            resultText.Text = cal.RClear();
            this.oprUsed = false;
            //this.isCaled = false;
        }
        /// <summary>
        /// button 1~9 Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                if (radioBtnNormal.Checked)
                {
                    resultText.Text = cal.NumberKey(btnSender.Text);
                }
                else
                {
                    displayText.Text += btnSender.Text;
                }
            }
        }
        /// <summary>
        /// button 0 Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked)
            {
                if (resultText.Text != "0")//when the calculator is not initial state
                {
                    resultText.Text = cal.NumberKey(button0.Text);
                }
            }
            else
            {
                displayText.Text += button0.Text;
            }
        }
        /// <summary>
        /// button "." Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked)
            {
                if (cal.DotUsed() == -1)
                {
                    resultText.Text = cal.NumberKey(buttonDot.Text);
                }
            }
            else
            {
                if (displayText.Text.IndexOf(".") == -1)//a bug
                {
                    displayText.Text += buttonDot.Text;
                }
            }
        }
        /// <summary>
        /// button "+-*/" Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;

                if (radioBtnNormal.Checked)
                {
                    try
                    {
                        cal.Result = Convert.ToDouble(resultText.Text);
                        if (this.oprUsed)
                        {
                            cal.Calc();
                        }
                        this.oprUsed = true;
                    }
                    catch (FormatException ex)// convertion format exception
                    {
                        return;
                    }

                    if (displayText.Text == "")
                    {
                        displayText.Text = resultText.Text + cal.SetOperatorByLetter(btnSender.Text);
                    }
                    else
                    {
                        displayText.Text += resultText.Text + cal.SetOperatorByLetter(btnSender.Text);
                    }
                    cal.ResultStr = string.Empty;
                }
                else
                {
                    displayText.Text += btnSender.Text;
                }
            }
        }
        /// <summary>
        /// button "=" Click event, Calculate the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCal_Click(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked)
            {
                try
                {
                    cal.Result = Convert.ToDouble(resultText.Text);
                }
                catch (Exception ex)
                {
                    resultText.Text = "Error";
                }
                resultText.Text = cal.Calc();
                displayText.Text = string.Empty;
                this.oprUsed = false;
            }
            else
            {
                double results;
                try
                {
                    calSci.Compute(displayText.Text, out results);
                    resultText.Text = results.ToString();
                }
                catch (Exception ex)
                {
                    resultText.Text = "Wrong Expression";
                }  
            }
            if (resultText.Text.Length > 13)
            {
                resultText.Text = cal.Result.ToString("E8"); //if the result is too long. use scientific notation
            }
        }

        #region the keyboard perform the keydown event
        private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Back:
                    buttonBack.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.C:
                    buttonClear.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad0:
                    button0.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D0:
                    button0.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D1:
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D3:
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Divide:
                    buttonDivide.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Add:
                    buttonAdd.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Multiply:
                    buttonMul.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Subtract:
                    buttonMinus.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Decimal:
                    buttonDot.PerformClick();
                    e.Handled = true;
                    break;
                
                default: break;
            }
        }
        #endregion    

        #region Change the state of the radiobutton in order the control the mode of this calculator
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked == true)
            {
                radioBtnScience.Checked = false;
                buttonClear_Click(null, null);//clear the text when mode changed
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnScience.Checked == true)
            {
                radioBtnNormal.Checked = false;
                buttonClear_Click(null, null);//clear the text when mode changed
            }
        } 
        #endregion

        private void button_Enter(object sender, EventArgs e)
        {
            this.buttonCal.Focus();
        }

        private void buttonColor1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = Color.FromArgb(115, 115, 115);
            }
        }

        private void buttonColor1_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = Color.FromArgb(51, 51, 51);
            }
        }

        private void buttonColor2_MouseDown(object sender, MouseEventArgs e)
        {
            if(sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = Color.FromArgb(252, 199, 141);
            }
        }

        private void buttonColor2_MouseUp(object sender, MouseEventArgs e)
        {
            if(sender is Button)
            {
                Button btnSender = (Button)sender;
                btnSender.BackColor = Color.FromArgb(255, 149, 0);
            }
        }
    }
}
