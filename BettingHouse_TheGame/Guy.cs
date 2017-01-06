using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingHouse_TheGame
{
    public class Guy
    {
        public string Name; // nazwa faceta
        public Bet MyBet; // instancja klasy Bet przechowujaca dane o zakładzie
        public int Cash; // ile kasiory ma facet

        // Ostatnie dwa pola są kontrolkami GUI na formularzu
        public RadioButton MyRadioButton;  // moje pole wyboru
        public Label MyLabel;   // Moja etykieta

        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        public void UpdateLabels()
        {
           
            // ustwa moje pole tekstowe na opis zakładu, a napis obok pola wyboru tak,
            // aby pokazywał ilość pieniędzy ("Janek ma 43 zł")
            if (MyBet == null)
            {
                MyLabel.Text = String.Format("{0} nie ma pieniędzy na zakład", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " ma " + Cash + " złotych";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            // wyczyść mój zakład, aby był równy zero
        }

        public bool PlaceBet(int Amount, int Dog)        // pamiętaj, ze zakłady sa reprezentowane przez instancje klasy 
        {
            // ustal nowy zaklad i przechowaj go w polu MyBet
            // zwroc true, jeżeli facet ma wystarczającą ilość pieniędzy aby obstawić
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)         // Poproś o wypłatę zakładu
        {
            Cash += MyBet.PayOut(Winner);  // kluczem do rozwiązania jest użycie obiektu Bet , pozwól mu wykonywac swoją pracę
        }
    }
}
