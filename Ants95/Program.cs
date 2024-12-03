using static Ants95.Formula;

namespace Ants95
{
    static public class Static
    {
        static public Random rnd = new Random();
        static public string filePath = "C:\\Users\\admin\\Desktop\\Git\\Ants95\\Ants95\\table.png";
        
        static public int SIZE_X = 100;
        static public int SIZE_Y = 100;

        static public int DELTA_X = SIZE_X - 1;
        static public int DELTA_Y = SIZE_Y - 1;
    }

    public class Programs
    {

        static public char[,]? table;


        static void Main()
        {
            Vector2 vec = new Vector2(99, 100);

            Console.WriteLine(vec.position);

            //Ants95 ant = new Ants95();
            //ant.RandomPosition();
            //Console.WriteLine(ant.position.ToString());

            //table = Table.GenRndTable(Static.SIZE_X, Static.SIZE_Y);
            //Table.DrawTable(table);
            //Table.SaveAsImage(table, Static.filePath, 1);
        }


    }
}
