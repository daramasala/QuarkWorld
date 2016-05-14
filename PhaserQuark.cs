using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkWorld
{
    public class PhaserQuark : Quark
    {
        public PhaserQuark() : base('%', ConsoleColor.Magenta)
        {
        }

        public override void Update(World world)
        {
            X = Simulation.Rand.Next(world.MaxX);
            Y = Simulation.Rand.Next(world.MaxY);
        }
    }
}
