using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkWorld
{
    public class PhantomQuark : Quark
    {
        public override void Update(World world)
        {
            X += VelocityX;
            Y += VelocityY;
            if (X < 0)
            {
                X = world.MaxX - 1;
            }
            if (X >= world.MaxX)
            {
                X = 0;
            }
            if (Y < 0)
            {
                Y = world.MaxY - 1;
            }
            if (Y >= world.MaxY)
            {
                Y = 0;
            }
        }

        public PhantomQuark(int width, int height) : base('@', ConsoleColor.Blue, width, height)
        {
            var tuple = Simulation.NonZeroRandomTuple(-1, 2);
            VelocityX = tuple.Item1;
            VelocityY = tuple.Item2;
        }
    }
}
