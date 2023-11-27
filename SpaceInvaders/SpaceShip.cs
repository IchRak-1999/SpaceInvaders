using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal abstract class SpaceShip: SimpleObject
    {

        public SpaceShip(double speedPixelPerSecond, Vecteur2D position, int lives, Bitmap image) : base (position,image)
        {
            this.SpeedPixelPerSecond = speedPixelPerSecond;
            this.Position = position;
            this.Lives = lives;
            this.Image = image;
        }

        public override abstract void Update();

        public override abstract void Draw(Vecteur2D position);
    }
}
