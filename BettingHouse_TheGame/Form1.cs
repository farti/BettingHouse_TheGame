using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingHouse_TheGame
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }
    private void SetupRaceTrack()
        {
            MinimumBet.Text = string.Format("Minimalny zakład: {0} zł", (int)BetAmount.Minimu,);

            int startingPosition = pictureBoxDog2.Right - SetupRaceTrack.Left;
            int raceTracklenght = raceTracklenght.Size.Width;

            guys[0] = new Guy("Janek",null,50, janekButton, janekBet );
            guys[1] = new Guy("Bartek",null,75, bartekButton, bartekBet );
            guys[2] = new Guy("Arek",null, 45, arekButton, arekBet );

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }

            dogs[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            dogs[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            while (Run()==false )
            {
                for (int i = 0; i < 4; i++)
                {

                }
            }
        }
    }
}
