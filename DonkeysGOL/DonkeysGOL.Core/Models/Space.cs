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

        int CountNeighborhood()
        {
            throw new NotImplementedException();
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

    }
}
