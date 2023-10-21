using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Vecteur2D
    {
        public double x;
        public double y;

        public Vecteur2D(double x = 0, double y = 0) {
            this.x = x;
            this.y = y;
        }

        public double Norme {
            get {
                return Math.Sqrt(x * x + y * y);
            }
        }

        public static Vecteur2D operator +(Vecteur2D v1, Vecteur2D v2) {
            
            return new Vecteur2D(v1.x + v2.x, v1.y + v2.y);

        }

        public static Vecteur2D operator -(Vecteur2D v1, Vecteur2D v2)
        {

            return new Vecteur2D(v1.x - v2.x, v1.y - v2.y);

        }

        public static Vecteur2D operator -(Vecteur2D v) {

            return new Vecteur2D(-v.x, -v.y);

        }

        public static Vecteur2D operator *(Vecteur2D v, double scalaire) {

            return new Vecteur2D(scalaire * v.x, scalaire * v.y);

        }

        public static Vecteur2D operator *(double scalaire, Vecteur2D v)
        {

            return new Vecteur2D(scalaire * v.x, scalaire * v.y);

        }

        public static Vecteur2D operator /(Vecteur2D v, double scalaire)
        {

            return new Vecteur2D(v.x / scalaire, v.y / scalaire);

        }

    }
}
