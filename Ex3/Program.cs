namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Outputting Strings
            /*
            a. Declare a string and give it the value “I’m in Game 1377: Scripting for Game Designers”.
            b. Output the string to a new line.
            c. Output the string in all caps in a new line.
            d. Output the string in all lower case in a new line.
            e. Output the letters starting from 8
            f. Output letters 8-11 inclusive.
            g. Output just letter 8.
            */
            string smt = "I’m in Game 1377: Scripting for Game Designers";

            Console.WriteLine("\n" + smt);
            Console.WriteLine("\n" + smt.ToUpper());
            Console.WriteLine("\n" + smt.ToLower());
            Console.WriteLine("\n" + smt.Substring(7));
            Console.WriteLine("\n" + smt.Substring(7, 4));
            Console.WriteLine("\n" + smt[7]);

            //2 Arithmetic
            /*
            a. Declare two integer variables and name them intInput1 and intInput2.
            b. Read in two inputs from the user and store them in these two variables (You may want
            to declare some other variables to do this safely, but you don’t have to)
            c. Output the sum (add), difference (subtract), product (multiply), quotient (divide) and
            remainder (modulo) of the first input by the second input.
            d. i.e. first input + second input, first input – second input, etc.
            e. NOTE: be sure the division can output decimal points
             */

            Console.WriteLine("\n Insert int1");
            int intInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Insert int2");
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            int sum = intInput1 + intInput2;
            int diff = intInput1 - intInput2;
            int prod = intInput1 * intInput2;
            float quot = (float)intInput1 / intInput2;
            int rem = intInput1 % intInput2;

            Console.WriteLine("\n operations:" + "\n" + sum + "\n" + diff + "\n" + prod + "\n" + quot + "\n" + rem);

            //3 Assignment
            /*
            a. Declare two new float variables and name them floatInput1 and floatInput2
            b. Read in two inputs from the user and store them in these two variables
            c. Add floatInput2 to floatInput1 and assign that to floatInput2 using one operation
            d. Subtract floatInput1 from floatInput2 and assign that to floatInput2 using one operation
            e. Multiply floatInput1 by floatInput2 and assign that to floatInput2 using one operation
            f. Divide floatInput2 by floatInput1 and assign that to floatInput2 using one operation
             */
            Console.WriteLine("\n Insert float1: ");
            float floatInput1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Insert float2: ");
            float floatInput2 = float.Parse(Console.ReadLine());
            floatInput2 += floatInput1;
            floatInput2 -= floatInput1;
            floatInput2 *= floatInput1;
            floatInput2 /= floatInput1;

            //4 Comparison and Conditionals
            /*
            a. Declare two integer variables and name them intInput1 and intInput2.
            b. Read in two inputs from the user and store them in these two variables
            c. Using some comparison operations (==, !=, &lt;, &gt;, &lt;=, and &gt;=) and conditional statements
            (if, else if, else), output information that tells if they are equal or which one is greater.
            (you will not need all of the comparison operations).
            d. Examples:
            i. if you input 1 and 2, the program should output
                1. “intInput2 is greater than intInput1”
            ii. If you input 1 and 1, the program should output
                1. “The inputs are equal”
            iii. If you input 1 and 0, the program should output
                1. “intInput1 is greater than intInput2”
             */

            Console.WriteLine("\n Insert another int1: ");
            int newIntInput1 = Convert.ToInt32(Console.ReadLine()); //they were already declared with the same name in part 1.
            Console.WriteLine("\n Insert another int2: ");
            int newIntInput2 = Convert.ToInt32(Console.ReadLine());

            if (intInput1 == intInput2) { Console.WriteLine("int input 1 is equal to int input 2"); }
            else if (intInput1 != intInput2)
            {
                Console.WriteLine("int input 1 and int input 2 are different: \n");
                if (intInput1 > intInput2) { Console.WriteLine("int input 1 grater than int input 2"); }
                else if (intInput1 < intInput2) { Console.WriteLine("int input 2 grater than int input 1"); }
            }
        }
    }
}
