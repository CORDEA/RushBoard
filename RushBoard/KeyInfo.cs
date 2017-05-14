using System.Windows.Forms;

namespace RushBoard
{
    class KeyInfo
    {
        public const int BaseHeight = 4;

        public const int BaseWidth = 4;

        public int Width
        {
            get
            {
                return BaseWidth + Margin;
            }
        }

        public int CurrentIndex { get; private set; }

        public Keys Key { get; }

        private int Margin { get; }

        public KeyInfo(Keys key, int margin = 1)
        {
            Key = key;
            Margin = margin;
        }

        public bool Shift()
        {
            ++CurrentIndex;
            return CurrentIndex < Width;
        }

        public int[] Dot
        {
            get
            {
                return Key.ToDot();
            }
        }

        public int[] LineDot
        {
            get
            {
                var dot = Dot;
                if (CurrentIndex > (BaseWidth - 1))
                {
                    return new int[] { 0, 0, 0, 0 };
                }
                return new int[]
                {
                    dot[CurrentIndex],
                    dot[CurrentIndex + BaseWidth],
                    dot[CurrentIndex + (BaseWidth * 2)],
                    dot[CurrentIndex + (BaseWidth * 3)]
                };
            }
        }
    }
}
