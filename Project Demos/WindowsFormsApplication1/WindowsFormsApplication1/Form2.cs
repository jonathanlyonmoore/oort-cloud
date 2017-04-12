using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private int batteryLifeTime = 50;       
       
        public Form2()
        {           
            InitializeComponent();
            
        }

        

        public void Form2_Load(object sender, EventArgs e)
        {
            Batterytimer.Tick += new EventHandler(Battery);

            Batterytimer.Interval = 1000;
            Batterytimer.Start();          
            
        }

        void Battery(Object myObject,EventArgs myEventArgs)
        {
            Batterytimer.Stop();
            percent.Text = "The Battery Life is " + batteryLifeTime;
            if (batteryLifeTime <= 50)
            {
                batteryLifeTime -= 1;
                Batterytimer.Enabled = true;

                if (batteryLifeTime == 0)
                {
                    MessageBox.Show("Battery dead");
                    Batterytimer.Enabled = false;
                    Batterytimer.Stop();
                }
            }
            
        }



       
        
            
        





    }

    
}
