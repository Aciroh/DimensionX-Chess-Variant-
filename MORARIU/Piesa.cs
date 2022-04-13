using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Drawing;
namespace DimensionX
{
    public class Piesa
    {
        static Bitmap spriteSheet;


        public bool Alb;
        public Rang Rank;
        public Bitmap Imagine;


        public Piesa()
        {
            Alb = true;
            Rank = Rang.Pion;
            Imagine = null;
        }
        public Piesa(Rang r, bool a)
        {
            Alb = a;
            Rank = r;


            if(spriteSheet == null)
            {
                spriteSheet = new Bitmap(Image.FromFile(@"CHESS_SPRITESHEET.png"));
            }

            Imagine = spriteSheet.Clone(new Rectangle(165*((int)Rank),
                                                      213*(Alb?1:0),
                                                      165,
                                                      213),
                                        spriteSheet.PixelFormat);


        }
    }
}
