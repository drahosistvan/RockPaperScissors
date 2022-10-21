using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RockPaperScissorsGame
    {
        public bool gameInProgress { get; internal set; }
        public int player1Points { get; internal set; }
        public int player2Points { get; internal set; }
        public GameOption lastOptionPlayer1 { get; internal set; }
        public GameOption lastOptionPlayer2 { get; internal set; }
        public Shape lastShapePlayer1 { get; internal set; }
        public Shape lastShapePlayer2 { get; internal set; }
        public string resultMessage { get; internal set; }

        public RockPaperScissorsGame()
        {
            gameInProgress = false;
            player1Points = 0;
            player2Points = 0;
        }

        public bool PlayRound(GameOption player1Option)
        {
            lastOptionPlayer1 = player1Option;
            lastOptionPlayer2 = generateComputerOption();

            lastShapePlayer1 = determinePlayerShape(lastOptionPlayer1);
            lastShapePlayer2 = determinePlayerShape(lastOptionPlayer2);

            if (!gameInProgress)
            {
                return false;
            }

            int winner = determineWinner(lastOptionPlayer1, lastOptionPlayer2);
            Console.WriteLine("Winner: " + winner.ToString());

            resultMessage = "Döntetlen! Ebben a körben senki nem kapott pontot.";
            switch (winner)
            {
                case -1:
                    player2Points++;
                    resultMessage = "Ezt a kört a gép nyerte!";
                    break;
                case 1:
                    player1Points++;
                    resultMessage = "Ezt a kört a játékos nyerte!";
                    break;
                    
            }

            if (player1Points >= 2 || player2Points >= 2)
            {
                gameInProgress = false;
            }

            return true;
        }

        public void StartGame()
        {
            gameInProgress = true;
        }

        public void ResetGame()
        {
            gameInProgress = false;
            player1Points = 0;
            player2Points = 0;
        }

        private GameOption generateComputerOption()
        {
            int random = new Random().Next(0, 2);
            GameOption gameOption;
            Enum.TryParse(random.ToString(), out gameOption);
            return gameOption;
        }

        /*
         -1: player2 won
          0: draw
          1: player1 won
         */
        private int determineWinner(GameOption player1Option, GameOption player2Option)
        {
            if (player1Option == player2Option)
            {
                return 0;
            }

            switch (player1Option)
            {
                case GameOption.Paper:
                    return (player2Option == GameOption.Rock) ? 1 : -1;

                case GameOption.Rock:
                    return (player2Option == GameOption.Scissors) ? 1 : -1;

                case GameOption.Scissors:
                    return (player2Option == GameOption.Paper) ? 1 : -1;
            }

            return -1;
        }

        private Shape determinePlayerShape(GameOption fromGameOption)
        {
            switch (fromGameOption)
            {
                case GameOption.Paper:
                    return new Paper();

                case GameOption.Rock:
                    return new Rock();

                default:
                    return new Scissors();
            }
        }

    }
}
