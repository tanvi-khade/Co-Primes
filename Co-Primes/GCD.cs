namespace Co_Primes
{
    public class GCDCalculator
    {
        public static int FindGCD(int x, int y)
        {
            int smallestNumber = (x < y) ? x : y;
            int gcd = 1;
            for (int i = smallestNumber; i >= 2; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    gcd = i;
                }
            }

            return gcd;
        }
    }
}
