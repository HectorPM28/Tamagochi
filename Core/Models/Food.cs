using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Food: AItem
    {
        public ETypeFood Type { get; set; }
        public Food(ETypeFood type)
        {
            Type = type;
        }
    }
}
