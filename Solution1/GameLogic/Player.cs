using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum ePlayerSymbol
    {
        Space,
        X,
        O
    }
    public class Player
    {
        private ePlayerSymbol m_Symbol;
        private int m_Score;
        private bool m_IsAIPlayer;
        private readonly Random m_rand = new Random();

        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
                m_Score = value;
            }
        }
        public bool IsAIPlayer
        {
            get { return m_IsAIPlayer; }
            set { m_IsAIPlayer = value; }
        }

        public ePlayerSymbol Symbol
        {
            get
            {
                return m_Symbol;
            }
            set
            {
                m_Symbol = value;
            }
        }
        public Player(ePlayerSymbol i_Symbol, bool i_isAIPlayer)
        {
            m_Symbol = i_Symbol;
            m_Score = 0;
            m_IsAIPlayer = i_isAIPlayer;
        }
        public void IncreaseScore()
        {
            m_Score += 1;
        }
        public Move GenerateRandomMove(Board i_GameBoard)
        {
            List<Move> availableMoves = i_GameBoard.GetAllAvailableMoves();
            int randIndex = m_rand.Next(availableMoves.Count);

            return availableMoves[randIndex];
        }
    }
}
