using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DiceGame.UnitsControll
{
    class Player
    {
        public int Id { get; set; }
        public int[] pointsArray { get; set; }
        public int TotalPoints { get; set; }



        public Player(int id, int[] pointsArray, int totalPoints)
        {
            this.Id = id;
            this.pointsArray = pointsArray;
            this.TotalPoints = totalPoints;
        }


        public void Render()
        {
            Console.Write($"P{ Id}: ");
            for (int i = 0; i < pointsArray.Length; i++)
            {
                Console.Write(pointsArray[i] + " ");
            }
            Console.Write($"Total points: { TotalPoints}");
            Console.WriteLine();
            Console.WriteLine();
        }



    }
}
