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



        public Minigame(MINIGAME_GAMES minigameType)
        {
            HasBeenPlayed = false;
            TypeOfGame = minigameType;
        }

        //return true if minigame is won, and false if it is lost
        public Boolean start()
        {

            if (TypeOfGame == MINIGAME_GAMES.DRESSUP_CONTEST) {
                DressUpContest newContest = new DressUpContest();

                newContest.ShowDialog();

            }
            //for now default to true
            return true;
        }

        public Boolean HasBeenPlayed
        {
            get;
            set;

        }

        public Boolean Won
        {
            get;
            set;

        }

        public MINIGAME_GAMES TypeOfGame
        {
            get;

        }




    }
}
