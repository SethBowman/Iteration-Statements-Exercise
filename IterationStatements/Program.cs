namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNums1000()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThree()
        {
            for(int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TwoNumsSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are the same");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not the same");
                return false;
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is positive");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is negative");
                return false;
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while(canParse == false)
            {
                Console.WriteLine("Please enter a valid age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if(userAge >= 18)
            {
                Console.WriteLine($"Congrats! {userAge} is old enough to vote!");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote..");
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInTenRange(int num)
        {
            if(num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the ten range");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is not in the ten range");
                return false;
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyThru12(int num)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNums1000();
            UpByThree();
            TwoNumsSame(4, 3);
            EvenOrOdd(16);
            IsPositive(18);
            CanVote();
            IsInTenRange(-10);
            MultiplyThru12(5);
        }
    }
}
