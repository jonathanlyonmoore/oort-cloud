using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public delegate void SendDetails(string Details);

  public partial class Form2 : Form
    {
        public event SendDetails SendInfo;
       
        public Form2()
        {
            InitializeComponent();
        }
               

        private void button1_Click(object sender, EventArgs e)
        {
            SendInfo(txtName.Text.Trim());
            this.Close();

        }
    }
}
