using System;

namespace ex40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(50, 16);
            Renderer renderer = new Renderer(player);

            renderer.DrawPlayer(player);
        }
    }

    class Renderer
    {
        private Player _player;

        public Renderer(Player player) 
        {
            _player = player;
        }

        public void DrawPlayer(Player player, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(player.X, player.Y);
            Console.WriteLine(character);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
