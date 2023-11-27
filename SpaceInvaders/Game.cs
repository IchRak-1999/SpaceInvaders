using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Game
    {
        public SpaceShip playership;

        public Game(SpaceShip playerShip)
        {
            Vecteur2D pos = new Vecteur2D(0, -1);
            playerShip.Lives = 3;
            playerShip.Draw(pos);
        }
    }


}
