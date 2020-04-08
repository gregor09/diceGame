using System;
using System.Collections.Generic;
using DiceGame.GUI;
using DiceGame.UnitsControll;

using DiceGame.Controllers;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Game game = new Game();
            game.Play();



            Console.ReadKey();
        }
    }
}
