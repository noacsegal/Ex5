using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class CellChangedEventArgs
    {
        private readonly int m_Row;
        private readonly int m_Col;
        private readonly ePlayerSymbol m_Symbol;

        public int Row
        {
            get { return m_Row; }
        }
        public int Col
        {
            get { return m_Col; }
        }
        public ePlayerSymbol Symbol
        {
            get { return m_Symbol; }
        }

        public CellChangedEventArgs(int i_Row, int i_Col, ePlayerSymbol i_Symbol)
        {
            m_Row = i_Row;
            m_Col = i_Col;
            m_Symbol = i_Symbol;
        }
    }
}
