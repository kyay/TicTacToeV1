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
        private int alpha = 255;
        public int FadeSpeed { get; set; }
        public int Alpha {
            get {
                return alpha;
            }
            set
            {
                alpha = value;
                ForeColor = ForeColor;
            }
        }

        public override Color ForeColor { get => Color.FromArgb(Alpha, base.ForeColor); set => base.ForeColor = value; }
    }
}
