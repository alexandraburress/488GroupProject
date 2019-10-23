using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test003
{
    public class Choice
    {
        public Choice(string filename, string buttonText="", Story thisStory=null)
        {
            Filename = filename;
            ButtonText = buttonText;
            Story = thisStory;
        }

        public string Filename
        {
            get;
            set;
        }

        public string ButtonText
        {
            get;
            set;
        }

        public Story Story
        {
            get;
            set;
        }
    }


}
