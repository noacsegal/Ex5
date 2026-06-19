using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Move
    {
        public int m_Row;
        public int m_Col;
        public Move(int i_Row, int i_Col)
        {
            m_Col = i_Col;
            m_Row = i_Row;
        }
    }
}
