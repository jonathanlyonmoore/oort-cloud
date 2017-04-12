using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Halley;

namespace Halley.Robot1Battery
{
    public partial class Robot1BatteryForm : Form
    {
        private int Robot1batteryLifeTime = 50;

        public Robot1BatteryForm()
        {
            InitializeComponent();

            batteryTimer.Tick += new EventHandler(Battery);

            batteryTimer.Interval = 1000;
            batteryTimer.Start();          
        }

        void Battery(Object myObject, EventArgs myEventArgs)
        {
            batteryTimer.Stop();
            percent.Text = "The Battery Life is " + Robot1batteryLifeTime + "%";
            if (Robot1batteryLifeTime <= 50)
            {
                Robot1batteryLifeTime -= 1;
                batteryTimer.Enabled = true;

                if (Robot1batteryLifeTime == 0)
                {
                    MessageBox.Show("Robot 1's Battery Dead");
                    batteryTimer.Enabled = false;
                    batteryTimer.Stop();
                }
            }

        }
    }
}
