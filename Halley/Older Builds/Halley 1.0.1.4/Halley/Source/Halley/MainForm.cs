using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Halley.About;
using Halley.Robot1Battery;

namespace Halley
{   
    public partial class MainForm : Form
    {
        Robot1BatteryForm robot1bat = new Robot1BatteryForm();
             
        
        public MainForm()
        {            
            InitializeComponent();
                      
           
        }

        #region ROBOT 1

        private void myButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                myButton2.BackColor = System.Drawing.Color.Blue;
                myButton2.Text = "Robot 1";
                myButton2.Focus();
                myButton1.UseVisualStyleBackColor = true;
                myButton1.Text = " ";
                e.Handled = true;
            }
        }

        private void myButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                myButton1.BackColor = System.Drawing.Color.Blue;
                myButton1.Text = "Robot 1";
                myButton1.Focus();
                myButton2.UseVisualStyleBackColor = true;
                myButton2.Text = " ";
                e.Handled = true;
            }

        }
        #endregion 

        #region MENU STRIP

        private void robot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            robot1bat.ShowDialog();
            


        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.Show();

        }

        #endregion

        

       

        


        

        

       
    }

}
