using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants95
{
    public class Dump
    {
        static public bool ValidCheck(List<char[,]> list, char[,] array)
        {
            foreach (var item in list)
            {
                if (CompareTables(item, array))
                {
                    return true;
                }
            }
            return false;
        }
        static public bool CompareTables(char[,] table1, char[,] table2)
        {
            if (table1.GetLength(0) != table2.GetLength(0))
                return false;
            if (table1.GetLength(1) != table2.GetLength(1))
                return false;

            for (int i = 0; i < table1.GetLength(0); i++)
            {
                for (int j = 0; j < table1.GetLength(1); j++)
                {
                    if (table1[i, j] != table2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static public char[,] CloneTable(char[,] original)
        {
            int Row = original.GetLength(0);
            int Col = original.GetLength(1);

            char[,] clone = new char[Row, Col];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    clone[i, j] = original[i, j];
                }
            }
            return clone;
        }

    }
}
