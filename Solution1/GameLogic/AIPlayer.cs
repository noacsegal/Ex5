using System;
using System.Collections.Generic;

namespace GameLogic
{
    internal class AIPlayer
    {
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
       
        
        public void IncreaseScore()
        {
            m_Score += 1;
        }
    }
}
