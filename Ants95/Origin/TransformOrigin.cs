using System.Drawing.Printing;
using System.Numerics;

namespace Ants95
{
    public class TransformOrigin
    {
        public TransformOrigin()
        {
            Console.WriteLine("Transform 생성됨");
            Console.WriteLine($"생성 위치 : {position}");
            Console.WriteLine();
        }

        // 직접 수정할때만
        private Vector2 vec;
        // 반환받을때만
        public Vector2 position { get => vec; }


        public int speed = 1;

        private int _direction;
        public int direction
        {
            get => _direction;
            set
            {
                if (value <= -1)
                {
                    _direction = value + 4;
                }
                else if (value >= 4)
                {
                    _direction = value - 4;
                }
                else
                {
                    _direction = value;
                }
            }
        }

        public void Direct(bool valid) => direction = valid ? direction + 1 : direction - 1;
        public void Reverse() => this.direction = this.direction switch { 0 => 1, 1 => 0, 2 => 3, 3 => 2 };

        public void Move()
        {
            (direction * 90).p();
            switch (direction)
            {
                case 0:
                    Up(); break;
                case 1:
                    Right(); break;
                case 2:
                    Down(); break;
                case 3:
                    Left(); break;
            }
        }
        public void Up() => vec = vec + (Vector2.up * speed);
        public void Right() => vec = vec + (Vector2.right * speed);
        public void Down() => vec = vec + (Vector2.down * speed);
        public void Left() => vec = vec + (Vector2.left * speed);
        public void SetPosition(int x, int y) => vec = new Vector2(x, y);
        public void SetPosition(Vector2 vc2) => vec = vc2;
    }
}