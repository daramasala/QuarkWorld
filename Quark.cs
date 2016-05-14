using System;

namespace QuarkWorld
{
    public abstract class Quark
    {
        public int X { get; set; }
        public int Y { get; set; }
        protected int VelocityX { get; set; }
        protected int VelocityY { get; set; }

        private readonly char sprite;
        private readonly ConsoleColor color;

        protected Quark(char sprite, ConsoleColor color)
        {
            this.sprite = sprite;
            this.color = color;
        }

        public abstract void Update(World world);

        public void Erase()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(' ');
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = color;
            Console.Write(sprite);
        }
    }
}
