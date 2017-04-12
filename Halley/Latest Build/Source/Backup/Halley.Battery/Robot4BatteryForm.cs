using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Halley.Battery
{
    public delegate void SendRobot4Details(string Robot4Details);

    public partial class Robot4BatteryForm : Form
    {   //battery custom event definition
        public event SendRobot4Details SendRobot4Info;

        int incr4 = 1;
        //construtor
        public Robot4BatteryForm()
        {
            InitializeComponent();
            Robot4Timer.Start();
           
        }
        //Timer method
        private void Robot4Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= incr4;
            }
            else if (progressBar4.Value <= 0)
            {
                recharge4.Enabled = true;
                Robot4Timer.Stop();
                SendRobot4Info(Robot4dead.Text);

            }
        }
        //Recharge button click method
        private void recharge4_Click(object sender, EventArgs e)
        {
            progressBar4.Value = 100;
            recharge4.Enabled = false;
            Robot4Timer.Start();
        }
    }
}
