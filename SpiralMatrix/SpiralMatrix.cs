using System;


namespace Matrix
{
    public static class SpiralMatrix
    {
        public static void Main(string[] args)
        {
            int size = 4;
            int[,] arr = new int[size, size];

            int count = 1;
            int cirl = 0;

            while (count <= arr.Length)
            {
                GotoRight(arr, size, ref count, cirl);
                GotoDown(arr, size, ref count, cirl);
                GotoLeft(arr, size, ref count, cirl);
                GotoUp(arr, size, ref count, cirl);
                cirl++;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
            }

            Console.WriteLine();
        }

        private static void GotoRight(int[,] arr, int size, ref int count, int cirl)
        {
            for (int i = cirl; i < size - cirl; i++)
            {
                arr[cirl, i] = count;
                count++;
            }
        }
        private static void GotoDown(int[,] arr, int size, ref int count, int cirl)
        {
            for (int j = cirl; j < (size - 1) - cirl; j++)
            {
                arr[j + 1, (size - 1) - cirl] = count;
                count++;
            }
        }
        private static void GotoLeft(int[,] arr, int size, ref int count, int cirl)
        {
            for (int k = (size - 1) - cirl; k > cirl; k--)
            {
                arr[(size - 1) - cirl, k - 1] = count;
                count++;
            }
        }
        private static void GotoUp(int[,] arr, int size, ref int count, int cirl)
        {
            for (int l = (size - 1) - cirl; l > cirl + 1; l--)
            {
                arr[l - 1, cirl] = count;
                count++;
            }
        }
    }
}
