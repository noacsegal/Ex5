using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
    public class GameManager
    {
        private Board m_GameBoard;
        private Player m_Player1;
        private Player m_Player2;
        private Player m_CurrentPlayer;
        private int m_BoardSize;
        private eGameType m_GameType = 0;
        private string m_Player1Name;
        private string m_Player2Name;

        public event Action ScoreChanged;
        public event Action<CellChangedEventArgs> CellChanged;
        public event Action<string, string> GameEnd;

        public Player Player1
        {
            get { return m_Player1; }
        }
        public Player Player2
        {
            get { return m_Player2; }
        }

        public void StartGame(int i_BoardSize, bool i_IsAIPlayer, string i_Player1Name, string i_Player2Name)
        {
            m_BoardSize = i_BoardSize;
            m_GameBoard = new Board(i_BoardSize);
            m_Player1 = new Player(ePlayerSymbol.O, false);
            m_Player2 = new Player(ePlayerSymbol.X, i_IsAIPlayer);
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            m_CurrentPlayer = m_Player1;
            m_GameType = i_IsAIPlayer ? eGameType.computer : eGameType.player;
        }


        public void RunTwoPlayers(int i_Row, int i_Col)
        {
            ePlayerSymbol? gameWinner = null;
            bool isBoardFull = false;

            gameWinner = m_GameBoard.GetGameWinner();
            isBoardFull = m_GameBoard.IsBoardFull();
            if (gameWinner != null || isBoardFull)
            {
                return;
            }
            UpdatePlayerMoveOnBoard(m_CurrentPlayer,1, i_Row, i_Col);
            gameWinner = m_GameBoard.GetGameWinner();
            isBoardFull = m_GameBoard.IsBoardFull();
            if (gameWinner == null && !isBoardFull)
            {
                if (m_GameType == eGameType.computer)
                {
                    m_CurrentPlayer = m_Player2;
                    UpdatePlayerMoveOnBoard(m_CurrentPlayer,2, i_Row, i_Col);
                    gameWinner = m_GameBoard.GetGameWinner();
                    isBoardFull = m_GameBoard.IsBoardFull();
                    m_CurrentPlayer = m_Player1;
                }
                else
                {
                    m_CurrentPlayer = (m_CurrentPlayer == m_Player1) ? m_Player2 : m_Player1;
                }
            }
            if (gameWinner != null)
            {
                string winnerName = "";
                if (gameWinner == ePlayerSymbol.O)
                {
                    m_Player1.IncreaseScore();
                    winnerName = m_Player1Name;

                }
                else if (gameWinner != null)
                {
                    m_Player2.IncreaseScore();
                    winnerName = m_Player2Name;
                }
                ScoreChanged?.Invoke();
                GameEnd?.Invoke($"The winner is {winnerName}!", "A Win!");
            }
            else if (isBoardFull)
            {
                GameEnd?.Invoke("Tie!", "A Tie!");
            }
        }

        public void ResetGameRound()
        {
            m_GameBoard = new Board(m_BoardSize);
            m_CurrentPlayer = m_Player1;
        }

        public void UpdatePlayerMoveOnBoard(Player i_Player, int i_NumOfPlayer, int i_Row, int i_Col)
        {
            if (i_Player.IsAIPlayer)
            {
                Move placeOnBoard = i_Player.GenerateRandomMove(m_GameBoard);
                m_GameBoard.UpdateMove(placeOnBoard, i_Player.Symbol);
                CellChangedEventArgs cellChangedArgs = new CellChangedEventArgs(placeOnBoard.m_Row, placeOnBoard.m_Col, i_Player.Symbol);
                CellChanged?.Invoke(cellChangedArgs);
            }
            else
            {
                Move placeInMatPlayer = new Move(i_Row, i_Col);
                m_GameBoard.UpdateMove(placeInMatPlayer, i_Player.Symbol);
                CellChangedEventArgs cellChangedArgs = new CellChangedEventArgs(i_Row, i_Col, i_Player.Symbol);
                CellChanged?.Invoke(cellChangedArgs);
            }
        }
    }
}
