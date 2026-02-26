using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Snack: AFood
    {
        public ETypeSnack Name { get; set; }

        public Snack(ETypeSnack name)
        {
            Name = name;
        }
    }
}
