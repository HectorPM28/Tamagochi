using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Interfaces
{
    public interface ISatiety
    {
        public void Eat(APet pet, AFood food)
        {
            Console.WriteLine(UIConfig.PetActions.Eat, pet.Name, food.GetType);
        }
    }
}
