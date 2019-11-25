using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Test003
{

    
    public class Hero
    {


        public Hero()
        {
            Name = "Henry";
            Nickname = "Henrietta";
            //Will be using TYPESOFCLOTHING enum in multiple locations
            int clothingTypeSize = (int)Enum.GetNames(typeof(TYPESOFCLOTHING)).Length;
            int maxClothingItemNumber = 20;

            //initlizie wardrobe array with first position being size of TYPESOF CLOTHING ENUM
            //setting second  number as maximum number of clothing pieces in here
            Wardrobe = new Clothing[clothingTypeSize, maxClothingItemNumber];
            Body = Properties.Resources.Henry004;

            //Will access the positions in this array bassed on DistinctClothing Pieces ENUM
            Outfit = new Clothing[clothingTypeSize];


            //This will be the outfit that Henry will be wearying when the game starts
            //layer order taken care of in dressHero(). Not important here
            //Should also add to Henry's wardrobe, so that later in the game he can select this again

            int outfitTypeNum = (int)TYPESOFCLOTHING.SHIRT;
            int subNum = (int)SHIRTSENUM.WEAVY_BLUE;
            Clothing workingItem = Clothing.Shirts[subNum];

            starterOutfit(outfitTypeNum, subNum, workingItem);


            outfitTypeNum = (int)TYPESOFCLOTHING.PANTS;
            subNum = (int)PANTSENUM.SKIRT_BLUE;
            workingItem = Clothing.Pants[subNum];

            starterOutfit(outfitTypeNum, subNum, workingItem);


            outfitTypeNum = (int)TYPESOFCLOTHING.FACE;
            subNum = (int)FACES_ENUM.DERP;
            workingItem = Clothing.Faces[subNum];

            starterOutfit(outfitTypeNum, subNum, workingItem);

            outfitTypeNum = (int)TYPESOFCLOTHING.HAIR;
            subNum = (int)HAIR_ENUM.CURLY_PURPLE;
            workingItem = Clothing.Hair[subNum];

            starterOutfit(outfitTypeNum, subNum, workingItem);


            DressedHero = dressHero();

        }

        private void starterOutfit(int outfitTypeNum, int subNum, Clothing workingItem)
        {
            Outfit[outfitTypeNum] = workingItem;
            addToWardrobe(outfitTypeNum, subNum, workingItem);


        }

        public string Name
        {
            get;
            set;

        }

        public string Nickname
        {
            get;
            set;
        }

        public Bitmap Body
        {
            get;
            set;
        }

        public Clothing[] Outfit
        {
            get;
            set;
        }

        public Bitmap DressedHero
        {
            get;

            }

        //wardrobe is to keep track of clothing that henry owns. It should return null
        //where Henry dosen't have that clothing piece yet
        public Clothing[,] Wardrobe
        {
            get;

        }

        public void addToWardrobe(int clothingTypeEnum,int clothingItemEnum,Clothing addClothing)
        {


            Wardrobe[clothingTypeEnum, clothingItemEnum] =addClothing;


        }

        public Bitmap dressHero()
        {

            //clone hero body, so that base is untouched
            Bitmap newHero = (Bitmap)Body.Clone();

            //use graphics object as base to dress
            Graphics graphics = Graphics.FromImage(newHero);



            //order of outfit items is important so that the image layers appears in the right order
            graphics.DrawImage(Outfit[(int)TYPESOFCLOTHING.FACE].Image, 0, 0, newHero.Size.Width, newHero.Size.Height);
            graphics.DrawImage(Outfit[(int)TYPESOFCLOTHING.PANTS].Image, 0, 0, newHero.Size.Width, newHero.Size.Height);
            graphics.DrawImage(Outfit[(int)TYPESOFCLOTHING.SHIRT].Image, 0, 0, newHero.Size.Width, newHero.Size.Height);
            graphics.DrawImage(Outfit[(int)TYPESOFCLOTHING.HAIR].Image, 0, 0, newHero.Size.Width, newHero.Size.Height);


            //draw arm on top off all clothing
            graphics.DrawImage(Properties.Resources.forground_arm, 0, 0, newHero.Size.Width, newHero.Size.Height);


            //Releases resources used by graphics
            graphics.Dispose();





            Bitmap output = newHero;

            return output;
        }
        
        

    }
}
