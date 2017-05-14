using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RushBoard
{
    class Controller
    {
        private const int AnimationDelay = 50;

        private Color Color { get; }

        private Color BaseColor { get; }

        private Queue<KeyInfo> Buffer { get; } = new Queue<KeyInfo>();

        private bool IsAnimating { get; set; }

        private KeyInfo CurrentKeyInfo { get; set; }

        private int[][] DisplayMatrix { get; }

        private Key?[][] KeyboardMatrix { get; }

        private bool IsAllClear
        {
            get
            {
                foreach (var item in DisplayMatrix)
                {
                    foreach (var it in item)
                    {
                        if (it == 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public Controller(Color baseColor, Color color)
        {
            BaseColor = baseColor;
            Color = color;

            DisplayMatrix =
                Enumerable
                    .Range(0, KeyInfo.BaseHeight)
                    .Select(item =>
                        Enumerable
                            .Range(0, Assign.Row1.Length)
                            .Select(it => 0)
                            .ToArray())
                    .ToArray();

            KeyboardMatrix =
                Enumerable
                    .Range(0, KeyInfo.BaseHeight)
                    .Select(item => Enumerable
                        .Range(0, Assign.Row1.Length)
                        .Select(it => GetKey(item, it))
                        .ToArray())
                    .ToArray();

            Keyboard.Instance.SetAll(baseColor);
        }

        public async Task RequestAnimation(KeyInfo key)
        {
            Buffer.Enqueue(key);
            if (!IsAnimating)
            {
                await StartAnimation();
            }
        }

        private async Task StartAnimation()
        {
            IsAnimating = true;
            while (true)
            {
                Next();
                Draw();
                if (Buffer.Count == 0 && CurrentKeyInfo == null && IsAllClear)
                {
                    break;
                }
                await Task.Delay(AnimationDelay);
            }
            IsAnimating = false;
        }

        private void Draw()
        {
            var instance = Keyboard.Instance;

            for (var i = 0; i < KeyboardMatrix.Length; i++)
            {
                for (var j = 0; j < KeyboardMatrix[i].Length; j++)
                {
                    var key = KeyboardMatrix[i][j];
                    if (!key.HasValue)
                    {
                        continue;
                    }
                    var c = DisplayMatrix[i][j];
                    if (c == 1)
                    {
                        instance.SetKey(key.Value, Color);
                        continue;
                    }
                    instance.SetKey(key.Value, BaseColor);
                }
            }
        }

        private void Next()
        {
            for (var i = 0; i < DisplayMatrix.Length; i++)
            {
                DisplayMatrix[i] = Shift(DisplayMatrix[i]);
            }

            var length = DisplayMatrix[0].Length - 1;
            if (CurrentKeyInfo != null)
            {
                var dot = CurrentKeyInfo.LineDot;
                for (var i = 0; i < KeyInfo.BaseHeight; i++)
                {
                    DisplayMatrix[i][length] = dot[i];
                }
                if (!CurrentKeyInfo.Shift())
                {
                    CurrentKeyInfo = null;
                }
            }
            else
            {
                if (Buffer.Count > 0)
                {
                    var info = Buffer.Dequeue();
                    CurrentKeyInfo = info;
                    var dot = CurrentKeyInfo.LineDot;
                    for (var i = 0; i < KeyInfo.BaseHeight; i++)
                    {
                        DisplayMatrix[i][length] = dot[i];
                    }
                    CurrentKeyInfo.Shift();
                }
            }
        }

        private int[] Shift(int[] arr)
        {
            var newArr = new int[arr.Length];
            Array.Copy(arr, 1, newArr, 0, arr.Length - 1);
            return newArr;
        }

        private Key? GetKey(int row, int index)
        {
            var r = Assign.Row1;
            switch (row)
            {
                case 1:
                    r = Assign.Row2;
                    break;
                case 2:
                    r = Assign.Row3;
                    break;
                case 3:
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
