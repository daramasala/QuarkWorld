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

        public ColliderQuark(int width, int height) : base('O', ConsoleColor.Red, width, height)
        {
            var tuple = Simulation.NonZeroRandomTuple(-1, 2);
            VelocityX = tuple.Item1;
            VelocityY = tuple.Item2;
        }
    }
}
