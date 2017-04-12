using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            byte[] bytes = new byte[0];
            rand.NextBytes(bytes);
            //for (int ctr = 0; ctr <= 0; ctr++)
            int ctr2 = 14; /*+= String.Format("{0,8:N0}",*/ //rand.Next(101);
            if (ctr2 == rand.Next(101))
            {

        }
    }
}
