using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Collectins
{
    class Program
    {
        public static void DisplayList(List<string> input)
        {
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n");
        }
        public static void RemoveAllWith(char character, ref List<string> input)
        {
            int i = 0;
            while (i < input.Count)
            {
                if (input[i][0] == character)
                {
                    input.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
        public static void DisplayLengthOfEachListItem(List<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"length of {item}: {item.Length}");
            }
            Console.Write("\n");
        }
        public static void ListWork()
        {
            // Create a list of strings and add at least five different names to it.
            List<string> list = ["Buhran", "Areeba", "Ali", "Noor", "Rahan"];
            DisplayList(list);

            // Write a method to remove all names from the list that start with the letter 'A'.
            RemoveAllWith('A', ref list);
            DisplayList(list);

            // Write a program to display the length of each name in the list.

            DisplayLengthOfEachListItem(list);
        }

        public static void PrintOldestPerson(Dictionary<string, int> input)
        {
            string oldestPersonID = "";
            int oldestPersonAge = 0;

            foreach (var item in input)
            {
                if (item.Value > oldestPersonAge)
                {
                    oldestPersonAge = item.Value;
                    oldestPersonID = item.Key;
                }
            }
            Console.WriteLine($"{oldestPersonID}: {oldestPersonAge}");
        }

        public static void DictionaryWork()
        {
            // Create a dictionary of string keys and int values to represent the ages of people.
            Dictionary<string, int> person = new()
            {
                // Add at least three entries to the dictionary
                { "L1F21BSCS1059", 21 },
                { "L1F21BSCS0485", 22 },
                { "L1F21BSCS0484", 5 }
            };
            //Write a method to find and print the oldest person's name and age from the dictionary.
            PrintOldestPerson(person);
        }
        public static void DisplayHashSet(HashSet<int> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintUnion(HashSet<int> input1, HashSet<int> input2)
        {
            Console.WriteLine("Union:");
            HashSet<int> union = new(input1);
            union.UnionWith(input2);
            DisplayHashSet(union);
        }
        public static void PrintIntersection(HashSet<int> input1, HashSet<int> input2)
        {
            Console.WriteLine("Intersection:");
            HashSet<int> intersection = new(input1);
            intersection.IntersectWith(input2);
            foreach (var item in intersection)
            {
                Console.WriteLine(item);
            }
        }
        public static void HashSetWork()
        {
            // Create two sets of integers with some common elements.
            HashSet<int> set1 = [1, 3, 4, 2, 5, 145, 65];
            HashSet<int> set2 = [48, 65, 3, 4, 48, 245, 45];
            // Write a method to find and print the union of the two sets.
            PrintUnion(set1, set2);
            // Write a program to find and print the intersection of the two sets.
            PrintIntersection(set1, set2);
        }
        public static void PrintUniqueElementFromList()
        {
            List<int> intigerList = [1, 5, 1, 5, 65, 16, 4, 84, 51, 34, 684, 51, 64, 654, 8614, 654, 515, 41, 5616, 1, 64, 51];

            HashSet<int> intigerListToSet = new(intigerList);
            DisplayHashSet(intigerListToSet);
            Console.WriteLine($"intigerList: {intigerList.Count}");
            Console.WriteLine($"intigerListToSet: {intigerListToSet.Count}");
        }
        public static int FindSecondLargest(int[] input)
        {
            int secondLargest;
            if (input.Length == 2)
            {
                secondLargest = input[0];
                if (secondLargest > input[1])
                {
                    secondLargest = input[1];
                }
            }
            else if (input.Length > 2)
            {
                List<int> sortedInput = new(input);
                sortedInput.Sort();
                secondLargest = sortedInput[^2];
            }
            else
            {
                throw new Exception("Array length must be at least 2.");
            }
            return secondLargest;
        }

        public static void PrintUniqueWordCount()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? "";
            string[] wordArray = input.Split(' ');
            Dictionary<string, int> wordCount = new();
            foreach (var word in wordArray)
            {
                if (word != "")
                {
                    if (wordCount.TryGetValue(word, out int itemCount))
                    {
                        wordCount[word] = itemCount + 1;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }
                }
            }

            foreach (var word in wordCount)
            {
                if (word.Value == 1)
                {
                    Console.WriteLine($"{{{word.Key}}} count: {word.Value}");
                }
            }
        }
        public static void RandomPasswordGenerator()
        {
            Console.Write("Enter the length of password you want: ");
            int passwordLength = Convert.ToInt32(Console.ReadLine());
            string Password = "";

            Random generator = new Random();
            bool containsUppercaseAlphabet = false;
            bool containsLowercaseAlphabet = false;
            bool containsNumber = false;
            bool containsSpecialCharacter = false;
            char character;
            while (true)
            {
                Password = ""; // Reset password for each iteration
                while (Password.Length < passwordLength)
                {
                    character = Convert.ToChar(generator.Next(32, 127));
                    Password += character;

                    if (character >= 'A' && character <= 'Z') { containsUppercaseAlphabet = true; }
                    else if (character >= 'a' && character <= 'z') { containsLowercaseAlphabet = true; }
                    else if (character >= '0' && character <= '9') { containsNumber = true; }
                    else { containsSpecialCharacter = true; }
                }

                if (containsUppercaseAlphabet && containsLowercaseAlphabet &&
                    containsNumber && containsSpecialCharacter)
                {
                    break;
                }
                else
                {
                    containsUppercaseAlphabet = false;
                    containsLowercaseAlphabet = false;
                    containsNumber = false;
                    containsSpecialCharacter = false;
                }
            }
            Console.WriteLine($"Random Password: {Password}");
        }
        public static void Main()
        {
            //ListWork();
            //DictionaryWork();
            //HashSetWork();

            //// Write a program that takes a list of integers as input and returns a new list with only the unique elements.
            //PrintUniqueElementFromList();

            //// Write a method that takes an array of integers and returns the second largest element.
            //try
            //{
            //    Console.WriteLine($"Second largest value: {FindSecondLargest([1, 2, 3, 4, 5, 6, 7, 8, 9])}");
            //    Console.WriteLine($"Second largest value: {FindSecondLargest([8, 9])}");
            //    Console.WriteLine($"Second largest value: {FindSecondLargest([1])}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// Write a program that reads a sentence from the user and prints the count of each unique word in the sentence.
            //PrintUniqueWordCount();

            //// Write a program that generates a random password of a given length, ensuring it contains a mix of uppercase letters, lowercase letters, numbers, and special characters.
            //RandomPasswordGenerator();
        }
    }
}
