using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;

namespace Tamagochi.Core.Models
{
    public class Inventory
    {
        public AItem[] items { get; set; } = Array.Empty<AItem>();

        public Inventory()
        {

        }

        public void openInventory() { }
        public void addItem(AItem item) { }
        public void deleteItem(AItem item) { }
    }
}
