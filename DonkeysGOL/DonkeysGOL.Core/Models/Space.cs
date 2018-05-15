using System;
namespace DonkeysGOL.Core.Models
{
    public class Space
    {

        public const int SPACE_SIZE = 100;

        public bool[,] SpaceArray;
       
        public int CountNeighborhood(int x, int y)
        {
            throw new NotImplementedException();
        }
      
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

        public bool[,] SpaceArray;
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
    }
}
