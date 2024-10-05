namespace Handle_duplication
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            try
            {
                
                Console.WriteLine("Enter a list of integers separated by spaces:");
                string integers = Console.ReadLine();

                
                string[] inputArray = integers.Split(' ');

                
                List<int> numbers = new List<int>();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    numbers.Add(int.Parse(inputArray[i]));
                }

               
                for (int i = 0; i < numbers.Count; i++)
                {
                    for (int j = i + 1; j < numbers.Count; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                           
                            throw new Exception($"Duplicate number founded: {numbers[i]}");
                        }
                    }
                }

                
                Console.WriteLine("  entered numbers are:");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(" Please enter only integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
