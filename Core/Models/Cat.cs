using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

namespace Tamagochi.Core.Models
{
    public class Cat: APet
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
    }
}
