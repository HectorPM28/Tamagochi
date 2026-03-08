using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Cat : APet, ISleep, IEat
    {
        public Cat(string name) : base(name)
        {

        }
        public static void ShowEmotion(APet cat)
        {
            switch (cat.State)
            {
                case EEmotions.Happy:
                    Console.WriteLine(UIConfig.CatsSprites.HappyCat);
                    break;
                case EEmotions.Sad:
                    Console.WriteLine(UIConfig.CatsSprites.SadCat);
                    break;
                case EEmotions.Angry:
                    Console.WriteLine(UIConfig.CatsSprites.AngryCat);
                    break;
                case EEmotions.Tired:
                    Console.WriteLine(UIConfig.CatsSprites.TiredCat);
                    break;
                case EEmotions.Sick:
                    Console.WriteLine(UIConfig.CatsSprites.SickCat);
                    break;
            }
        }

        public void Eat(APet pet, AItem food)
        {
            if (food is Food realFood)
            {
                Console.WriteLine(UIConfig.PetActions.Eat, pet.Name, realFood.Type);
                pet.Stats.Satiety += (int)realFood.Type;
                if (realFood.Type is ETypeFood.Snack)
                {
                    pet.State = EEmotions.Happy;
                }
            }
        }

        public void Sleep(APet pet)
        {
            Console.WriteLine(UIConfig.PetActions.Sleep, pet.Name);
            pet.Stats.Energy += 30;
        }
    }
}
