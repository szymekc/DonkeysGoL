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

            var spacedd = new Space();

            spacedd.SpaceArray = new bool[5, 4] { { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false }, { true, false, true, false } };
           
            CrudeRenderer.RenderSpace(spacedd);
            System.Console.ReadKey();
        }


    }



}

