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
            if (eventBoxActive == false)
            {
                outputLbl.Text = myStory.next();
            }

            checkForImageChange();


        }

        private void backgroundImage_Click(object sender, EventArgs e)
        {

        }

        private void middleCharacterBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void leftPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
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
            if (myStory.Position== myStory.TextEndPosition-1)
            { 
                MessageBox.Show("Default next text file"); 
                nextStory=allStories[storySelection];


            }
            

        }

        public void occuranceSwitch(Boolean onOrOff)
        {
            eventAlertPanel.Visible = onOrOff;
            eventBoxActive = onOrOff;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void eventAlertPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void foregroundImage_Click(object sender, EventArgs e)
        {

        }

        private void selectOption()
        {

        }
    }
}
