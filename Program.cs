using System;
using System.Diagnostics;
using System.Threading;

namespace QuarkWorld
{
    public class Simulation
    {
        public static Random Rand { get; } = new Random();

        const int Width = 80;
        const int Height = 25;

        private static readonly Func<Quark>[] QuarkFactories = 
            {
                () => new PhantomQuark(),
                () => new ColliderQuark(),
                () => new PhaserQuark()
            };

        private static readonly TimeSpan SleepTime = TimeSpan.FromMilliseconds(100);

        private Quark[] CreateQuarks()
        {
            var quarks = new Quark[30];
            for (int i = 0; i < quarks.Length; i++)
            {
                var factoryIndex = Rand.Next(QuarkFactories.Length);
                var quark = QuarkFactories[factoryIndex]();
                quark.X = Rand.Next(Width);
                quark.Y = Rand.Next(Height - 1);
                quarks[i] = quark;
            }
            return quarks;
        }

        public void Run()
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(Width, Height);
            Console.WindowWidth = Width;
            Console.WindowHeight = Height;
            var world = new World(
                CreateQuarks(),
                Width, Height -1
                );
            while (true)
            {
                world.Update();
                Thread.Sleep(SleepTime);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sim = new Simulation();
            sim.Run();
        }
    }
}
