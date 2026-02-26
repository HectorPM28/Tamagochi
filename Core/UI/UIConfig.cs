using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi.Core.Models;

namespace Tamagochi.Core.UI
{
    public static class UIConfig
    {
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
        public static class RobotSprites
        {
            public const string HappyRobot = "    l    \r\n   ^^^   \r\n d[^_^]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
            public const string SadRobot = "    l    \r\n   ^^^   \r\n d[╥_╥]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
            public const string AngryRobot = "    l    \r\n   ^^^   \r\n d[@_@]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
            public const string TiredRobot = "    l    \r\n   ^^^   \r\n d[-_-]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
            public const string SickRobot = "    l    \r\n   ^^^   \r\n d[X_X]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
        }
        public static class DogSprites
        {
            public const string HappyDog = "           __\r\n      (___()^`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string SadDog = "           __\r\n      (___()╥`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string AngryDog = "           __\r\n      (___()@`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string TiredDog = "           __\r\n      (___()-`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
            public const string SickDog = "           __\r\n      (___()X`;\r\n      /,    /`\r\n      \\\\\"--\\\\";
        }
        public static class CactusSprite
        {
            //No emotions
            public const string Cactus = "           *-*,\r\n       ,*\\/|`| \\\r\n       \\'  | |'| *,\r\n        \\ `| | |/ )\r\n         | |'| , /\r\n         |'| |, /\r\n       __|_|_|_|__\r\n      [___________]\r\n        |       |\r\n        |_______|";
        }
        public static class PetActions
        {
            public const string DressUp = "{0} dresses up with the {1}, looking fabulous";
            public const string Eat = "{0} eats the {1}";
            public const string Play = "{0} plays with the {1}";
            public const string Sleep = "{0} sleeps peacfully";
        }
        public static class ChoosePet
        {
            public const string Selection = "Select your pet";
            public const string Dog = "1 - Dog";
            public const string Cat = "2 - Cat";
            public const string Chicken = "3 - Chicken";
            public const string Robot = "4 - Robot";
            public const string Cactus = "5 - Cactus";
            public const string SetName = "What's the name of your pet?";
        }
        public static class IntErrorControl
        {
            public const string FormatError = "Must insert a number";
            public const string OverflowException = "Must insert a tinier number";            
        }
        public static class TamagochiBase
        {
            public const string Spacer     = "----------------------------------";
            public const string SquareBase = "==================================";
            public const string petInfo    = "    Name: {0} Status: {1}";
            public const string petBirth   = "=    Birth: {0}   ="; 
        }
    }
}
