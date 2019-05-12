namespace UnicodeTools
{
    public class UnicodeRange
    {
        public int Lowest { get; }
        public int Highest { get; }

        public UnicodeRange(int lowest, int highest)
        {
            Lowest = lowest;
            Highest = highest;
        }
    }
