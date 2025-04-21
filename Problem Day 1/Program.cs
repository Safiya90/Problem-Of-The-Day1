namespace Problem_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
                Console.WriteLine("Enter the number of elements:");
                int n = int.Parse(Console.ReadLine());

                List<int> numbers = new List<int>();
                Console.WriteLine("Enter the numbers:");

                for (int i = 0; i < n; i++)
                {
                    int input = int.Parse(Console.ReadLine());
                    numbers.Add(input);
                }

                int tallest = numbers[0];
                int count = 1;

                for (int i = 1; i < n; i++)
                {
                    if (numbers[i] > tallest)
                    {
                        tallest = numbers[i];
                        count = 1;
                    }
                    else if (numbers[i] == tallest)
                    {
                        count++;
                    }
                }

                Console.WriteLine("The tallest candle is " + tallest);
                Console.WriteLine("It appears: " + count + " times.");
            }
        }

    }


