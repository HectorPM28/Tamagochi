using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi.Core.Models
{
    public class Stats
    {
        public int Satiety { get; set; } = 100;
        public int Energy { get; set; } = 100;
        public int Hp { get; set; } = 100;
        public int Charm { get; set; } = 0;
        public Stats()
        {

        }
    }
}
