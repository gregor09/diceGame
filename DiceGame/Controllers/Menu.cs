using System;
using System.Collections.Generic;
using System.Text;
using DiceGame.GUI;
using DiceGame.Controllers;

namespace DiceGame.Controllers
{
    static class Menu
    {

      public static MainMenu main;
      public static PlayerSelectionMenu playerMenu;
      public static DiceSelectionMenu diceMenu;
      public static GoodByeMenu goodBye;

        public static void MainMenuRender()
        {
            main = new MainMenu();
            main.Render();
        }

        public static void PlayerMenuRender()
        {
            playerMenu = new PlayerSelectionMenu();
            playerMenu.Render();
        }

        public static void DiceMenuRender()
        {
            diceMenu = new DiceSelectionMenu();
            diceMenu.Render();
        }

        public static void GoodByeRender()
        {
            goodBye = new GoodByeMenu();
            goodBye.Render();
        }



    }
}
