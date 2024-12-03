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

            private int _x;
            private int _y;
            public int x
            {
                get => this._x;
                set
                {
                    if(value < 0)
                    {
                        _x = value + Static.SIZE_X;
                    }
                    else if(value > Static.DELTA_X)
                    {
                        _x = value - Static.SIZE_X;
                    }
                    else
                        _x = value;
                }
            }
            public int y
            {
                get => this._y;
                set
                {
                    if(value < 0)
                    {
                        _y = value + Static.SIZE_Y;
                    }
                    else if(value > Static.DELTA_Y)
                    {
                        _y = value - Static.SIZE_Y;
                    }
                    else
                        _y = value;
                }
            }

            public Vector2 position { get => this; }

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
            public void Direct(bool valid)
            {
                if (valid)
                    this.direction++;
                else
                    this.direction--;
            }
            public void Reverse()
            {
                this.direction = this.direction switch
                {
                    0 => 1,
                    1 => 0,
                    2 => 3,
                    3 => 2
                };
            }

            public void Move()
            {
                switch(direction)
                {
                    case 0:
                        Up(); break;
                    case 1:
                        Down(); break;
                    case 2:
                        Right(); break;
                    case 3:
                        Left(); break;
                }
            }

            public void Up() => this = this + up;
            public void Down() => this = this + down;
            public void Right() => this = this + right;
            public void Left() => this = this + left;
        }

    }
}
