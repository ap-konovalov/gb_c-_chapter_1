using System;

namespace Lesson2
{
    enum Days
    {
        Pn = 1,
        Vt,
        Sr,
        Cht,
        Pt,
        Sb,
        Vs
    }

    enum LvlGame
    {
        Easy = 10,
        Medium = 30,
        Hard = 100
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select game level from 1 to 3");
            var templvl = Convert.ToByte(Console.ReadLine());

            LvlGame lvl;

            switch (templvl)
            {
                case 1: lvl = LvlGame.Easy; break;
                case 2: lvl = LvlGame.Medium; break;
                case 3: lvl = LvlGame.Hard; break;
                default: lvl = LvlGame.Easy; break;
            }

            Console.WriteLine((int)lvl);

            //var day = Convert.ToByte(Console.ReadLine());

            //#region Switch

            //switch (day)
            //{
            //    case 1: Console.WriteLine("Пн"); break;
            //    case 2: Console.WriteLine("Вт"); break;
            //    case 3:
            //    case 4:
            //    case 5: Console.WriteLine("Ср,Чт,Пт"); break;
            //    default:Console.WriteLine("Такого дня нет");
            //        break;
            //}
            //#endregion

            //Console.WriteLine((Days)day);


        }
    }
}
