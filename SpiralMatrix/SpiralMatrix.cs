using System;


namespace Matrix
{
    static class SpiralMatrix
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int size;

                try
                {
                    GetSize(out size);

                    if (size == 0)
                    {
                        ShowFirstTExeption();
                        continue;
                    }
                }
                catch (Exception)
                {
                    ShowSecondTExeption();
                    continue;
                }

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

                ShowMatrix(arr, size);
                TryExit();
            }
        }

        static void GotoRight(int[,] arr, int size, ref int count, int cirl)
        {
            for (int i = cirl; i < size - cirl; i++)
            {
                arr[cirl, i] = count;
                count++;
            }
        }
        static void GotoDown(int[,] arr, int size, ref int count, int cirl)
        {
            for (int j = cirl; j < (size - 1) - cirl; j++)
            {
                arr[j + 1, (size - 1) - cirl] = count;
                count++;
            }
        }
        static void GotoLeft(int[,] arr, int size, ref int count, int cirl)
        {
            for (int k = (size - 1) - cirl; k > cirl; k--)
            {
                arr[(size - 1) - cirl, k - 1] = count;
                count++;
            }
        }
        static void GotoUp(int[,] arr, int size, ref int count, int cirl)
        {
            for (int l = (size - 1) - cirl; l > cirl + 1; l--)
            {
                arr[l - 1, cirl] = count;
                count++;
            }
        }

        static void GetSize(out int size)
        {
            Console.WriteLine("\nInput a size (natural number) for spiral matrix: ");
            size = int.Parse(Console.ReadLine()); 
        }
        static void ShowFirstTExeption()
        {
            Console.WriteLine("\nExeption. Size can't be equal zero.\nPress Enter to continue.");
            Console.ReadLine();
        }
        static void ShowSecondTExeption()
        {
            Console.WriteLine("\nExeption. Size isn't a natural number.\nPress Enter to continue.");
            Console.ReadLine();
        }
        static void ShowMatrix(int[,] arr, int size)
        {
            Console.WriteLine("Success, your spiral matrix:");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
            }
        }
        static void TryExit()
        {
            string keyWord = "0";
            string enterWord;
            Console.WriteLine("\n\nPress \"0\" to quit or any other key to continue");
            enterWord = Console.ReadLine();

            if (keyWord == enterWord)
            {
                Environment.Exit(0);
            }
        }
    }
}
