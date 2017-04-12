using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WriteXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(("friends.xml"), null);
            xmlWriter.Formatting = Formatting.Indented;

            // Write root element
            xmlWriter.WriteStartElement("FriendsList");
            // Write first sub element of root element
            xmlWriter.WriteStartElement("Friend");

            // now start adding names 1.name
            xmlWriter.WriteElementString("Name", "David");
            // 2.name
            xmlWriter.WriteElementString("Age", "?");

            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Friend");

            xmlWriter.WriteElementString("Name", "Joanna");

            xmlWriter.WriteElementString("Age", "18");
            
            xmlWriter.WriteEndElement();

            // close writer
            xmlWriter.Close();

            label1.Text = "XML Written";
        }
    }
}
