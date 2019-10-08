using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Test003
{
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

    }

}
