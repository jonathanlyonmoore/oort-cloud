using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Halley.Battery
{
    public delegate void SendRobot3Details(string Robot3Details);

    public partial class Robot3BatteryForm : Form
    {   //battery custom event definition
        public event SendRobot3Details SendRobot3Info;

        int incr3 = 1;
        //construtor
        public Robot3BatteryForm()
        {
            

                InitializeComponent();
                Robot3Timer.Start();
           
        }
        //Timer method
        private void Robot3Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= incr3;
            }
            else if (progressBar3.Value <= 0)
            {
                recharge3.Enabled = true;
                Robot3Timer.Stop();
                SendRobot3Info(Robot3dead.Text);

            }
        }
        //Recharge button click method
        private void recharge3_Click(object sender, EventArgs e)
        {
            progressBar3.Value = 100;
            recharge3.Enabled = false;
            Robot3Timer.Start();
        }
    }
}
