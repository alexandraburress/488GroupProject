using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Test003
{

    public enum TYPESOFCLOTHING
    {
        FACE,
        SHIRT,
        PANTS,
        HAIR,
        GLASSES,
        SOCKS,
        SHOES
    }

    public enum SHIRTSENUM
    {
        WEAVY_BLUE, MAGIC_BLACK,TSHIRT_RED

    }

    public enum PANTSENUM
    {
        SKIRT_BLUE, JEANS_BLUE

    }

    public enum FACES_ENUM
    {
        DERP,ANIME,REALISITC
    }

    public enum HAIR_ENUM
    {
        CURLY_PURPLE,BRAIDS_BROWN,PIXIE_BLOND
    }

    public enum GLASSES_ENUM
    {
        RED_AND_GOLD,SUNGLASSES_BLACK
    }
    
    public enum SOCKS_ENUM
    {

        PINK    
    }

    public enum SHOES_ENUM
    {

        CLOGS_BROWN

    }



    public class Clothing
    {

        
        public Clothing(string name, Bitmap image,int score=0)
        {
            Name = name;
            Image = image;
            Score = score;



        }

        public string Name
        {
            get;
            set;
        }

        public Bitmap Image
        {
            get;
            set;

        }

        public int Number
        {
            get;
            set;
        }

        public int Score
        {
            get;
            set;
        }


        //holding an array backed by an enum for each clothing item

        public static Clothing[] Faces
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.FACE]; }
        }

        public static Clothing[] Shirts
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SHIRT]; }

        }

        public static Clothing[] Pants
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.PANTS]; }

        }
        public static Clothing[] Hair
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.HAIR]; }

        }

        public static Clothing[] Glasses
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.GLASSES]; }

        }


        public static Clothing[] Shoes
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SHOES]; }

        }


        public static Clothing[] Socks
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SOCKS]; }

        }

        public static Clothing[][] Wardrobe
        {
            get {

                //Will be using TYPESOFCLOTHING enum in multiple locations
                int clothingTypeSize = (int)Enum.GetNames(typeof(TYPESOFCLOTHING)).Length;

                //initlizie wardrobe array with first position being size of TYPESOF CLOTHING ENUM
                //setting second  number as maximum number of clothing pieces in here
                Clothing[][]Wardrobe = new Clothing[clothingTypeSize][];
                Wardrobe[(int)TYPESOFCLOTHING.SHIRT] = initializeShirts();
                Wardrobe[(int)TYPESOFCLOTHING.PANTS] = initializePants();
                Wardrobe[(int)TYPESOFCLOTHING.FACE] = initializeFaces();
                Wardrobe[(int)TYPESOFCLOTHING.HAIR] = initializeHair();
                Wardrobe[(int)TYPESOFCLOTHING.GLASSES] = initializeGlasses();
                Wardrobe[(int)TYPESOFCLOTHING.SHOES] = initializeShoes();
                Wardrobe[(int)TYPESOFCLOTHING.SOCKS] = initializeSocks();

                return Wardrobe;
            }
        }

        //intilizing the items in the clothing arrays

        private static Clothing[] initializeFaces()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(FACES_ENUM)).Length];
            clothing[(int)FACES_ENUM.DERP] = new Clothing("Derp Face", Properties.Resources.face_derp_001);
            clothing[(int)FACES_ENUM.ANIME] = new Clothing("Anime Face", Properties.Resources.face_anime_001);
            clothing[(int)FACES_ENUM.REALISITC] = new Clothing("Realistic Face", Properties.Resources.face_realistic_001);


            return clothing;
        }


        private static Clothing[] initializeShirts()
        {
            Clothing[] shirts = new Clothing[(int)Enum.GetNames(typeof(SHIRTSENUM)).Length];
            shirts[(int)SHIRTSENUM.WEAVY_BLUE] = new Clothing("Wavy Blue Shirt", Properties.Resources.shirt_wavy_blue);
            shirts[(int)SHIRTSENUM.MAGIC_BLACK] = new Clothing("Magic Black Shirt", Properties.Resources.shirt_magicGirlTop001);
            shirts[(int)SHIRTSENUM.TSHIRT_RED] = new Clothing("Red T-Shirt", Properties.Resources.shirt_tShirt_red);


            return shirts;
        }

        private static Clothing[] initializePants()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(PANTSENUM)).Length];
            clothing[(int)PANTSENUM.SKIRT_BLUE] = new Clothing("Blue Skirt", Properties.Resources.pants_skirt_blue);
            clothing[(int)PANTSENUM.JEANS_BLUE] = new Clothing("Blue Jeans", Properties.Resources.pants_jeans_blue);

            return clothing;
        }
        private static Clothing[] initializeHair()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(HAIR_ENUM)).Length];
            clothing[(int)HAIR_ENUM.CURLY_PURPLE] = new Clothing("Wavy Purple Hair", Properties.Resources.hair_curly_purple);
            clothing[(int)HAIR_ENUM.BRAIDS_BROWN] = new Clothing("Brown Braids Bun", Properties.Resources.hair_brown_bun);
            clothing[(int)HAIR_ENUM.PIXIE_BLOND] = new Clothing("Blond Pixie Cut", Properties.Resources.hair_pixie_blond);


            return clothing;
        }

        private static Clothing[] initializeGlasses()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(GLASSES_ENUM)).Length];
            clothing[(int)GLASSES_ENUM.RED_AND_GOLD] = new Clothing("Red and Gold Glasses", Properties.Resources.glasses_gold_and_red);
            clothing[(int)GLASSES_ENUM.SUNGLASSES_BLACK] = new Clothing("Sunglasses", Properties.Resources.glasses_sun_black);


            return clothing;
        }

        private static Clothing[] initializeShoes()
        {

            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(SHOES_ENUM)).Length];
            clothing[(int)SHOES_ENUM.CLOGS_BROWN] = new Clothing("Brown Clogs", Properties.Resources.shoes_clogs_brown);
            return clothing;
        }

        private static Clothing[] initializeSocks()
        {

            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(SOCKS_ENUM)).Length];
            clothing[(int)SOCKS_ENUM.PINK] = new Clothing("Pink Socks", Properties.Resources.socks_pink);
            return clothing;
        }


    }

}
