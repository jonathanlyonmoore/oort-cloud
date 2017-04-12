using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Halley.About
{
    public partial class AboutForm : Form
    {
        public Label lab;
        //constructor
        public AboutForm()
        {
            InitializeComponent();     

           
        }
        //Gets the Version of the Assembly.
        public void Version()
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();            
            label1.Text = " " + assemName.Name + assemName.Version.Major + "." + assemName.Version.Minor + "." + assemName.Version.Build;
            
            

        }

        

        
            
    }
}
