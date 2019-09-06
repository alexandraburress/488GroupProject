using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Test003
{
    public class GameData
    {
        List<Item> inventory = new List<Item>();
        Panel eventAlertPanel = new Panel();

        GameData(Panel eventAlertPanel) {
            this.eventAlertPanel = eventAlertPanel;

        }

        public Panel EventPanel{
            get;
            set;
        }

        //plots from various files

        //INport story file
        private static Story inportStoryFile(string fileName)
        {
            List<string> testText = new List<string>();
            Story myStory = new Story(testText);


            StreamReader inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream)
            {
                testText.Add(inputFile.ReadLine());

            }

            inputFile.Close();
            return myStory;
        }



        //Glamor hobo plot
        public static Story initilizeGlamorHobosAdventure()
        {

            Story myStory;
            myStory=inportStoryFile("Story.txt");


            

            //resize arrays based on new testText file size
            myStory.updateImageArraySizes();
            myStory.addMiddleCharacterImage(0, 0, Properties.Resources.James_Green_Think_full);
            myStory.addMiddleCharacterImage(1, 2, Properties.Resources.James_Green_Vashoom_full);
            myStory.addMiddleCharacterImage(3, 3, Properties.Resources.pumpernickel001);
            myStory.addMiddleCharacterImage(4, 6, Properties.Resources.James_Green_Vashoom_full);
            myStory.addBackgroundImage(0, 4, Properties.Resources.GlamorLair001);
            myStory.addBackgroundImage(5, 6, Properties.Resources.DefaultOutdoor);

            Item testItem = new Item("Test Item");
            myStory.findItem(6,testItem);

            return myStory;
        }

    }
}
