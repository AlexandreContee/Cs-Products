using System.Globalization;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos a serem cadastrados: ");
            int N = int.Parse(Console.ReadLine());

            Product[] products = new Product[N];

            for(int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for(int i = 0; i < N; i++)
            {
                sum += products[i].Price;
            }
            
            double avg = sum / N;
            Console.WriteLine("The average price is: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
