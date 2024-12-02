using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Ants95
{
    static public class Static
    {
        static public Random rnd = new Random();
        static public string filePath = "C:\\Users\\admin\\Desktop\\Git\\Ants95\\Ants95\\table.png";
        
        static public int SIZE_X = 100;
        static public int SIZE_Y = 100;

        static public int SIZE_dX = SIZE_X - 1;
        static public int SIZE_dY = SIZE_Y - 1;
    }

    public class Programs
    {

        static public char[,]? table;


        static void Main()
        {
            Ants95 ant = new Ants95();
            ant.SetPosition(3231, 22);
            Console.WriteLine(ant.position.ToString());

            //table = Table.GenEmptyTable(Static.SIZE_X, Static.SIZE_Y);
            //table[Static.SIZE_X, Static.SIZE_Y] = 'x';
            //Table.DrawTable(table);
            ////SaveAsImage(table, filePath, 1);
        }
         

    }
}
