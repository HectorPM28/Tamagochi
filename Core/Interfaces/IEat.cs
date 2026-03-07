using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Interfaces
{
    public interface IEat
    {
        public void Eat(APet pet, Food food)
        {
            Console.WriteLine(UIConfig.PetActions.Eat, pet.Name, food.Type);
        }
    }
}
