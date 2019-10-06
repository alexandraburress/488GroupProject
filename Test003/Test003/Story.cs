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
            ForegroundPicture = new Bitmap[storyText.Count];


        }

        public void updateImageArraySizes()
        {
            MiddleCharacterPicture = new Bitmap[text.Count];
            BackgroundPicture = new Bitmap[text.Count];
            ForegroundPicture = new Bitmap[text.Count];
            StoryOccurances = new Occurance[text.Count];
            TextEndPosition = text.Count;
        }

   

        public void addMiddleCharacterImage(int imagePositionStart, int imagePositionEnd, Bitmap image)
        {
            imageArrayVisableLoop(MiddleCharacterPicture, imagePositionStart, imagePositionEnd, image);

            }

        //middle character with default to one frame if not specified
        public void addMiddleCharacterImage(int imagePosition, Bitmap image)
        {


            addMiddleCharacterImage(imagePosition, imagePosition, image);

        }

        public void addBackgroundImage(int imagePosition, int imagePositionEnd, Bitmap image)
        {
            BackgroundPicture=imageArrayVisableLoop(BackgroundPicture, imagePosition, imagePositionEnd, image);

        }


        //if there is no end position specified, then consider it a one frame image
        public void addBackgroundImage(int imagePosition, Bitmap image)
        {
            addBackgroundImage(imagePosition,imagePosition,image);
        }


        public void addForegroundImage(int imagePosition, int imagePositionEnd, Bitmap image)
        {
            //subtract position end from position start and loop though those numbers.

            imageArrayVisableLoop(ForegroundPicture, imagePosition, imagePositionEnd, image);


        }

        public void addForegroundImage(int imagePosition, Bitmap image)
        {
            addForegroundImage(imagePosition, imagePosition, image);
        }

        private Bitmap[] imageArrayVisableLoop(Bitmap[] imageArray, int imagePosition, int imagePositionEnd, Bitmap image)
        {
            int count = imagePositionEnd - imagePosition;
            try
            {
                for (int i = 0; i <= count; i++)
                {
                    imageArray[imagePosition + i] = image;
                    //ForegroundPictureOn[imagePosition + i] = true;

                }

            }
            catch (Exception ex)
            {
                string message = "";
                if (0 > count)
                {
                    message = "End Position Lower then Start position\n";
                }
                message += ex.Message;

                MessageBox.Show(message);

            }

            return imageArray;
        }



        public void addOccurance(int storyLocation, Occurance myOccurance)
        {
            StoryOccurances[storyLocation] = myOccurance;
        }

        public int TextEndPosition
        {
            get;
            set;
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

        public Bitmap[] ForegroundPicture
        {
            get;
            set;
        }

        public Boolean[] ForegroundPictureOn
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
