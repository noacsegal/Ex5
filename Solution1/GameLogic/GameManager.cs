using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum eGameType
    {
        player = 0,
        computer = 1
    }
    internal class GameManager
    {
        private Board m_GameBoard;
        private eGameType m_GameType = 0;
        private static bool s_QuitGame = false;

        public static bool QuitGame
        {
            get
            {
                return s_QuitGame;
            }
            set
            {
                s_QuitGame = value;
            }
        }

        //public void StartGame(int i_BoardSize)
        //{
        //    int boardSize = i_BoardSize;

        //    if (!s_QuitGame)
        //    {
        //        m_GameBoard = new Board(boardSize);
        //        Player player1 = new Player(ePlayerSymbol.O);
        //        Player player2 = new Player(ePlayerSymbol.X);
        //        AIPlayer playerAI = new AIPlayer();

        //        if (!s_QuitGame)
        //        {

        //            if (m_GameType == eGameType.player)
        //            {
        //                RunTwoPlayers(player1, player2);
        //            }
        //            else
        //            {
        //                RunPlayerVsComputer(player1, playerAI);
        //            }
        //            if (!s_QuitGame)
        //            {
        //                playGame = InputManager.AnotherGame();
        //                m_GameBoard = new Board(boardSize);
        //            }
        //            else
        //            {
        //                playGame = false;
        //            }
        //        }
        //    }
        //}

        //// $G$ DSN-004 (-10) Code duplication. This method and RunPlayerVsComputer() method shares the same game loop structure.
        //// The cause of this problem is becasue of the AIPlayer class. Since in this assignment the AIPlayer class do not have any real functionality,
        //// it would be better to remove that class and move the GenerateRandomMove() method from AIPlayer class to this class.
        //// and add a condition in the game loop to check if player 2 is computer and then call GenerateRandomMove() method.
        //public void RunPlayerVsComputer(Player i_Player1, AIPlayer i_Player2)
        //{
        //    ePlayerSymbol? gameWinner = null;
        //    bool isBoardFull = false;
        //    DisplayManager.PrintBoard(m_GameBoard);
        //    while (!s_QuitGame && gameWinner == null && !isBoardFull)
        //    {
        //        if (!UpdatePlayerMoveOnBoard(i_Player1, 1))
        //        {
        //            DisplayManager.PrintBoard(m_GameBoard);
        //            gameWinner = m_GameBoard.GetGameWinner();
        //            isBoardFull = m_GameBoard.IsBoardFull();

        //            if (gameWinner == null && !isBoardFull)
        //            {
        //                UpdateAIPlayerMoveOnBoard(i_Player2, 2);
        //                DisplayManager.PrintBoard(m_GameBoard);
        //                gameWinner = m_GameBoard.GetGameWinner();
        //                isBoardFull = m_GameBoard.IsBoardFull();
        //            }
        //        }
        //    }
        //    if (gameWinner != null)
        //    {
        //        if (gameWinner == ePlayerSymbol.O)
        //        {
        //            i_Player1.IncreaseScore();
        //        }
        //        else if (gameWinner != null)
        //        {
        //            i_Player2.IncreaseScore();
        //        }
        //    }

        //    DisplayManager.PrintEndScreen(gameWinner, s_QuitGame);
        //    if (!s_QuitGame)
        //    {
        //        DisplayManager.PrintScore(i_Player1.Score, i_Player2.Score, "Computer");
        //    }
        //}
        //public void RunTwoPlayers(Player i_Player1, Player i_Player2)
        //{
        //    ePlayerSymbol? gameWinner = null;
        //    bool isBoardFull = false;
        //    DisplayManager.PrintBoard(m_GameBoard);
        //    while (!s_QuitGame && gameWinner == null && !isBoardFull)
        //    {
        //        if (!UpdatePlayerMoveOnBoard(i_Player1, 1))
        //        {
        //            DisplayManager.PrintBoard(m_GameBoard);
        //            gameWinner = m_GameBoard.GetGameWinner();
        //            isBoardFull = m_GameBoard.IsBoardFull();

        //            if (gameWinner == null && !isBoardFull)
        //            {
        //                if (!UpdatePlayerMoveOnBoard(i_Player2, 2))
        //                {
        //                    DisplayManager.PrintBoard(m_GameBoard);
        //                    gameWinner = m_GameBoard.GetGameWinner();
        //                    isBoardFull = m_GameBoard.IsBoardFull();
        //                }
        //            }
        //        }
        //    }
        //    if (gameWinner != null)
        //    {
        //        if (gameWinner == ePlayerSymbol.O)
        //        {
        //            i_Player1.IncreaseScore();
        //        }
        //        else if (gameWinner != null)
        //        {
        //            i_Player2.IncreaseScore();
        //        }
        //    }


        //    DisplayManager.PrintEndScreen(gameWinner, s_QuitGame);
        //    if (!s_QuitGame)
        //    {
        //        DisplayManager.PrintScore(i_Player1.Score, i_Player2.Score, "Player 2");
        //    }
        //}

        //public bool UpdatePlayerMoveOnBoard(Player i_Player, int i_NumOfPlayer)
        //{
        //    bool isQuit = false;
        //    InputManager.GetPosition(i_NumOfPlayer, m_GameBoard.BoardSize, out int numInRow, out int numInCol);
        //    if (numInCol != -1 && numInRow != -1)
        //    {
        //        Move placeInMatPlayer1 = new Move(numInRow - 1, numInCol - 1);

        //        while (!m_GameBoard.CheckValidMove(placeInMatPlayer1) && !isQuit)
        //        {
        //            DisplayManager.PrintInvalidCellMessage();
        //            InputManager.GetPosition(i_NumOfPlayer, m_GameBoard.BoardSize, out numInRow, out numInCol);
        //            if (numInCol != -1 && numInRow != -1)
        //            {
        //                placeInMatPlayer1 = new Move(numInRow - 1, numInCol - 1);
        //            }
        //            else
        //            {
        //                isQuit = true;
        //            }
        //        }
        //        m_GameBoard.UpdateMove(placeInMatPlayer1, i_Player.Symbol);
        //    }
        //    else
        //    {
        //        isQuit = true;
        //    }

        //    return isQuit;
        //}

        public void UpdateAIPlayerMoveOnBoard(AIPlayer i_Player, int i_NumberOfPlayer)
        {
            Move placeOnBoard = i_Player.GenerateRandomMove(m_GameBoard);
            m_GameBoard.UpdateMove(placeOnBoard, i_Player.Symbol);
        }
    }
}
