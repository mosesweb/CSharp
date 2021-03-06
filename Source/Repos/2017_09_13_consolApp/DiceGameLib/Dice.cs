﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameLib
{
    public class Dice
    {
        private int numberOfDots = 6;
        private int currentNumberOfDots = 0;
        private Random random;

        public Dice(Random random)
        {
            this.random = random;
        }
        public void ThrowDice()
        {
            currentNumberOfDots = random.Next(1, this.numberOfDots);
        }
        // for testing
        public void ThrowDice(int dicedots)
        {
            currentNumberOfDots = dicedots;
        }
        public int CurrentNumberOfDots
        {
            get
            {
                return currentNumberOfDots;
            }
        }
    }
}
