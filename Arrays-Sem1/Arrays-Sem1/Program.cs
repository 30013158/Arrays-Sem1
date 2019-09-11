using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Sem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Examples of array declarations*/

            /*------------------------------------------------------------------------------------*/

            /*Create an array of strings called names*/
            string[] names;
            /*This array has been created with no size and therefor cant be used as it is, an array
              has to be given a size for it to be used, in this case names can now hold 3 strings*/
            names = new string[3];
            /*We can now add some data to the array, in this case the array can hold 3 strings*/
            names[0] = "Jacob";
            names[1] = "Hamiora";
            names[2] = "Steven";
            /*We can use a foreach loop to display all of the names*/
            Console.WriteLine("***** String Array *****");
            foreach (string x in names)
            {
                Console.WriteLine(x);
            }

            /*------------------------------------------------------------------------------------*/

            /*We can also create and declare the size of the array on one line*/
            double[] numbers = new double[4];
            /*We may not always have the data to put into the array at the time when its created so 
            we can always do this at a later time. Lets fill it with some data using a for loop*/
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i + 1) / 3.6;
            }
            /*Display the array*/
            Console.WriteLine("\n\n***** Doubles Array *****");
            foreach (double x in numbers)
            {
                Console.WriteLine(x);
            }
            /*------------------------------------------------------------------------------------*/


            /*We can also create an array and fill it with data straight away*/
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            /*Display the array*/
            Console.WriteLine("\n\n***** Char Array *****");
            foreach (char x in vowels)
            {
                Console.Write(x + " ");
            }

            /*-----------------------------------------------------------------------------------*/
            Console.WriteLine("********************************");
            Console.WriteLine("******** Array Elements ********");
            Console.WriteLine("********************************\n");

            /*Create an int array of size 5 with no data in it*/
            int[] nums = new int[5];

            /*Assign ints' to the 5 elements in the array*/
            /*Remember - Arrays indicies always start at 0*/
            nums[0] = 10;
            nums[1] = 100;
            nums[2] = 1000;
            nums[3] = 10000;
            nums[4] = 100000;

            /*We can also display each element by using its index(it number)*/
            Console.WriteLine("Display elements individually");
            Console.WriteLine("Index 0: " + nums[0]);
            Console.WriteLine("Index 4: " + nums[4]);

            /*Or we could use a loop to go through the indicies*/
            Console.WriteLine("\nDisplay elements using a loop");
            for (int i = 0; i < nums.Length; i++)
            {
                /*We can use i inside of the square brackets to go through the array*/
                Console.WriteLine("Index " + i + ": " + nums[i]);
            }

            /*Create a string array to hold the names of trees*/
            string[] trees = { "Tawa", "Kauri", "Totara", "Rimu", "Pohutukawa" };

            Console.WriteLine("****************************************");
            Console.WriteLine("********* The Length Property **********");
            Console.WriteLine("****************************************\n");
            Console.Write("Number of elements in the array: ");

            /*Use the .Length property to see how many elements are in the array*/
            Console.Write(trees.Length);

            Console.Write("\n\n\n");
            Console.WriteLine("****************************************");
            Console.WriteLine("*********** The Sort Method ************");
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Elements in the array BEFOR sorting, take note of the unsorted order: ");
            DisplayArrays(trees);

            /*Here we use the array.sort() method and pass it our trees array*/
            Array.Sort(trees);

            Console.WriteLine("Elements in the array AFTER sorting, take note of the alphabetical order: ");
            DisplayArrays(trees);

            Console.Write("\n\n\n");
            Console.WriteLine("****************************************");
            Console.WriteLine("********** The Reverse Method **********");
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Elements in the array BEFOR reversing, take note they are still in alphbetical order: ");
            DisplayArrays(trees);
            Array.Reverse(trees);

            Console.WriteLine("Elements in the array AFTER reversing, take note they are in reverse alphbetical order: ");
            DisplayArrays(trees);

            //array  revision questions of screenshot2

            /*Ex 1*/
            int size = 50;
            int[] nums = new int[size];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 100);
            }

            Display(nums);


            /*Ex 2*/
            Console.WriteLine($"The value is located at index {FindIndex(nums)}");

            Console.ReadLine();

            /*Ex 3*/
            int[] copiedArray = new int[nums.Length];
            Array.Copy(nums, copiedArray, nums.Length);
            Display(copiedArray);

            /*Ex 4*/
            Array.Sort(copiedArray);
            Console.WriteLine("\n...Sorted Order...");
            Display(copiedArray);
            Console.WriteLine("\n...Reversed Order...");
            Array.Reverse(copiedArray);
            Display(copiedArray);
        }
        static void DisplayArrays<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine("\n");
        }
        static int FindIndex(int[] arr)
        {
            Console.WriteLine("What value would you like to find: ");
            int input = int.Parse(Console.ReadLine());
            return Array.IndexOf(arr, input);
        }

        static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
