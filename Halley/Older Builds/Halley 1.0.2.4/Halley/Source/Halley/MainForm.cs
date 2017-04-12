using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Halley.About;
using Halley.Battery;

namespace Halley
{   
    public partial class MainForm : Form
    {
        Robot1BatteryForm robot1bat = new Robot1BatteryForm();
        

        #region Construtor

        public MainForm()
        {            
            InitializeComponent();
            StartupRobots();
            
            keyButton1.GotFocus += new EventHandler(keyButton1_GotFocus);
            keyButton2.GotFocus += new EventHandler(keyButton2_GotFocus);
            
 
            


        }
        
        #endregion 

        #region Menu Srtip

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
            aboutform.Version();
            aboutform.ShowDialog();    

        }

        #endregion

        #region Radio Buttons

        private void radioButton1_Click(object sender, EventArgs e)
        {
            keyButton1.BackColor = System.Drawing.Color.Blue;
            keyButton1.Text = "Robot 1";
            keyButton2.UseVisualStyleBackColor = true;
            keyButton2.Text = " ";



        }

        #endregion


        #region Robot Key Down Events

        private void keyButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                keyButton2.BackColor = System.Drawing.Color.Blue;
                keyButton2.Text = "Robot 1";
                keyButton2.Focus();
                keyButton1.UseVisualStyleBackColor = true;
                keyButton1.Text = " ";
                e.Handled = true;

                if (radioButton2.Checked)
                    {
                        
                        keyButton2.BackColor = System.Drawing.Color.Yellow;
                        keyButton2.Text = "Robot 2";                      
                        keyButton2.Focus();
                        keyButton1.UseVisualStyleBackColor = true;
                        keyButton1.Text = " ";
                        MainForm mainform = (MainForm)Application.OpenForms["MainForm"];
                        mainform.MessageBox1.Text = "30";
                        e.Handled = true;
                    }

            }           

            if (e.KeyCode == Keys.Right)
            {
                keyButton21.BackColor = System.Drawing.Color.Blue;
                keyButton21.Text = "Robot 1";
                keyButton21.Focus();
                keyButton1.UseVisualStyleBackColor = true;
                keyButton1.Text = " ";
                e.Handled = true;
            }

           
        }

        private void keyButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                keyButton1.BackColor = System.Drawing.Color.Blue;
                keyButton1.Text = "Robot 1";
                keyButton1.Focus();
                keyButton2.UseVisualStyleBackColor = true;
                keyButton2.Text = " ";
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                keyButton3.BackColor = System.Drawing.Color.Blue;
                keyButton3.Text = "Robot 1";
                keyButton3.Focus();
                keyButton2.UseVisualStyleBackColor = true;
                keyButton2.Text = " ";
                e.Handled = true;
            }

        }

        private void keyButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                keyButton2.BackColor = System.Drawing.Color.Blue;
                keyButton2.Text = "Robot 1";
                keyButton2.Focus();
                keyButton3.UseVisualStyleBackColor = true;
                keyButton3.Text = " ";
                e.Handled = true;
            }

        }

        #endregion


        #region Robot 1 Got Focus Events

        void keyButton1_GotFocus(object sender, EventArgs e)
        {             
            Sensors.Sensors sen = new Halley.Sensors.Sensors();
            MessageBox1.Text = sen.btn1Temp;            
            
        }

        void keyButton2_GotFocus(object sender, EventArgs e)
        {
            string robot1 = "Robot 1";
            if (robot1 == keyButton2.Text)
            {
                Sensors.Sensors sen = new Halley.Sensors.Sensors();
                MessageBox1.Text = sen.btn1Temp + "\r\n" + sen.btn1Slope;
            }
                      

        }

        #endregion
        
        public void StartupRobots()
        {
            if (radioButton1.Checked)
            {
                keyButton1.BackColor = System.Drawing.Color.Blue;
                keyButton1.Text = "Robot 1";
                
            }
            else if (radioButton2.Checked)
            {
                keyButton2.BackColor = System.Drawing.Color.Yellow;
                keyButton2.Text = "Robot 2";
               
            }
        }

       

       

        



        

    }

}
