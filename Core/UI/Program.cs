using System;
using System.Numerics;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const int minMenuValue = 1, maxMenuValue = 5, minPetOptValue = 1, maxPetOptValue = 3, minInvOpt = 1, maxInvOpt = 3, minItemOpt = 1, maxItemOpt = 5;

        string petName;
        int petSelector = 0, op = 0, invOp = 0, itemOp = 0, deleteItemOp = 0, eatFoodOp = 0;
        bool existingOpt = false;

        UIConfig.ShowPetOptions();
        petSelector = CheckInt(petSelector, existingOpt, minPetOptValue, maxPetOptValue, UIConfig.IntErrorControl.NotAPetOptError);
        Console.Clear();

        Console.WriteLine(UIConfig.ChoosePet.SetName);
        petName = Console.ReadLine();

        if (petName == "")
        {
            petName = "SinNombre";
        }

        Inventory inventory = new Inventory();
        Player player = new Player(AdoptPet(petSelector, petName), inventory);

        do
        {
            UIConfig.ShowGameBase(player.Pet);
            ShowPet(player.Pet);
            UIConfig.ShowStatsBars(player.Pet);
            UIConfig.ShowActions();
            op = CheckInt(op, existingOpt, minMenuValue, maxMenuValue, UIConfig.IntErrorControl.NotAMenuOptError);

            switch (op)
            {
                case 1:
                    break;
                case 2:
                    Console.Clear();
                    if (player.Inventory.items == Array.Empty<AItem>() || player.Inventory.items[0] == null)
                    {
                        Console.WriteLine(UIConfig.WrongItemsUsed.EmptyInv);
                    }
                    else
                    {
                        if (player.Pet is IEat eatingPet)
                        {
                            Console.WriteLine(UIConfig.ItemOptions.EatFood);
                            player.Inventory.openInventory(player.Inventory);
                            eatFoodOp = CheckInt(eatFoodOp, existingOpt, minItemOpt, player.Inventory.items.Length, UIConfig.IntErrorControl.NotInInvError);
                            if (player.Inventory.items[eatFoodOp - 1] is Food)
                            {
                                eatingPet.Eat(player.Pet, player.Inventory.items[eatFoodOp - 1]);
                                player.Inventory.deleteItem(player.Inventory.items[eatFoodOp - 1], player.Inventory);
                            }
                            else
                            {
                                Console.WriteLine(UIConfig.WrongItemsUsed.NotAFood);
                            }
                        }
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    if (player.Pet is ISleep sleepingPet)
                    {
                        sleepingPet.Sleep(player.Pet);
                    }
                    break;
                case 4:
                    Console.Clear();
                    UIConfig.ShowInventoryOptions();
                    invOp = CheckInt(invOp, existingOpt, minInvOpt, maxInvOpt, UIConfig.IntErrorControl.NotAInvOptError);

                    switch (invOp)
                    {
                        case 1:
                            Console.Clear();
                            player.Inventory.openInventory(player.Inventory);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            UIConfig.ShowItemOptions();
                            itemOp = CheckInt(itemOp, existingOpt, minItemOpt, maxItemOpt, UIConfig.IntErrorControl.NotAItemOptError);

                            switch (itemOp)
                            {
                                case 1:
                                    Food meal = new Food(Tamagochi.Core.Models.Enum.ETypeFood.Meal);
                                    player.Inventory.addItem(meal, player.Inventory);
                                    Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, meal.Type);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Food snack = new Food(Tamagochi.Core.Models.Enum.ETypeFood.Snack);
                                    player.Inventory.addItem(snack, player.Inventory);
                                    Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, snack.Type);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Toy ball = new Toy(Tamagochi.Core.Models.Enum.ETypeToys.Ball);
                                    player.Inventory.addItem(ball, player.Inventory);
                                    Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, ball.Type);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Toy rope = new Toy(Tamagochi.Core.Models.Enum.ETypeToys.Rope);
                                    player.Inventory.addItem(rope, player.Inventory);
                                    Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, rope.Type);
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Toy chewtoy = new Toy(Tamagochi.Core.Models.Enum.ETypeToys.ChewToy);
                                    player.Inventory.addItem(chewtoy, player.Inventory);
                                    Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, chewtoy.Type);
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(UIConfig.ItemOptions.DeleteItemMenu);
                            player.Inventory.openInventory(player.Inventory);
                            deleteItemOp = CheckInt(deleteItemOp, existingOpt, minItemOpt, player.Inventory.items.Length, UIConfig.IntErrorControl.NotInInvError);
                            player.Inventory.deleteItem(player.Inventory.items[deleteItemOp - 1], player.Inventory);
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 5:
                    player.Pet.DeadState = true;
                    break;
            }
            player.Pet.Stats.Satiety -= 10;
            player.Pet.Stats.Energy -= 15;

            if (player.Pet.Stats.Energy < 0)
            {
                player.Pet.Stats.Energy = 0;
            }
            if (player.Pet.Stats.Energy > 100)
            {
                player.Pet.Stats.Energy = 100;
            }

            if (player.Pet.Stats.Satiety < 0)
            {
                player.Pet.Stats.Satiety = 0;
            }
            if (player.Pet.Stats.Satiety > 100)
            {
                player.Pet.Stats.Satiety = 100;
            }

            player.Pet.Stats.Hp = (player.Pet.Stats.Energy + player.Pet.Stats.Satiety) / 2;
            if (player.Pet.Stats.Hp < 1)
            {
                player.Pet.DeadState = true;
                player.Pet.Stats.Hp = 0;
            }
            if (player.Pet.Stats.Hp > 100)
            {
                player.Pet.Stats.Hp = 100;
            }

            Console.Clear();
        } while (!player.Pet.DeadState);
        Console.WriteLine("Your pet died, happy?");
    }
    public static APet AdoptPet(int numPet, string petName)
    {
        switch (numPet)
        {
            case 1:
                Dog playerDog = new Dog(petName);
                return playerDog;
            case 2:
                Cat playerCat = new Cat(petName);
                return playerCat;
            case 3:
                Chicken playerChicken = new Chicken(petName);
                return playerChicken;
            default:
                //Default should never be reached but is inserted so all paths return a value
                Dog nonExistentPet = new Dog(petName);
                return nonExistentPet;
        }
    }
    public static void ShowPet(APet pet)
    {
        switch (pet)
        {
            case Cat:
                Cat.ShowEmotion(pet);
                break;
            case Dog:
                Dog.ShowEmotion(pet);
                break;
            case Chicken:
                Chicken.ShowEmotion(pet);
                break;

        }
    }
    public static int CheckInt(int op, bool existingOpt, int minValue, int maxValue, string errorText)
    {
        do
        {
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                existingOpt = true;
            }
            catch (FormatException)
            {
                existingOpt = false;
            }
            catch (OverflowException)
            {
                existingOpt = false;
            }
            catch (Exception)
            {
                existingOpt = false;
            }
            if (op < minValue || op > maxValue)
            {
                existingOpt = false;
                Console.WriteLine(errorText);
            }
        } while (!existingOpt);
        return op;
    }
}