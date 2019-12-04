using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test003
{
    
    public enum MINIGAME_GAMES
    {
        DRESSUP_CONTEST

    }

    public class Minigame
    {
        


        public Minigame(MINIGAME_GAMES minigameType, Hero hero, string loserMessage = "You have lost. Please try again")
        {
            TypeOfGame = minigameType;
            LoserMessage = loserMessage;
            CurrentHero = hero;
        }

        //return true if minigame is won, and false if it is lost
        public void start()
        {


            if (TypeOfGame == MINIGAME_GAMES.DRESSUP_CONTEST) {
                DressUpContest newContest = new DressUpContest(this);

                newContest.ShowDialog();
                CurrentHero.DressedHero = CurrentHero.dressHero();
            }
            Won = true;



        }



        public bool Won
        {
            get;
            set;

        }

        public MINIGAME_GAMES TypeOfGame
        {
            get;

        }

        public string LoserMessage
        {
            get;
            set;
        }

        public Hero CurrentHero
        {
            get;
            set;
        }



    }
}
