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
    public delegate void SendRobot6Details(string Robot6Details);

    public partial class Robot6BatteryForm : Form
    {   //battery custom event definition
        public event SendRobot6Details SendRobot6Info;

        int incr6 = 1;
        //construtor
        public Robot6BatteryForm()
        {
            InitializeComponent();
            Robot6Timer.Start();
        }
        //Timer method
        private void Robot6Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= incr6;
            }
            else if (progressBar6.Value <= 0)
            {
                recharge6.Enabled = true;
                Robot6Timer.Stop();
                SendRobot6Info(Robot6dead.Text);

            }
        }
        //Recharge button click method
        private void recharge6_Click(object sender, EventArgs e)
        {
            progressBar6.Value = 100;
            recharge6.Enabled = false;
            Robot6Timer.Start();
        }
    }
}
