using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yahtzee.Web;
using System.Threading.Tasks;
namespace Yahtzee.Web
{
    class Score : Dice
    {
        const int UPPERBONUS = 35;
        const int YAHTZEEBONUS = 100;

        private int _ones = 0;
        private int _twos = 0;
        private int _threes = 0;
        private int _fours = 0;
        private int _fives = 0;
        private int _sixes = 0;

        private int _threeOfAKind = 0;
        private int _fourOfAKind = 0;
        private int _fullHouse = 0;
        private int _smallStraight = 0;
        private int _largeStraight = 0;
        private int _yahtzee = 0;
        private int _chance = 0;

        private int _totalScore = 0;
        private int _upperBonus = 0;
        private int _yahtzeeBonusCount = 0;
        private int _yahtzeeBonusTotal = 0;
        private int _upperTotal = 0;
        private int _lowerTotal = 0;
        private int _grandTotal = 0;

        public Score()
        {
            this.Ones = 0;
            this.Twos = 0;
            this.Threes = 0;
            this.Fours = 0;
            this.Fives = 0;
            this.Sixes = 0;

            this.ThreeOfAKind = 0;
            this.FourOfAKind = 0;
            this.FullHouse = 0;
            this.SmallStraight = 0;
            this.LargeStraight = 0;
            this.Yahtzee = 0;
            this.Chance = 0;

            this.TotalScore = 0;
            this.UpperTotal = 0;
            this.YahtzeeBonusCount = 0;
            this.YahtzeeBonusTotal = 0;
            this.LowerTotal = 0;
            this.GrandTotal = 0;
        }

        public int Ones
        {
            get { return _ones; }
            set { _ones = value; }
        }

        public int Twos
        {
            get { return _twos; }
            set { _twos = value; }
        }

        public int Threes
        {
            get { return _threes; }
            set { _threes = value; }
        }

        public int Fours
        {
            get { return _fours; }
            set { _fours = value; }
        }

        public int Fives
        {
            get { return _fives; }
            set { _fives = value; }
        }
        public int Sixes
        {
            get { return _sixes; }
            set { _sixes = value; }
        }

        public int ThreeOfAKind
        {
            get { return _threeOfAKind; }
            set { _threeOfAKind = value; }
        }

        public int FourOfAKind
        {
            get { return _fourOfAKind; }
            set { _fourOfAKind = value; }
        }

        public int FullHouse
        {
            get { return _fullHouse; }
            set { _fullHouse = value; }
        }

        public int SmallStraight
        {
            get { return _smallStraight; }
            set { _smallStraight = value; }
        }

        public int LargeStraight
        {
            get { return _largeStraight; }
            set { _largeStraight = value; }
        }

        public int Yahtzee
        {
            get { return _yahtzee; }
            set { _yahtzee = value; }
        }

        public int Chance
        {
            get { return _chance; }
            set { _chance = value; }
        }

        public int TotalScore
        {
            get { return _totalScore; }
            set { _totalScore = value; }
        }

        public int UpperBonus
        {
            get { return _upperBonus; }
            set { _upperBonus = value; }
        }

        public int YahtzeeBonusCount
        {
            get { return _yahtzeeBonusCount; }
            set { _yahtzeeBonusCount = value; }
        }

        public int YahtzeeBonusTotal
        {
            get { return _yahtzeeBonusTotal; }
            set { _yahtzeeBonusTotal = value; }
        }

        public int UpperTotal
        {
            get { return _upperTotal; }
            set { _upperTotal = value; }
        }

        public int LowerTotal
        {
            get { return _lowerTotal; }
            set { _lowerTotal = value; }
        }

        public int GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }

        // -- Lower, uppertotal and Total were done already and 
        //names were changed to match the two methods from codeproject below.
        //codeproject.com -- http://www.codeproject.com/Articles/8657/A-Simple-Yahtzee-Game
        //Two methods from Calculatescore.cs in ^

        public void ResetScores()
        {
            // if we clear these, I'm pretty sure we'll have to clear all the rest also
            // this method may not be used cause we can just start a new instance of the score class and null this one out
            this.TotalScore = 0;
            this.UpperTotal = 0;
            this.LowerTotal = 0;
            this.UpperBonus = 0;

        }

        // need to work on this part.. still have to place scores in proper catagories
        // public void UpdateTotals(int Score, int ScoreCatagory (0 - 12), bool isThisUpperScoreCard) -- will be able to remove bool isThisUperScoreCard
        //codeproject.com
        public void UpdateTotals(int Score, bool isThisUpperScoreCard)
        {
            if (isThisUpperScoreCard == true)
            {
                UpperTotal += Score;
                if (UpperTotal >= 63)
                    UpperTotal += UPPERBONUS;
            }
            else
            {
                LowerTotal += Score;
            }

            TotalScore = UpperTotal + LowerTotal;
        }

        public int AddUpDice()
        {
            int sum = 0;

            foreach (int item in gameDice)
            {
                sum += item;
            }
            return sum;
        }

