using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Draw
    {
        #region Drawing Methods

        /// <summary>
        /// Прорисовка поля.
        /// </summary>
        public void DrawBoard(char[] arrayTable)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[1], arrayTable[2], arrayTable[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[4], arrayTable[5], arrayTable[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[7], arrayTable[8], arrayTable[9]);
            Console.WriteLine("     |     |      ");
        }

        #endregion
    }
}
