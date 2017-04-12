using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;






namespace Halley.Battery
{
    public partial class Robot1BatteryForm : Form 
    {
        int incr = 1;
        
        

        public Robot1BatteryForm()
        {
            InitializeComponent();
            batteryTimer.Start();
            batteryTimer.Interval = 100;
            
        }
        
        private void batteryTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= incr;
            }
            else if (progressBar1.Value <= 0)
            {
                recharge.Enabled = true;
                batteryTimer.Stop();
               
                
            }
        }

        private void recharge_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            recharge.Enabled = false;
            batteryTimer.Start();
            
        }

       

        


       

        
        

    }
}
