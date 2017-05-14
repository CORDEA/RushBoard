using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RushBoard
{
    class Controller
    {

        private const int AnimationDelay = 20;

        private Color Color { get; }

        private Color BaseColor { get; }

        private Queue<Keys> Buffer { get; } = new Queue<Keys>();

        private bool IsAnimating { get; set; } = false;

        public Controller(Color baseColor, Color color)
        {
            BaseColor = baseColor;
            Color = color;

            Keyboard.Instance.SetAll(baseColor);
        }

        public async Task RequestAnimation(Keys key)
        {
            if (IsAnimating)
            {
                Buffer.Enqueue(key);
                return;
            }
            IsAnimating = true;
            await StartAnimation(key);
            IsAnimating = false;
            if (Buffer.Count > 0)
            {
                await RequestAnimation(Buffer.Dequeue());
            }
        }

        public async Task StartAnimation(Keys key)
        {
            var keys = Assign.Row1;
            for (var i = 0; i < keys.Length; i++)
            {
                Draw(key.ToDot(), i + 4);
                await Task.Delay(AnimationDelay);
            }
        }

        public void Draw(int[] charArr, int index)
        {
            var matrix = new Key?[]
            {
                GetKey(1, index), GetKey(1, index - 1), GetKey(1, index - 2), GetKey(1, index - 3),
                GetKey(2, index), GetKey(2, index - 1), GetKey(2, index - 2), GetKey(2, index - 3),
                GetKey(3, index), GetKey(3, index - 1), GetKey(3, index - 2), GetKey(3, index - 3),
                GetKey(4, index), GetKey(4, index - 1), GetKey(4, index - 2), GetKey(4, index - 3),
            };

            var instance = Keyboard.Instance;
            instance.SetAll(BaseColor);
            for (var i = 0; i < 16; i++)
            {
                var key = matrix[i];
                if (!key.HasValue)
                {
                    continue;
                }
                if (charArr[i] == 1)
                {
                    instance.SetKey(key.Value, Color);
                    continue;
                }
                instance.SetKey(key.Value, BaseColor);
            }
        }

        public Key? GetKey(int row, int index)
        {
            var r = Assign.Row1;
            switch (row)
            {
                case 2:
                    r = Assign.Row2;
                    break;
                case 3:
                    r = Assign.Row3;
                    break;
                case 4:
                    r = Assign.Row4;
                    break;
            }

            if (r.Length > index)
            {
                return r[index];
            }
            return null;
        }

    }
}
