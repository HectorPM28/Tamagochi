using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Clothing: AItem
    {
        public ETypeClothes Name { get; set; }

        public Clothing (ETypeClothes name)
        {
            Name = name;
        }
    }
}
