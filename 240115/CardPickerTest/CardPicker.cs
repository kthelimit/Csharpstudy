using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPickerTest
{
    internal class CardPicker
    {
        static Random random = new Random();
        public string[] PickSomeCards(int numberofCards)
        {
            string[] pickedCards = new string[numberofCards];
            for (int i = 0; i < numberofCards; i++)
            {
                pickedCards[i] = RandomSuit() + RandomValue();
            }
            return pickedCards;
        }

        private string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "♠";
            if (value == 2) return "♥";
            if (value == 3) return "♣";
            return "◆";

        }

        private string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "A";
            if (value == 11) return "J";
            if (value == 12) return "Q";
            if (value == 13) return "K";
            return value.ToString();
        }
    }
}
