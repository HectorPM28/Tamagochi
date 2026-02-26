using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;

namespace Tamagochi.Core.Models
{
    public class Player
    {
        public APet Pet { get; set; }
        public Inventory Inventory { get; set; }
    }
}
