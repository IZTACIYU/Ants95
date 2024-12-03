using static Ants95.Vector;

namespace Ants95
{
    static public class Static
    {
        static public Random rnd = new Random();
        static public string filePath = "C:\\Users\\admin\\Desktop\\Git\\Ants95\\Ants95\\table.png";    // 상대경로 대체 어케함???

        static public int SIZE_X = 1000;
        static public int SIZE_Y = 1000;

        static public int DELTA_X = SIZE_X - 1;
        static public int DELTA_Y = SIZE_Y - 1;
    }

    public class Programs
    {
        static public char[,]? table;

        static void Main()
        {
            table = Table.GenFilledTable(Static.SIZE_X, Static.SIZE_Y);

            Ants95 ant = new Ants95(Func_0, table);
            Ants95 ant1 = new Ants95(Func_1, table);
            Ants95 ant2 = new Ants95(Func_1, table);
            Ants95 ant3 = new Ants95(Func_1, table);

            ant.RandomPosition();
            ant1.RandomPosition();
            ant2.RandomPosition();
            ant3.RandomPosition();

            Console.WriteLine(ant.transform.position);
            Console.WriteLine(ant1.transform.position);
            Console.WriteLine(ant2.transform.position);
            Console.WriteLine(ant3.transform.position);

            Console.ReadLine();
            int i = 0;

            while(true)
            {
                i++;

                ant.SetTile();
                ant.SetDirection();
                ant.AntsMove();

                ant1.SetTile();
                ant1.SetDirection();
                ant1.AntsMove();

                ant2.SetTile();
                ant2.SetDirection();
                ant2.AntsMove();

                ant3.SetTile();
                ant3.SetDirection();
                ant3.AntsMove();

                if(ant.isLast)
                {
                    Console.WriteLine(i);
                    Table.SaveAsImage(table, Static.filePath, 1);
                    break;
                }
                if(ant1.isLast)
                {
                    Console.WriteLine(i);
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
    }
}
