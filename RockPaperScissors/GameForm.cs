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
    public partial class GameForm : Form
    {
        GameControl gameControl = new GameControl();
        RockPaperScissorsGame game = new RockPaperScissorsGame();

        public GameForm()
        {
            InitializeComponent();
            gameControl.userSelected += onUserSelection;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            gameLayoutPanel.Controls.Clear();
            game.StartGame();
            setPlayerPoints(0, 0);
            gameLayoutPanel.Controls.Add(gameControl);
        }

        private void onUserSelection(object sender, GameOption selection)
        {
            gameLayoutPanel.Controls.Clear();
            game.PlayRound(selection);
            RoundResultsControl roundResultsControl = new RoundResultsControl(game.lastOptionPlayer1, game.lastOptionPlayer2, game.gameInProgress);
            roundResultsControl.OnButtonClicked += onRoundResultButtonClicked;

            gameLayoutPanel.Controls.Clear();
            gameLayoutPanel.Controls.Add(roundResultsControl);

            setPlayerPoints(game.player1Points, game.player2Points);
        } 

        private void onRoundResultButtonClicked(object sender, string buttonType)
        {
            if (buttonType == "finish")
            {
                gameLayoutPanel.Controls.Clear();
                game.ResetGame();
                setPlayerPoints(0, 0);
            } else
            {
                gameLayoutPanel.Controls.Clear();
                gameLayoutPanel.Controls.Add(gameControl);
            }
        }

        private void setPlayerPoints(int player1Points, int player2Points)
        {
            this.player1Points.Text = player1Points.ToString();
            this.player2Points.Text = player2Points.ToString();
        }
    }
}
