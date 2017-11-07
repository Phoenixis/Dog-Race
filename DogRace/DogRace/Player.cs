using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    class Player
    {
        public string Name { get; set; }

        public double Bet { get; set; }

        public Double Money { get; set; }

        public int Dog { get; set; }

        public Boolean HasBet { get; set; }

        public string printmessage()
        {
            string Message = Name + " has bet $" + Bet + " on Dog no."+ Dog;
            return Message;
        }

        public string printBalance()
        {
            string Message = Name + " has $" + Money;
            return Message;
        }

        public string Busted()
        {
            string Message = Name + " has Busted and is left with $" + Money;
            return Message;
        }

        public double Win()
        { 
            Money = Money + 2 * Bet;
            return Money;
        }

        public double Lose()
        {
            //Money = Money - Bet; //Not needed.
            return Money;
        }

    }
}
