using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkWorld
{
    public class World
    {
        public int MaxX { get; }
        public int MaxY { get; }

        public Quark[] Quarks { get; }

        public World(Quark[] quarks, int maxX, int maxY)
        {
            Quarks = quarks;
            MaxX = maxX;
            MaxY = maxY;
        }

        public void Update()
        {
            foreach (var quark in Quarks)
            {
                quark.Erase();
            }
            foreach (var quark in Quarks)
            {
                quark.Update(this);
            }
            foreach (var quark in Quarks)
            {
                quark.Draw();
            }
        }
    }
}
