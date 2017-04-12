using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Halley.About;
using Halley.Battery;
using Halley.Radiation;
using Halley.Compressability;
using Halley.Slope;
using Halley.Thermometer;

namespace Halley
{

    public partial class MainForm : Form
    {
        //StreamReader variable
        StreamReader SR;        

        #region Construtor

        public MainForm()
        {
            InitializeComponent();                 

            #region Robot Battery Sensor Constructor Details
            //Creating robots Battery Dead Event and setting the progress bar Interval
            robot1bat.SendInfo += new SendDetails(robot1bat_SendInfo);
            robot1bat.batteryTimer.Interval = 10000;
            robot2bat.SendRobot2Info += new SendRobot2Details(robot2bat_SendRobot2Info);
            robot2bat.Robot2Timer.Interval = 10000;
            robot3bat.SendRobot3Info +=new SendRobot3Details(robot3bat_SendRobot3Info);
            robot3bat.Robot3Timer.Interval = 10000;
            robot4bat.SendRobot4Info += new SendRobot4Details(robot4bat_SendRobot4Info);
            robot4bat.Robot4Timer.Interval = 10000;
            robot5bat.SendRobot5Info += new SendRobot5Details(robot5bat_SendRobot5Info);
            robot5bat.Robot5Timer.Interval = 10000;
            robot6bat.SendRobot6Info += new SendRobot6Details(robot6bat_SendRobot6Info);
            robot6bat.Robot6Timer.Interval = 10000;

            #endregion

        }

        


        #endregion        

        #region Battery Sensor Methods
        //Creating 6 new instances of the Robot Battery Class
        Robot1BatteryForm robot1bat = new Robot1BatteryForm();
        Robot2BatteryForm robot2bat = new Robot2BatteryForm();
        Robot3BatteryForm robot3bat = new Robot3BatteryForm();
        Robot4BatteryForm robot4bat = new Robot4BatteryForm();
        Robot5BatteryForm robot5bat = new Robot5BatteryForm();
        Robot6BatteryForm robot6bat = new Robot6BatteryForm();

        //The following 6 methods send Battery needs to be recharged to the message box
        public void robot1bat_SendInfo(string Details)
        {
            MessageBox1.AppendText("\r\n" + Details + "\r\n");
        }

        public void robot2bat_SendRobot2Info(string Robot2Details)
        {
            MessageBox1.AppendText("\r\n" + Robot2Details + "\r\n");
        }

        public void robot3bat_SendRobot3Info(string Robot3Details)
        {
            MessageBox1.AppendText("\r\n" + Robot3Details + "\r\n");
        }

        void robot4bat_SendRobot4Info(string Robot4Details)
        {
            MessageBox1.AppendText("\r\n" + Robot4Details + "\r\n");
            
        }

        void robot5bat_SendRobot5Info(string Robot5Details)
        {
            MessageBox1.AppendText("\r\n" + Robot5Details + "\r\n");
        }

        void robot6bat_SendRobot6Info(string Robot6Details)
        {
            MessageBox1.AppendText("\r\n" + Robot6Details + "\r\n");
        }       


        #endregion 

        #region Radiation Sensor Methods
        //Creating 6 new instances of the Robot Radiation Class
        Robot1Radiation robot1rad = new Robot1Radiation();
        Robot2Radiation robot2rad = new Robot2Radiation();
        Robot3Radiation robot3rad = new Robot3Radiation();
        Robot4Radiation robot4rad = new Robot4Radiation();
        Robot5Radiation robot5rad = new Robot5Radiation();
        Robot6Radiation robot6rad = new Robot6Radiation();

        #endregion        

        #region Compressability Sensor Methods
        //Creating 6 new instances of the Robot Compressability Class
        Robot1Compressability robot1com = new Robot1Compressability();
        Robot2Compressability robot2com = new Robot2Compressability();
        Robot3Compressability robot3com = new Robot3Compressability();
        Robot4Compressability robot4com = new Robot4Compressability();
        Robot5Compressability robot5com = new Robot5Compressability();
        Robot6Compressability robot6com = new Robot6Compressability();

        //Called when the fix Commpressability button is pressed
        public void fixRobot1compress()
        {
            robot1com.Combutton1.Visible = true;
            robot1com.Com1pictureBox2.Visible = true;
            robot1com.Com1pictureBox1.Visible = false;
            robot1com.Com1label1.Visible = false;

        }

        #endregion

        #region Slope Methods
        //Creating 6 new instances of the Robot Slope Class
        Robot1Slope slope1 = new Robot1Slope();
        Robot2Slope slope2 = new Robot2Slope();
        Robot3Slope slope3 = new Robot3Slope();
        Robot4Slope slope4 = new Robot4Slope();
        Robot5Slope slope5 = new Robot5Slope();
        Robot6Slope slope6 = new Robot6Slope();

        #endregion

        #region Thermometer Methods
        //Creating 6 new instances of the Robot Thermometer Class
        Robot1Thermometer thermo1 = new Robot1Thermometer();
        Robot2Thermometer thermo2 = new Robot2Thermometer();
        Robot3Thermometer thermo3 = new Robot3Thermometer();
        Robot4Thermometer thermo4 = new Robot4Thermometer();
        Robot5Thermometer thermo5 = new Robot5Thermometer();
        Robot6Thermometer thermo6 = new Robot6Thermometer();

        #endregion

        #region Menu Srtip
        // When a menu item is clicked the ShowDialog() Method is called for the 
        // following 30 Methods to show to Form.
        private void robot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            robot1bat.ShowDialog();

        }

