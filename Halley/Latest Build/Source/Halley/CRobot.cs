using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Halley.Battery;
using Halley.Compressability;

namespace Halley
{
    class CRobot
    {
        private Panel p;
        private MainForm mainform;
        private Robot1Compressability robot1Com;
        
        

        public Panel getp()
        {
            return p;
        }
        //Creation of the grid.
        public CRobot()
        {
            p = new System.Windows.Forms.Panel();
            p.Location = new System.Drawing.Point(1,1);
            p.Size = new System.Drawing.Size(505, 535);
            p.BackColor = new System.Drawing.Color();

            CButton grid = default(CButton);
            int i = 0;
            int j = 0;
            int ctlCount = 0;


            for (i = 0; i <= 50; i++)
            {
                for (j = 0; j <= 50; j++)
                {
                    ctlCount += 1;

                    grid = new CButton(i * 10, j * 10);
                    grid.Tag = ctlCount;
                    grid.Name = "btn" + ctlCount;
                    grid.LostFocus += this.LostFocusHandler;
                    grid.GotFocus += this.GotFocusHandler;
                    grid.PreviewKeyDown += this.PreviewKeyDownHandler;
                    p.Controls.Add(grid);
                    
                }
            }
            
        }
        //up and down event handler
        public void GotFocusHandler(object sender, System.EventArgs e)
        {
            


                mainform = new MainForm();
                mainform = (MainForm)Application.OpenForms["MainForm"];

                robot1Com = new Robot1Compressability();
                robot1Com = (Robot1Compressability)Application.OpenForms["Robot1Compressability"];


                System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
                Button = (System.Windows.Forms.Button)sender;
                
                if (mainform.radioButton1.Checked == true)
                {
                    Button.BackColor = Color.Blue;
                    mainform.ReadFromFile();
                }

                else if (mainform.radioButton2.Checked == true)
                {
                    Button.BackColor = Color.Black;
                    mainform.ReadFromFile();
                }

                else if (mainform.radioButton3.Checked == true)
                {
                    Button.BackColor = Color.Orange;
                    mainform.ReadFromFile();
                }

                else if (mainform.radioButton4.Checked == true)
                {
                    Button.BackColor = Color.Brown;
                    mainform.ReadFromFile();
                }

                else if (mainform.radioButton5.Checked == true)
                {
                    Button.BackColor = Color.Gold;
                    mainform.ReadFromFile();
                }

                else if (mainform.radioButton6.Checked == true)
                {
                    Button.BackColor = Color.Magenta;
                    mainform.ReadFromFile();
                }
                //randon number generatator ofor compressability sensor
                Random rand = new Random();
                byte[] bytes = new byte[0];
                rand.NextBytes(bytes);

                int ctr = 14;
                if (ctr == rand.Next(15))
                {
                    
                    mainform.MessageBox1.Text = "Robot 1's Compressability Sensor is Broken \n\r";
                    mainform.fixRobot1compress();
                }         



        }
    

            
    //lost focus event handler       
    public void LostFocusHandler(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
            Button = (System.Windows.Forms.Button)sender;
            Button.BackColor = mainform.BackColor;
        }
    //right and left key down event handler
    public void PreviewKeyDownHandler(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
            System.Windows.Forms.Button NextButton = default(System.Windows.Forms.Button);
            Button = (System.Windows.Forms.Button)sender;

            switch (e.KeyCode)
            {
                case Keys.Right:

                    if ((p.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) + 50)] is Button))
                    {
                        NextButton = (System.Windows.Forms.Button)p.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) + 50)];
                        NextButton.Focus();
                    }

                    break;

                case Keys.Left:
                    if ((p.Controls["btn" + Convert.ToString((Convert.ToInt32(Button.Tag) - 50))] is Button))
                    {
                        NextButton = (System.Windows.Forms.Button)p.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) - 50)];
                        NextButton.Focus();
                    }

                    break;
            }
        }

      
    }
}


