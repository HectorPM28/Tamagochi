using System;
using System.Numerics;
using Tamagochi.Core.Interfaces;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.Models.Enum;
using Tamagochi.Core.UI;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const int minMenuValue = 1, maxMenuValue = 5, minPetOptValue = 1, maxPetOptValue = 3, minInvOpt = 1, maxInvOpt = 3, minItemOpt = 1, maxItemOpt = 5, minAngryValue = 1, maxAngryValue = 5;

        string petName;
        int petSelector = 0, op = 0, invOp = 0, itemOp = 0, deleteItemOp = 0, useItemOp = 0, declinePlay = 1;
        bool existingOpt = false;

        Random rnd = new Random();

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
                    Console.Clear();
                    if (player.Pet.State is EEmotions.Angry || player.Pet.State is EEmotions.Sad)
                    {
                        declinePlay = rnd.Next(minAngryValue, maxAngryValue);
                    }
                    if (declinePlay == maxAngryValue || player.Pet.State is EEmotions.Tired || player.Pet.State is EEmotions.Sick)
                    {
                        Console.WriteLine(UIConfig.EmotionResponse.NoPlay, player.Pet.Name, player.Pet.State);
                    }
                    else 
                    {
                        if (player.Inventory.items == Array.Empty<AItem>() || player.Inventory.items[0] == null)
                        {
                            Console.WriteLine(UIConfig.WrongItemsUsed.EmptyInv);
                        }
                        else
                        {
                            if (player.Pet is IPlay playingPet)
                            {
                                Console.WriteLine(UIConfig.ItemOptions.PlayWithToy);
                                player.Inventory.OpenInventory(player.Inventory);
                                useItemOp = CheckInt(useItemOp, existingOpt, minItemOpt, player.Inventory.items.Length, UIConfig.IntErrorControl.NotInInvError);
                                if (player.Inventory.items[useItemOp - 1] is Toy)
                                {
                                    playingPet.Play(player.Inventory.items[useItemOp - 1], player.Pet);
                                }
                                else
                                {
                                    Console.WriteLine(UIConfig.WrongItemsUsed.NotAToy);
                                }
                            }
                        }                        
                    }                                        
                        Console.ReadKey();
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
                            player.Inventory.OpenInventory(player.Inventory);
                            useItemOp = CheckInt(useItemOp, existingOpt, minItemOpt, player.Inventory.items.Length, UIConfig.IntErrorControl.NotInInvError);
                            if (player.Inventory.items[useItemOp - 1] is Food)
                            {
                                eatingPet.Eat(player.Pet, player.Inventory.items[useItemOp - 1]);
                                player.Inventory.DeleteItem(player.Inventory.items[useItemOp - 1], player.Inventory);
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
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    UIConfig.ShowInventoryOptions();
                    invOp = CheckInt(invOp, existingOpt, minInvOpt, maxInvOpt, UIConfig.IntErrorControl.NotAInvOptError);

                    switch (invOp)
                    {
                        case 1:
                            Console.Clear();
                            player.Inventory.OpenInventory(player.Inventory);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            UIConfig.ShowItemOptions();
                            itemOp = CheckInt(itemOp, existingOpt, minItemOpt, maxItemOpt, UIConfig.IntErrorControl.NotAItemOptError);
                            GetItemToInv(player.Inventory, itemOp);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            TryDeletingItem(player.Inventory);
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 5:
                    player.Pet.DeadState = true;
                    break;
            }

            CheckSatiety(player.Pet);
            CheckEnergy(player.Pet);
            CheckHp(player.Pet);

            Console.Clear();
        } while (!player.Pet.DeadState);
        Console.WriteLine("Your pet died, happy?");
    }
    public static void TryDeletingItem(Inventory inventory)
    {                
        if (inventory.items == Array.Empty<AItem>() || inventory.items[0] == null)
        {
            Console.WriteLine(UIConfig.WrongItemsUsed.EmptyInv);
        }
        else
        {
            AvaliableDelete(inventory);
        }
    }
    public static void AvaliableDelete(Inventory inventory)
    {
        bool existingOpt = false;
        int minItemOpt = 1, deleteItemOp = 0;

        Console.WriteLine(UIConfig.ItemOptions.DeleteItemMenu);
        inventory.OpenInventory(inventory);
        deleteItemOp = CheckInt(deleteItemOp, existingOpt, minItemOpt, inventory.items.Length, UIConfig.IntErrorControl.NotInInvError);
        inventory.DeleteItem(inventory.items[deleteItemOp - 1], inventory);
        Console.WriteLine(UIConfig.InventoryOptions.ItemDeleted);
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
    public static void GetItemToInv(Inventory inventory, int itemOp)
    {
        switch (itemOp)
        {
            case 1:
                Food meal = new Food(ETypeFood.Meal);
                inventory.AddItem(meal, inventory);
                Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, meal.Type);
                break;
            case 2:
                Food snack = new Food(ETypeFood.Snack);
                inventory.AddItem(snack, inventory);
                Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, snack.Type);
                break;
            case 3:
                Toy ball = new Toy(ETypeToys.Ball);
                inventory.AddItem(ball, inventory);
                Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, ball.Type);
                break;
            case 4:
                Toy rope = new Toy(ETypeToys.Rope);
                inventory.AddItem(rope, inventory);
                Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, rope.Type);
                break;
            case 5:
                Toy chewtoy = new Toy(ETypeToys.ChewToy);
                inventory.AddItem(chewtoy, inventory);
                Console.WriteLine(UIConfig.InventoryOptions.ItemAdded, chewtoy.Type);
                break;
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
    public static void CheckHp(APet pet)
    {
        pet.Stats.Hp = ((pet.Stats.Energy + pet.Stats.Satiety) / 2) + (int)pet.State;

        switch (pet.Stats.Hp)
        {
            case < 0:
                pet.Stats.Hp = 0;
                pet.DeadState = true;
                break;
            case <= 20:
                pet.State = EEmotions.Sick;
                break;
            case <= 55:
                pet.State = EEmotions.Sad;
                break;
            case > 100:
                pet.Stats.Hp = 100;
                break;
        }
    }
    public static void CheckEnergy(APet pet)
    {
        pet.Stats.Energy -= 15;

        switch (pet.Stats.Energy)
        {
            case < 0:
                pet.Stats.Energy = 0;
                break;
            case <= 30:
                pet.State = EEmotions.Tired;
                break;
            case > 100:
                pet.Stats.Energy = 100;
                break;
        }
    }
    public static void CheckSatiety(APet pet)
    {
        pet.Stats.Satiety -= 10;

        switch (pet.Stats.Satiety)
        {
            case < 0:
                pet.Stats.Satiety = 0;
                break;
            case <= 50:
                pet.State = EEmotions.Angry;
                break;
            case > 100:
                pet.Stats.Satiety = 100;
                break;
        }
    }
}