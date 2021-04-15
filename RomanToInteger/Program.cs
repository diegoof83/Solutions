using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman1 = "VI";
            int interger1 = RomanToInt(roman1);
            Console.WriteLine("Roman: {0} = Integer: {1}", roman1, interger1);

            string roman2 = "IV";
            int interger2 = RomanToInt(roman2);
            Console.WriteLine("Roman: {0} = Integer: {1}", roman2, interger2);

            //string roman3 = "";
            //int interger3 = RomanToInt(roman3);
            //Console.WriteLine("Roman: {0} = Integer: {1}", roman1, interger3);
        }

        public static int RomanToInt(string romanNumber)
        {
            //Building a map between Roman and Integer values
            var dictionary = new Dictionary<char, int>(){
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            var value = 0;

            if (!string.IsNullOrWhiteSpace(romanNumber) && (romanNumber.Length >= 1) && (romanNumber.Length <= 15))
            {
                var keybefore = char.MinValue;
                var romanNumberReversedList = romanNumber.Reverse<char>();

                //Reverse loop
                foreach (var key in romanNumberReversedList)
                {
                    if (keybefore.Equals(char.MinValue))
                    {
                        keybefore = key;
                        value += dictionary.GetValueOrDefault(key);
                    }
                    else
                    {
                        //I can be placed before V(5) and X(10) to make 4 and 9.
                        if (key.Equals('I'))
                            if ((keybefore.Equals('V')) || (keybefore.Equals('X')))
                            {
                                value -= dictionary.GetValueOrDefault(key);
                            }
                            else
                            {
                                value += dictionary.GetValueOrDefault(key);
                            }
                    }

                    //X can be placed before L(50) and C(100) to make 40 and 90.
                    //C can be placed before D(500) and M(1000) to make 400 and 900.                    
                }
            }
            return value;
        }

        public bool CheckSmallestToLargest(char c)
        {
            return true;
        }
    }
}
