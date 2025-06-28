using System.ComponentModel;

namespace Ants95
{
    public class Ants95origin
    {
        public Ants95origin()
        {
            transform = new TransformOrigin();
        }
        public Ants95origin(Func<char[,], Vector2, bool> func, char[,] board)
        {
            method = func;
            table = board;
            transform = new TransformOrigin();
        }

        public char[,] table;

        public TransformOrigin transform;

        public Func<char[,], Vector2, bool> method { get; set; }


        public bool isValid { get => method?.Invoke(table, transform.position) ?? false; }
        public bool isLast { get => transform.position.x == Static.DELTA_X && transform.position.y == Static.DELTA_Y; }

        /// <summary>
        /// Detected any border
        /// </summary>
        public bool isAny { get => transform.position.x == Static.DELTA_X || transform.position.y == Static.DELTA_Y; }

        // 스타트 포지션
        public void InitPosition()
        {
            this.transform.SetPosition(Vector2.zero);
            Console.WriteLine("초기 위치 지정됨");
            Console.WriteLine($"현재 위치 : {transform.position}");
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
            Console.WriteLine("위치 수정됨");
            Console.WriteLine($"현재 위치 : {transform.position}");
        }

        public void RandomPosition()
        {
            int x = Static.rnd.Next(0, Static.SIZE_X);
            int y = Static.rnd.Next(0, Static.SIZE_Y);

            if (x < Static.SIZE_X && y < Static.SIZE_Y)
                this.transform.SetPosition(x, y);
            else
                this.transform.SetPosition(Static.DELTA_X, Static.DELTA_Y);
            Console.WriteLine("랜덤 위치 지정됨");
            Console.WriteLine($"현재 위치 : {transform.position}");
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
            if (table[transform.position.x, transform.position.y] == '■') table[transform.position.x, transform.position.y] = '□';
            else if (table[transform.position.x, transform.position.y] == '□') table[transform.position.x, transform.position.y] = '■';
        }

        public void Logics()
        {
            this.SetDirection();
            this.SetTile();
            this.AntsMove();
        }
    }
}