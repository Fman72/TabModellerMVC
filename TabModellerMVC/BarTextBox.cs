using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabModellerMVC
{
    /// <summary>
    /// This is a helper sub class of label. It is identical to a label except that it contains another property called id used to identify what bar it is displaying in the GraphicalBarView. 
    /// </summary>
    class BarTextBox : RichTextBox
    {
        public int id { get; set; }

        public BarTextBox(int id): base()
        {
            //Initializing customizations.
            this.Font = new System.Drawing.Font("Courier New", 6.75F);
            this.ReadOnly = true;
            this.id = id;
        }
    }
}
