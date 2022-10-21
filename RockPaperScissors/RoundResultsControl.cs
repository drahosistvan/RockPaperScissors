using RockPaperScissors.Models;
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
        public RoundResultsControl(Shape player1Option, Shape player2Option, bool isGameInProgress, string resultMessage = "")
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

            player1ResultText.Text = player1Option.Name;
            player1Picture.Image = player1Option.Image;

            player2ResultText.Text = player2Option.Name;
            player2Picture.Image = player2Option.Image;

            this.resultMessage.Text = resultMessage;   
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
