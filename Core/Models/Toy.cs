using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Toy: AItem
    {
        public ETypeToys Type { get; set; }

        public Toy(ETypeToys type)
        {
            Type = type;
        }
    }
}
