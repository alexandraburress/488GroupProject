using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test003
{
    public partial class Form1 : Form
    {
        Story myStory;
        Story nextStory;
        Boolean eventBoxActive = false;
        List<Story> allStories = new List<Story>();
        int storySelection = 0;


        public Form1(Story inportStory, int position=0)
        {
            InitializeComponent();
            myStory = inportStory;

        }

        public Form1(List<Story> inportStory, int position=0)
        {
            InitializeComponent();
            //in case of multiple stories, start at the first story
            allStories = inportStory;
            myStory = inportStory[storySelection];


        }


        private void Form1_Load(object sender, EventArgs e)
        {
              //default foreground to false
            foregroundImage.Visible = false;
            backgroundImage.Controls.Add(middleCharacterBoxImage);
            middleCharacterBoxImage.BackColor = Color.Transparent;

            //if I've changed position 0 I need to reload anyway
            checkForImageChange();

            outputLbl.Text = myStory.start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            next();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            next();

        }

        private void next()
        {
            if (eventBoxActive == false)
            {
                outputLbl.Text = myStory.next();
            }

            checkForImageChange();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (eventBoxActive == false)
            {
                outputLbl.Text = myStory.last();
            }

            if (buttonOptionBox.Visible==true)
            {
                buttonOptionBox.Visible = false;

            }

            checkForImageChange();
        }

        private void checkForImageChange()
        {
            int num = myStory.Position;
            Bitmap currentMiddleCharacterImage = myStory.MiddleCharacterPicture[num];
            Bitmap currentBackgroundImage = myStory.BackgroundPicture[num];
            Occurance currentOccurence = myStory.StoryOccurances[num];
            
            //combined Foreground Image 
            Bitmap currentForegroundImage = myStory.ForegroundPicture[num];
            //Boolean currentForegroundImageOn = myStory.ForegroundPictureOn[num];

            //update images
            if (currentMiddleCharacterImage != null)
            {
                middleCharacterBoxImage.Visible = true;
                middleCharacterBoxImage.Image = currentMiddleCharacterImage;
            }
            else
            {
                middleCharacterBoxImage.Visible = false;

            }

            if (currentBackgroundImage != null)
            {
                backgroundImage.Image = currentBackgroundImage;
            }

            if (currentForegroundImage != null)
            {
                foregroundImage.Visible = true;
                foregroundImage.Image = currentForegroundImage;
            }
            else
            {
                foregroundImage.Visible = false;
            }

            //check for events 

            if (eventBoxActive == true)
            {
                occuranceSwitch(false);

            }
            else if (currentOccurence != null && currentOccurence.Occured==false)
            {
                eventOutputLbl.Text = currentOccurence.Name + "\n" + currentOccurence.Description;
                occuranceSwitch(true);
                currentOccurence.Occured = true;
            }
            if (myStory.Position==myStory.TextEndPosition-1 && myStory.HasChoices==true)
            {
                showMultipleChoiceRoutes();
                nextStory=allStories[storySelection];


            }
            

        }

        public void occuranceSwitch(Boolean onOrOff)
        {
            eventAlertPanel.Visible = onOrOff;
            eventBoxActive = onOrOff;

        }




        public void showMultipleChoiceRoutes()
        {
            buttonOptionBox.Visible = true;
            int i = 0;

            Choice[] choices = myStory.Choices;

                foreach (var button in buttonOptionBox.Controls.OfType<Button>())
                {

                    if (choices[i] == null)
                    {

                        button.Text = "This test should only appear when there is no choice in here "+i;
                        button.Visible = false;

                    }
                    else
                    {

                        button.Text = choices[i].ButtonText;
                        button.Visible = true;
                }
                if(i<2)
                {
                    i++;

                }


                }


        }

        private void multipleChoiceABtn_Click(object sender, EventArgs e)
        {
            selectNextStory(0);

        }

        private void multipleChoiceBBtn_Click(object sender, EventArgs e)
        {
            selectNextStory(1);

        }

        private void multipleChoiceCBtn_Click(object sender, EventArgs e)
        {
            selectNextStory(2);
        }
        
        private void selectNextStory(int arrayPosition)
        {
            if (myStory.Choices[arrayPosition]!=null)
            {
                //set next story
                Story myNextStory = myStory.Choices[arrayPosition].Story;
                MessageBox.Show(myStory.Choices[arrayPosition].Filename);

                //if I've changed position 0 I need to reload anyway
                
                myStory = myNextStory;
                myStory.Position = 0;
                checkForImageChange();


                outputLbl.Text = myStory.start();
                buttonOptionBox.Visible = false;
            }
            else
            {

                MessageBox.Show("No vailid option connected to this button, please select another (or, Anna, YOU can fix this)");

            }
        }
    }
}
