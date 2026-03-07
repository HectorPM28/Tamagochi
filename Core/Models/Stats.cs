using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;

namespace Tamagochi.Core.Models
{
    public class Stats
    {
        public int Satiety { get; set; }
        public int Energy { get; set; }
        public int Hp { get; set; }
        public Stats(int satiety = 100, int energy = 100, int hp = 100)
        {
            Satiety = satiety;
            Energy = energy;
            Hp = hp;
        }
    }
}
