using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class MyButton : System.Windows.Forms.Button
    {
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "My button");
            //base.OnClick(e);
        }
    }
}
