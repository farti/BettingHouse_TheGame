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
        public int dog;  // numer psa od 1 do 4
        public int StartingPosition; // miejsce gdzie rozpoczyna się PictureBox
        public int RacetrackLenght ; // Jak długa jest trasa
        public PictureBox MyPictureBox = null ; // Mój obiekt PictureBox
        public int Location = 0; // moje położenie na torze wyścigowym
        public Random MyRandom; // Instancja klasy Random
        public bool Run()
        {
            // przesuń się do przodu losowo o 1,2,3 lub 4 punkty
            // zaktualizuj położenie PictureBox na formularzu
            // Zwróć true , jeśli wygrałem wyścig
            MyRandom = new Random();
            int distance = MyRandom.Next(3) + 1; // generuję liczbę z zakresu 1-4 jako distance - przesunięcie 

            MoveMyPictureBox(distance);

            Location += distance;

            if (Location >= (RacetrackLenght - StartingPosition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void TakeStartingPositin()
        {
            MoveMyPictureBox(-Location);
            Location=0; //  resetuję położenie psa
        }

        public void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;  // pobieram aktualną pozycje obrazka
            p.X += distance; // dodaję wartość distance, abyzmienić współrzędną X
            MyPictureBox.Location = p; // aktualizuję położenie PictureBox
        }

    }
}
