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

        const int minMenuValue = 1, maxMenuValue = 5, minPetOptValue = 1, maxPetOptValue = 3;

        string petName;
        int petSelector = 0, op = 0;
        bool existingOpt;

        do
        {
            UIConfig.ShowPetOptions();

            try
            {
                petSelector = Convert.ToInt32(Console.ReadLine());
                existingOpt = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(UIConfig.IntErrorControl.FormatError);
                existingOpt = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine(UIConfig.IntErrorControl.OverflowException);
                existingOpt = false;
            }
            catch (Exception)
            {
                Console.WriteLine(UIConfig.IntErrorControl.FormatError);
                existingOpt = false;
            }
            Console.Clear();
            if(petSelector < minPetOptValue || petSelector > maxPetOptValue)
            {
                existingOpt = false;
                Console.WriteLine(UIConfig.IntErrorControl.NotAPetOptError);
            }
        } while (!existingOpt);

        Console.WriteLine(UIConfig.ChoosePet.SetName);
        petName = Console.ReadLine();

        if(petName == null)
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
            do
            {
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                    existingOpt = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(UIConfig.IntErrorControl.FormatError);
                    existingOpt = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(UIConfig.IntErrorControl.OverflowException);
                    existingOpt = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(UIConfig.IntErrorControl.FormatError);
                    existingOpt = false;
                }
                if (op < minMenuValue || op > maxMenuValue)
                {
                    existingOpt = false;
                    Console.WriteLine(UIConfig.IntErrorControl.NotAMenuOptError);
                }
            } while (!existingOpt);

            switch (op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    if (player.Pet is ISleep sleepingPet)
                    {
                        sleepingPet.Sleep(player.Pet);
                    }
                    break;
                case 4:
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
}