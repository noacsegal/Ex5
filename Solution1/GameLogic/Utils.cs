using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    internal class Utils
    {
        public static char ConvertEnumToChar(ePlayerSymbol? i_Symbol)
        {
            char symbolChar = ' ';

            if (i_Symbol == ePlayerSymbol.X)
            {
                symbolChar = 'X';
            }
            else if (i_Symbol == ePlayerSymbol.O)
            {
                symbolChar = 'O';
            }

            return symbolChar;
        }
    }
}
