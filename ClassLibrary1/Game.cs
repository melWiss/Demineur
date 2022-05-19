using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public enum Level { Beginner = 10, Intermediate = 20, Advanced = 40 };
    public class Game
    {
        #region attributes,getters and setters
        public int Bombs { get; private set; }
        public int Lines { get; private set; }
        public int Columns { get; private set; }
        public int[,] Grid { get; private set; }

        #endregion

        #region constructors
        public Game(Level level)
        {
            Bombs = (int)level;
            switch (level)
            {
                case Level.Beginner:
                    Lines = 9;
                    Columns = 9;
                    break;
                case Level.Intermediate:
                    Lines = 12;
                    Columns = 12;
                    break;
                case Level.Advanced:
                    Lines = 16;
                    Columns = 16;
                    break;
            }
            Grid = new int[Lines, Columns];
            initGrid();
        }
        #endregion

        #region methodes
        /// <summary>
        /// placement des bombes
        /// </summary>
        private void initBombs()
        {
            Random rnd = new Random();
            int nb = 1;
            int i, j;
            while (nb <= Bombs)
            {
                i = rnd.Next(Lines);
                j = rnd.Next(Columns);
                if (Grid[i, j] != 9)
                {
                    Grid[i, j] = 9;
                    nb++;
                }
            }
        }
        /// <summary>
        /// initialisation de grid 
        /// </summary>
        private void initGrid()
        {
            initBombs();
        }
        #endregion
    }
}
