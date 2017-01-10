using System;
/// <summary>
/// Выполнить сортировку пузырьком целочисленного массива.
/// </summary>
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {4, 8, 9, 6, 2, 1, 5};
            Show(intArray);
            Console.WriteLine();
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        int bubble = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = bubble;
                    }
                }
            }
            Show(intArray);
            Console.ReadLine();
        }

        static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ",a[i]);
            }
        }
    }
}
