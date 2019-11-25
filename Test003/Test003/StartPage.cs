using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test003
{
    public partial class StartPage : Form
    {
        Story glamorLairStory = GameData.initilizeGlamorHobosAdventure();
        List<Story> magicSchoolStories = new List<Story>();

        public StartPage()
        {
            InitializeComponent();
            Hero henry = new Hero();



            Story dressUpMagicSchoolStory = GameData.initilizeStory("MagicSchool.txt", true);
            dressUpMagicSchoolStory.addBackgroundImage(0, Properties.Resources.PumpkinFarm001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(0, Properties.Resources.farmerMother001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(1, 3,henry.DressedHero);
            dressUpMagicSchoolStory.addBackgroundImage(1, Properties.Resources.TownFestival001);

            //add minigame 
            dressUpMagicSchoolStory.addMinigame(2);


            Story henrysFirstSchoolDay = GameData.initilizeStory("HenrysFirstDayOfSchool.txt");
            henrysFirstSchoolDay.addBackgroundImage(0, Properties.Resources.School_A);

            //Do to how refences work, it's easier to set up the story routes and then connecet them
            Choice choiceGoToGirlsSchool = new Choice("HenrysFirstDayOfSchool.txt", "Go To Girl's School", henrysFirstSchoolDay);
            dressUpMagicSchoolStory.branchStory(choiceGoToGirlsSchool);

            magicSchoolStories.Add(dressUpMagicSchoolStory);
            magicSchoolStories.Add(henrysFirstSchoolDay);
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Form1 magicSchoolStart = new Form1(magicSchoolStories);
            magicSchoolStart.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
