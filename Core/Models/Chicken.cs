using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Chicken: APet
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
    }
}
