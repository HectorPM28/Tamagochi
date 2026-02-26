using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;

namespace Tamagochi.Core.Models.Abstracts
{
    public abstract class AObjects:APet, IEnergy, IPlay
    {
        public AObjects(string name) : base(name)
        {
            Stats.Satiety = 0;
        }
        public abstract void DecreaseEnergy();
        public abstract void UpdateHp();
    }
}
