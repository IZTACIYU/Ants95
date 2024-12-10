namespace Ants95
{
    public class Vector
    {
        public struct Object<T>
        {
            public T[,] tag { get; set; }
        }

        public struct Vector2
        {
            public Vector2() {  }

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


            readonly static public Vector2 up = new Vector2(0, 1);
            readonly static public Vector2 right = new Vector2(1, 0);
            readonly static public Vector2 down = new Vector2(0, -1);
            readonly static public Vector2 left = new Vector2(-1, 0);
            readonly static public Vector2 zero = new Vector2(0, 0);

            // 사용자 정의 연산자 (operator 키워드) 오버로딩
            static public Vector2 operator + (Vector2 a, Vector2 b) => new Vector2(a.x + b.x, a.y + b.y);
            static public Vector2 operator - (Vector2 a, Vector2 b) => new Vector2(a.x - b.x, a.y - b.y);
            static public Vector2 operator * (Vector2 a, Vector2 b) => new Vector2(a.x * b.x, a.y * b.y);
            static public Vector2 operator * (Vector2 a, int b) => new Vector2(a.x * b, a.y * b);
            static public bool operator == (Vector2 a, Vector2 b) => a.x == b.x && a.y == b.y;
            static public bool operator != (Vector2 a, Vector2 b) => !(a == b);

            public override string ToString() => $"{x}, {y}";
        }
    }
}
