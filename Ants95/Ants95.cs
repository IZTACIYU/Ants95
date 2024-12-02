namespace Ants95
{
    public class Ants95 : Formula
    {
        public Ants95()
        {

        }

        public Vector2 position { get => vec; }

        private Vector2 vec = new Vector2();

        public void InitPosition()
        {
            this.vec = Vector2.zero;
        }
        public void SetPosition(int x, int y)
        {
            if(x < Static.SIZE_X &&  y < Static.SIZE_Y)
                this.vec = new Vector2(x, y);
            else
                this.vec = new Vector2(Static.SIZE_dX, Static.SIZE_dY);
        }
        public void RandomPosition()
        {
            int x = Static.rnd.Next(0, Static.SIZE_X);
            int y = Static.rnd.Next(0, Static.SIZE_Y);

            if(x < Static.SIZE_X &&  y < Static.SIZE_Y)
                this.vec = new Vector2(x, y);
            else
                this.vec = new Vector2(Static.SIZE_dX, Static.SIZE_dY);
        }
        public void AntsMove()
        {
            this.vec.Move();
        }
    }
}
