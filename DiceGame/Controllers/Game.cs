using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;
using DiceGame.UnitsControll;
using System.Linq;
using System.Collections;

namespace DiceGame.Controllers
{
    class Game
    {
        private int numberOfPlayers;
        private List<int> winners;
        private GameOver gameOver;
        private int[] pointsArray;
        private int totalPoints;

        private PlayerSelection player = new PlayerSelection();
        private Dice dice = new Dice();
        private List<Player> players = new List<Player>();
        
        
        public void Play()
        {
            InitGame();
            
        }

        public void Start()
        { 
            player.SelectPlayers();
            dice.SelectDice();
            RollAndPlay();
        }

        public void InitGame()
        {
            Menu.MainMenuRender();
           
            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            int hashCode = pressedChar.Key.GetHashCode();
            switch (pressedChar.Key)
            {
                case ConsoleKey.P:
                    Start();
                    break;
                case ConsoleKey.Q:
                    Menu.GoodByeRender();
                    break;
                default:
                    break;
            }
        }


        public void RollAndPlay()
        {
            numberOfPlayers = player.GetPlayersNumber();
            
            do
            {
                int id = 1;
                if (players.Count == numberOfPlayers)
                {
                    players.Clear();
                }
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    pointsArray = dice.RollDice();
                    totalPoints = dice.CountPoints(pointsArray);
                    players.Add(new Player(id, pointsArray, totalPoints));
                    id++;
                }

                int max = players.Max(p => p.TotalPoints);

                var winner = players.Where(p => p.TotalPoints == max).Select(p => p.Id);
                winners = winner.ToList(); 
            } 
            while (winners.Count!=1);

            PrintPoints();
            AskAgain();
        }

        public void PrintPoints()
        {
            Console.Clear();
            foreach (Player item in players)
            {
                item.Render();
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int item in winners)
            {
                Console.WriteLine("The winner is P" + item);
            }
        }


        public void AskAgain()
        {
            gameOver = new GameOver();
            gameOver.Render();
            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            int hashCode = pressedChar.Key.GetHashCode();
            switch (pressedChar.Key)
            {
                case ConsoleKey.R:
                    RollAndPlay();
                    break;
                case ConsoleKey.M:
                    ChangeMenu();
                    break;
                case ConsoleKey.Q:
                    Menu.GoodByeRender();
                    break;
                default:
                    break;
            }
        }

        public void ChangeMenu()
        {
            Array.Clear(pointsArray, 0, pointsArray.Length);
            players.Clear();
            winners.Clear();
            Start();
        }


    }
}
