using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{    
    enum Suits { heart, club, diamond, spade };
    internal class Card
    {
        public int value { get; set; }
        public Suits suit { get; set; }
        public string image { get; set; }

        public Card()
        {
            Random r = new Random();
            value = r.Next(13)+1;
            Array values = Enum.GetValues(typeof(Suits));
            suit = (Suits)values.GetValue(r.Next(4));

            image = "C:\\Users\\michaelg\\Desktop\\C Sharp\\Blackjack\\Blackjack\\Cards\\128\\" + suit + "-" + value + "-128.png";
            Debug.WriteLine(image);
        }

    }
}
