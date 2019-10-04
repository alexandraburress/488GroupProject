﻿using System;
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
    public partial class Map : Form
    {
        Story glamorLairStory =GameData.initilizeGlamorHobosAdventure();
        List<Story> magicSchoolStories = new List<Story>();

        public Map()
        {
            InitializeComponent();

            
            Story dressUpMagicSchoolStory = GameData.initilizeStory("MagicSchool.txt");
            dressUpMagicSchoolStory.addBackgroundImage(0,2, Properties.Resources.PumpkinFarm001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(0, 2, Properties.Resources.FarmerFamilyGroupScene);
            //dressUpMagicSchoolStory.updateStory();

            Story henrysFirstSchoolDay = GameData.initilizeStory("HenrysFirstDayOfSchool.txt");

            magicSchoolStories.Add(dressUpMagicSchoolStory);
            magicSchoolStories.Add(henrysFirstSchoolDay);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void glamorLairPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 glamorLair = new Form1(glamorLairStory,0);
            glamorLair.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        public void resumeWorld(Story myStory)
        {
            int position = myStory.Position;
            Form1 openWorld = new Form1(glamorLairStory,position);
            openWorld.ShowDialog();

        }

        private void dressUpGameButton_Click(object sender, EventArgs e)
        {
            Form1 glamorLair = new Form1(magicSchoolStories);
            glamorLair.ShowDialog();
        }
    }
}
