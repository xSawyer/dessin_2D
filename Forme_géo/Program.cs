using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Forme_géo
{
    static class Program
    {

        static void Main()
        {

        }

    }
    class Ligne
    {
        //champs
        public Point A, B;
        public int epaisseur;
        public double longueur;
        public int r, v, b;
        public int angle;


        //méthodes
        public void Dessiner()
        {

        }

        public void Rotation(int alpha)
        {
            angle = angle + alpha;
        }

        public void Echelle(double coeff)
        {
            int mX, mY;
            mX = ((A.X + B.X) / 2);
            mY = ((A.Y + B.Y) / 2);

            Translation(-mX, -mY);

            A.X = (int)(A.X * coeff);
            A.Y = (int)(A.Y * coeff);
            B.X = (int)(B.X * coeff);
            B.Y = (int)(B.Y * coeff);

            Translation(mX, mY);
        }

        public void Translation(int x, int y) 
        {
            A.X += x;
            A.Y += y;
            B.X += x;
            B.Y += y;
        }
    }
    
 
}
