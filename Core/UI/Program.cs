using System;
using Tamagochi.Core.Models;
using Tamagochi.Core.Models.Abstracts;
using Tamagochi.Core.UI;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        const int minMenuValue = 1, maxMenuValue = 5, minPetOptValue = 1, maxPetOptValue = 5;

        string petName;
        int petSelector = 0, op = 0;
        bool existingOpt;


        //Delete this pet when finished testing
        Cat gato = new Cat("XD");
        
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
        
        do
        {
            UIConfig.ShowGameBase(gato);
            ShowPet(gato);
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
                    break;
                case 4:
                    break;
                case 5:
                    gato.DeadState = true;
                    break;
            }
            

        } while (!gato.DeadState);
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