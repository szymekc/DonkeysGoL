using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonkeysGOL.Console.View;
using DonkeysGOL.Core.Models;

namespace DonkeysGOL.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            var game = new Game();

<<<<<<< HEAD
            game.Space = new Space();

            game.Space.SpaceArray = new bool[5, 4] { { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false } };
           
            CrudeRenderer.RenderSpace(game.Space);

=======
            var spacedd = new Space();

            spacedd.SpaceArray = new bool[5, 4] { { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false } };
           
            CrudeRenderer.RenderSpace(spacedd);
>>>>>>> d7749598be2d0c257095875718cdc0a65d095fc5
            System.Console.ReadKey();
        }


    }



}

