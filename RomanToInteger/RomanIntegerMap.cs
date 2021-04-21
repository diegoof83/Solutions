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
            private static readonly Dictionary<char, int> _map = new()
            {
                { Roman.I.Value, 1},
                { Roman.V.Value, 5},
                { Roman.X.Value, 10},
                { Roman.L.Value, 50},
                { Roman.C.Value, 100},
                { Roman.D.Value, 500},
                { Roman.M.Value, 1000}                
            };

            public static int GetValueByKey(char Key)
            {
                return _map.GetValueOrDefault(Key);
            }
        }
    }
}
