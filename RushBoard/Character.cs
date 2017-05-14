namespace RushBoard
{
    static class Character
    {
        public static readonly int[] None = new int[]
        {
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0,
        };

        public static readonly int[] N1 = new int[]
        {
            1, 1, 1, 0,
            0, 1, 1, 0,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] N2 = new int[]
        {
            1, 1, 1, 1,
            0, 0, 1, 0,
            1, 1, 0, 0,
            1, 1, 1, 1,
        };

        public static readonly int[] N3 = new int[]
        {
            1, 1, 1, 1,
            0, 1, 1, 1,
            0, 1, 1, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] N4 = new int[]
        {
            0, 0, 1, 0,
            0, 1, 1, 0,
            1, 1, 1, 1,
            0, 0, 1, 0,

        };

        public static readonly int[] N5 = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            1, 1, 1, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] N6 = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            1, 1, 1, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] N7 = new int[]
        {
            1, 1, 1, 1,
            0, 0, 1, 1,
            0, 0, 1, 0,
            0, 1, 0, 0,
        };

        public static readonly int[] N8 = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 1,
            0, 1, 1, 0,
            1, 1, 1, 1,

        };

        public static readonly int[] N9 = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 1,
            0, 0, 0, 1,
            1, 1, 1, 1,

        };

        public static readonly int[] N0 = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,

        };

        public static readonly int[] Q = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] W = new int[]
        {
            1, 0, 0, 1,
            1, 1, 1, 1,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] E = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 0,
            1, 1, 1, 0,
            1, 1, 1, 1,
        };

        public static readonly int[] R = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 1,
            1, 1, 0, 0,
            1, 0, 1, 1,
        };

        public static readonly int[] T = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 1,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] Y = new int[]
        {
            1, 0, 0, 1,
            1, 1, 1, 1,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] U = new int[]
        {
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] I = new int[]
        {
            0, 1, 1, 0,
            0, 1, 1, 0,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] O = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] P = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
            1, 0, 0, 0,
        };

        public static readonly int[] A = new int[]
        {
            0, 1, 1, 0,
            1, 0, 0, 1,
            1, 1, 1, 1,
            1, 0, 0, 1,
        };

        public static readonly int[] S = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            0, 1, 1, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] D = new int[]
        {
            1, 1, 1, 0,
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 0,
        };

        public static readonly int[] F = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            1, 1, 1, 0,
            1, 0, 0, 0,
        };

        public static readonly int[] G = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            1, 0, 1, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] H = new int[]
        {
            1, 0, 0, 1,
            1, 1, 1, 1,
            1, 1, 1, 1,
            1, 0, 0, 1,
        };

        public static readonly int[] J = new int[]
        {
            0, 0, 0, 1,
            0, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
        };

        public static readonly int[] K = new int[]
        {
            1, 0, 1, 1,
            1, 1, 0, 0,
            1, 1, 0, 0,
            1, 0, 1, 1,
        };

        public static readonly int[] L = new int[]
        {
            1, 0, 0, 0,
            1, 0, 0, 0,
            1, 0, 0, 0,
            1, 1, 1, 1,
        };

        public static readonly int[] Z = new int[]
        {
            1, 1, 1, 1,
            0, 0, 1, 0,
            0, 1, 0, 0,
            1, 1, 1, 1,
        };

        public static readonly int[] X = new int[]
        {
            1, 0, 0, 1,
            0, 1, 1, 0,
            0, 1, 1, 0,
            1, 0, 0, 1,
        };

        public static readonly int[] C = new int[]
        {
            1, 1, 1, 1,
            1, 0, 0, 0,
            1, 0, 0, 0,
            1, 1, 1, 1,
        };

        public static readonly int[] V = new int[]
        {
            1, 0, 0, 1,
            1, 0, 0, 1,
            0, 1, 1, 0,
            0, 1, 1, 0,
        };

        public static readonly int[] B = new int[]
        {
            1, 1, 1, 1,
            1, 1, 1, 1,
            1, 0, 0, 1,
            1, 1, 1, 0,
        };

        public static readonly int[] N = new int[]
        {
            1, 0, 0, 1,
            1, 1, 0, 1,
            1, 0, 1, 1,
            1, 0, 0, 1,
        };

        public static readonly int[] M = new int[]
        {
            1, 0, 0, 1,
            1, 0, 0, 1,
            1, 1, 1, 1,
            1, 1, 1, 1,
        };


    }
}
