using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class GameLogic
    {
        #region Game Logic Methods

        /// <summary>
        /// Проверка на выйгрышь.
        /// </summary>
        /// <returns>Победа, ничья.</returns>
        public int CheckWin(char[] arrayTable)
        {
            if ((arrayTable[1] == arrayTable[2] && arrayTable[2] == arrayTable[3]) && (arrayTable[1] != ' ' && arrayTable[2] != ' ' && arrayTable[3] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[4] == arrayTable[5] && arrayTable[5] == arrayTable[6]) && (arrayTable[4] != ' ' && arrayTable[5] != ' ' && arrayTable[6] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[6] == arrayTable[7] && arrayTable[7] == arrayTable[8]) && (arrayTable[6] != ' ' && arrayTable[7] != ' ' && arrayTable[8] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[1] == arrayTable[4] && arrayTable[4] == arrayTable[7]) && (arrayTable[1] != ' ' && arrayTable[4] != ' ' && arrayTable[7] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[2] == arrayTable[5] && arrayTable[5] == arrayTable[8]) && (arrayTable[2] != ' ' && arrayTable[5] != ' ' && arrayTable[5] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[3] == arrayTable[6] && arrayTable[6] == arrayTable[9]) && (arrayTable[3] != ' ' && arrayTable[6] != ' ' && arrayTable[9] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[1] == arrayTable[5] && arrayTable[5] == arrayTable[9]) && (arrayTable[1] != ' ' && arrayTable[5] != ' ' && arrayTable[9] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[3] == arrayTable[5] && arrayTable[5] == arrayTable[7]) && (arrayTable[3] != ' ' && arrayTable[5] != ' ' && arrayTable[7] != ' '))
            {
                return 1;
            }
            else if (arrayTable[1] != ' ' && arrayTable[2] != ' ' && arrayTable[3] != ' ' && arrayTable[4] != ' ' && arrayTable[5] != ' ' && arrayTable[6] != ' ' && arrayTable[7] != ' ' && arrayTable[8] != ' ' && arrayTable[9] != ' ')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}
