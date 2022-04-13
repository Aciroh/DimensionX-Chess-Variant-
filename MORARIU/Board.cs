using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionX
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        Manager man;


        private void Form1_Load(object sender, EventArgs e)
        {
            man = new Manager();
            foreach(BoardSquare x in man.board)
            {
                flowLayoutPanel1.Controls.Add(x);
            }
            man.PlaceOnBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            man = new Manager();
            foreach (BoardSquare x in man.board)
            {
                flowLayoutPanel1.Controls.Add(x);
            }
            man.PlaceOnBoard();
        }
    }
}
