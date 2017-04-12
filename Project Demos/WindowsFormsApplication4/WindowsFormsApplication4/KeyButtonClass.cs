using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Halley
{
    class KeyButton : System.Windows.Forms.Button
    {
        
       
        protected override bool ProcessDialogKey(Keys key)
        {
            switch (key)
            {
                case (Keys.Left):
                case (Keys.Right):
                case (Keys.Down):
                case (Keys.Up):
                case (Keys.Enter):
                    return false;
            }
            return base.ProcessDialogKey(key);

        }
        public KeyButton(int x, int y) 
        {
            Size = new System.Drawing.Size(15,15);
            Location = new System.Drawing.Point(x, y);
        }
    }
}
