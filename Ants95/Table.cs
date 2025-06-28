using System.Drawing;

namespace Ants95
{
    public class Table
    {
        static public char[,] GenEmptyTable(int row, int col)
        {
            char[,] table = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = '□';
                }
            }

            return table;
        }
        static public char[,] GenEmptyTable(Vector2 vec)
        {
            char[,] table = new char[vec.x, vec.y];

            for (int i = 0; i < vec.x; i++)
            {
                for (int j = 0; j < vec.y; j++)
                {
                    table[i, j] = '□';
                }
            }

            return table;
        }

        static public char[,] GenFilledTable(int row, int col)
        {
            char[,] table = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = '■';
                }
            }

            return table;
        }
        static public char[,] GenFilledTable(Vector2 vec)
        {
            char[,] table = new char[vec.x, vec.y];

            for (int i = 0; i < vec.x; i++)
            {
                for (int j = 0; j < vec.y; j++)
                {
                    table[i, j] = '■';
                }
            }

            return table;
        }

        static public char[,] GenRndTable(int row, int col)
        {
            char[,] table = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = '■';
                }
            }

            int time = Static.rnd.Next(row * col / 10, row * col / 2);

            for (int i = 0; i < time;)
            {
                int x = Static.rnd.Next(0, row);
                int y = Static.rnd.Next(0, row);

                if (table[x, y] != '□')
                {
                    table[x, y] = '□';
                    i++;
                }
            }

            return table;
        }
        static public char[,] GenRndTable(int row, int col, int time)
        {
            char[,] table = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = '■';
                }
            }

            for (int i = 0; i < time;)
            {
                int x = Static.rnd.Next(0, row);
                int y = Static.rnd.Next(0, row);

                if (table[x, y] != '□')
                {
                    table[x, y] = '□';
                    i++;
                }
            }

            return table;
        }
        static public char[,] GenRndTable(Vector2 vec)
        {
            char[,] table = new char[vec.x, vec.y];

            for (int i = 0; i < vec.x; i++)
            {
                for (int j = 0; j < vec.y; j++)
                {
                    table[i, j] = '■';
                }
            }

            int time = Static.rnd.Next(vec.x * vec.y / 10, vec.x * vec.y / 2);

            for (int i = 0; i < time;)
            {
                int x = Static.rnd.Next(0, vec.x);
                int y = Static.rnd.Next(0, vec.y);

                if (table[x, y] != '□')
                {
                    table[x, y] = '□';
                    i++;
                }
            }

            return table;
        }
        static public char[,] GenRndTable(Vector2 vec, int time)
        {
            char[,] table = new char[vec.x, vec.y];

            for (int i = 0; i < vec.x; i++)
            {
                for (int j = 0; j < vec.y; j++)
                {
                    table[i, j] = '■';
                }
            }

            for (int i = 0; i < time;)
            {
                int x = Static.rnd.Next(0, vec.x);
                int y = Static.rnd.Next(0, vec.y);

                if (table[x, y] != '□')
                {
                    table[x, y] = '□';
                    i++;
                }
            }

            return table;
        }

        static public void DrawTable(char[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        static public void SaveAsImage(char[,] table, string filePath, int pixelSize)
        {
            int rows = table.GetLength(0);
            int cols = table.GetLength(1);

            using (Bitmap bitmap = new Bitmap(cols * pixelSize, rows * pixelSize))
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Color color = table[i, j] != '■' ? Color.Black : Color.White;
                        Brush brush = new SolidBrush(color);
                        graphics.FillRectangle(brush, j * pixelSize, i * pixelSize, pixelSize, pixelSize);
                    }
                }

                bitmap.Save(filePath);
            }

            Console.WriteLine($"이미지가 {filePath}에 저장되었습니다.");
        }
    }
}
