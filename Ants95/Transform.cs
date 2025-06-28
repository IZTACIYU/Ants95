using System.Drawing.Printing;

namespace Ants95
{
    public class Transform : Component
    {
        // 직접 수정할때만
        private Vector2 pos;
        // 반환받을때만
        public Vector2 position { get => pos; set => pos = value; }


        private Querternion rot;
        public Querternion rotation { get => rot; set => rot = value; }

        public void SetPosition(int x, int y) => pos = new Vector2(x, y);
        public void SetPosition(Vector2 vc2) => pos = vc2;

        public void Rotate(int x, int y, int z) => rotation = new Querternion(rotation.x + x, rotation.y + y, rotation.z + z);
    }
}
