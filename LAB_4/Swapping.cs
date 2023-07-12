using System;

namespace LAB_4
{
    internal class Swapping
    {


        static void Swap(int[] array, int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
                Console.WriteLine("Swapping successful!");
            }
            else
            {
                Console.WriteLine("Invalid indices. Swapping failed!");
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of your array");
            int size = int.Parse(Console.ReadLine());

            int[] students = new int[size];

            for (int i=0; i<size; i++)
            {
                Console.WriteLine($"Enter the value for index {i+1}");
                students[i] = int.Parse(Console.ReadLine());
            }
           Console.WriteLine("Array before swapping ");
           PrintArray(students);

            Console.WriteLine("Enter first index ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second index ");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("After Swapping ");
            Swap( students, x, y);
            PrintArray(students);

           

            




        }
    }
}