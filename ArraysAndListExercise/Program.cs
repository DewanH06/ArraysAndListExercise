//TODO:

// Create an int Array and populate numbers 1-10 - DONE
var numbers = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

/* Create two Lists of type int.
 * Name one List "evens"
 * Name the other List "odds" - DONE
 */
var evens = new List<int>();
var odds = new List<int>();

/* Using either a foreach or for loop,
 * nest an if statement to check to see
 *  if a number is even or odd.
 * Then add those numbers to either the evens List
 * or the odds List - DONE
 */
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evens.Add(numbers[i]);
    }
    else
    {
        odds.Add(numbers[i]);
    }
}
/* Now using foreach or for loops,
 * display each List of even and odd numbers
 *
 * Try to be creative in your display -DONE
 */ 
foreach(var evenNum in evens)
{
    Console.WriteLine($"{evenNum} is an even number");
}
foreach(var oddNum in odds)
{
    Console.WriteLine($"{oddNum} is an odd number");
}

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50 -DONE
            var numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine($"first number: {numbers[0]}\n");
            //TODO: Print the last number of the array            
            Console.WriteLine($"last number {numbers[numbers.Length - 1]}\n");


            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            var numbersReversed = numbers;

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbersReversed);
            NumberPrinter(numbersReversed);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);


            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();



            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numList}");




            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);



            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Capacity}");


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isANumber;


            do
            {

                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);


            } while (isANumber == false);
            NumberChecker(numList, userNumber);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);


            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();

            //TODO: Clear the list

            numList.Clear();

            Console.WriteLine("List is clear");

            #endregion
        }



        private static void ThreeKiller(int[] numbers)

        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            } NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yes we have the number you searched for");
            }
            else
            {
                Console.WriteLine(" No the number is not on the list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            while (numberList.Count <= 50)
            {
                var number = rng.Next(0, 51);

                numberList.Add(number);
            }
            NumberPrinter(numberList);
        }


        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            var reversedArray = new int[array.Length];
            var counter = 0;

            for (var i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[counter++] = array[i];
                counter++;
            }

        }



        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>

        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    } 
}
