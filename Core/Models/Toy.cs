using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Toy: AItem
    {
        public ETypeToys Name { get; set; }

        public Toy(ETypeToys name)
        {
            Name = name;
        }
    }
}
