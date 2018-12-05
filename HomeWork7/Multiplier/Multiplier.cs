using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    class Multiplier
    {
        Stack<int> history = new Stack<int>();
        
        public enum StatusGame
        {
            Game, Win, Lose
        }

        public int YNumber { get; private set; }

        public int GNumber { get; }

        public int GSteps { get; }

        public int YSteps { get; private set; }

        public StatusGame StGame { get; private set; }

        public Multiplier(int min, int max)
        {
            Random rnd = new Random();
            GNumber = rnd.Next(min,max);
            YNumber = 1;
            GSteps = SetGSteps(GNumber);
            YSteps = 0;
            StGame = StatusGame.Game;
        }

        private int SetGSteps(int goal)
        {
            int result = 0;
            do
            {
                if ((goal % 2) == 1)
                {
                    goal -= 1;
                    result++;
                }
                else
                {
                    goal = goal / 2;
                    result++;
                }
            }
            while (goal != 1);

            return result;
        }

        public void Plus()
        {
            YNumber++;
            YSteps++;
            history.Push(1);
        }

        public void Multi()
        {
            YNumber *= 2;
            YSteps++;
            history.Push(2);
        }

        public void Reset()
        {
            YNumber = 1;
            YSteps = 0;
            history.Clear();
        }

        public void StepBack()
        {
            if (history.Count > 0)
            {
                if (history.Peek() == 1)
                {
                    YNumber--;
                    YSteps--;
                    history.Pop();
                }
                else if (history.Peek() == 2)
                {
                    YNumber /= 2;
                    YSteps--;
                    history.Pop();
                }
            }
        }
        
        public void CheckStatus()
        {
            if (YNumber == GNumber)
            {
                if (YSteps == GSteps) StGame = StatusGame.Win;
                else StGame = StatusGame.Lose;
            }
            else StGame = StatusGame.Game;
        }
    }
}
