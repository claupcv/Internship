using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    enum Cards { Spades = 1, Clubs = 2, Diamonds = 4, Hearts = 8 }
    [Flags]
    enum CardsFlags { Spades = 1, Clubs = 2, Diamonds = 4, Hearts = 8 }
    class EnumFlags
    {
        public static void RunEnumAndEnumFlags()
        {
            Cards card = Cards.Spades | Cards.Diamonds;
            CardsFlags cardFlag = CardsFlags.Spades | CardsFlags.Diamonds;
            Console.WriteLine(card);
            Console.WriteLine(cardFlag);

            var str1 = (Cards.Spades | Cards.Diamonds).ToString();
            var str2 = (CardsFlags.Spades | CardsFlags.Diamonds).ToString();

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

    }
}
