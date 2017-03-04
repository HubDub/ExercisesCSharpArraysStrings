﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This file is about arrays and strings");
            Console.WriteLine("First let's print each item in an array by index");
            int[] numbers = {1, 2, 3, 4};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            numbers[2] = 5;
            Console.WriteLine("I inserted 5 into 2nd index. it will replace 3");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine("To print out everything in the array, we can do a foreach");
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("You can create multidimensional arrays and then foreach through them to print each item out");
            int[,] moreNumbers = new int[3, 2] {{9, 99}, {3, 33}, {5, 55}};
            foreach(int i in moreNumbers)
            {
                Console.WriteLine("{0 }", i);
            }
            Console.WriteLine("You can also create jagged arrays but can't foreach through it. Do a nested for loop");
            int[][] thirdNumbers = new int[][] { new int[] {1, 2}, new int[] {3, 4, 5}};
            for (var i = 0; i < thirdNumbers.Length; i++)
            {
                for (var j = 0; j < thirdNumbers[i].Length; j++)
                {
                Console.WriteLine(thirdNumbers[i][j]);
                }
            }
            Console.WriteLine("then you can assign different values to them and then print them again:");
            thirdNumbers[0][0] = 58;
            thirdNumbers[1][1] = 667;
            for (var i = 0; i < thirdNumbers.Length; i++)
            {
                for (var j = 0; j < thirdNumbers[i].Length; j++)
                {
                Console.WriteLine(thirdNumbers[i][j]);
                }
            }
            Console.WriteLine("Here's a new array");
            var array = new object[] {1, 2};
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("you can put it into a stack type collection and it is then backwards because the newest item goes on top");
            var stack = new Stack<object>(array);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("you can push into arrays:");
            stack.Push("last");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("you can pop off arrays:");
            var poppedValue = stack.Pop();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("STRINGS");
            var name = "John";
            Console.WriteLine("first we'll tell the type of the new variable 'name' which is many characters");
            Console.WriteLine(name.GetType());

            var str = 'H';
            Console.WriteLine("then we'll tell the type of the new variable 'H' which is one character");
            Console.WriteLine(str.GetType());

            Console.WriteLine("You can add tabs or carriage returns by adding appropriate letters and escaping them with backslashes so they are not printed:");
            Console.WriteLine("Hello \t World - this added a tab");
            Console.WriteLine("Hello \nWorld - this added a carriage return");
            Console.WriteLine("you can print out strings and add quotation marks by either escaping the extra quote using backslash:");
            var str1 = "Hello, \"World\"";
            Console.WriteLine(str1);
            Console.WriteLine("or by using the @ symbol which ignores escape symbols or allows you to use extra quotation marks");
            var str2 = @"Hello, ""World""";
            Console.WriteLine(str2);
            var str3 = @"c:\folder\folder2\folder3\file";
            Console.WriteLine(str3);

            Console.WriteLine("let's get a first and last name and then put them together");
            Console.WriteLine("first we'll concatenate them using the overloaded + symbol:");
            string s1 = "John";
            string s2 = "Leavings";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            Console.WriteLine("Then we'll do the same by using the concat method on String");
            string s4 = "John";
            string s5 = "Leavings";
            string s6 = String.Concat(s4, " ", s5);
            Console.WriteLine(s6);

            Console.WriteLine("we can also use composite formatting to output to the console instead of concatenation: ");
            string stringJane = "Jane";
            Console.WriteLine("Here we will use '{0}' and then put the variable with the name Jane stored in it after the sentence:");
            Console.WriteLine("The variable stored in stringJane is: {0}", stringJane);
            Console.WriteLine("You can do this with multiple variables:");
            string stringJoe = "Joe";
            Console.WriteLine("{0} and {1} up in a tree K I S S I N G", stringJane, stringJoe);

            Console.WriteLine("we can tell the length of a string by using the length method of String:");
            string stringJohn = "John";
            Console.WriteLine("The length of John is: " + stringJohn.Length);            

            Console.WriteLine("here we'll print a bunch of numbers separated by a space");
            string numList = "1 2 3 4 5";
            Console.WriteLine(numList);
            Console.WriteLine("then we tell it to break this string into an array on the space by telling it the space is the deliminating character");
            char[] delimChar = {' '};
            string[] splitList = numList.Split(delimChar);
            Console.WriteLine("then you can print each item in the array by calling on it's index or by foreaching through it, like before:");            
            Console.WriteLine(splitList[0]);

            Console.WriteLine("The difference between type String and type string is that there is no real difference. string is a built in alias for System.String but in general usage when we talk about a string object we use little s and when referring to a method we use big S");

            Console.WriteLine("You can make a string all lowercase: ");
            string stringLuke = "Luke";
            Console.WriteLine("So, {0} becomes {1}", stringLuke, stringLuke.ToLower());
            Console.WriteLine("You can make a string all uppercase: ");
            string stringLiz = "Liz";
            Console.WriteLine("So, " + stringLiz + " becomes " + stringLiz.ToUpper());

            Console.WriteLine("You can ask the user what their first and last names are and then print them out by saving them to variables:");
            Console.WriteLine("what is your first name?");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Your full name is: " + firstName1 + " " + lastName1);
            Console.WriteLine("make the name all upper case regardless of what they've written:");
            Console.WriteLine(firstName1.ToUpper() + " " + lastName1.ToUpper());

            Console.WriteLine("To see if two strings are equal use either the == signs, the instance method Equals or the static class method String.Equals:");
            string h1 = "hello";
            string h2 = "hello";
            bool a = (h1 == h2);
            Console.WriteLine(a);
            bool b = h1.Equals(h2);
            Console.WriteLine(b);
            bool c = String.Equals(h1, h2);
            Console.WriteLine(c);

            Console.WriteLine("You can figure out the index of the second usage of the word \"little\" in the rhyme by using the overloaded IndexOf method:");
            string maryLambLong = "Mary had a little lamb, little lamb, little lamb";
            Console.WriteLine(maryLambLong);
            Console.WriteLine("First you find the first usage of \"little\"");
            string findThis = "little";
            int firstLittle = maryLambLong.IndexOf(findThis);
            Console.WriteLine(firstLittle);
            Console.WriteLine("Then you figure out where you will start the IndexOf by adding together the index of the first instance of little to the length of little and saving that in a variable:");
            int searchAfter = firstLittle + findThis.Length;
            Console.WriteLine("so you will start searching on the {0} character", searchAfter);
            int secondLittle = maryLambLong.IndexOf("little", searchAfter);
            Console.WriteLine("so the starting index of the second instance of \"little\" is: " + secondLittle);

            Console.WriteLine("Now let's find the last occurance of \"little\" in this rhyme:");
            string maryRhyme = "Mary had a little lamb,\nlittle lamb,\nlittle lamb,\nMary had a little lamb that was as white as snow";
            Console.WriteLine(maryRhyme);
            string searchWord = "little";
            Console.WriteLine("we'll use the LastIndexOf method and find that the index of the last \"little\" is: " + maryRhyme.LastIndexOf(searchWord));

            
        }
    }
}
