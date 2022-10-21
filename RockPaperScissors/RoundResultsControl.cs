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
    public delegate void ResultsButtonClicked(object source, string buttonType);

    public partial class RoundResultsControl : UserControl
    {
        public event ResultsButtonClicked OnButtonClicked;
        public RoundResultsControl(GameOption player1Option, GameOption player2Option, bool isGameInProgress)
        {
            InitializeComponent();

            if (isGameInProgress)
            {
                continueGameButton.Show();
                finishGameButton.Hide();
            } else
            {
                continueGameButton.Hide();
                finishGameButton.Show();
            }

            player1ResultText.Text = player1Option.ToString();
            player2ResultText.Text = player2Option.ToString();
        }

        private void continueGameButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked.Invoke(this, "continue");
        }

        private void finishGameButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked.Invoke(this, "finish");
        }
    }
}
