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
            checkIfCoordsAreValid(x, y, "CountNeighborhood");

            return count(x, y);
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
        
        private void checkIfCoordsAreValid(int x, int y, string methodName)
        {
            string errorMessage = "Wrong parameter's value in " + methodName + " method!";

            if (x < 0 || x >= SpaceArray.GetLength(0))
                throw new ArgumentOutOfRangeException("x", errorMessage);

            if (y < 0 || y >= SpaceArray.GetLength(1))
                throw new ArgumentOutOfRangeException("y", errorMessage);
        }

        private uint count(int x, int y)
        {
            uint counter = 0;

            for (int i = x - 1; i <= x + 1; ++i)
            {
                for (int j = y - 1; j <= y + 1; ++j)
                {
                    if (i == x && j == y)
                        continue;

                    if (getCell(i, j))
                        ++counter;
                }
            }

            return counter;
        }

        private bool getCell(int x, int y)
        {
            x = adjustToSize(x, SpaceArray.GetLength(0));
            y = adjustToSize(y, SpaceArray.GetLength(1));

            return SpaceArray[x, y];
        }

        private int adjustToSize(int index, int size)
        {
            return (index + size) % size;              
        }
    }
}
