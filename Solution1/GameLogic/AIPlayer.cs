using System;
using System.Collections.Generic;

namespace GameLogic
{
    internal class AIPlayer
    {
        private readonly Random m_rand = new Random();
        private ePlayerSymbol m_Symbol;
        private int m_Score;
        public ePlayerSymbol Symbol
        {
            get
            {
                return m_Symbol;
            }
            set
            {
            }
        }
        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
            }
        }
        public AIPlayer()
        {
            m_Symbol = ePlayerSymbol.X;
            m_Score = 0;
        }

        public Move GenerateRandomMove(Board i_GameBoard)
        {
            List<Move> availableMoves = i_GameBoard.GetAllAvailableMoves();
            int randIndex = m_rand.Next(availableMoves.Count);

            return availableMoves[randIndex];
        }
        public void IncreaseScore()
        {
            m_Score += 1;
        }
    }
}
