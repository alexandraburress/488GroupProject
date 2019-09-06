using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Test003
{
    public class Story
    {
        List<string> text = new List<string>();
        Boolean timingEvents = true;

        public Story(List<string> storyText)
        {
            Position = 0;
            text = storyText;
            MiddleCharacterPicture = new Bitmap[storyText.Count];
            BackgroundPicture = new Bitmap[storyText.Count];


        }

        public void updateImageArraySizes()
        {
            MiddleCharacterPicture = new Bitmap[text.Count];
            BackgroundPicture = new Bitmap[text.Count];
            StoryOccurances = new Occurance[text.Count];
        }

        public void addMiddleCharacterImage(int imagePositionStart, int imagePositionEnd, Bitmap image)
        {
            MiddleCharacterPicture[imagePositionStart] = image;
            MiddleCharacterPicture[imagePositionEnd] = image;

        }

        public void addBackgroundImage(int imagePosition, int imagePositionEnd, Bitmap image)
        {
            BackgroundPicture[imagePosition] = image;
            BackgroundPicture[imagePositionEnd] = image;

        }


        public void addOccurance(int storyLocation, Occurance myOccurance)
        {
            StoryOccurances[storyLocation] = myOccurance;
        }

        public int Position
        {
            get;
            set;
        }

        public Bitmap[] MiddleCharacterPicture
        {
            get;
            set;

        }

        public Bitmap[] BackgroundPicture
        {
            get;
            set;

        }

        public Occurance[] StoryOccurances
        {
            get;
            set;

        }

        public string start()
        {
            Position = 0;

            string output = text[Position];
            if (timingEvents == true)
            {
                output = Position.ToString() + ": " + output;
            }
            return output;
        }

        public string next()
        {
            int maxPosition = text.Count - 1;
            string output = "";

            //only advance to next position in List if it exists
            //in case array is empty, output messages and set position to 0 for later code
            if(text.Count==0){
                output=("No text loaded");
                Position = 0;

            }
            //If at max position in array, stay there
            else if (Position >= maxPosition)
            {
                output=(text[maxPosition]);
            }
            else{
                
                output = text[++Position];
                
            }

            //add position reference to output so that I may time pictures and events properly
            if (timingEvents == true)
            {
                output = Position.ToString() + ": " + output;
            }

            return output;
        }

        public string last()
        {

            string output = "";

            if (Position != 0)
            {

                output = (text[--Position]);
            }
            else
            {
                output = text[Position];
            }

            //add position reference to output so that I may time pictures and events properly
            if (timingEvents == true)
            {
                output = Position.ToString() + ": " + output;
            }

            return output;

        }


        public void findItem(int storyLocation,Item myItem,string myDescription=null)
        {
            string name = "You found "+ myItem.Name;
            string description = myDescription+"\n"+myItem.Description;
            Bitmap image = myItem.Image;

            //update image here if image exists in database
            //if (item.Image != null)
            //{
            //   eventAlertPanel.Visible = true;
            //}



            Occurance output= new Occurance(name, description, image);
            addOccurance(storyLocation,output);

        }


    }
}
