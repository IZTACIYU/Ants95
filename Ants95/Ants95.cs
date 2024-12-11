using System.ComponentModel;
using static Ants95.Vector;

namespace Ants95
{
    public class Ants95
    {
        public Ants95()
        {
            transform = new Transform();
        }
        public Ants95(Func<char[,], Vector2, bool> func, char[,] board)
        {
            method = func;
            table = board;
            transform = new Transform();
        }

        public Transform transform;

        public char[,] table;

        public Func<char[,], Vector2, bool> method { get; set; }


        public bool isValid { get => method?.Invoke(table, transform.position) ?? false; }
        public bool isLast { get => transform.position.x == Static.DELTA_X && transform.position.y == Static.DELTA_Y; } 
        public bool isAny { get => transform.position.x == Static.DELTA_X || transform.position.y == Static.DELTA_Y; } 

        // 스타트 포지션
        public void InitPosition()
        {
            this.transform.SetPosition(Vector2.zero);
        }
        public void SetPosition(int x, int y)
        {
            if (x < Static.SIZE_X && y < Static.SIZE_Y)
                this.transform.SetPosition(x, y);
            else
                this.transform.SetPosition(Static.DELTA_X, Static.DELTA_Y);

            Console.WriteLine("위치 수정됨");
            Console.WriteLine($"현재 위치 : {transform.position}");
        }
        public void SetPosition(Vector2 vec)
        {
            if (vec.x < Static.SIZE_X && vec.y < Static.SIZE_Y)
                this.transform.SetPosition(vec);
            else
                this.transform.SetPosition(Static.DELTA_X, Static.DELTA_Y);
        }

        public void RandomPosition()
        {
            int x = Static.rnd.Next(0, Static.SIZE_X);
            int y = Static.rnd.Next(0, Static.SIZE_Y);

            if(x < Static.SIZE_X &&  y < Static.SIZE_Y)
                this.transform.SetPosition(x, y);
            else
                this.transform.SetPosition(Static.DELTA_X, Static.DELTA_Y);
        }



        // 이동 방향 변경
        public void SetDirection() => this.transform.Direct(isValid);
        // 이동
        public void AntsMove() => this.transform.Move();


        public void SetTile()
        {
            this.Tile(table);
        }
        public void Tile(char[,] table)
        {
            if (table[transform.position.x, transform.position.y] == '■')       table[transform.position.x, transform.position.y] = '□';
            else if (table[transform.position.x, transform.position.y] == '□')  table[transform.position.x, transform.position.y] = '■';
        }

        public void Logics()
        {
            this.SetDirection();
            this.SetTile();
            this.AntsMove();
        }
    }
}
