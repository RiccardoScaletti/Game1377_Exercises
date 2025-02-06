using System;
using System.Collections;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Switch
 a. Output a line to the user prompting them “Input a WASD key”.
 b. Using a switch statement, output the following
 i. “You moved up” if the user put in a W.
 ii. “You moved down” if the user put in an S.
 iii. “You moved left” if the user put in an A.
 iv. “You moved right” if the user put in a D.
             */

            Console.WriteLine("Input a WASD key");
            string input = Console.ReadLine();
            switch (input)
            {
                case "W":
                    Console.WriteLine("You moved up");
                    break;
                case "A":
                    Console.WriteLine("You moved down");
                    break;
                case "S":
                    Console.WriteLine("You moved left");
                    break;
                case "D":
                    Console.WriteLine("You moved right");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                break;
            }

            /*
             Arrays and Loops
a. Write an array of ints with the values 100, 94, 159, -783, 132, 179, 47, 107, 135, 50.
b. Using a for or while loop, output all of the integers in reverse order.
c. Write a while loop that continually prompts the player for an input number. Exit the
while loop once the player selects any of the numbers in the array.
d. Using a for loop, find the average of the numbers in the array.
e. Using a for loop and continue statements, output every other number of the array
i. Hint: You will need one of the arithmetic operators to do this.
f. Using a for loop and continue statements, output every third number of the array
i. Hint: You will need one of the arithmetic operators to do this.
g. Write code that allows you to get three numbers from the user. Store these numbers in
three variables called arraySize, rangeMin, and rangeMax. Dynamically create an array
of that arraySize, then set every element of that array to a random number between
rangeMin and rangeMax.
             */
            Console.WriteLine("\n Part 2");
            int[] values = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("\n Insert Number:");
            int newInput;
            bool stop = false;

            while (stop == false) 
            {
                newInput = int.Parse(Console.ReadLine());
                foreach (var item in values)
                {
                    if (newInput == item) { stop = true; break; }
                }
                if (stop == false) { Console.WriteLine("\n Wrong Input, try again: "); } 
            }

            int num = 0;
            for (int i = 0; i < values.Length; i++) 
            {
                num += values[i];
                if (i == values.Length - 1)
                {
                    int avg = num / values.Length;
                    Console.WriteLine("\n avg : " + avg);
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (i%2 != 0) 
                {
                    continue;
                }
                Console.WriteLine("Every other number: " + values[i]);
            }

            for (int i = 2; i < values.Length; i++)
            {
                if (i%3 != 0)
                {
                    continue;
                }
                Console.WriteLine("Every third number: " + values[i]);
            }

            //arraySize, rangeMin, and rangeMax
            Console.WriteLine("\n Insert Array Size ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Insert rangeMin:");
            int rangeMin = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Insert rangeMax:");
            int rangeMax = int.Parse(Console.ReadLine());

            int[] newArr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                newArr[i] = new Random().Next(rangeMin, rangeMax);
            }
        }


        /*
         3. Methods
a. Write a method that can output all the elements of an integer array. It should take an
array of ints as a parameter.
b. Write two overloaded methods (methods with the same name) that can output all the
elements of an array of floats and an array of doubles.
c. Write a method that takes an array of ints as a parameter and returns a float average of
those values (you can reuse some of the code from the previous part).
d. Write two overloaded methods (methods with the same name) that find the averages of
arrays of floats and the array of doubles.
e. Write a method that creates a dynamically sized array of random integers based off of
three inputs: arraySize, rangeMin, and rangeMax
         */

        void ArrayOutput(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        void ArrayOutput2(float[] floatArray)
        {
            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.WriteLine(floatArray[i]);
            }
        }

        void ArrayOutput2(double[] doubleArray)
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
        }
    
        float AvgFloat(int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            float avg = (float)sum / intArray.Length;
            return avg;
        }
    
        void FindAvg(float[] floatArray)
        {
            float sum = 0;
            foreach (var item in floatArray)
            {
                sum += item;
            }
            float avg = sum / floatArray.Length;
            Console.WriteLine(avg);
        }

        void FindAvg(double[] doubleArray)
        {
            double sum = 0;
            foreach (var item in doubleArray)
            {
                sum += item;
            }
            double avg = sum / doubleArray.Length;
            Console.WriteLine(avg);
        }

        void ArrayMaker(int arraySize, int rangeMin, int rangeMax)
        {
           
            int[] newArr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                newArr[i] = new Random().Next(rangeMin, rangeMax);
            }
            Console.Write(newArr);
        }
    }
}
