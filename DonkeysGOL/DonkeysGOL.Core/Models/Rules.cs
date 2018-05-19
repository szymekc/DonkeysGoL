using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeysGOL.Core.Models
{
    //If a cell becomes alive/dead, the methods return true/false
    //If the method does not affect a cell, it returns null
   public static class Rules
    {

        public static Nullable<bool> Underpopulation(int x, int y, ref Space space)
        {
            if (space.SpaceArray[x,y] && space.CountNeighborhood(x, y) < 2)
                return false;
            else
                return null;
        }

        public static Nullable<bool> NextGeneration(int x, int y, ref Space space)
        {
            int neighbours = space.CountNeighborhood(x, y);
            if (space.SpaceArray[x, y] && (neighbours == 2 || neighbours == 3))
                return true;
            else
                return null;
        }

        public static Nullable<bool> Overpopulation(int x, int y, ref Space space)
        {
            if (space.SpaceArray[x, y] && space.CountNeighborhood(x, y) > 3)
                return false;
            else
                return null;
        }

        public static Nullable<bool> Reproduction(int x, int y, ref Space space)
        {
            if (space.SpaceArray[x, y] == false && space.CountNeighborhood(x, y) == 3)
                return true;
            else
                return null;
        }

    }
}
