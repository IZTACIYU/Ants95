using static Ants95.Formula;

namespace Ants95
{
    public class Formula
    {
        public struct Object<T>
        {
            public T[,] tag { get; set; }
        }

        public struct Vector2
        {
            private int _direction;
            public int direction
            {
                get => _direction;
                set
                {
                    if (value < 0)
                    {
                        _direction = value + 4;
                    }
                    else if (value > 3)
                    {
                        _direction = value - 4;
                    }
                    else
                    {
                        _direction = value;
                    }
                }
            }

            public Vector2(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }

            public int x { get; set; }
            public int y { get; set; }

            public static readonly Vector2 up = new Vector2(0, 1);
            public static readonly Vector2 down = new Vector2(0, -1);
            public static readonly Vector2 right = new Vector2(1, 0);
            public static readonly Vector2 left = new Vector2(-1, 0);
            public static readonly Vector2 zero = new Vector2(0, 0);

            static public Vector2 operator + (Vector2 a, Vector2 b)
            {
                return new Vector2(a.x + b.x, a.y + b.y);
            }
            static public Vector2 operator - (Vector2 a, Vector2 b)
            {
                return new Vector2(a.x - b.x, a.y - b.y);
            }
            static public Vector2 operator * (Vector2 a, Vector2 b)
            {
                return new Vector2(a.x * b.x, a.y * b.y);
            }
            public override string ToString()
            {
                return $"{x}, {y}";
            }

            public void Direct(ref int direct, bool valid)
            {
                if (valid)
                    direct++;
                else
                    direct--;
            }
            public void Reverse(ref int direct)
            {
                direct = direct switch
                {
                    0 => 1,
                    1 => 0,
                    2 => 3,
                    3 => 2
                };
            }
        }

    }
    static public class ExtensionMethod
    {
        static public void Move(this ref Vector2 v)
        {
            int direct = v.direction;
            switch(direct)
            {
                case 0:
                    Up(ref v); break;
                case 1:
                    Down(ref v); break;
                case 2:
                    Right(ref v); break;
                case 3:
                    Left(ref v); break;
            }
        }

        static public void Up(ref Vector2 v) => v = v + Vector2.up;
        static public void Down(ref Vector2 v) => v = v + Vector2.down;
        static public void Right(ref Vector2 v) => v = v + Vector2.right;
        static public void Left(ref Vector2 v) => v = v + Vector2.left;
    }
}
