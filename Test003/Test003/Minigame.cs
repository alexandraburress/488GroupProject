using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test003
{
    public class Minigame
    {
        public Minigame()
        {
            HasBeenPlayed = false;
        }

        //return true if minigame is won, and false if it is lost
        public Boolean start()
        {

            
            //for now default to true
            return true;
        }

        public Boolean HasBeenPlayed
        {
            get;
            set;

        }




    }
}