        public int CalcX(int dieValue)
        {
            int total = 0;

            for (int i = 0; i < gameDice.Length; i++)
            {
                if (gameDice[i] == dieValue)
                {
                    total += gameDice[i];
                }
            }

            return total;
        }

        public int CalcXOfAKind(int numOfAKind)
        {
            int total = 0;
            int counter = 1;
            bool isXOfAKind = false;

            // sort the dice array
            Array.Sort(gameDice);

            for (int i = 0; i < gameDice.Length; i++)
            {
                // sum up all the dice
                total += gameDice[i];

                if (i < gameDice.Length - 1)
                {
                    // two consecutive die values, increment the counter
                    if (gameDice[i] == gameDice[i + 1])
                    {
                        counter++;

                        // if the counter = the X of a kind (3, 4, or 5), flag it
                        if (numOfAKind == counter)
                        {
                            isXOfAKind = true;
                        }
                    }
                    else
                    {
                        // two consecutive die values do not equate, start the counter over
                        counter = 1;
                    }
                }
            }

            if (!isXOfAKind)
            {
                // not a X of a kind
                total = 0;
            }
            else
            {
                // X of a kind, adjust score for Yahtzee (5 of a kind)
                if (numOfAKind == 5)
                {
                    total = 50;
                }
            }

            return total;
        }


        public int CalcFullHouse()
        {
            int total = 0;
            bool setOf2 = false;
            bool setOf3 = false;
            bool isFullHouse = true;

            // sort the dice array
            Array.Sort(gameDice);

            for (int i = 0; i < gameDice.Length; i++)
            {
                if (i < gameDice.Length - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (gameDice[i] != gameDice[i + 1])
                            {
                                // full house not possible - in a sorted array, the first 2 values MUST be equal for a full house to exist
                                isFullHouse = false;
                            }
                            break;
                        case 1:
                            if (gameDice[i] == gameDice[i + 1])
                            {
                                // a set of 3 has been made
                                setOf3 = true;
                            }
                            else
                            {
                                // a set of 2 has been made
                                setOf2 = true;
                            }
                            break;
                        case 2:
                            if (gameDice[i] == gameDice[i + 1])
                            {
                                if (setOf3)
                                {
                                    // full house not possible - due to 4 of a kind
                                    isFullHouse = false;
                                }
                            }
                            else
                            {
                                if (setOf2)
                                {
                                    // full house not possible - due to more than two values represented in the array of dice
                                    isFullHouse = false;
                                }
                            }
                            break;
                        case 3:
                            if (gameDice[i] != gameDice[i + 1])
                            {
                                // full house not possible - in a sorted array, the last 2 values MUST be equal for a full house to exist
                                isFullHouse = false;
                            }
                            break;
                        default:
                            // do nothing
                            break;
                    }
                }

                if (!isFullHouse)
                {
                    // full house not possible, stop analyzing the dice, no score
                    break;
                }
            }

            if (isFullHouse)
            {
                // full house determined
                total = 25;
            }

            return total;
        }


        public int CalcStraight(bool wantLargeStraight)
        {
            int total = 0;
            bool isStraight = true;
            bool smallStraightPassUsed = false;

            // sort the dice array
            Array.Sort(gameDice);

            for (int i = 0; i < gameDice.Length; i++)
            {
                if (i < gameDice.Length - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (gameDice[i] != gameDice[i + 1] - 1)
                            {
                                if (wantLargeStraight)
                                {
                                    // large straight not possible - each of the 5 dice values MUST be consecutively one less than the next
                                    isStraight = false;
                                }
                                else
                                {
                                    smallStraightPassUsed = true;
                                }
                            }
                            break;
                        case 1:
                        case 2:
                            if (gameDice[i] != gameDice[i + 1] - 1)
                            {
                                // straight not possible - the first 4 dice OR, the last 4 dice, values MUST be consecutively one less than the next
                                isStraight = false;
                            }
                            break;
                        case 3:
                            if (gameDice[i] != gameDice[i + 1] - 1)
                            {
                                if (wantLargeStraight)
                                {
                                    // large straight not possible - each of the 5 dice values MUST be consecutively one less than the next
                                    isStraight = false;
                                }
                                else
                                {
                                    if (smallStraightPassUsed)
                                    {
                                        // small straight not possible - must have 4 consecutive values of one less than the next
                                        isStraight = false;
                                    }
                                }
                            }
                            break;
                    }
                }

                if (!isStraight)
                {
                    // straight not possible, stop analyzing the dice, no score
                    break;
                }
            }

            if (isStraight)
            {
                // straight determined
                if (wantLargeStraight)
                {
                    total = 40;
                }
                else
                {
                    total = 30;
                }
            }

            return total;
        }

        public int CalcChance()
        {
            int total = 0;

            for (int i = 0; i < gameDice.Length; i++)
            {
                // sum up all the dice
                total += gameDice[i];
            }

            return total;
        }

    }
}