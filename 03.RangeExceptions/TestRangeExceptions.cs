// Problem 3. Range Exceptions
// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].
// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
// entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _03.RangeExceptions
{
    using System;

    public static class TestRangeExceptions
    {
        public static void Main()
        {
            Console.Write("To test a number press 1, to test a date press any othe key to continue: ");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Enter an integer: ");
                PrintNumber();
            }
            else
            {
                Console.Write("Enter a date in the format: dd, mm, yyyy: " );
                PrintDate();
            }
        }

        public static int GetNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("Number out of range", start, end);
            }

            return number;
        }

        public static void PrintNumber()
        {
            try
            {
                Console.WriteLine("Enter an integer: " + GetNumber(1, 100));
            }
            catch (InvalidRangeException<int> irex)
            {
                Console.WriteLine("Number is out of the range [{0} to {1}]", irex.Start, irex.End);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured!" , e.Message);
            }    
        }

        public static DateTime GetDate(DateTime start, DateTime end)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("The date is out of range", start, end);
            }

            return date;
        }

        public static void PrintDate()
        {
            try
            {
                Console.WriteLine("Enter a date: " + GetDate(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31)));
            }
            catch (InvalidRangeException<DateTime> irex)
            {
                Console.WriteLine("The date is out of the range [{0} to {1}]", irex.Start, irex.End);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured!" , e.Message);
            }
        }
    }
}
