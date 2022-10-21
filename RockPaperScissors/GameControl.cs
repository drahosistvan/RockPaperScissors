using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public delegate void PlayerOptionClicked(object source, GameOption option);

    public partial class GameControl : UserControl
    {
        public event PlayerOptionClicked userSelected;
        public GameControl()
        {
            InitializeComponent();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            userSelected.Invoke(this, GameOption.Rock);
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            userSelected.Invoke(this, GameOption.Paper);
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            userSelected.Invoke(this, GameOption.Scissors);
        }
    }
}
