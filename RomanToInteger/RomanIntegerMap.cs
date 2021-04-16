using System.Collections.Generic;

namespace RomanToInteger
{
    public partial class Program
    {
        /// <summary>
        /// The map between Roman and Integer values
        /// </summary>
        public static class RomanIntegerMap
        {            
            private static readonly Dictionary<char, int> _map = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            public static int GetValueByKey(char Key)
            {
                return _map.GetValueOrDefault(Key);
            }
        }
    }
}
