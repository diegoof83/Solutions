using System;
using System.Linq;

namespace RomanToInteger
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string roman1 = "XXXVIII"; //38
                int interger1 = RomanToInt(roman1);
                Console.WriteLine("Roman: {0} = Integer: {1}", roman1, interger1);

                string roman2 = "LXXXIV"; //84
                int interger2 = RomanToInt(roman2);
                Console.WriteLine("Roman: {0} = Integer: {1}", roman2, interger2);

                string roman3 = "CMXCIX"; //999
                int interger3 = RomanToInt(roman3);
                Console.WriteLine("Roman: {0} = Integer: {1}", roman3, interger3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }

        /// <summary>
        /// Convert any Roman number into an Integer
        /// </summary>
        /// <param name="romanNumber"></param>
        /// <returns></returns>
        public static int RomanToInt(string romanNumber)
        {
            var convertionValue = 0;

            if (!string.IsNullOrWhiteSpace(romanNumber) && (romanNumber.Length >= 1) && (romanNumber.Length <= 15))
            {
                var previousKey = new char();
                var romanNumberReversedList = romanNumber.Reverse<char>();

                //Reverse loop
                foreach (var actualKey in romanNumberReversedList)
                {
                    convertionValue = IsSubtraction(actualKey, previousKey)
                        ? convertionValue -= RomanIntegerMap.GetValueByKey(actualKey)
                        : convertionValue += RomanIntegerMap.GetValueByKey(actualKey);

                    previousKey = actualKey;
                }
            }
            return convertionValue;
        }

        /// <summary>
        /// Verifies if a subtraction is necessary in cases of Integer numbers such as 4, 9, 40, 90, 400 or 900.
        /// </summary>
        /// <param name="key">the actual key</param>
        /// <param name="previousKey">the previous</param>
        /// <returns>True in case it is a subtrasction situation</returns>
        private static bool IsSubtraction(char key, char previousKey)
        {
            if ((key.Equals('I'))
                && ((previousKey.Equals('V')) || (previousKey.Equals('X')))) //I(1) placed before V(5) and X(10) to make 4 and 9.             
            {
                return true;
            }
            else if ((key.Equals('X'))
                && ((previousKey.Equals('L')) || (previousKey.Equals('C'))))//X(10) placed before L(50) and C(100) to make 40 and 90.
            {
                return true;
            }
            else if ((key.Equals('C'))
                && ((previousKey.Equals('D')) || (previousKey.Equals('M'))))//C(100) placed before D(500) and M(1000) to make 400 and 900.
            {
                return true;
            }
            return false;
        }
    }
}
