using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahtzee
{
     class YahtzeeDice : Dice
    {
        public class Die                // Basically a struct but it's better
        {                               // to have holdStatus set to false,
            public int faceValue;       // so we used an internal class instead.
            public string imgURL;
            public bool holdStatus = false;
            //Copy Yahtzee to AppStart

        }

        Die[] gameDice = new Die[5];
        String[] imgUrls = { "Images/Dice1.png", "Images/Dice2.png", "Images/Dice3.png",
                             "Images/Dice4.png", "Images/Dice5.png", "Images/Dice6.png" };

        public new void RollDice(Random rnd)  // using new to explicitly hid parent RollDice
        {
            for (int i = 0; i < gameDice.Length; i++)
            {
                if (gameDice[i].holdStatus == false)
                {
                    gameDice[i].faceValue = rnd.Next(1, SidesOfDie + 1);
                    gameDice[i].imgURL = imgUrls[i];

                }
            }
        }

        // We probably won't need this
        public void RollOneDie(Random rnd, ref Die die)  //  Using pass by reference for die
        {
            die.faceValue = rnd.Next(1, SidesOfDie + 1);
        }

    }

}
