using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingHouse_TheGame
{
    public class Bet            //  Instancję Bet tworzysz w kodzie klasy Guy. Użyj słowa this i wten sposób
                                // przekaże referencję do damej siebie do inicjalizowania obiektu Bet
    {
        public int Amount;  // ilosc postawionych pieniedzy
        public int Dog;  // Numer psa na którego postawiono
        public Guy Bettor; // Facet, który zawiera zakład

        public Bet (int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
             // zwraca string , który określa, kto obstawił wyści, jak dużo pieniędzy obstawił
             // i na którego psa ("Janek postawił 8 zł na psa numer 4").
             // jeżeli zero , zakład nie został zawarty ("Janek nie zawarł zakładu")
             if (Amount>0)
            {
                description = String.Format (Bettor + " postawił " + Amount + " zł na psa numer " + Dog);
            }
             else
            {
                description = String.Format (Bettor + " nie zawarł zakładu");
            }
            return description;
        }
        public int PayOut(int Winner)
        {
            // parametrem jest zwycięzca wyścigu. Jeżeli pies wygrał, zwróć wartość postawioną.
            // w przeciwnym razie odejmij wartość postawioną
            if (Dog==Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
