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
        HAIR
    }

    public enum SHIRTSENUM
    {
        WEAVY_BLUE, MAGIC_BLACK

    }

    public enum PANTSENUM
    {
        SKIRT_BLUE

    }

    public enum FACES_ENUM
    {
        DERP,ANIME,REALISITC
    }

    public enum HAIR_ENUM
    {
        CURLY_PURPLE,BRAIDS_BROWN,PIXIE_BLOND
    }


              

    public class Clothing
    {

        
        public Clothing(string name, Bitmap image)
        {
            Name = name;
            Image = image;

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


        //holding an array backed by an enum for each clothing item

        public static Clothing[] Faces
        {
            get { return initilizeFaces(); }
        }

        public static Clothing[] Shirts
        {
            get { return initilizeShirts(); }

        }

        public static Clothing[] Pants
        {
            get { return initilizePants(); }

        }
        public static Clothing[] Hair
        {
            get { return initilizeHair(); }

        }

        //intilizing the items in the clothing arrays

        private static Clothing[] initilizeFaces()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(FACES_ENUM)).Length];
            clothing[(int)FACES_ENUM.DERP] = new Clothing("Derp Face", Properties.Resources.face_derp_001);
            clothing[(int)FACES_ENUM.ANIME] = new Clothing("Anime Face", Properties.Resources.face_anime_001);
            clothing[(int)FACES_ENUM.REALISITC] = new Clothing("Realistic Face", Properties.Resources.face_realistic_001);


            return clothing;
        }


        private static Clothing[] initilizeShirts()
        {
            Clothing[] shirts = new Clothing[(int)Enum.GetNames(typeof(SHIRTSENUM)).Length];
            shirts[(int)SHIRTSENUM.WEAVY_BLUE] = new Clothing("Wavy Blue Shirt", Properties.Resources.shirt_wavy_blue);
            shirts[(int)SHIRTSENUM.MAGIC_BLACK] = new Clothing("Magic Black Shirt", Properties.Resources.shirt_magicGirlTop001);


            return shirts;
        }

        private static Clothing[] initilizePants()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(PANTSENUM)).Length];
            clothing[(int)SHIRTSENUM.WEAVY_BLUE] = new Clothing("Blue Skirt", Properties.Resources.pants_skirt_blue);


            return clothing;
        }
        private static Clothing[] initilizeHair()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(HAIR_ENUM)).Length];
            clothing[(int)HAIR_ENUM.CURLY_PURPLE] = new Clothing("Wavy Purple Hair", Properties.Resources.hair_curly_purple);
            clothing[(int)HAIR_ENUM.BRAIDS_BROWN] = new Clothing("Brown Braids Bun", Properties.Resources.hair_brown_bun);
            clothing[(int)HAIR_ENUM.PIXIE_BLOND] = new Clothing("Blond Pixie Cut", Properties.Resources.hair_pixie_blond);


            return clothing;
        }



    }

}
