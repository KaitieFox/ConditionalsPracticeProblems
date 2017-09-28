using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w1d3
{
    class Program
    {
        static void Main(string[] args)
        //first problem
        {
            Console.WriteLine("Please enter a number");
            int userNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("I needs another number also.");
            int userNum2 = int.Parse(Console.ReadLine());

            if (userNum1 == userNum2)
            {
                Console.WriteLine(userNum1 + " and " + userNum2 + " are equal.");
            }
            else
            {
                Console.WriteLine(userNum1 + " and " + userNum2 + " are not equal.");
            }
            //second problem

            Console.WriteLine("Let's try something else. Can I have another number?");
            int evenOdd = int.Parse(Console.ReadLine());

            if (evenOdd % 2 == 0)
            {
                Console.WriteLine(evenOdd + " is even, dawg.");
            }

            else
            {
                Console.WriteLine(evenOdd + " is odd, like you.");
            }

            //third
            Console.WriteLine("Seems legit. But let's move on from here. I'd like another number, if that's not too much trouble.");
            int negPos = int.Parse(Console.ReadLine());

            if (negPos < 0)
            {
                Console.WriteLine(negPos + " is just so negative.");
            }
            else if (negPos > 0)
            {
                Console.WriteLine("That's thinking positive! " + negPos + " is positive.");
            }
            else
            {
                Console.WriteLine("Or you can enter " + negPos + ". That's fine too.");
            }

            //problem 4
            //and boy how this is a problem.

            Console.WriteLine("This is great. Let's switch gears. How about a letter?");

            string letter = Console.ReadLine().ToLower();
            char userLetter = char.Parse(letter);
            {
                switch (userLetter)
                {
                    case 'a':
                        Console.WriteLine("That's a vowel.");
                        break;
                    case 'e':
                        Console.WriteLine("That's a vowel.");
                        break;
                    case 'i':
                        Console.WriteLine("That's a vowel.");
                        break;
                    case 'o':
                        Console.WriteLine("That's an actual vowel.");
                        break;
                    case 'u':
                        Console.WriteLine("That's a vowel.");
                        break;
                    default:
                        Console.WriteLine("Well, that's a consonant.");
                        break;
                }
            }

            //problem 5

            Console.WriteLine("Moving on. Another number.");

            int compareThis = int.Parse(Console.ReadLine());

            Console.WriteLine("And another. I promise this will be fun.");

            int compareThat = int.Parse(Console.ReadLine());

            if (compareThis > compareThat)
                Console.WriteLine(compareThis + " is the biggerest.");
            else if (compareThis < compareThat)
                Console.WriteLine(compareThat + "is yuger.");
            else
                Console.WriteLine("I really don't know what you did.");

            //problem 6
            
            Console.WriteLine("Maybe that wasn't so fun. This one will though! I'm going to need a number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Another.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Last one.");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Just kidding I need one more.");
            int number4 = int.Parse(Console.ReadLine());

            double sum = number1 + number2 + number3 + number4;
            Console.WriteLine("Watch this. It's a trick. The mean is " + (sum / 4) + ".");



        }
    }
}
