namespace Ants95
{
    public class Ants95 : Formula
    {
        public Ants95()
        {

        }

        private Vector2 vec = new Vector2();

        public Func<bool> method { get; set; }
        public bool isValid { get => method?.Invoke() ?? false; }


        public void InitPosition()
        {
            this.vec = Vector2.zero;
        }
        public void SetPosition(int x, int y)
        {
            if(x < Static.SIZE_X &&  y < Static.SIZE_Y)
                this.vec = new Vector2(x, y);
            else
                this.vec = new Vector2(Static.DELTA_X, Static.DELTA_Y);
        }
        public void RandomPosition()
        {
            int x = Static.rnd.Next(0, Static.SIZE_X);
            int y = Static.rnd.Next(0, Static.SIZE_Y);

            if(x < Static.SIZE_X &&  y < Static.SIZE_Y)
                this.vec = new Vector2(x, y);
            else
                this.vec = new Vector2(Static.DELTA_X, Static.DELTA_Y);
        }

        public void SetDirection()
        {
            //this.vec.Direct()
        }
        public void AntsMove()
        { 
            this.vec.Move();
        }
    }
}
