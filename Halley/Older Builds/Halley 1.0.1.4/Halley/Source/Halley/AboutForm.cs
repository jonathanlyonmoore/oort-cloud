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
        public AboutForm()
        {
            
            InitializeComponent();
            Version();
        }

        public void Version()
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            AssemblyName assemName = assem.GetName();
            Label lab = new Label();
            lab.Location = new System.Drawing.Point(216, 249);
            lab.Text = " " + assemName.Name + assemName.Version.Major + "." + assemName.Version.Minor + "." + assemName.Version.Build;
            Controls.Add(lab);

        }
            
    }
}
