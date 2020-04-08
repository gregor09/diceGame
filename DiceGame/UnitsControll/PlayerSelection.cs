using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;
using DiceGame.UnitsControll;
using DiceGame.Controllers;

namespace DiceGame.UnitsControll
{
    class PlayerSelection
    {
        private int activeButton;
        private int playersNumber;
        private PlayerSelectionMenu select = new PlayerSelectionMenu();

        
        public int SelectPlayers()
        {
            Render();
            ConsoleKeyInfo pressedChar;
            do
            {
                activeButton = GetActiveId();

                pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();

                if (activeButton == 2)
                {
                    if (pressedChar.Key == ConsoleKey.RightArrow)
                    {
                        ActivateButton(3);
                    }
                    else if (pressedChar.Key == ConsoleKey.DownArrow)
                    {
                        ActivateButton(4);
                    }
                }
                else if (activeButton == 3)
                {
                    if (pressedChar.Key == ConsoleKey.LeftArrow)
                    {
                        ActivateButton(2);
                    }
                    else if (pressedChar.Key == ConsoleKey.DownArrow)
                    {
                        ActivateButton(5);
                    }
                }

                else if (activeButton == 4)
                {
                    if (pressedChar.Key == ConsoleKey.RightArrow)
                    {
                        ActivateButton(5);
                    }
                    else if (pressedChar.Key == ConsoleKey.DownArrow)
                    {
                        ActivateButton(6);
                    }
                    else if (pressedChar.Key == ConsoleKey.UpArrow)
                    {
                        ActivateButton(2);
                    }
                }
                else if (activeButton == 5)
                {
                    if (pressedChar.Key == ConsoleKey.LeftArrow)
                    {
                        ActivateButton(4);
                    }
                    else if (pressedChar.Key == ConsoleKey.DownArrow)
                    {
                        ActivateButton(7);
                    }
                    else if (pressedChar.Key == ConsoleKey.UpArrow)
                    {
                        ActivateButton(3);
                    }
                }
                else if (activeButton == 6)
                {
                    if (pressedChar.Key == ConsoleKey.RightArrow)
                    {
                        ActivateButton(7);
                    }
                    else if (pressedChar.Key == ConsoleKey.UpArrow)
                    {
                        ActivateButton(4);
                    }
                }
                else if (activeButton == 7)
                {
                    if (pressedChar.Key == ConsoleKey.LeftArrow)
                    {
                        ActivateButton(6);
                    }
                    else if (pressedChar.Key == ConsoleKey.UpArrow)
                    {
                        ActivateButton(5);
                    }
                }
                Render();
            }
            while (pressedChar.Key != ConsoleKey.Enter);
            switch (activeButton)
            {
                case 2:
                    playersNumber = 2;
                    break;
                case 3:
                    playersNumber = 3;
                    break;
                case 4:
                    playersNumber = 4;
                    break;
                case 5:
                    playersNumber = 5;
                    break;
                case 6:
                    playersNumber = 6;
                    break;
                case 7:
                    playersNumber = 7;
                    break;
            }
            return playersNumber;
        }


        public int GetActiveId()
        {
           int id = select.GetActiveButtonId();
           return id;
        }

        public void ActivateButton(int id)
        {
            select.ActivateButtonById(id);
        }

        public void Render()
        {
            select.Render();
        }


        public int GetPlayersNumber()
        {
            return playersNumber;
        }


    }
}
