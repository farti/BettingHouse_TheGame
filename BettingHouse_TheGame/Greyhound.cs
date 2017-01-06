using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BettingHouse_TheGame
{
    public class Greyhound
    {
        public int StartingPosition; // miejsce gdzie rozpoczyna się PictureBox
        public int RacetrackLenght; // Jak długa jest trasa
        public PictureBox MyPictureBox = null ; // Mój obiekt PictureBox
        public int Location = 0; // moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy Random
        public bool Run()
        {
            // przesuń się do przodu losowo o 1,2,3 lub 4 punkty
            // zaktualizuj położenie PictureBox na formularzu
            // Zwróć true , jeśli wygrałem wyścig

            Point p = MyPictureBox.Location;  // pobieram aktualną pozycje obrazka
            int distance = MyRandom.Next(3) + 1; // generuję liczbę z zakresu 1-4 jako distance - przesunięcie 
            p.X += distance; // dodaję wartość distance, abyzmienić współrzędną X
            MyPictureBox.Location = p; // aktualizuję położenie PictureBox
            if (p.X == RacetrackLenght) return true;  // jeśli PictureBox dotrze do końca wygrywa
        }

    }
}
