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

        static public void p<T>(this T t) => Console.WriteLine(t.ToString());


        static public int max(this int value, int max) => value > max ? max : value;
        static public int min(this int value, int min) => value < min ? min : value;

        static public float max(this float value, float max) => value > max ? max : value;
        static public float min(this float value, float min) => value < min ? min : value;

        static public int range(this int value, int min, int max) => value.min(min).max(max);
        static public float range(this float value, float min, float max) => value.min(min).max(max);
    }

    public class Programs
    {
        static void Main()
        {
            Ants();
        }

        // 로테이션 방식 오류
        static public void Ants()
        {
            char[,] table = Table.GenEmptyTable(Static.SIZE_X, Static.SIZE_Y);

            Ants95 ant = new Ants95(Func_0, table);

            ant.SetPosition(Vector2.center);

            Console.ReadLine();
            int i = 0;

            while (true)
            {
                i++;

                ant.Logics();

                //Table.DrawTable(table);
                //Console.ReadLine();
                if (ant.isAny)
                {
                    Console.WriteLine(i);
                    Table.DrawTable(table);
                    Table.SaveAsImage(table, Static.filePath, 1);
                    break;
                }
            }

        }
        static public void Ants(int a)
        {
            char[,] table = Table.GenEmptyTable(Static.SIZE_X, Static.SIZE_Y);

            Ants95origin ant = new Ants95origin(Func_0, table);

            ant.SetPosition(Vector2.center);

            Console.ReadLine();
            int i = 0;

            while (true)
            {
                i++;

                ant.Logics();

                //Table.DrawTable(table);
                //Console.ReadLine();
                if (ant.isAny)
                {
                    Console.WriteLine(i);
                    Table.DrawTable(table);
                    Table.SaveAsImage(table, Static.filePath, 1);
                    break;
                }
            }

        }
        static public void Rider()
        {
            TrenchRider rider = new TrenchRider();

            var at = rider.AddComponent<Transform>();
            at.position.p();

            Querternion qut = new Querternion();

            qut.x = 361;

            qut.x.p();

        }




        static private bool Func_0(char[,] tables, Vector2 pos)
        {
            if (tables[pos.x, pos.y] == '■')
                return true;
            else
                return false;
        }
        static private bool Func_1(char[,] tables, Vector2 pos)
        {
            if (tables[pos.x, pos.y] == '□')
                return true;
            else
                return false;
        }
    }
}
