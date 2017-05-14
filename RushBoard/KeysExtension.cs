using System.Windows.Forms;

namespace RushBoard
{
    static class KeysExtension
    {
        public static int[] ToDot(this Keys keys)
        {
            switch (keys)
            {
                case Keys.D0:
                    return Character.N0;
                case Keys.D1:
                    return Character.N1;
                case Keys.D2:
                    return Character.N2;
                case Keys.D3:
                    return Character.N3;
                case Keys.D4:
                    return Character.N4;
                case Keys.D5:
                    return Character.N5;
                case Keys.D6:
                    return Character.N6;
                case Keys.D7:
                    return Character.N7;
                case Keys.D8:
                    return Character.N8;
                case Keys.D9:
                    return Character.N9;
                case Keys.A:
                    return Character.A;
                case Keys.B:
                    return Character.B;
                case Keys.C:
                    return Character.C;
                case Keys.D:
                    return Character.D;
                case Keys.E:
                    return Character.E;
                case Keys.F:
                    return Character.F;
                case Keys.G:
                    return Character.G;
                case Keys.H:
                    return Character.H;
                case Keys.I:
                    return Character.I;
                case Keys.J:
                    return Character.J;
                case Keys.K:
                    return Character.K;
                case Keys.L:
                    return Character.L;
                case Keys.M:
                    return Character.M;
                case Keys.N:
                    return Character.N;
                case Keys.O:
                    return Character.O;
                case Keys.P:
                    return Character.P;
                case Keys.Q:
                    return Character.Q;
                case Keys.R:
                    return Character.R;
                case Keys.S:
                    return Character.S;
                case Keys.T:
                    return Character.T;
                case Keys.U:
                    return Character.U;
                case Keys.V:
                    return Character.V;
                case Keys.W:
                    return Character.W;
                case Keys.X:
                    return Character.X;
                case Keys.Y:
                    return Character.Y;
                case Keys.Z:
                    return Character.Z;
                default:
                    return Character.None;
            }
        }
    }
}
