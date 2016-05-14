using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkWorld
{
    public class ColliderQuark : Quark
    {
        public override void Update(World world)
        {
            var nextX = X + VelocityX;
            var nextY = Y + VelocityY;
            if (nextX < 0 || nextX >= world.MaxX)
            {
                VelocityX *= -1;
            }
            if (nextY < 0 || nextY >= world.MaxY)
            {
                VelocityY *= -1;
            }
            X += VelocityX;
            Y += VelocityY;
        }

        public ColliderQuark() : base('O', ConsoleColor.Red)
        {
            while (VelocityX == 0 && VelocityY == 0)
            {
                VelocityX = 1 - Simulation.Rand.Next(3);
                VelocityY = 1 - Simulation.Rand.Next(3);
            }
        }
    }
}
