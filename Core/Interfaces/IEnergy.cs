using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Interfaces
{
    public interface IEnergy
    {
        public void Sleep(APet pet)
        {
            Console.WriteLine(UIConfig.PetActions.Sleep, pet.Name);
        }
    }
}
