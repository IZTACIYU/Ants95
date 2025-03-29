using System.Diagnostics;
using static Ants95.Vector;

namespace Ants95
{
    static public class Static
    {
        static public Random rnd = new Random();
        static public string filePath = "table.png";    // 상대경로 대체 어케함???

        static public int SIZE_X = 100;
        static public int SIZE_Y = 100;

        static public int DELTA_X = SIZE_X - 1;
        static public int DELTA_Y = SIZE_Y - 1;
    }

    public class Programs
    {
        static void Main()
        {
            char[,] table = Table.GenEmptyTable(Static.SIZE_X, Static.SIZE_Y);

            Ants95 ant = new Ants95(Func_0, table);
            ant.SetPosition(Vector2.center);

            Console.ReadLine();
            int i = 0;

            while(true)
            {
                i++;

                ant.Logics();


                if(ant.isAny)
                {
                    Console.WriteLine(i);
                    Table.DrawTable(table);
                    Table.SaveAsImage(table, Static.filePath, 1);
                    break;
                }
            }
        }

        static public bool Func_0(char[,] tables, Vector2 pos)
        {
            if (tables[pos.x, pos.y] == '■')
                return true;
            else
                return false;
        }
        static public bool Func_1(char[,] tables, Vector2 pos)
        {
            if (tables[pos.x, pos.y] == '□')
                return true;
            else
                return false;
        }

        static private void Debug()
        {

        }
    }
}
