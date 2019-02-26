using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_TankFight.World_of_Tanks;
namespace HW_TankFight
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] T_34 = new Tank[5];
            T_34[0] = new Tank("T_34-1");
            T_34[1] = new Tank("T_34-2");
            T_34[2] = new Tank("T_34-3");
            T_34[3] = new Tank("T_34-4");
            T_34[4] = new Tank("T_34-5");
            Tank[] Pantera = new Tank[5];
            Pantera[0] = new Tank("Пантера-1");
            Pantera[1] = new Tank("Пантера-2");
            Pantera[2] = new Tank("Пантера-3");
            Pantera[3] = new Tank("Пантера-4");
            Pantera[4] = new Tank("Пантера-5");
            for (int i = 0; i < 5; i++)
            {
                if ((T_34[i] * Pantera[i]) == true)
                {
                    System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Победили Т_34");
                    System.Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Победили Пантеры");
                    System.Console.ForegroundColor = ConsoleColor.White;

                }
            }

        }
    }
}
