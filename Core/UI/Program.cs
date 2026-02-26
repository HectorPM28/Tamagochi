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
        int petSelector = 0;
        bool existingOpt;

        Console.WriteLine(UIConfig.RobotSprites.HappyRobot);
        Console.WriteLine(UIConfig.RobotSprites.SadRobot);
        Console.WriteLine(UIConfig.RobotSprites.AngryRobot);
        Console.WriteLine(UIConfig.RobotSprites.TiredRobot);
        Console.WriteLine(UIConfig.RobotSprites.SickRobot);

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
        } while (!existingOpt);

        Console.WriteLine(UIConfig.ChoosePet.SetName);
        petName = Console.ReadLine();

        if(petName == null)
        {
            petName = "SinNombre";
        }

        petName = petName.Substring(0, 1).ToUpper() + petName.Substring(1).ToLower();

        switch (petSelector)
        {
            case 1:
                Dog playerDog = new Dog(petName);
                ShowGameBase(playerDog);
                break;
            case 2:
                Cat playerCat = new Cat(petName);
                break;
            case 3:
                Chicken playerChicken = new Chicken(petName);
                break;
            case 4:
                Robot playerRobot = new Robot(petName);
                break;
            case 5:
                Cactus playerCactus = new Cactus(petName);
                break;
        }
    }
    public static void ShowGameBase(APet pet)
    {
        Console.WriteLine(UIConfig.TamagochiBase.SquareBase);
        Console.WriteLine(UIConfig.TamagochiBase.petInfo, pet.Name, pet.State);
        Console.WriteLine(UIConfig.TamagochiBase.petBirth, pet.DateBirth);
        Console.WriteLine(UIConfig.TamagochiBase.SquareBase);
    }
}