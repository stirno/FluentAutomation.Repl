using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentAutomation.REPL
{
    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.ExStyle |= 0x00000020;
                return parms;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }
    }
}
