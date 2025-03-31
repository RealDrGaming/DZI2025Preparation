namespace _03._29.Peev
{
    internal class Program
    {
        static int ev(int n)
        {
            int count = 0;
            while (n % 2 == 0)
            {
                n /= 2;
                count++;
            }
            return count;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int p = int.Parse(input[0]);
            int q = int.Parse(input[1]);

            int maxEv = -1;
            int bestNumber = p;

            for (int i = p; i <= q; i++)
            {
                int currentEv = ev(i);
                if (currentEv > maxEv || (currentEv == maxEv && i > bestNumber))
                {
                    maxEv = currentEv;
                    bestNumber = i;
                }
            }

            Console.WriteLine(bestNumber);
        }
    }
}
