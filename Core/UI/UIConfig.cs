using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;

namespace Tamagochi.Core.UI
{
    public static class UIConfig
    {
        public static void ShowPetOptions()
        {
            Console.WriteLine(ChoosePet.Selection);
            Console.WriteLine(ChoosePet.Dog);
            Console.WriteLine(ChoosePet.Cat);
            Console.WriteLine(ChoosePet.Chicken);
        }
        public static void ShowStatsBars(APet pet)
        {
            Console.WriteLine($"{DrawStatBar(pet.Stats.Hp)} Hp");
            Console.WriteLine($"{DrawStatBar(pet.Stats.Satiety)} Satiety");
            Console.WriteLine($"{DrawStatBar(pet.Stats.Energy)} Energy");
        }
        public static void ShowActions()
        {
            Console.WriteLine(ActionsMenu.Play);
            Console.WriteLine(ActionsMenu.Eat);
            Console.WriteLine(ActionsMenu.Sleep);
            Console.WriteLine(ActionsMenu.Inventory);
            Console.WriteLine(ActionsMenu.Exit);
        }
        public static void ShowGameBase(APet pet)
        {
            Console.WriteLine(TamagochiBase.SquareBase);
            Console.WriteLine(TamagochiBase.petInfo, pet.Name, pet.State);
            Console.WriteLine(TamagochiBase.petBirth, pet.DateBirth);
            Console.WriteLine(TamagochiBase.SquareBase);
        }
        public static void ShowInventoryOptions()
        {
            Console.WriteLine(InventoryOptions.OpenInventory);
            Console.WriteLine(InventoryOptions.AddItem);
            Console.WriteLine(InventoryOptions.RemoveItem);
        }
        public static void ShowItemOptions()
        {
            Console.WriteLine(ItemOptions.Meal);
            Console.WriteLine(ItemOptions.Snack);
            Console.WriteLine(ItemOptions.Ball);
            Console.WriteLine(ItemOptions.Rope);
            Console.WriteLine(ItemOptions.ChewToy);
        }
        public static class WrongItemsUsed
        {
            public const string NotAFood = "The item selected isn't a food";
            public const string NotAToy = "The item isn't a toy";
            public const string EmptyInv = "The inventory is empty";
        }
        public static class ItemOptions
        {
            public const string Meal = "1 - Meal";
            public const string Snack = "2 - Snack";
            public const string Ball = "3 - Ball";
            public const string Rope = "4 - Rope";
            public const string ChewToy = "5 - Chew toy";
            public const string EatFood = "Which food would you like to eat";
            public const string PlayWithToy = "Which toy would you like to play with";
            public const string DeleteItemMenu = "Which item would you like to delete";
        }
        public static class PetCantAct
        {
            public const string CantSleep = "This pet can't rest";
            public const string CantEat = "This pet can't eat";
            public const string CantPlay = "This pet can't play";
        }
        public static class InventoryOptions
        {
            public const string OpenInventory = "1 - Open inventory";
            public const string AddItem = "2 - Add item to inventory";
            public const string RemoveItem = "3 - Remove item from inventory";
            public const string ItemAdded = "You added a {0} to the inventory";
            public const string ItemDeleted = "You deleted the item from the inventory";
        }
        public static class CatsSprites
        {
            public const string HappyCat = "      /\\_/\\      \r\n     ( ^‿^ )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string SadCat = "      /\\_/\\      \r\n     ( ╥﹏╥ )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string AngryCat = "      /\\_/\\      \r\n     ( @_@ )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string TiredCat = "      /\\_/\\      \r\n     ( -_- ) zzz     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string SickCat = "      /\\_/\\      \r\n     ( x_x )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
        }
        public static class ChickenSprites
        {
            public const string HappyChicken = "   \\\\\r\n   (^>\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
            public const string SadChicken = "   \\\\\r\n   (╥>\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
            public const string AngryChicken = "   \\\\\r\n   (@>\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
            public const string TiredChicken = "   \\\\\r\n   (->\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
            public const string SickChicken = "   \\\\\r\n   (X>\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
        }
        public static class DogSprites
        {
            public const string HappyDog = "           __\r\n      (___()^`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string SadDog = "           __\r\n      (___()╥`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string AngryDog = "           __\r\n      (___()@`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string TiredDog = "           __\r\n      (___()-`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string SickDog = "           __\r\n      (___()X`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
        }
        public static class PetActions
        {
            public const string Eat = "{0} eats the {1}";
            public const string Play = "{0} plays with the {1}";
            public const string Sleep = "{0} sleeps peacefully";
        }
        public static class ChoosePet
        {
            public const string Selection = "Select your pet";
            public const string Dog = "1 - Dog";
            public const string Cat = "2 - Cat";
            public const string Chicken = "3 - Chicken";
            public const string SetName = "What's the name of your pet?";
        }
        public static class IntErrorControl
        {
            public const string NotAPetOptError = "Number must be between 1-3";
            public const string NotAMenuOptError = "Number must be between 1-5";
            public const string NotAInvOptError = "Number must be between 1-3";
            public const string NotAItemOptError = "Number must be between 1-5";
            public const string NotInInvError = "You must select an exising item";
        }
        public static class TamagochiBase
        {
            public const string Spacer = "----------------------------------";
            public const string SquareBase = "==================================";
            public const string petInfo = "    Name: {0} Status: {1}";
            public const string petBirth = "=    Birth: {0}   =";
        }
        public static class ActionsMenu
        {
            public const string Play = "1 - Play";
            public const string Eat = "2 - Give food";
            public const string Sleep = "3 - Sleep";
            public const string Inventory = "4 - Inventory";
            public const string Exit = "5 - Kill the pet";

        }
        public static class EmotionResponse
        {
            public const string NoPlay = "{0} is too {1} to play with you";
        }
        public static string DrawStatBar(int value)
        {
            int totalBlocks = 20;
            int filledBlocks = value * totalBlocks / 100;

            return "[" +
                new string('#', filledBlocks) +
                new string('-', totalBlocks - filledBlocks) +
                $"] {value}%";
        }
    }
}
