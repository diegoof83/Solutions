namespace RomanToInteger
{
    /// <summary>
    /// Constant values for the roman number
    /// </summary>
    public class Roman
    {
        public char Value { get; private set; }

        public static readonly Roman I = new('I');
        public static readonly Roman V = new('V');
        public static readonly Roman X = new('X');
        public static readonly Roman L = new('L');
        public static readonly Roman C = new('C');
        public static readonly Roman D = new('D');
        public static readonly Roman M = new('M');

        private Roman(char value)
        {
            this.Value = value;
        }
    }
}
