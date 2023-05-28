namespace h3task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers separated by a space");
            string[] series = Console.ReadLine().Split(' ');
            int[] numbersArr = new int[series.Length + 1];
            bool firstFivePositive = true;
            int counter = 0;
            foreach (string i in series)
            {
                numbersArr[Convert.ToInt32(counter)] = Convert.ToInt32(i);
                counter++;
            }

            for (int i = 0; i < 5; i++)
            {
                if (numbersArr[i] < 0) { firstFivePositive = false; break; }
            }

            if (firstFivePositive)
            { 
                Console.WriteLine($"Sum of first 5 numbers is" +
                    $" {numbersArr[0] + numbersArr[1] + numbersArr[2] + numbersArr[3] + numbersArr[4]}");
            }
            else {
                Console.WriteLine($"The product of the last 5 numbers is" +
                $" {numbersArr[5] * numbersArr[6] * numbersArr[7] * numbersArr[8] * numbersArr[9]}");
            };
        }
    }
}