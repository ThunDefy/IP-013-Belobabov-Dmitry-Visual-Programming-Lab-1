namespace Lab1
{
    internal class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int buyers = customers.Length;
            int[] BuyingNow = new int[n]; for (int k = 0; k < n; k++) BuyingNow[k] = 0;
            int[] time = new int[n]; for (int k = 0; k < n; k++) time[k] = 0;
            if (n > buyers) n = buyers; // Если касс больше чем посетителей, то лишние кассы не работают.
            int i = -1;

            if (n <= 0) throw new HWException("Введено некорректное значение! Количество касс должно быть больше нуля.");

            while (i != buyers-1 )
            {
                for (int j = 0; j < n; j++)
                {
                    if (BuyingNow[j] == 0)
                    {
                        if(i<buyers-1)i++; 
                        BuyingNow[j] = customers[i];
                        time[j] += customers[i];
                    }
                    BuyingNow[j] -= 1;
                }
            }

            return time.Max();
        }
    }
}
