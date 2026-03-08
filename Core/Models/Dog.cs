using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Dog : APet, ISleep, IEat, IPlay
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