using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;

namespace Tamagochi.Core.Models
{
    public class Dog: AAnimal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void DecreaseEnergy()
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