        private void robot2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot2bat.ShowDialog();

        }

        private void robot3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot3bat.ShowDialog();

        }

        private void robot4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot4bat.ShowDialog();

        }

        private void robot5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot5bat.ShowDialog();

        }

        private void robot6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            robot6bat.ShowDialog();

        }

        private void robot1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot1com.ShowDialog();

        }

        private void robot2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot2com.ShowDialog();


        }

        private void robot3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot3com.ShowDialog();

        }

        private void robot4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot4com.ShowDialog();

        }

        private void robot5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot5com.ShowDialog();
        }

        private void robot6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot6com.ShowDialog();
        }

        private void robot1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            robot1rad.ShowDialog();

        }

        private void robot2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot2rad.ShowDialog();
        }

        private void robot3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot3rad.ShowDialog();

        }

        private void robot4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot4rad.ShowDialog();

        }

        private void robot5ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot5rad.ShowDialog();

        }

        private void robot6ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            robot6rad.ShowDialog();

        }

        private void robot1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope1.ShowDialog();

        }

        private void robot2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope2.ShowDialog();
        }

        private void robot3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope3.ShowDialog();
        }

        private void robot4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope4.ShowDialog();
        }

        private void robot5ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope5.ShowDialog();
        }

        private void robot6ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            slope6.ShowDialog();
        }

        private void robot1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo1.ShowDialog();
        }

        private void robot2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo2.ShowDialog();
        }

        private void robot3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo3.ShowDialog();
        }

        private void robot4ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo4.ShowDialog();
        }

        private void robot5ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo5.ShowDialog();
        }

        private void robot6ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thermo6.ShowDialog();
        }


        //When the Exit Menu item is selected the Application Exits
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //When the About form opens the Assembly version is gotten.
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.Version();
            aboutform.ShowDialog();

        }
        //When the Shutdown robots Item is selected all panels are disposed of if created
        private void shutdownRobotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                r1.getp().Dispose();
                r2.getp().Dispose();
                r3.getp().Dispose();
                r4.getp().Dispose();
                r5.getp().Dispose();
                r6.getp().Dispose();
                MessageBox.Show("Select the Robot again an inialize it", "Error", MessageBoxButtons.OKCancel);
            }

            catch
            {
                MessageBox.Show("You must first inialize all robots before you shut them down", "Error", MessageBoxButtons.OKCancel);
            }


        }
        //open user manual
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Final User Manual.pdf"); 

            
        }

        #endregion

        #region MessageBox Methods
        //Opens a text File
        public void OpenFile(string filename)
        {
            SR = File.OpenText(filename);
        }
        //Reads text File and outputs into the message box
        public void ReadFromFile()
        {
            try
            {
                
                string[] name_arr = { "Temperature", "Radiation", "Slope", "Compressability" };
                string buff = SR.ReadLine();

                int count = 0;
                int flag = 0;
                for (int i = 0; i < buff.Length; i++)
                {
                    if (buff[i] != ' ')
                    {

                        if (count == 0 && flag == 0)
                        {
                            MessageBox1.AppendText(name_arr[0]);
                            flag = 1;
                        }
                        MessageBox1.AppendText(buff[i].ToString());

                    }
                    else
                    {
                        count = (count + 1) % 4; flag = 0;
                        MessageBox1.AppendText("\r\n");
                        MessageBox1.AppendText(name_arr[count]);

                    }
                }

                MessageBox1.AppendText("\r\n\r\n");
            }

            catch
            {

            }
            
        }
        //Closes the StreamReader
        public void CloseFile()
        {
            SR.Close();
        }

        #endregion

        #region Select Robots & Clear MessageBox Buttons
        //The Select Robots Button Click method
        //When a radio button is selected a new instance of
        //the CRobot Class is created then the panel is added to the 
        //form. Visibility is set to true and the Text File is opened
        //for reading. When the next radio button is selected the previous
        //panel is disposed of to save resources.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked)
                {
                    pictureBox2.Dispose();
                    r1 = new CRobot();                    
                    this.Controls.Add(r1.getp());
                    r1.getp().Visible = true;
                    OpenFile("grid1.txt");             


                }
                else if (radioButton2.Checked)
                {
                    r1.getp().Dispose();
                    r2 = new CRobot();
                    this.Controls.Add(r2.getp());
                    r2.getp().Visible = true;
                    OpenFile("grid2.txt");
                    
                    

                }
                else if (radioButton3.Checked)
                {
                    r2.getp().Dispose();
                    r3 = new CRobot();
                    this.Controls.Add(r3.getp());
                    r3.getp().Visible = true;
                    OpenFile("grid3.txt");
                    

                }

                else if (radioButton4.Checked)
                {
                    r3.getp().Dispose();
                    r4 = new CRobot();
                    this.Controls.Add(r4.getp());
                    r4.getp().Visible = true;
                    OpenFile("Robot 4.txt");
                    
                   


                }
                else if (radioButton5.Checked)
                {
                    r4.getp().Dispose();
                    r5 = new CRobot();
                    this.Controls.Add(r5.getp());
                    r5.getp().Visible = true;
                    OpenFile("Robot 5.txt");
                    

                }
                else if (radioButton6.Checked)
                {
                    r5.getp().Dispose();
                    r6 = new CRobot();
                    this.Controls.Add(r6.getp());
                    r6.getp().Visible = true;
                    OpenFile("Robot 6.txt");
                    //r4.getp().Visible = false;
                    //r5.getp().Visible = false;


                }
            }

            catch
            {
                MessageBox.Show("You cannot select this robot out of order","Error",MessageBoxButtons.OKCancel);

            }


          

        }       

        //The Clear Message Box Method 
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox1.Text = " ";
        }

        #endregion

        

        
        

        

        
       

        

        

        

        

        

    }


}


