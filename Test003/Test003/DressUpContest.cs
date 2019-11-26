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
            fillClothingComboBox(shirtSelctionComboBox, shirts);
            fillClothingComboBox(pantsSelctionComboBox, pants);


            //shirtsPanel.
        }

        private void fillClothingComboBox(ComboBox comboBox,Clothing[] arrayToFill)
        {
            



            //Guide on how to use Dictonary class: http://net-informations.com/q/faq/combovalue.html
            Dictionary<string, Clothing> shirtDictionary = new Dictionary<string, Clothing>();

            foreach (Clothing clothingPiece in arrayToFill)
            {

                if (clothingPiece != null)
                {
                    shirtDictionary.Add(clothingPiece.Name, clothingPiece);
                }

                comboBox.DataSource = new BindingSource(shirtDictionary, null);
                comboBox.DisplayMember = "Key";
                comboBox.ValueMember = "Value";


            }

        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            minigame.Won = true;
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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void shirtsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pantsSelctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shirt_selectBtn_Click(object sender, EventArgs e)
        {
            
            Clothing clothing = ((KeyValuePair<string,Clothing>)shirtSelctionComboBox.SelectedItem).Value;
            hero.changeShirt(clothing);
            dressUpPictureBox.Image=hero.DressedHero;
            
        }

        private void shirtSelctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
