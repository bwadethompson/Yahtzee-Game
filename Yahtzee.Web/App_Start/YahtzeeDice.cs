using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Web
{
     class YahtzeeDice : Dice
    {

        public class Die                // Basically a struct but it's better
        {                               // to have holdStatus set to false,
            public int faceValue;       // so we used an internal class instead.
            public string imgURL;
            public bool holdStatus = false;
            public long timeStamp;


        }


        public Die[] DiceArray = new Die[5];
        public String[] imgUrls = { "Images/Dice 1.png", "Images/Dice 2.png",
                                    "Images/Dice 3.png", "Images/Dice 4.png",
                                    "Images/Dice 5.png", "Images/Dice 6.png" };
        
        /***************** CONSTRUCTORS *******************/

        public YahtzeeDice() //Roll the creation
        {
            DateTime dt = DateTime.Now;
            long tStamp = long.Parse(dt.ToString("yyyyMMddHHmmss"));// Unlike stucts, classes need

            for (int i = 0; i < DiceArray.Length; i++)  // need to be initialized, so...
            {                                        // need to be initialized, so...
                DiceArray[i] = new Die();
                DiceArray[i].timeStamp = tStamp;
            }
            //RollDice(new Random()); It was rolling twice

        }

        /***************** METHODS ************************/
        
        public new void RollDice(Random rnd)  // using new to explicitly hid parent RollDice
        {
            int fVal, imgIdx;
            System.Diagnostics.Debug.WriteLine("\n================================\n");

            for (int i = 0; i < DiceArray.Length; i++)
            {
                if (DiceArray[i].holdStatus == false)
                {
                    fVal = rnd.Next(1, SidesOfDie + 1);
                    imgIdx = fVal - 1;
                    DiceArray[i].faceValue = fVal;
                    DiceArray[i].imgURL = imgUrls[imgIdx];

                    System.Diagnostics.Debug.WriteLine("ROLLING: " + i);
                }
                else
                    System.Diagnostics.Debug.WriteLine("\tSKIPPING: " + i);
                    // set the image for held dice

                    //imgIdx = gameDice[i].faceValue - 1;
                    //gameDice[i].imgURL = imgUrls[imgIdx];
            }
            System.Diagnostics.Debug.WriteLine("\n================================\n");

        }


        // We probably won't need this
        public void RollOneDie(Random rnd, ref Die die)  //  Using pass by reference for die
        {
            die.faceValue = rnd.Next(1, SidesOfDie + 1);
        }


    }//End Class

}
