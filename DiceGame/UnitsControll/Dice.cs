using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;

namespace DiceGame.UnitsControll
{
    class Dice
    {
        private DiceSelectionMenu selectionMenu;
        private int diceNumber;

        public Dice()
        {
            selectionMenu = new DiceSelectionMenu();
        }

        public void SelectDice()
        {
            selectionMenu.Render();
            diceNumber = 1;
            Render();

            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Add:
                            diceNumber++;
                            break;
                        case ConsoleKey.Subtract:
                            diceNumber--;
                            break;
                        default:
                            break;
                    }
                if (diceNumber>0)
                {
                    Render();
                }
    
            }
            while (pressedChar.Key != ConsoleKey.Enter && pressedChar.Key != ConsoleKey.Escape);
            if (pressedChar.Key == ConsoleKey.Escape)
            {
                GoodByeMenu goodBye = new GoodByeMenu();
                goodBye.Render();
            }

        }


        public int[] RollDice()
        {
            Random rnd = new Random();
            int[] pointsArray = new int[diceNumber];
            for (int i = 0; i < diceNumber; i++)
            {
                int points = rnd.Next(1, 7);
                pointsArray[i] = points;
            }
            return pointsArray;
        }

        public int CountPoints(int[] pointsArray)
        {
            int sum = 0;
            for (int i = 0; i < pointsArray.Length; i++)
            {
                sum = sum + pointsArray[i];
            }
            return sum;
        }


        public int GetDiceNumber()
        {
            return diceNumber;
        }

        public void Render()
        {
            Console.SetCursorPosition(59, 12);
            Console.WriteLine(diceNumber);
        }



    }
}
