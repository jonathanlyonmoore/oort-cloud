using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Halley.Battery
{
    public delegate void SendRobot5Details(string Robot5Details);

    public partial class Robot5BatteryForm : Form
    {   
        public event SendRobot5Details SendRobot5Info;

        int incr5 = 1;
        //construtor
        public Robot5BatteryForm()
        {
            InitializeComponent();
            Robot5Timer.Start();
        }
        //Timer method
        private void Robot5Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar5.Value > 0)
            {
                progressBar5.Value -= incr5;
            }
            else if (progressBar5.Value <= 0)
            {
                recharge5.Enabled = true;
                Robot5Timer.Stop();
                SendRobot5Info(Robot5dead.Text);

            }
        }
        //Recharge button click method
        private void recharge5_Click(object sender, EventArgs e)
        {
            progressBar5.Value = 100;
            recharge5.Enabled = false;
            Robot5Timer.Start();
        }
    }
}
