using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV1
{
    public class FadingLabel : Label
    {
        private int alpha = 0;
        public int FadeSpeed { get; set; }
        public int Alpha {
            get {
                return alpha;
            }
            set
            {
                if (value > 255)
                {
                    value = 255;
                }
                if(value < 0)
                {
                    value = 0;
                }
                alpha = value;
                Refresh();
            }
        }


        public override Color ForeColor { get => base.ForeColor.Blend(SystemColors.Control, alpha / 255d); set => base.ForeColor = value; }
    }

}
