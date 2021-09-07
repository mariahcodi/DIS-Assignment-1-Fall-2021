using System;
using System.Collections.Generic;
using System.Linq;

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
        }
    }
}
