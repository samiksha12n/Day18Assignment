using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Assignment
{
    public class Game
    {
        
        public int EnergyLevel { get; set; }
        public int WiningProbability { get; set; }
        public int noofSpin { get; set; }

        public void FirstSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 1;
            WiningProbability += 10;
        }
        public void SecondSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 2;
            WiningProbability += 20;
        }
        public void ThirdSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel -= 3;
            WiningProbability -=30;
        }
        public void FourtSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 4;
            WiningProbability +=40;
        }
        public void FifthSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 5;
            WiningProbability += 50;
        }
        public void SixthSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel -=1;
            WiningProbability -= 60;
        }
        public void SeventhSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 1;
            WiningProbability += 70;
        }
        public void EigthSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel -= 2;
            WiningProbability -=20;
        }
        public void NinthSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel -=3;
            WiningProbability -=30;
        }
        public void TenthSpin()
        {
            EnergyLevel = 1;
            WiningProbability = 100;
            EnergyLevel += 10;
            WiningProbability += 100;
        }



    }
}
