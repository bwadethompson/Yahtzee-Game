using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace Yahtzee.Web
{
    public partial class About : Page
    {

        YahtzeeDice ytzDice = new YahtzeeDice(); //Dice object for yatClass
        Dice TestDice = new Dice(); // using to try to pass int values to diceclass




        #region ViewStateProperties

        protected int RollCount
        {
            get
            {
                return int.Parse(ViewState["RollCount"].ToString());
            }
            set
            {
                ViewState["RollCount"] = value;
            }
        }
        protected int RoundCount
        {
            get
            {
                return int.Parse(ViewState["RoundCount"].ToString());
            }
            set
            {
                ViewState["RoundCount"] = value;
            }
        }


        protected int aces
        {
            get
            {
                return int.Parse(ViewState["aces"].ToString());
            }
            set
            {
                ViewState["aces"] = value;
            }
        }


        protected int twos
        {
            get
            {
                return int.Parse(ViewState["twos"].ToString());
            }
            set
            {
                ViewState["twos"] = value;
            }
        }


        protected int threes
        {
            get
            {
                return int.Parse(ViewState["threes"].ToString());
            }
            set
            {
                ViewState["threes"] = value;
            }
        }


        protected int fours
        {
            get
            {
                return int.Parse(ViewState["fours"].ToString());
            }
            set
            {
                ViewState["fours"] = value;
            }
        }


        protected int fives
        {
            get
            {
                return int.Parse(ViewState["fives"].ToString());
            }
            set
            {
                ViewState["fives"] = value;
            }
        }


        protected int sixs
        {
            get
            {
                return int.Parse(ViewState["sixs"].ToString());
            }
            set
            {
                ViewState["sixs"] = value;
            }
        }

        protected int ThreeofKind
        {
            get
            {
                return int.Parse(ViewState["ThreeofKind"].ToString());
            }
            set
            {
                ViewState["ThreeofKind"] = value;
            }
        }
       
        protected int FourofKind
        {
            get
            {
                return int.Parse(ViewState["FourofKind"].ToString());
            }
            set
            {
                ViewState["FourofKind"] = value;
            }
        }


        protected int FullHouse
        {
            get
            {
                return int.Parse(ViewState["FullHouse"].ToString());
            }
            set
            {
                ViewState["FullHouse"] = value;
            }
        }

        protected int SmallStraight
        {
            get
            {
                return int.Parse(ViewState["SmallStraight"].ToString());
            }
            set
            {
                ViewState["SmallStraight"] = value;
            }
        }

        protected int LargeStraight
        {
            get
            {
                return int.Parse(ViewState["LargeStraight"].ToString());
            }
            set
            {
                ViewState["LargeStraight"] = value;
            }
        }
        protected int Yahtzee
        {
            get
            {
                return int.Parse(ViewState["Yahtzee"].ToString());
            }
            set
            {
                ViewState["Yahtzee"] = value;
            }
        }
        protected int Chance
        {
            get
            {
                return int.Parse(ViewState["Chance"].ToString());
            }
            set
            {
                ViewState["Chance"] = value;
            }
        }
        protected int UpperBonus
        {
            get
            {
                return int.Parse(ViewState["UpperBonus"].ToString());
            }
            set
            {
                ViewState["UpperBonus"] = value;
            }
        }
        protected int YahtzeeBonus
        {
            get
            {
                return int.Parse(ViewState["YahtzeeBonus"].ToString());
            }
            set
            {
                ViewState["YahtzeeBonus"] = value;
            }
        }
        protected int TotalScore
        {
            get
            {
                return int.Parse(ViewState["TotalScore"].ToString());
            }
            set
            {
                ViewState["TotalScore"] = value;
            }
        }

        protected bool acesSaved
        {
            get { return (bool)ViewState["acesSaved"]; }
            set { ViewState["acesSaved"] = value; }
        }
        protected bool twosSaved
        {
            get { return (bool)ViewState["twosSaved"]; }
            set { ViewState["twosSaved"] = value; }
        }
        protected bool threesSaved
        {
            get { return (bool)ViewState["threesSaved"]; }
            set { ViewState["threesSaved"] = value; }
        }
        protected bool foursSaved
        {
            get { return (bool)ViewState["foursSaved"]; }
            set { ViewState["foursSaved"] = value; }
        }
        protected bool fivesSaved
        {
            get { return (bool)ViewState["fivesSaved"]; }
            set { ViewState["fivesSaved"] = value; }
        }
        protected bool sixesSaved
        {
            get { return (bool)ViewState["sixesSaved"]; }
            set { ViewState["sixesSaved"] = value; }
        }
        protected bool fullHouseSaved
        {
            get { return (bool)ViewState["fullHouseSaved"]; }
            set { ViewState["fullHouseSaved"] = value; }
        }
        protected bool smallStraightSaved
        {
            get { return (bool)ViewState["smallStraightSaved"]; }
            set { ViewState["smallStraightSaved"] = value; }
        }
        protected bool largeStraightSaved
        {
            get { return (bool)ViewState["largeStraightSaved"]; }
            set { ViewState["largeStraightSaved"] = value; }
        }
        protected bool threeOfaKindSaved
        {
            get { return (bool)ViewState["threeOfaKindSaved"]; }// == null ? false : (bool)ViewState["bool"]; }
            set { ViewState["threeOfaKindSaved"] = value; }
        }
        protected bool fourOfAKindSaved
        {
            get { return (bool)ViewState["fourOfAKindSaved"]; }
            set { ViewState["fourOfAKindSaved"] = value; }
        }
        protected bool YahtzeeSaved
        {
            get { return (bool)ViewState["YahtzeeSaved"]; }
            set { ViewState["YahtzeeSaved"] = value; }
        }
        protected bool ChanceSaved
        {
            get { return (bool)ViewState["ChanceSaved"]; }
            set { ViewState["ChanceSaved"] = value; }
        }



        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetupNewGame();

            }

           btnAces.OnClientClick = "return ckZero('" + acesScoreValue.ClientID + "')";
           btnTwos.OnClientClick = "return ckZero('" + twosScoreValue.ClientID + "')";
           btnThrees.OnClientClick = "return ckZero('" + threesScoreValue.ClientID + "')";
        }



        protected void SetupImages()
        {
            imgDie1.ImageUrl = "Images\\Dice 1.png";
            imgDie2.ImageUrl = "Images\\Dice 2.png";
            imgDie3.ImageUrl = "Images\\Dice 3.png";
            imgDie4.ImageUrl = "Images\\Dice 4.png";
            imgDie5.ImageUrl = "Images\\Dice 5.png";
        }


        protected void SetupNewGame()
        {
            ClearSaveCheckboxes();
            SetupImages();
            //SetDieImageSrc();
            RollCount = 0;
            RoundCount = 1;
            RollNumber.InnerText = RollCount.ToString();
            RoundNumber.InnerText = RoundCount.ToString();
            btnRoll.Enabled = true;
            btnYahtzeeBonus.Visible = false;
            aces = 0;
            twos = 0;
            threes = 0;
            fours = 0;
            fives = 0;
            sixs = 0;
            FullHouse = 0;
            ThreeofKind = 0;
            FourofKind = 0;
            Yahtzee = 0;
            SmallStraight = 0;
            LargeStraight = 0;
            Chance = 0;
            UpperBonus = 0;
            YahtzeeBonus = 0;
            TotalScore = 0;
            acesSaved = false;
            twosSaved = false;
            threesSaved = false;
            foursSaved = false;
            fivesSaved = false;
            sixesSaved = false;
            fullHouseSaved = false;
            threeOfaKindSaved = false;
            fourOfAKindSaved = false;
            smallStraightSaved = false;
            largeStraightSaved = false;
            YahtzeeSaved = false;
            ChanceSaved = false;

            ClearScoreCard();


        }


        protected void ClearSaveCheckboxes()
        {
            //using this to be called when needed 
            //to clear saved checkboxes between turns and new games
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;

        }
        protected void ClearScoreCard()
        {   //used for clearing between games

            //upper section
            acesScoreValue.Text = "";
            twosScoreValue.Text = "";
            threesScoreValue.Text = "";
            foursScoreValue.Text = "";
            fivesScoreValue.Text = "";
            sixesScoreValue.Text = "";

            //lower section
            fullHouseScoreValue.Text = "";
            ThreeofKindScoreValue.Text = "";
            FourofKindScoreValue.Text = "";
            smallStraightScoreValue.Text = "";
            largeStraightScoreValue.Text = "";
            YahtzeeScoreValue.Text = "";
            yahtzeeBonusScoreValue.Text = "";
            chanceScoreValue.Text = "";


        }

        private void showPotentialUpperScore()
        {
            //needed to change the text of the score if greater than 0
            int aceTotal = 0;
            int twoTotal = 0;
            int threeTotal = 0;
            int fourTotal = 0;
            int fiveTotal = 0;
            int sixTotal = 0;

            //clear old potential scores
            ClearScoreCard();

            for (int idx = 0; idx < 5; idx++)
            {
                //save the increments of the dice roll
                if (ytzDice.DiceArray[idx].faceValue == 1) { aceTotal += 1; }
                if (ytzDice.DiceArray[idx].faceValue == 2) { twoTotal += 2; }
                if (ytzDice.DiceArray[idx].faceValue == 3) { threeTotal += 3; }
                if (ytzDice.DiceArray[idx].faceValue == 4) { fourTotal += 4; }
                if (ytzDice.DiceArray[idx].faceValue == 5) { fiveTotal += 5; }
                if (ytzDice.DiceArray[idx].faceValue == 6) { sixTotal += 6; }
            }

            //needs to have a value greater then 0 to not show null  on the score value

            if (aceTotal >= 0 && acesSaved == false) { acesScoreValue.Text = aceTotal.ToString(); acesScoreValue.ForeColor = Color.Red; }
            if (twoTotal >= 0 && twosSaved == false) { twosScoreValue.Text = twoTotal.ToString(); twosScoreValue.ForeColor = Color.Red; }
            if (threeTotal >= 0 && threesSaved == false) { threesScoreValue.Text = threeTotal.ToString(); threesScoreValue.ForeColor = Color.Red; }
            if (fourTotal >= 0 && foursSaved == false) { foursScoreValue.Text = fourTotal.ToString(); foursScoreValue.ForeColor = Color.Red; }
            if (fiveTotal >= 0 && fivesSaved == false) { fivesScoreValue.Text = fiveTotal.ToString(); fivesScoreValue.ForeColor = Color.Red; }
            if (sixTotal >= 0 && sixesSaved == false) { sixesScoreValue.Text = sixTotal.ToString(); sixesScoreValue.ForeColor = Color.Red; }

        }

        protected void showPotentialLowerScore()
        {
            const int FULL_HOUSE = 25;
            const int SMALL_STRAIGHT = 30;
            const int LARGE_STRAIGHT = 40;
            const int YAHTZEE = 50;
            int fieldValue = 0;


            for (int i = 0; i < ytzDice.DiceArray.Length; i++)
            {
                TestDice.gameDice[i] = ytzDice.DiceArray[i].faceValue;

            }


            fieldValue = ytzDice.CalcFullHouse(TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if (fullHouseSaved == false)
            {
                fullHouseScoreValue.Text = FullHouse.ToString();
                fullHouseScoreValue.ForeColor = Color.Red;
                if (fieldValue > 0)
                {
                    fullHouseScoreValue.Text = FULL_HOUSE.ToString();
                    fullHouseScoreValue.ForeColor = Color.Red;
                }
            }
            
            //small striaght check
            fieldValue = ytzDice.CalcStraight(false, TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if(smallStraightSaved == false)
            {
                smallStraightScoreValue.Text = SmallStraight.ToString();
                smallStraightScoreValue.ForeColor = Color.Red;

                if (fieldValue > 0)
                {
                    smallStraightScoreValue.Text = SMALL_STRAIGHT.ToString();
                    smallStraightScoreValue.ForeColor = Color.Red;

                }
            }
          

            fieldValue = ytzDice.CalcStraight(true, TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if(largeStraightSaved == false)
            {
                largeStraightScoreValue.Text = LargeStraight.ToString();
                largeStraightScoreValue.ForeColor = Color.Red;

                if (fieldValue > 0)
                {
                    largeStraightScoreValue.Text = LARGE_STRAIGHT.ToString();
                    largeStraightScoreValue.ForeColor = Color.Red;
                }

            }

            fieldValue = ytzDice.CalcXOfAKind(3, TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if(threeOfaKindSaved == false)
            {
                ThreeofKindScoreValue.Text = ThreeofKind.ToString();
                ThreeofKindScoreValue.ForeColor = Color.Red;
                if (fieldValue > 0)
                {
                    ThreeofKindScoreValue.Text = fieldValue.ToString();
                    ThreeofKindScoreValue.ForeColor = Color.Red;
                }
            }

            fieldValue = ytzDice.CalcXOfAKind(4, TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if(fourOfAKindSaved == false)
            {
                FourofKindScoreValue.Text = FourofKind.ToString();
                FourofKindScoreValue.ForeColor = Color.Red;

                if (fieldValue > 0)
                {
                    FourofKindScoreValue.Text = fieldValue.ToString();
                    FourofKindScoreValue.ForeColor = Color.Red;
                }
            }

            fieldValue = ytzDice.CalcXOfAKind(5, TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
            if(YahtzeeSaved == false)
            {
                YahtzeeScoreValue.Text = Yahtzee.ToString();
                YahtzeeScoreValue.ForeColor = Color.Red;
                if (fieldValue > 0)
                {
                    YahtzeeScoreValue.Text = YAHTZEE.ToString();
                    YahtzeeScoreValue.ForeColor = Color.Red;
                }

            }


            fieldValue = ytzDice.CalcChance(TestDice.gameDice);
            System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
          if(ChanceSaved == false)
            {
                chanceScoreValue.Text = Chance.ToString();
                chanceScoreValue.ForeColor = Color.Red;
                if (fieldValue > 0)
                {
                    chanceScoreValue.Text = fieldValue.ToString();
                    chanceScoreValue.ForeColor = Color.Red;
                }
            }



        }


        protected void buttonRestartGame_Click(object sender, EventArgs e)
        {
            SetupNewGame();
        }



        protected void HoldDice()
        {
            int fv1 = Convert.ToInt32(Request.Form["fv1"]);
            int fv2 = Convert.ToInt32(Request.Form["fv2"]);
            int fv3 = Convert.ToInt32(Request.Form["fv3"]);
            int fv4 = Convert.ToInt32(Request.Form["fv4"]);
            int fv5 = Convert.ToInt32(Request.Form["fv5"]);

            if (chk1.Checked == true)
            {
                ytzDice.DiceArray[0].holdStatus = true;
                ytzDice.DiceArray[0].faceValue = fv1;
                ytzDice.DiceArray[0].imgURL = ytzDice.imgUrls[fv1 - 1];


            }
            if (chk2.Checked == true)
            {
                ytzDice.DiceArray[1].holdStatus = true;
                ytzDice.DiceArray[1].faceValue = fv2;
                ytzDice.DiceArray[1].imgURL = ytzDice.imgUrls[fv2 - 1];
            }
            if (chk3.Checked == true)
            {
                ytzDice.DiceArray[2].holdStatus = true;
                ytzDice.DiceArray[2].faceValue = fv3;
                ytzDice.DiceArray[2].imgURL = ytzDice.imgUrls[fv3 - 1];
            }
            if (chk4.Checked == true)
            {
                ytzDice.DiceArray[3].holdStatus = true;
                ytzDice.DiceArray[3].faceValue = fv4;
                ytzDice.DiceArray[3].imgURL = ytzDice.imgUrls[fv4 - 1];
            }

            if (chk5.Checked == true)
            {
                ytzDice.DiceArray[4].holdStatus = true;
                ytzDice.DiceArray[4].faceValue = fv5;
                ytzDice.DiceArray[4].imgURL = ytzDice.imgUrls[fv5 - 1];
            }

            System.Diagnostics.Debug.WriteLine("\n===========================\n");
            System.Diagnostics.Debug.WriteLine("HOLD STATUS:");
            System.Diagnostics.Debug.WriteLine(ytzDice.DiceArray[0].holdStatus.ToString() + "\n" +
                                                ytzDice.DiceArray[1].holdStatus.ToString() + "\n" +
                                                ytzDice.DiceArray[2].holdStatus.ToString() + "\n" +
                                                ytzDice.DiceArray[3].holdStatus.ToString() + "\n" +
                                                ytzDice.DiceArray[4].holdStatus.ToString() + "\n"
                                               );
            System.Diagnostics.Debug.WriteLine("\n===========================\n");


        }
        protected void SetDieImageSrc()     // Sets the image src url on page
        {
            imgDie1.ImageUrl = ytzDice.DiceArray[0].imgURL;
            imgDie2.ImageUrl = ytzDice.DiceArray[1].imgURL;
            imgDie3.ImageUrl = ytzDice.DiceArray[2].imgURL;
            imgDie4.ImageUrl = ytzDice.DiceArray[3].imgURL;
            imgDie5.ImageUrl = ytzDice.DiceArray[4].imgURL;
            System.Diagnostics.Debug.WriteLine("\n===========================\n");
            System.Diagnostics.Debug.WriteLine("DIE IMG URL:");
            System.Diagnostics.Debug.WriteLine("die 0: Value: " + ytzDice.DiceArray[0].faceValue + " IMG: " + ytzDice.DiceArray[0].imgURL + "\n" +
                                                "die 1: Value: " + ytzDice.DiceArray[1].faceValue + " IMG: " + ytzDice.DiceArray[1].imgURL + "\n" +
                                                "die 2: Value: " + ytzDice.DiceArray[2].faceValue + " IMG: " + ytzDice.DiceArray[2].imgURL + "\n" +
                                                "die 3: Value: " + ytzDice.DiceArray[3].faceValue + " IMG: " + ytzDice.DiceArray[3].imgURL + "\n" +
                                                "die 4: Value: " + ytzDice.DiceArray[4].faceValue + " IMG: " + ytzDice.DiceArray[4].imgURL + "\n"
                                               );
            System.Diagnostics.Debug.WriteLine("\n===========================\n");

        }
        public String GetFieldFaceValue(int idx)
        {
            return ytzDice.DiceArray[idx].faceValue.ToString();
        }



        protected void btnRoll_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int RollCheck = RollCount;
            switch (RollCheck)
            {

                case 0:
                    ytzDice.RollDice(rnd);
                    SetDieImageSrc(); //For the imd src url on page
                    showPotentialUpperScore();
                    showPotentialLowerScore();
                    LoadCurrentScores();
                    RollCount = RollCount + 1;
                    RollNumber.InnerText = RollCount.ToString();
                    break;

                case 1:
                    HoldDice();
                    ytzDice.RollDice(rnd);
                    SetDieImageSrc(); //For the imd src url on page
                    showPotentialUpperScore();
                    showPotentialLowerScore();
                    YahtzeeBonuses();
                    LoadCurrentScores();
                    RollCount = RollCount + 1;
                    RollNumber.InnerText = RollCount.ToString();
                    
                    break;
                case 2:
                  
                    if(RoundCount == 13)
                    {
                        // Stop game functions and give final score
                        btnRoll.Enabled = false;
                        btnRoll.Visible = false;
                        RollText.Text = "The Game has ended";
                    }
                    else
                    {
                        HoldDice();
                        ytzDice.RollDice(rnd);
                        SetDieImageSrc(); //For the imd src url on page
                        showPotentialUpperScore();
                        showPotentialLowerScore();
                        YahtzeeBonuses();
                        LoadCurrentScores();
                        RollCount = RollCount + 1;
                        RollNumber.InnerText = RollCount.ToString();                
                        CheckBoxesDisable();
                        ClearSaveCheckboxes();
                        RollNumber.InnerText = RollCount.ToString();
                        RoundNumber.InnerText = RoundCount.ToString();
                        ResetBoxes();
                      

                    }
                    break;
                case 3:
                    


                    break;

                default:
                    Console.WriteLine("We gotta problem here");
                    break;
            }
       
              
        }
        protected void ResetBoxes()
        {

            btnRoll.Enabled = false;
            btnRoll.Visible = false;
            RollText.Text = "You are out of rolls for this round. Please make a save selection";
            RollText.ForeColor = Color.Red;
            RollText.Font.Size = 18;
            CheckBoxesDisable();
            
        }
            
            protected void CheckBoxesEnable()
            {
                chk1.Enabled = true;
                chk2.Enabled = true;
                chk3.Enabled = true;
                chk4.Enabled = true;
                chk5.Enabled = true;
                chk1.Visible = true;
                chk2.Visible = true;
                chk3.Visible = true;
                chk4.Visible = true;
                chk5.Visible = true;
            }
        //Method that hide the checkboxes

           protected void CheckBoxesDisable()
        {
            chk1.Enabled = false;
            chk2.Enabled = false;
            chk3.Enabled = false;
            chk4.Enabled = false;
            chk5.Enabled = false;
            chk1.Visible = false;
            chk2.Visible = false;
            chk3.Visible = false;
            chk4.Visible = false;
            chk5.Visible = false;
        }

        


        protected void OnClickSave()
        {
           
            
          
                RoundCount++;
                RoundNumber.InnerText = RoundCount.ToString();
                RollCount = 0;
                RollNumber.InnerText = RollCount.ToString();
                btnRoll.Enabled = true;
                btnRoll.Visible = true;
                RollText.Text = "";
                ClearSaveCheckboxes();                
                CheckBoxesEnable(); //unhide the checkboxes
                ClearScoreCard();
                showPotentialUpperScore();
                showPotentialLowerScore();
                LoadCurrentScores();
            

        }
        protected void UpperBonusCalc()
        {
            if (aces + twos + threes + fours + fives + sixs > 63)
            {
                UpperBonus = 35;
            }

        }

        protected void YahtzeeBonuses()
        {
            //if you did not already save the bonus then continue on with the loop otherwise it is locked out for the rest of the game
            if (btnYahtzeeBonus.Enabled == true)
            {
                int fieldValue = 0;
                fieldValue = ytzDice.CalcXOfAKind(5, TestDice.gameDice);
                System.Diagnostics.Debug.WriteLine(fieldValue.ToString());
                if (Yahtzee > 0 && fieldValue > 0)
                {
                    btnYahtzeeBonus.Visible = true;
                    YahtzeeBonus += 100;

                    yahtzeeBonusScoreValue.Text = YahtzeeBonus.ToString();
                    yahtzeeBonusScoreValue.ForeColor = Color.Red;

                }
            }
        }
       
        protected void BonusOnClickSave()
        {
            ////makes sure to fill an empty slot if you get a yahtzee bonus
            YahtzeeBonus = int.Parse(yahtzeeBonusScoreValue.Text);
            int tracker = ytzDice.DiceArray[0].faceValue;

            if (tracker == 1 && aces == 0)
            {
                aces = int.Parse(acesScoreValue.Text);
                OnClickSave();
            }
            else if (tracker == 2 && twos == 0)
            {
                twos = int.Parse(twosScoreValue.Text);
                OnClickSave();
            }
            else if (tracker == 3 && threes == 0)
            {
                threes = int.Parse(threesScoreValue.Text);
                OnClickSave();
            }
            else if (tracker == 4 && fours == 0)
            {
                fours = int.Parse(foursScoreValue.Text);
                OnClickSave();
            }
            else if (tracker == 5 && fives == 0)
            {
                fives = int.Parse(fivesScoreValue.Text);
                OnClickSave();
            }
            else if (tracker == 6 && sixs == 0)
            {
                sixs = int.Parse(sixesScoreValue.Text);
                OnClickSave();
            }
        }

   


        protected void TotalScoreCalc()
        {
            TotalScore = aces +
                            twos +
                            threes +
                            fours +
                            fives +
                            sixs +
                            ThreeofKind +
                            FourofKind +
                            FullHouse +
                            SmallStraight +
                            LargeStraight +
                            YahtzeeBonus +
                            Chance +
                            UpperBonus +
                            Yahtzee;

            totalScore.Text = TotalScore.ToString();
        }
        #region LoadScores
        protected void LoadCurrentScores()
        {
            if (acesSaved == true)
            {
                
                    acesScoreValue.Text = aces.ToString();
                    acesScoreValue.ForeColor = Color.Black;
                    btnAces.Enabled = false;
                    btnAces.Visible = false;
                
            }

            if (twosSaved == true )
            {
                twosScoreValue.Text = twos.ToString();
                twosScoreValue.ForeColor = Color.Black;
                btnTwos.Enabled = false;
                btnTwos.Visible = false;
            }

            if (threesSaved == true)
            {
                threesScoreValue.Text = threes.ToString();
                threesScoreValue.ForeColor = Color.Black;
                btnThrees.Enabled = false;
                btnThrees.Visible = false;
            }
            if (foursSaved == true)
            {
                foursScoreValue.Text = fours.ToString();
                foursScoreValue.ForeColor = Color.Black;
                btnFours.Enabled = false;
                btnFours.Visible = false;
            }
            if (fivesSaved == true)
            {
                fivesScoreValue.Text = fives.ToString();
                fivesScoreValue.ForeColor = Color.Black;
                btnFives.Enabled = false;
                btnFives.Visible = false;
            }
            if (sixesSaved == true)
            {
                sixesScoreValue.Text = sixs.ToString();
                sixesScoreValue.ForeColor = Color.Black;
                btnSixes.Enabled = false;
                btnSixes.Visible = false;
            }

            if (threeOfaKindSaved == true)
            {
                ThreeofKindScoreValue.Text = ThreeofKind.ToString();
                ThreeofKindScoreValue.ForeColor = Color.Black;
                btnThreeKind.Enabled = false;
                btnThreeKind.Visible = false;
            }

            if (fourOfAKindSaved == true)
            {
                FourofKindScoreValue.Text = fours.ToString();
                FourofKindScoreValue.ForeColor = Color.Black;
                btnFourKind.Enabled = false;
                btnFourKind.Visible = false;
            }
            if (fullHouseSaved == true)
            {
                fullHouseScoreValue.Text = FullHouse.ToString();
                fullHouseScoreValue.ForeColor = Color.Black;
                btnFullHouse.Enabled = false;
                btnFullHouse.Visible = false;
            }
            if (smallStraightSaved == true)
            {
                smallStraightScoreValue.Text = SmallStraight.ToString();
                smallStraightScoreValue.ForeColor = Color.Black;
                btnSmallStraight.Enabled = false;
                btnSmallStraight.Visible = false;
            }
            if (largeStraightSaved == true)
            {
                largeStraightScoreValue.Text = LargeStraight.ToString();
                largeStraightScoreValue.ForeColor = Color.Black;
                btnLargeStraight.Enabled = false;
                btnLargeStraight.Visible = false;

            }
            if (YahtzeeSaved == true)
            {
                YahtzeeScoreValue.Text = Yahtzee.ToString();
                YahtzeeScoreValue.ForeColor = Color.Black;
                btnYahtzee.Enabled = false;
                btnYahtzee.Visible = false;
            }
            if (ChanceSaved == true)
            {
                chanceScoreValue.Text = Chance.ToString();
                chanceScoreValue.ForeColor = Color.Black;
                btnChance.Enabled = false;
                btnChance.Visible = false;
            }

            if (YahtzeeBonus > 0)
            {
                yahtzeeBonusScoreValue.Text = YahtzeeBonus.ToString();
                yahtzeeBonusScoreValue.ForeColor = Color.Black;
                btnYahtzeeBonus.Enabled = false;
                btnYahtzeeBonus.Visible = false;
            }

            //check if upper bonus achieved
            UpperBonusCalc();
            if (UpperBonus == 35)
            {
                upperBonusScoreValue.Text = UpperBonus.ToString();
                upperBonusScoreValue.ForeColor = Color.Black;
            }

            TotalScoreCalc();
        }
        #endregion


        #region SetScores
        protected void btnAces_Click(object sender, EventArgs e)
        {
            try
            {
                if (acesScoreValue.Text == null)
                {

                    // raise dialog box with yes/ no/ cancel for accepting zero for a score



                }
                
                aces = int.Parse(acesScoreValue.Text);
                acesSaved = true;
                OnClickSave();
            }
            catch (Exception ex)
            {
                throw (ex);

            }
        }

        protected void btnTwos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(twosSaved.ToString());
            twos = int.Parse(twosScoreValue.Text);
            twosSaved = true;
            System.Diagnostics.Debug.WriteLine(twosSaved.ToString());
            OnClickSave();
        }


        protected void btnThrees_Click(object sender, EventArgs e)
        {
            
            threes = int.Parse(threesScoreValue.Text);
            threesSaved = true;
            OnClickSave();
        }

        protected void btnFours_Click(object sender, EventArgs e)
        {

            fours = int.Parse(foursScoreValue.Text);
            foursSaved = true;
            OnClickSave();
        }

        protected void btnFives_Click(object sender, EventArgs e)
        {
            fives = int.Parse(fivesScoreValue.Text);
            fivesSaved = true;
            OnClickSave();
        }

        protected void btnSixes_Click(object sender, EventArgs e)
        {
            sixs = int.Parse(sixesScoreValue.Text);
            sixesSaved = true;
            OnClickSave();
        }

        protected void btnThreeKind_Click(object sender, EventArgs e)
        {
            ThreeofKind = int.Parse(ThreeofKindScoreValue.Text);
            threeOfaKindSaved = true;
            OnClickSave();
        }

        protected void btnFourKind_Click(object sender, EventArgs e)
        {
            FourofKind = int.Parse(FourofKindScoreValue.Text);
            fourOfAKindSaved = true;
            OnClickSave();
        }

        protected void btnFullHouse_Click(object sender, EventArgs e)
        {
            FullHouse = int.Parse(fullHouseScoreValue.Text);
            fullHouseSaved = true;
            OnClickSave();
        }

        protected void btnSmallStraight_Click(object sender, EventArgs e)
        {
            SmallStraight = int.Parse(smallStraightScoreValue.Text);
            smallStraightSaved = true;
            OnClickSave();
        }

        protected void btnLargeStraight_Click(object sender, EventArgs e)
        {
            LargeStraight = int.Parse(largeStraightScoreValue.Text);
            largeStraightSaved = true;
            OnClickSave();
        }

        protected void btnYahtzee_Click(object sender, EventArgs e)
        {
            Yahtzee = int.Parse(YahtzeeScoreValue.Text);
            YahtzeeSaved = true;
            OnClickSave();
        }

        protected void btnChance_Click(object sender, EventArgs e)
        {
            Chance = int.Parse(chanceScoreValue.Text);
            ChanceSaved = true;
            OnClickSave();
        }
        
        protected void btnYahtzeeBonus_Click(object sender, EventArgs e)
        {

            BonusOnClickSave();
        }
        
        #endregion
    }//End Class

}