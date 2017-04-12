



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericEventHandler
{
    public class KeyButtonClass : System.Windows.Forms.Button
    {

        public KeyButtonClass(int Rows, int cols)
        {

            this.Top = Rows * 2;
            this.Left = 100;
            Size = new System.Drawing.Size(15, 15);
            Location = new System.Drawing.Point(Rows, cols);

        }


    } 
}
