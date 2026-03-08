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

        public void OpenInventory(Inventory inv)
        {
            for (int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] is Food food) Console.WriteLine($"{i + 1} - {food.Type}");
                if (inv.items[i] is Toy toy) Console.WriteLine($"{i + 1} - {toy.Type}");
            }
        }
        public void AddItem(AItem item, Inventory inv)
        {
            AItem[] invHelper = new AItem[inv.items.Length + 1];
            for (int i = 0; i < inv.items.Length; i++)
            {
                invHelper[i] = inv.items[i];
            }
            invHelper[invHelper.Length - 1] = item;
            inv.items = invHelper;
            ReorganizeInventory(inv);
        }
        public void DeleteItem(AItem item, Inventory inv)
        {
            AItem[] invHelper = new AItem[inv.items.Length];
            for (int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] != item)
                {
                    invHelper[i] = inv.items[i];
                }
            }
            inv.items = invHelper;
            ReorganizeInventory(inv);
        }
        private void ReorganizeInventory(Inventory inv)
        {
            int nullFoundHelper = 0;
            AItem[] invHelper = new AItem[inv.items.Length];
            for (int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] != null)
                {
                    invHelper[i - nullFoundHelper] = inv.items[i];
                }
                else
                {
                    nullFoundHelper++;
                }
            }
            inv.items = invHelper;
        }
    }
}
