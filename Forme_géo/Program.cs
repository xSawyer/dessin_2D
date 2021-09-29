﻿using System;
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
            Form myForm;
            Bitmap btmp;
            Graphics grphcs;

            Ligne ligne1;
            btmp = new Bitmap(800, 400);

            ligne1 = new Ligne(100, 100, 200, 300, 255, 0, 0);
            grphcs = Graphics.FromImage(btmp);

            ligne1.Dessiner(grphcs);

            myForm = new Form();
            myForm.Text = "CNAM Licence Cyber-Sécurité 2021-2022";
            myForm.BackColor = Color.FromArgb(255,255,255);
            myForm.ClientSize = btmp.Size;
            myForm.BackgroundImage = btmp;
            myForm.Cursor = Cursors.Cross;
            myForm.ShowDialog();
            myForm.Dispose();


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

        //Constructeur
        public Ligne(int xA, int yA, int xB, int yB, int rouge, int vert, int bleu) 
        {
            A.X = xA;
            A.Y = yA;
            B.X = xB;
            B.Y = yB;

            angle = 0;
            epaisseur = 1;
            r = rouge; v = vert; b = bleu;
        }


        //méthodes
        public void Dessiner(Graphics grphcs)
        {
            grphcs.RotateTransform(angle);
            grphcs.DrawLine(new Pen(Color.FromArgb(255,0,0)), A, B);
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
