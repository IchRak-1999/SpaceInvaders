using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{

    internal abstract class GameObject
    {
        public abstract void Update();
        public abstract void Draw(Vecteur2D position);
        public bool isAlive(int lives)
        {
            if(lives > 0) return true;
            else return false;
        }
    }
}
