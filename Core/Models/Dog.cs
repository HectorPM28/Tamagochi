using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Dog: APet, ISleep
    {
        public Dog(string name) : base(name)
        {

        }
        public static void ShowEmotion(APet dog)
        {
            switch (dog.State)
            {
                case EEmotions.Happy:
                    Console.WriteLine(UIConfig.DogSprites.HappyDog);
                    break;
                case EEmotions.Sad:
                    Console.WriteLine(UIConfig.DogSprites.SadDog);
                    break;
                case EEmotions.Angry:
                    Console.WriteLine(UIConfig.DogSprites.AngryDog);
                    break;
                case EEmotions.Tired:
                    Console.WriteLine(UIConfig.DogSprites.TiredDog);
                    break;
                case EEmotions.Sick:
                    Console.WriteLine(UIConfig.DogSprites.SickDog);
                    break;
            }
        }
        public void Sleep(APet pet)
        {
            Console.WriteLine(UIConfig.PetActions.Sleep, pet.Name);
            pet.Stats.Energy += 30;
        }
    }
}