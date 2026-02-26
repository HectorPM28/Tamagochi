using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;

namespace Tamagochi.Core.Models.Abstracts
{
    public abstract class AAnimal: APet, ISatiety, IEnergy, IPlay
    {
        public AAnimal(string name) : base(name)
        {

        }
        public abstract void DecreaseSatiety();
        public abstract void DecreaseEnergy();
        public abstract void UpdateHp();
    }
}
