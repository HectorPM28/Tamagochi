using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;

namespace Tamagochi.Core.Models
{
    public class Cactus: APlants
    {
        public Cactus(string name) : base(name)
        {
            
        }
        public override void DecreaseSatiety()
        {
        }

        public override void UpdateHp()
        {
        }
    }
}
