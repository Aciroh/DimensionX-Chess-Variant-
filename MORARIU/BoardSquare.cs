using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionX
{
    public partial class BoardSquare : UserControl
    {

        public Point boardLocation;
        private Piesa p;
        public Piesa currentPiece
        {
            get { return p; }
            set
            {
                p = value;
                if (p != null)
                    pictureBox1.Image = p.Imagine;
                else
                    pictureBox1.Image = null;
            }
        }

        public BoardSquare()
        {
            InitializeComponent();
        }
        public BoardSquare(int x, int y, bool a)
        {
            InitializeComponent();

            boardLocation.X = x;
            boardLocation.Y = y;

            pictureBox1.BackColor = a ? Color.Red : Color.GreenYellow;
        }
    }
}