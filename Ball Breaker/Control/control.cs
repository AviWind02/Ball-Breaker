using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Breaker.Control
{
    internal class control
    {

        public bool isLeftDown
        { set; get; }
        public bool isRightDown
        { set; get; }
        public void downKeyContol(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                isLeftDown = true;
            }
            else if (e.KeyData == Keys.D)
            {
                isRightDown = true;
            }
        }
        /*
         * This checks if the key is uy
         */
        public void upKeyContol(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                isLeftDown = false;
            }
            else if (e.KeyData == Keys.D)
            {
                isRightDown = false;
            }
        }



    }
}
