using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingHouse_TheGame
{
    class Guy
    {
        public string Name; // nazwa faceta
        public Bet MyBet; // instancja klasy Bet przechowujaca dane o zakładzie
        public int Cash; // ile kasiory ma facet

        // Ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton;  // moje pole wyboru
        public Label MyLabel;   // Moja etykieta

        public void UpdateLabels()
        {
            // UZUPEŁNIJ
            // ustwa moje pole tekstowe na opis zakładu, a napis obok pola wyboru tak,
            // aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
        }

        public void ClearBet()
        {
            // UZUPEŁNIJ
            // wyczyść mój zakład, aby był równy zero
        }

        public bool PlaceBet(int Amount, int Dog)        // pamiętaj, ze zakłady sa reprezentowane przez instancje klasy 
        {
            // UZUPELNIJ
            // ustal nowy zaklad i przechowaj go w polu MyBet
            // zwroc true, jeżeli facet ma wystarczającą ilość pieniędzy aby obstawić
            if (Cash > Amount) return true;
        }

        public void Collect(int Winner)         // Poproś o wypłatę zakładu
        {
            // UZUPELNIJ
            // kluczem do rozwiązania jest użycie obiektu Bet , pozwól mu wykonywac swoją pracę
        }
    }
}
