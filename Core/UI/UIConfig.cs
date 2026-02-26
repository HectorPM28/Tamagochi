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
            public const string Cactus = "           *-*,\r\n       ,*\\/|`| \\\r\n       \\'  | |'| *,\r\n        \\ `| | |/ )\r\n         | |'| , /\r\n         |'| |, /\r\n       __|_|_|_|__\r\n      [___________]\r\n       |         |\r\n       |         |\r\n       |         |\r\n       |_________|";
            public const string Perro = "    ,    /-.\r\n   ((___/ __>\r\n   /      }\r\n   \\ .--.(    \r\n    \\\\   \\\\ ";
            public const string Pollo = "   \\\\\r\n   (o>\r\n\\\\_//)\r\n \\_/_)\r\n  _|_";
            public const string Robot = "    l    \r\n   ^^^   \r\n d[o_0]b \r\n   --- \r\n  /   \\ \r\n  \\===/ \r\n  [] [] \r\n";
            public const string SadCat = "      /\\_/\\      \r\n     ( ╥﹏╥ )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string AngryCat = "      /\\_/\\      \r\n     ( >:c )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string TiredCat = "      /\\_/\\      \r\n     ( -_- ) zzz     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
            public const string SickCat = "      /\\_/\\      \r\n     ( x_x )     \r\n     /       \\    \r\n    |         |   \r\n     \\__/\\___/    ";
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
            public const string Dog = "1 - Dog";
            public const string Cat = "2 - Cat";
            public const string Chicken = "3 - Chicken";
            public const string Robot = "4 - Robot";
            public const string Cactus = "5 - Cactus";
            public const string SetName = "What's the name of your pet?";
        }
    }
}
