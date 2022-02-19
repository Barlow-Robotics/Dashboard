using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash4572 {
    public class DoubleBufferedPanel : System.Windows.Forms.Panel {

        public DoubleBufferedPanel() {
            //InitializeComponent();

            if (!this.DesignMode) {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            }
        }
    }
}
