using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////// Déclaration de variables ////////////////////////////////////////////

            string droneVivant = "x-O-x";
            string droneMort = "_____";
            int nvBatterieDebut = 0;
            int nvBatterie = 100;
            int Pos_x = 0;

            const int PERTE_DE_VIE = 2;
            const int POS_Y = 10;


            ////////////////////////////////////////// Début du programme ////////////////////////////////////////////////////


            while (nvBatterie > 0)
            {


                Console.Clear();

                Pos_x++;
                Console.SetCursorPosition(Pos_x, POS_Y);
                Console.WriteLine(droneVivant);

                nvBatterie = nvBatterie - 2;
                Thread.Sleep(100);

            }

            Console.Clear();
            Console.SetCursorPosition(Pos_x, POS_Y);
            Console.WriteLine(droneMort);



        }
    }
}
