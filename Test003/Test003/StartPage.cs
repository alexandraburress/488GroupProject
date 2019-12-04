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


        //declare main character
        Hero henry = new Hero();

        public StartPage()
        {
            InitializeComponent();
            

            //add some common character images
            Bitmap james_think = Properties.Resources.James_Green_Think_full;
            Bitmap james_vashoom = Properties.Resources.James_Green_Vashoom_full;
            Bitmap noel_smile = Properties.Resources.NoelRedSmile;
            Bitmap noel_think = Properties.Resources.NoelRedThink;
            Bitmap noel_worried = Properties.Resources.NoelRedWorried;
            Bitmap snobbyGirl_default = Properties.Resources.Klair001;


            Story dressUpMagicSchoolStory = GameData.initilizeStory("MagicSchool.txt", henry, true);
            dressUpMagicSchoolStory.addBackgroundImage(0, Properties.Resources.PumpkinFarm001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(0, Properties.Resources.farmerMother001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(1, 2,henry.DressedHero);
            dressUpMagicSchoolStory.addBackgroundImage(1, Properties.Resources.TownFestival001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(3,4, noel_smile);
            dressUpMagicSchoolStory.addMiddleCharacterImage(5, noel_think);
            dressUpMagicSchoolStory.addMiddleCharacterImage(6,7, noel_smile);

            //find item
            Item magicMushrooms = new Item("Magic Mushroom","They're.... magic");
            dressUpMagicSchoolStory.findItem(3,magicMushrooms);

            Item goldenGlasses = new Item("Gold and Red Glasses", "See the world through rose colored glass.", Properties.Resources.glasses_gold_and_red_small);
            dressUpMagicSchoolStory.findItem(7, goldenGlasses);
            dressUpMagicSchoolStory.addClothingToWardrobe(7,(int)TYPESOFCLOTHING.GLASSES,(int)GLASSES_ENUM.RED_AND_GOLD);


            //add minigame 
            dressUpMagicSchoolStory.addMinigame(2,4);


            Story henrysFirstSchoolDay = GameData.initilizeStory("HenrysFirstDayOfSchool.txt", henry, true);
            henrysFirstSchoolDay.addBackgroundImage(0, Properties.Resources.School_A);
            henrysFirstSchoolDay.addMiddleCharacterImage(5, henry.DressedHero);
            henrysFirstSchoolDay.addMiddleCharacterImage(3, james_think);
            henrysFirstSchoolDay.addMiddleCharacterImage(4, james_vashoom);
            henrysFirstSchoolDay.addMiddleCharacterImage(5, henry.DressedHero);
            henrysFirstSchoolDay.addMiddleCharacterImage(6, james_think);
            henrysFirstSchoolDay.addMiddleCharacterImage(9, snobbyGirl_default);

            Story ch2_learnFashion = GameData.initilizeStory("ch2_learnFashion.txt", henry);

            Story ch2_learnMagic = GameData.initilizeStory("ch2_learnMagic.txt", henry);

            //minigame
            henrysFirstSchoolDay.addMinigame(9,5);

            //Do to how refences work, it's easier to set up the story routes and then connecet them
            Choice choiceGoToGirlsSchool = new Choice("Go To Girl's School", henrysFirstSchoolDay);
            dressUpMagicSchoolStory.branchStory(choiceGoToGirlsSchool);

            Choice goTo_ch_2_learnFashion = new Choice("Learn about Fashion",ch2_learnFashion);
            Choice goTo_ch_2_learnMagic = new Choice("Learn about Magic",ch2_learnMagic);
            henrysFirstSchoolDay.branchStory(goTo_ch_2_learnFashion,goTo_ch_2_learnMagic);
            

            magicSchoolStories.Add(dressUpMagicSchoolStory);
            magicSchoolStories.Add(henrysFirstSchoolDay);

            magicSchoolStories.Add(ch2_learnFashion);
            magicSchoolStories.Add(ch2_learnMagic);
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

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void addMinigame(Story story, int position, int minimumScore)
        {

            story.addMinigame(position,minimumScore);

            //update image for future references for Henry based on how minigame has altered hero
            //I have these as sepeate parts because there may be some instances where I 
            //want to use a dressed model in one part of the game and don't want the data to transfer
            henry.DressedHero=henry.dressHero();
        }
    }
}
