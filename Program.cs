using System;
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

            Console.WriteLine("we can use the same method to find the index of the last occurance of the letter \"w\" in the rhyme:");
            Console.WriteLine(maryRhyme);
            string searchChar = "w";
            Console.WriteLine("the last instance of \"w\" is: " + maryRhyme.LastIndexOf("w"));

            Console.WriteLine("Print out the lenght of \"basketball\" without assigning any variables");
            Console.WriteLine("basketball".Length);

            Console.WriteLine("using mary's rhyme, replace every \"little\" with \"big big\" like this. first let's remember the rhyme: ");
            Console.WriteLine(maryRhyme);
            Console.WriteLine("then use the replace method: ");
            string toBeReplaced = "little";
            string replaceWith = "big big";
            string newMaryRhyme = maryRhyme.Replace("little", "big big");
            Console.WriteLine(newMaryRhyme);

            Console.WriteLine("now we'll remove the word \"little\" from the rhyme using the replace function: ");
            Console.WriteLine("original rhyme: \n" + maryRhyme);
            Console.WriteLine(maryRhyme.Replace("little", ""));

            string phoneNum = "111-222-3333";
            Console.WriteLine("Now we'll look at a phone number \n" + phoneNum + "\nand extract the area code using substring(index to start, number of characters)");
            Console.WriteLine("the area code is: " + phoneNum.Substring(0, 3));

            Console.WriteLine("now we'll extract the local number without area code using the same method");
            Console.WriteLine(phoneNum.Substring(4));

            Console.WriteLine("now we'll use the same method to extract the \"central office number\" or the three numbers in the midddle of the phone number");
            Console.WriteLine(phoneNum.Substring(4, 3));

            Console.WriteLine("Now we'll find the last \"1\" and print out its position");
            Console.WriteLine(phoneNum.LastIndexOf("1"));

            string greeting = "    how are you    ";
            Console.WriteLine("now we'll take the string printed below and trim out the whitespace, we'll prove the whitespace at the end is gone by printing X after it");
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.Trim() + "X");

            Console.WriteLine("Now we'll only trim the trailing whitespaces with the TrimEnd method, again adding the X to prove it");
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.TrimEnd() + "X");

            Console.WriteLine("Now we'll trim the beginning but not the end of the line: ");
            Console.WriteLine(greeting);
            Console.WriteLine(greeting.TrimStart() + "X");

            Console.WriteLine("Now, we'll look back at the mary's little lamb rhyme and figure out how to tell the position of the rhyme of the word \"lamb\" in the second line (basically get the index of the word \"lamb\" in the second line:");
            Console.WriteLine(maryRhyme);
            Console.WriteLine("first we find out the index of the beginning of the second line and the end of the second line using IndexOf:");
            int lineStartsAt = maryRhyme.IndexOf("\n") + 1;
            int wordStartsAt = maryRhyme.IndexOf("lamb", lineStartsAt);
            Console.WriteLine("so the second line begins at {0}", lineStartsAt);
            Console.WriteLine("now we overload IndexOf so that it looks for the word \"lamb\" after the beginning of the line");
            Console.WriteLine("so \"lamb\" starts at the index of " + wordStartsAt + " in the second line");
            Console.WriteLine("but we want the location RELATIVE to the second line, not the whole rhyme, so we need to subtract the index of where the line starts from the index of where the word starts.");
            Console.WriteLine("So, relative to only the second line, the word \"lamb\" is at position " + (wordStartsAt - lineStartsAt));

            string string1 = "Hello";
            string string2 = "Jonathon";
            Console.WriteLine("Now we'll take two words and have the program pad them so they are right justified on two seperate lines");
            Console.WriteLine("in this case with only two words we can just print out the first string but pad it left the lenght of the second");
            int difference = string2.Length - string1.Length;
            Console.WriteLine(string1.PadLeft(string2.Length) + "\n" + string2);

            Console.WriteLine("Now we'll take take the same two words but pad them left with the letter \"o\" instead of spaces by overloading the padleft method");
            Console.WriteLine(string1.PadLeft(string2.Length, 'o') + "\n" + string2);

            Console.WriteLine("now we'll use the same two strings and make them print out on separate lines, left aligned but with periods to make them the same lenghts");
            Console.WriteLine("we can use the padRight method to do this");
            Console.WriteLine(string1.PadRight(string2.Length, '.') + "\n" + string2);

            string smary = "mary";
            string shad = "had";
            string sa = "a";
            string slittle = "little";
            string slamb = "lamb";
            Console.WriteLine("now we'll look at \"mary had a little lamb\" each letter saved as a separate variable and print them out one on each line but in a field 10 characters long - this will right justify them at the end of the field");
            Console.WriteLine("{0, 10}", smary);
            Console.WriteLine("{0, 10}", shad);
            Console.WriteLine("{0, 10}", sa);
            Console.WriteLine("{0, 10}", slittle);
            Console.WriteLine("{0, 10}", slamb);
            
            Console.WriteLine("now we'll do the same but this time left justify them in a field that is 10 spaces and also put a pipe around the fields");
            Console.WriteLine("|{0, -10}|", smary);
            Console.WriteLine("|{0, -10}|", shad);
            Console.WriteLine("|{0, -10}|", sa);
            Console.WriteLine("|{0, -10}|", slittle);
            Console.WriteLine("|{0, -10}|", slamb);
            
        }
    }
}
