using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{

    class Cards
    {
        public string Suit { get; set; }
        public int Rankings { get; set; }
    }



    class Program
    {
        static void DisplayBlackJackGreeting()

        {
            Console.WriteLine("♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎");
            Console.WriteLine();
            Console.WriteLine(" Welcome! Try Your Hand at BlackJack ");
            Console.WriteLine();
            Console.WriteLine("♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎ ♠︎ ♣︎ ♥︎ ♦︎");
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            // recalling Black Jack greeting from method adding to top

            DisplayBlackJackGreeting();


            // Setting up deck of cards

            var suit = new List<string>() { "Hearts", "Diamonds", "Club", "Spade" };
            var rankings = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Setting up loop for deck of cards

            var cards = new List<string>();
            foreach (var suits in suit) { foreach (var rank in rankings)}
            { var newCard = new Cards};
            { suit = suit, rankings = rankings,};
        }






        // Shuffle the deck



        // Adding value to the deck


        // Responses to player based on card value

        var Player1 =

            switch (Player1)
            {
                case "Total21": Console.WriteLine("Awesome 21!"); break;
                case "TotalOver21": Console.WriteLine("BUSTED! Would you like to Play again? "); break;
                case "TotalLessThan21": Console.WriteLine("Would you like to HIT or STAY"); break;
            }

}
    }

    internal struct NewStruct
{
    public object Item1;
    public object Item2;

    public NewStruct(object item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
               System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Item1, Item2);
    }

    public void Deconstruct(out object item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (object, object)(NewStruct value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct((object, object) value)
    {
        return new NewStruct(value.Item1, value.Item2);
    }
}
}
