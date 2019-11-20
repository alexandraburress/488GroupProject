using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Test003
{
    public class Hero
    {
        public enum DistinctClothingPieces
        {
            SHIRT,
            PANTS
        }

        public Hero()
        {
            Name = "Henry";
            Nickname = "Henriettas";
            Body = Properties.Resources.Henry001;

            //Will access the positions in this array bassed on DistinctClothing Pieces ENUM
            Outfit = new Clothing[2];
            Outfit[(int)DistinctClothingPieces.SHIRT] = new Clothing("Purple Shirt", Properties.Resources.test_shitA);
            Outfit[(int)DistinctClothingPieces.PANTS] = new Clothing("Test Pants", Properties.Resources.test_pantsA);



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

        private Bitmap dressHero()
        {
            Bitmap newHero = (Bitmap)Body.Clone();
            foreach (Clothing piece in Outfit)
            {
                
                

            }

            return newHero;
        }
        
        

    }
}
