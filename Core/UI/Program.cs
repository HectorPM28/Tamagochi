using System;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        string petName;
        int petSelector = 0, op = 0;
        bool existingOpt;


        //Delete this pet when finished testing
        Cat gato = new Cat("XD");
        /*
        do
        {
            Console.WriteLine(UIConfig.ChoosePet.Selection);
            Console.WriteLine(UIConfig.ChoosePet.Dog);
            Console.WriteLine(UIConfig.ChoosePet.Cat);
            Console.WriteLine(UIConfig.ChoosePet.Chicken);
            Console.WriteLine(UIConfig.ChoosePet.Robot);
            Console.WriteLine(UIConfig.ChoosePet.Cactus);

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
            if(petSelector < 1 || petSelector > 5)
            {
                existingOpt = false;
                Console.WriteLine(UIConfig.IntErrorControl.NotAnOptionError);
            }
        } while (!existingOpt);

        Console.WriteLine(UIConfig.ChoosePet.SetName);
        petName = Console.ReadLine();

        if(petName == null)
        {
            petName = "SinNombre";
        }

        petName = petName.Substring(0, 1).ToUpper() + petName.Substring(1).ToLower();
        */
        do
        {
            ShowGameBase(gato);
            ShowPet(gato);
            ShowActions();
            Console.WriteLine(gato.Stats.Hp);
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
                if (op < 1 || op > 5)
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
                    break;
                case 4:
                    break;
                case 5:
                    gato.DeadState = true;
                    break;
            }
            

        } while (!gato.DeadState);
    }
    public static void ShowGameBase(APet pet)
    {
        Console.WriteLine(UIConfig.TamagochiBase.SquareBase);
        Console.WriteLine(UIConfig.TamagochiBase.petInfo, pet.Name, pet.State);
        Console.WriteLine(UIConfig.TamagochiBase.petBirth, pet.DateBirth);
        Console.WriteLine(UIConfig.TamagochiBase.SquareBase);
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
    public static void ShowActions()
    {
        Console.WriteLine(UIConfig.ActionsMenu.Play);
        Console.WriteLine(UIConfig.ActionsMenu.Eat);
        Console.WriteLine(UIConfig.ActionsMenu.Sleep);
        Console.WriteLine(UIConfig.ActionsMenu.Inventory);
        Console.WriteLine(UIConfig.ActionsMenu.Exit);
    }
}