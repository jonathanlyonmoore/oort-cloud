using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Halley.Battery
{
    
    public delegate void SendDetails(string Details);    

    public partial class Robot1BatteryForm : Form 
    {   //battery custom event definition
        public event SendDetails SendInfo;
        

        int incr = 1;    
        
        //construtor
        public Robot1BatteryForm()
        {         

                InitializeComponent();
                batteryTimer.Start();          
            
            
        }
        //Timer method
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
                    SendInfo(Robot1dead.Text);

                }            

        }
        //Recharge button click method
        private void recharge_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            recharge.Enabled = false;
            batteryTimer.Start();
            
        }

          

               

    }
}


