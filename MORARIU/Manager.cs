using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace DimensionX
{
    public class Manager
    {
        public List<BoardSquare> board;


        public Manager()
        {
            board = new List<BoardSquare>();
            bool alb = true;
            for(int i=0;i<8;i++)
            {
                for(int j=0;j<8;j++)
                {
                    board.Add(new BoardSquare(i, j, alb));
                    alb = !alb;
                }
                alb = !alb;
            }
        }

        public void PlaceOnBoard()
        {
            board[0].currentPiece = new Piesa(Rang.Tureta, true);
            board[1].currentPiece = new Piesa(Rang.Cal, true);
            board[2].currentPiece = new Piesa(Rang.Nebun, true);
            board[3].currentPiece = new Piesa(Rang.Regina, true);
            board[4].currentPiece = new Piesa(Rang.Rege, true);
            board[5].currentPiece = new Piesa(Rang.Nebun, true);
            board[6].currentPiece = new Piesa(Rang.Cal, true);
            board[7].currentPiece = new Piesa(Rang.Tureta, true);

            for(int i =8;i<16;i++)
            {
                board[i].currentPiece = new Piesa(Rang.Pion, true);
            }


            for (int i = 55; i > 47; i--)
            {
                board[i].currentPiece = new Piesa(Rang.Pion, false);
            }

            board[56].currentPiece = new Piesa(Rang.Tureta, false);
            board[57].currentPiece = new Piesa(Rang.Cal, false);
            board[58].currentPiece = new Piesa(Rang.Nebun, false);
            board[59].currentPiece = new Piesa(Rang.Regina, false);
            board[60].currentPiece = new Piesa(Rang.Rege, false);
            board[61].currentPiece = new Piesa(Rang.Nebun, false);
            board[62].currentPiece = new Piesa(Rang.Cal, false);
            board[63].currentPiece = new Piesa(Rang.Tureta, false);

            for (int i = 0; i < 64; i++)
            {
                board[i].pictureBox1.Click += move;
            }
        }

        Piesa aux = null;

        private void move(object sender, EventArgs e)
        {
            if (aux == null)
            {
                aux = ((BoardSquare)((PictureBox)sender).Parent).currentPiece;
                ((BoardSquare)((PictureBox)sender).Parent).currentPiece = null;
            }
            else
            {
                if (((BoardSquare)((PictureBox)sender).Parent).currentPiece == null)
                {
                    ((BoardSquare)((PictureBox)sender).Parent).currentPiece = aux;
                    aux = null;
                }
                else if (((BoardSquare)((PictureBox)sender).Parent).currentPiece.Alb != aux.Alb)
                {
                    ((BoardSquare)((PictureBox)sender).Parent).currentPiece = aux;
                    aux = null;
                }
                else
                {
                    MessageBox.Show("Miscare nepermisa.");
                }
            }
        }

    }
}
