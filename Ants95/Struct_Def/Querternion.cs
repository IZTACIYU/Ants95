namespace Ants95
{
    public struct Querternion
    {
        public Querternion(int x, int y, int z) { this.x = x;this.y = y;this.z = z; }

        private int _x;
        public int x
        {
            get => this._x;
            set
            {
                //if(value < 0)   while(value <= 0) { value += 360; }
                //if(value > 360) while(value > 361) { value -= 360; }
                if(value <= -1) _x = value + 360;
                if(value >= 361) _x = value - 360;
                _x = value / 90;
            }
        }

        private int _y;
        public int y
        {
            get => this._y * 90;
            set
            {
                if (value <= -1)    value =+ 4;
                if (value >= 4)     value =- 4;

                _y = value;
            }
        }

        private int _z;
        public int z
        {
            get => this._z * 90;
            set
            {
                if (value <= -1)    value =+ 4;
                if (value >= 4)     value =- 4;

                _z = value;
            }
        }

        readonly static public Querternion identity = new Querternion(0, 0, 0);

        // 사용자 정의 연산자 (operator 키워드) 오버로딩
        static public Querternion operator +(Querternion a, Querternion b) => new Querternion(a.x + b.x, a.y + b.y, a.z + b.z);
        static public Querternion operator -(Querternion a, Querternion b) => new Querternion(a.x - b.x, a.y - b.y, a.z - b.z);
        static public Querternion operator *(Querternion a, Querternion b) => new Querternion(a.x * b.x, a.y * b.y, a.z * b.z);
        static public Querternion operator *(Querternion a, int b) => new Querternion(a.x * b, a.y * b, a.z);
        static public bool operator ==(Querternion a, Querternion b) => a.x == b.x && a.y == b.y && a.z == b.z;
        static public bool operator !=(Querternion a, Querternion b) => !(a == b);


        public override string ToString() => $"{x}, {y}, {z}";
    }
}
