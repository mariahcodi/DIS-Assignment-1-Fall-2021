using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DIS_Assignment_1_Fall_2021
{
    class Program
    {
        static void Main(string[] args)
        {   //Question 1
            
            Console.WriteLine("Q1 : Enter the string:");
            //read string into variable s
            string s = Console.ReadLine();
            
            //new method, striung s is output of bool value (true/false)
            static bool HalvesAreAlike(string s)
            {
                //break string into 2 lengths
                int total = s.Length / 2;
                //define vowel set
                string vowels = "aeiouAEIOU";
                //initialize count variables to be used later
                int counta = 0;
                int countb = 0;

                //Console.WriteLine(s.Length % 2);


                try
                {
                    //handling only cases which fit constraints - all others will go to exception or return false
                    if (s.Length <= 1000 && s.Length >= 2 && (s.Length % 2) == 0)
                    {
                        //loop to get vowel count value for first half of string, total is half of s
                        for (int i = 0; i < total; i++)
                        {
                            if (vowels.Contains(s[i]))
                                counta++;
                        }
                        //starting at total, as a counted up to total exclusive
                        for (int i = total; i < s.Length; i++)
                        {
                            if (vowels.Contains(s[i]))
                                countb++;
                        }
                        //if same vowel count, return true
                        if (counta == countb)
                        {
                            return true;
                        }
                        //if not same, return false
                        else
                        {
                            return false;
                        }
                    }
                    //if < 2, > 1001, or not even length, will return false
                    else
                    {
                        return false;
                    }
                }            
                
                catch (Exception)            
                {                
                    throw;            
                }        
            }
            //assign bool value to variable
            bool pos = HalvesAreAlike(s);
            //if true, output alike. if false, output not alike
            if (pos)
            {
                Console.WriteLine("Both Halves of the string are alike");
            }
            else
            {
                Console.WriteLine("Both Halves of the string are not alike");
            }
            //for own checks I also wrote out the value true/false
            Console.WriteLine(pos);
            




            //Question 2
            Console.WriteLine(" Q2 : Enter the string to check for pangram:"); 
            string s1 = Console.ReadLine();
            //needed to remove spaces from line to handle w my solution, handles spaces in between and at beginnings and ends
            string trim = Regex.Replace(s1, @"\s+", "");
            bool flag = CheckIfPangram(trim);


            static bool CheckIfPangram(string sentence)
            {
                //initialize new array to hold count values 26 length (for unique numbers up to 26 letters of alphabet)
                int[] count = new int[26];

                try
                {
                    //get position for each character (character values are stored as a number) and add to array
                    foreach (char c in sentence)
                        count[c - 'a']++; //a-a = 0, b-a = 1, c-a = 2, etc

                    //if values of array equal 0 (if a didn't exist, or b, etc)
                    for (int i = 0; i < 26; i++)
                        if (count[i] == 0)
                            return false;
                    //else return true (meaning all characters exist uniquely)
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        

            //if true, is pangram
            if (flag) 
            { 
                Console.WriteLine("Yes, the given string is a pangram"); 
            } 
            //if false, not a pangram
            else 
            { 
                Console.WriteLine("No, the given string is not a pangram"); 
            }

            Console.WriteLine();
            
            
            
            
            //Question 3
            //two dimensional array initialization
            
            int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } }; 
            int Wealth = MaximumWealth(arr); 



            Console.WriteLine("Q3:"); 
            Console.WriteLine("Richest person has a wealth of {0}", Wealth);

            


            static int MaximumWealth(int[,] accounts)
            {
                

                //assign temp array to hold sum of wealth for each account holder
                int[] wealthArray = new int[accounts.GetLength(0)];
                int richestAccount;


                try
                {
                    // write your code here
                    //for loop where i<length of array passed
                    //for each person and account add balance for each account holder
                    for (int i = 0; i < accounts.GetLength(0); i++)
                    {
                        for (int j = 0; j < accounts.GetLength(1); j++)
                        {
                            wealthArray[i] += accounts[i, j];
                        }
                    }
                    //compare each account holders sum and assign value to richestAccount variable
                    richestAccount = wealthArray[0];
                    for (int i = 0; i < wealthArray.Length; i++)
                    {
                        if (richestAccount < wealthArray[i])
                        {
                            richestAccount = wealthArray[i];
                        }
                    }
                    //return the largest amt
                    return richestAccount;
                

                }
                catch (Exception)

                {
                    throw;
                }
            }
             




            //Question 4
            
            Console.WriteLine("Q4:");
            //you said not to change the code provided....leaving the below as it was in the assignment sheet, initially thought to do my own input but not sure what to do here
            string jewels = "aA"; 
            string stones = "aAAbbbb"; 
            
            
            int num = NumJewelsInStones(jewels, stones); 
            


            static int NumJewelsInStones(string jewels, string stones)
            {
                int result = 0;

                try
                {                // write your code here.

                    //foreach loop to get the instances where jewels characters = stones characters, then add to result count
                    foreach (char c in jewels)
                    {
                        foreach (char d in stones)
                        {
                            if (c==d)
                            {
                                ++result;
                            }
                        }
                    }
                    //if result is not 0, return value, else return 0
                    if (result != 0)
                    {
                        return result;
                    }
                    else
                    {
                        return 0;
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured: " + e.Message);
                    throw;
                }
            }
            //Console.WriteLine(jewels + ' ' + stones);
            Console.WriteLine("the number of stones you have that are also jewels are {0}:", num);
            Console.WriteLine();
            

            //Question 5
            



            Console.WriteLine("Q5:"); 
            String word2 = "aiohn"; 

            int[] indices = { 3, 1, 4, 2, 0 }; 

            String rotated_string = RestoreString(word2, indices);

            static string RestoreString(string s, int[] indices)
            {
                //new length variable to read in word2 length
                int length = s.Length;
                //new result character array with size "length"
                char[] result = new char[length];
                

                try
                {                // write your code here.
                    //for loop to determine which position 0 in untangled string matches with the tangled string
                    for (int i=0; i < length; i++)
                    {
                        result[indices[i]] = s[i];

                    }
                    //use string constructor, which is used when converting from char[] to string
                    if (result is not null)
                    {
                        return new string(result);
                    }
                    else
                    {
                        return "null";
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            //actually had to change the syntax below to +'s and add a space for the rotated string to show properly
            Console.WriteLine("The Final string after rotation is" + ' ' +  rotated_string);
           





            //Question 6
            Console.WriteLine("Q6: Enter the sentence to convert:"); 

            int[] nums = { 0, 1, 2, 3, 4 }; 
            int[] index = { 0, 1, 2, 2, 1 };
            int[] target = CreateTargetArray(nums, index);

            Console.WriteLine("Target array  for the Given array's is:");

            for (int i = 0; i < target.Length; i++) 
            { 
                Console.Write(target[i] + "\t"); 
            }

            Console.WriteLine();

            static int[] CreateTargetArray(int[] nums, int[] index) 
            { 
                try 
                { 
                    //initialize new target array with size length of nums array
                    int[] target = new int[nums.Length]; 

                    //for loop to stop once i >= length of array
                    for (int i = 0; i<nums.Length; i++)
                    {
                        //so for index 0 == 0...
                        if (index[i] == i)
                        {
                            //then target pos 0 is assigned nums pos 0 value
                            target[i] = nums[i];
                        }
                        else
                        {
                            //but if index[i] not equal to i, for loop to step back target position since you will need to iterate the position's value (multiple values into position 2)
                            for (int i2 = i; i2 > index[i]; i2--)
                            {
                                target[i2] = target[i2 - 1];

                            }
                            target[index[i]] = nums[i];
                        }
                    }
                    //return array
                    return target; 
                } 
                catch (Exception)
                { 
                    throw; 
                } 
            }
            
        }


    }


}
   

