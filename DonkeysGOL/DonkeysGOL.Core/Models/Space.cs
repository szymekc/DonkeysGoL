using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;

namespace DonkeysGOL.Core.Models
{
    public class Space
    {

        public const int SPACE_SIZE = 100;

        public bool[,] SpaceArray;

        uint CountNeighborhood(int x, int y)
        {
            uint count = 0;

            for (int i = x - 1; i <= x + 1; ++i)
            {
                for (int j = y - 1; j <= y + 1; ++y)
                {
                    if (i == x && j == y)
                        continue;

                    if (getCell(i, j))
                        ++count;
                }
            }

            return count;
        }

        void InitSpace(int seed)
        {
            Random rGenerator = new Random(seed);
            SpaceArray = new bool[SPACE_SIZE, SPACE_SIZE];
            for (int i = 0; i < SPACE_SIZE; i++)
            {
                for (int j = 0; j < SPACE_SIZE; j++)
                {
                    SpaceArray[i, j] = rGenerator.NextDouble() > 0.5;
                }
            }
        }
        public Space(int seed)
        {
            InitSpace(seed);
        }

        public Space()
        {
            Random rSeed = new Random();
            InitSpace(rSeed.Next());
        }

        private bool getCell(int x, int y)
        {
            x = adjustToSize(x, SPACE_SIZE);
            y = adjustToSize(y, SPACE_SIZE);

            return SpaceArray[x, y];
        }

        private int adjustToSize(int index, int size)
        {
            if (index >= 0)
                return (index % size);
            else
                return size + (index % size);
        }
    }
}
