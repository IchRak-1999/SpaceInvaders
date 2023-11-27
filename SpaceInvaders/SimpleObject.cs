using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal abstract class SimpleObject: GameObject
    {
        private double speedPixelPerSecond;
        private Vecteur2D position;
        private int lives;
        private Bitmap image;

        public Vecteur2D Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public double SpeedPixelPerSecond
        {
            get { return speedPixelPerSecond; }
            set { speedPixelPerSecond = value; }
        }


        public SimpleObject(Vecteur2D position, Bitmap image)
        {
            this.Position = position;
            this.Image = image;
        }




    }



}
