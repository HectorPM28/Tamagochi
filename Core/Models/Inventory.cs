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

        public void openInventory(Inventory inv)
        {
            for(int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] is Food food)
                {
                    Console.WriteLine($"{i + 1} - {food.Type}");
                }
                if (inv.items[i] is Toy toy)
                {
                    Console.WriteLine($"{i + 1} - {toy.Type}");
                }
            }
        }
        public void openToyInventory(Inventory inv)
        {
            for (int i = 0; i < inv.items.Length; i++)
            {                
                if (inv.items[i] is Toy toy)
                {
                    Console.WriteLine($"{i + 1} - {toy.Type}");
                }
            }
        }
        public void openFoodInventory(Inventory inv)
        {
            for (int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] is Food food)
                {
                    Console.WriteLine($"{i + 1} - {food.Type}");
                }
            }
        }
        public void addItem(AItem item, Inventory inventory)
        {
            AItem[] invHelper = new AItem[inventory.items.Length + 1];
            for( int i = 0; i < inventory.items.Length; i++)
            {
                invHelper[i] = inventory.items[i];
            }
            invHelper[invHelper.Length - 1] = item;
            inventory.items = invHelper;
        }
        public void deleteItem(AItem item) { }
    }
}
