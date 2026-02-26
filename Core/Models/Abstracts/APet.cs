using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models.Abstracts
{
    public abstract class APet
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public EEmotions State { get; set; } = EEmotions.Happy;
        public bool DeadState { get; set; } = false;
        public Stats Stats { get; set; }

        public APet(string name)
        {
            Name = name;
            DateBirth = DateTime.Now;
        }
    }
}
