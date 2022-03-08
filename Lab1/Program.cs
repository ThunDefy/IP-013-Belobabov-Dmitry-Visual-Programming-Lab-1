namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] customers1 = new int[4] { 5, 5, 5,2 };
                int[] customers2 = new int[4] { 6, 2, 8, 3 };
                int[] customers3 = new int[3] { 2, 3, 10 };

                Console.WriteLine($"Время первой очереди: {HW1.QueueTime(customers1, 3)}\n");
                Console.WriteLine($"Время второй очереди: {HW1.QueueTime(customers2, 3)}\n");
                Console.WriteLine($"Время третей очереди: {HW1.QueueTime(customers3, 2)}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"В ходе выполения программы возникла ошибка:\n {ex.Message}\n\n");
            }
        }
    }
}









