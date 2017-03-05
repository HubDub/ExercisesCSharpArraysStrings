using System;
using System.Linq;

namespace ConsoleApplication
{
    public class HighAndLowMethod
    {
        public static string HighAndLow(string numbers)
        {
            //receive a string of numbers and return the highest and lowest in string
            Console.WriteLine(numbers);
            var newString = numbers.Split().Select(int.Parse);                
            //string[] newArray = numbers.Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(newArray[0]);
            //int[] numArray = newArray.Select(s => int.Parse(s)).ToArray();
            //Console.WriteLine(numArray[0]);
            //string highestAndLowest = numArray.Max().ToString() + " " + numArray.Min().ToString(); 
            string highestAndLowest = newString.Max() + " " + newString.Min();
            Console.WriteLine(highestAndLowest);
            return highestAndLowest;
        }
    }
}
