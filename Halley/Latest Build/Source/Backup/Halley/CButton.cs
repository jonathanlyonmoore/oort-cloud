using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Halley
{   //class that creates a button
    class CButton : System.Windows.Forms.Button
    {
       
        public CButton(int Rows, int cols)
        {

            this.Top = Rows * 2;
            this.Left = 100;
            Size = new System.Drawing.Size(15, 15);
            Location = new System.Drawing.Point(Rows, cols);

        }
      
        
    }
}
