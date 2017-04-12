using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Halley.Battery
{
    public delegate void SendRobot2Details(string Robot2Details);

    public partial class Robot2BatteryForm : Form
    {   //battery custom event definition
        public event SendRobot2Details SendRobot2Info;

        int incr2 = 1;
        //construtor
        public Robot2BatteryForm()
        {        

                InitializeComponent();
                Robot2Timer.Start();
           

        }
        //Timer method
        private void Robot2Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= incr2;
            }
            else if (progressBar2.Value <= 0)
            {
                recharge2.Enabled = true;
                Robot2Timer.Stop();
                SendRobot2Info(Robot2dead.Text);

            }
        }
        //Recharge button click method
        private void recharge2_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 100;
            recharge2.Enabled = false;
            Robot2Timer.Start();
        }
    }
}
