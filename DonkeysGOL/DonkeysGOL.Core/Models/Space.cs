using System;
namespace DonkeysGOL.Core.Models
{
    public class Space
    {
        public bool[,] SpaceArray;

        
      
        public Space()
        {
            Random rSeed = new Random();
            InitSpace(50, rSeed.Next()); //default size is 50x50
        }
        public Space(int size)
        {
            Random rSeed = new Random();
            InitSpace(size, rSeed.Next());
        }
        public Space(int size, int seed)
        {
            InitSpace(size, seed);
        }

        public uint CountNeighborhood(int x, int y)
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

        
        void InitSpace(int size, int seed)
        {
            Random rGenerator = new Random(seed);
            SpaceArray = new bool[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    SpaceArray[i, j] = rGenerator.NextDouble() > 0.5;
                }
            }
        }        
        private bool getCell(int x, int y)
        {
            x = adjustToSize(x, SpaceArray.GetLength(0));
            y = adjustToSize(y, SpaceArray.GetLength(1));

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
