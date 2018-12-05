using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    public class Guessing
    {
        public enum StatusGame
        {
            Game, Win, Lose
        }

        public int GNumber { get; }

        public int YNumber { get; set; }

        public int TryCount { get; private set; }

        public StatusGame StGame { get; private set; }

        public string Info { get; private set; }

        public Guessing()
        {
            Random rnd = new Random();
            GNumber = rnd.Next(1, 101);
            YNumber = 0;
            TryCount = 3;
            StGame = StatusGame.Game;
            Info = "";
        }

        public void EnterYNumber(string text)
        {
            YNumber = Convert.ToInt32(text);
        }
        
        public void CheckAnswer()
        {
            TryCount--;
            if (TryCount > 0)
            {
                if (GNumber == YNumber)
                {
                    StGame = StatusGame.Win;
                }
                else
                {
                    if (GNumber > YNumber)
                    {
                        Info = "Your number is too low";
                        
                    }
                    else if (GNumber < YNumber)
                    {
                        Info = "Your number is too high";
                        //TryCount--;
                    }
                }
            }
            else StGame = StatusGame.Lose;
        }
    }
}
