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
    public partial class Map : Form
    {
        Story glamorLairStory =GameData.initilizeGlamorHobosAdventure();

        public Map()
        {
            InitializeComponent();
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
    }
}
