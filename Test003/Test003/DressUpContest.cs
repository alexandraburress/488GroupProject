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

        public DressUpContest(Minigame minigame)
        {
            InitializeComponent();
            this.minigame = minigame;
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
    }
}
