using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Meal: AFood
    {
        public ETypeMeal Name { get; set; }

        public Meal (ETypeMeal name)
        {
            Name = name;
        }
    }
}
