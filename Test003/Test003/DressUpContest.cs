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
    public partial class DressUpContest : Form
    {
        Minigame minigame;
        Hero hero;

        public DressUpContest(Minigame minigame)
        {
            InitializeComponent();
            this.minigame = minigame;
            hero = minigame.CurrentHero;

            Clothing[] shirts = hero.Shirts;
            Clothing[] pants = hero.Pants;

            //fill out combo boxes for every single item in the tab
            fillClothingSelectionBox(shirtSelectionListBox, shirts);
            fillClothingSelectionBox(pantsListBox, pants);
            fillClothingSelectionBox(faceListBox, hero.Wardrobe[(int)TYPESOFCLOTHING.FACE]);
            fillClothingSelectionBox(hairListBox, hero.Wardrobe[(int)TYPESOFCLOTHING.HAIR]);
            fillClothingSelectionBox(shoesListBox, hero.Wardrobe[(int)TYPESOFCLOTHING.SHOES]);
            fillClothingSelectionBox(socksListBox, hero.Wardrobe[(int)TYPESOFCLOTHING.SOCKS]);
        }

        public int Score{
            
            get;
            set;
        }

        private void fillClothingSelectionBox(ListBox box,Clothing[] arrayToFill)
        {
           
            //Guide on how to use Dictonary class: http://net-informations.com/q/faq/combovalue.html
            Dictionary<string, Clothing> shirtDictionary = new Dictionary<string, Clothing>();

            shirtDictionary.Add("Nothing", null);
            foreach (Clothing clothingPiece in arrayToFill)
            {

                if (clothingPiece != null)
                {
                    shirtDictionary.Add(clothingPiece.Name, clothingPiece);
                }

                box.DataSource = new BindingSource(shirtDictionary, null);
                box.DisplayMember = "Key";
                box.ValueMember = "Value";


            }

        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            minigame.Won = true;
            hero.dressHero();
            this.Close();
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            minigame.Won = false;
            this.Close();
        }

        private void DressUpContest_Load(object sender, EventArgs e)
        {
            dressUpPictureBox.Image = hero.DressedHero;
            Score = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void changeIndividualClothingItems(ListBox listBox, TYPESOFCLOTHING typeOfClothing)
        {
            Clothing clothing = ((KeyValuePair<string, Clothing>)listBox.SelectedItem).Value;
            hero.changeClothing(typeOfClothing, clothing);
            dressUpPictureBox.Image = hero.DressedHero;
        }


        private void shirtSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndividualClothingItems(shirtSelectionListBox, TYPESOFCLOTHING.SHIRT);
        }

        private void pantsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndividualClothingItems(pantsListBox, TYPESOFCLOTHING.PANTS);

        }

        private void socksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            changeIndividualClothingItems(socksListBox, TYPESOFCLOTHING.SOCKS);
        }

        private void shoesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndividualClothingItems(shoesListBox, TYPESOFCLOTHING.SHOES);

        }

        private void hairListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndividualClothingItems(hairListBox, TYPESOFCLOTHING.HAIR);

        }

        private void faceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndividualClothingItems(faceListBox, TYPESOFCLOTHING.FACE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add up score for every item in game
            int size= hero.Outfit.Length;
            int score = 0;
            foreach(Clothing item in hero.Outfit)
            {
                if(item != null)
                {
                    score += item.Score;


                }
            }


            Score = score;

            Close();

        }
    }
}
