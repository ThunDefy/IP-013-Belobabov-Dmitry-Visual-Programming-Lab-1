
int[] customers1 = new int[3] { 5,3,4};
int[] customers2 = new int[4] { 6,2,8,3 };
int[] customers3 = new int[3] { 2, 3, 10 };


HW1.QueueTime(customers1, 1);
HW1.QueueTime(customers2, 2);
HW1.QueueTime(customers3, 2);

public class HW1
{

    public static long QueueTime(int[] customers, int n)
    {
        int buyers = customers.Length;
        //int MostLong = customers.Max();
        int[] BuyingNow = new int[n]; for (int k = 0; k < n; k++) BuyingNow[k] = 0;
        int[] time = new int[n]; for (int k = 0; k < n; k++) time[k] = 0;

        //if(n == 1) Console.WriteLine(customers.Sum());

        int i = -1;

        while( i != buyers-1)
        {
            
            for (int j = 0; j < n; j++)
            {
                if (BuyingNow[j] == 0)
                {
                    i++;
                    BuyingNow[j] = customers[i];
                    time[j] += customers[i];
                }
                BuyingNow[j] -= 1;
            }
        }

        /*for (int j = 0; j < n; j++)
        {
            Console.WriteLine(time[j]);
            Console.WriteLine('\n');
        }*/
        Console.WriteLine(time.Max());


        return 0;
    }


}







