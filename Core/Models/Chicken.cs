using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Chicken : APet, ISleep, IEat, IPlay
    {
        public Chicken(string name) : base(name)
        {

        }
        public static void ShowEmotion(APet chicken)
        {
            switch (chicken.State)
            {
                case EEmotions.Happy:
                    Console.WriteLine(UIConfig.ChickenSprites.HappyChicken);
                    break;
                case EEmotions.Sad:
                    Console.WriteLine(UIConfig.ChickenSprites.SadChicken);
                    break;
                case EEmotions.Angry:
                    Console.WriteLine(UIConfig.ChickenSprites.AngryChicken);
                    break;
                case EEmotions.Tired:
                    Console.WriteLine(UIConfig.ChickenSprites.TiredChicken);
                    break;
                case EEmotions.Sick:
                    Console.WriteLine(UIConfig.ChickenSprites.SickChicken);
                    break;
            }
        }
        public void Play(AItem toy, APet pet)
        {
            if (toy is Toy realToy)
            {
                Console.WriteLine(UIConfig.PetActions.Play, pet.Name, realToy.Type);
                pet.Stats.Energy -= (int)realToy.Type;
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
