using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            //  Example:
            int[] arrayBSort = Bubble(new int[] { 34, 12, 24, 9, 5 });

            for (int i = 0; i < arrayBSort.Length; i++)
            {
                Console.Write(arrayBSort[i] + " ");
            }
            //  should print [5, 9, 12, 24, 34]
            Console.WriteLine();

            int[] arrayABSort = AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true);

            for (int i = 0; i < arrayABSort.Length; i++)
            {
                Console.Write(arrayABSort[i] + " ");
            }
            //  should print [34, 24, 12, 9, 5]
            Console.ReadLine();
        }

        public static int[] AdvancedBubble(int[] array, bool Reverse)
        {
            if (!Reverse)
            {
                int temp = 0;

                for (int write = 0; write < array.Length; write++)
                {
                    for (int sort = 0; sort < array.Length - 1; sort++)
                    {
                        if (array[sort] > array[sort + 1])
                        {
                            temp = array[sort + 1];
                            array[sort + 1] = array[sort];
                            array[sort] = temp;
                        }
                    }
                }
                return array;
            }
            else
            {
                int[] tempArray = new int[array.Length]; 
                int temp = 0;

                for (int write = 0; write < array.Length; write++)
                {
                    for (int sort = 0; sort < array.Length - 1; sort++)
                    {
                        if (array[sort] > array[sort + 1])
                        {
                            temp = array[sort + 1];
                            array[sort + 1] = array[sort];
                            array[sort] = temp;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[array.Length - (i + 1)];
                }

                return tempArray;
            }
        }

        public static int[] Bubble(int[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            return array;
        }
    }
}