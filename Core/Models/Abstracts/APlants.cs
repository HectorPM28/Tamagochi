using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;

namespace Tamagochi.Core.Models.Abstracts
{
    public abstract class APlants: APet, ISatiety
    {
        public APlants(string name) : base(name)
        {

        }
        public abstract void DecreaseSatiety();
        public abstract void UpdateHp();
    }
}
