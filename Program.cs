using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args, int n)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Algorithm Program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Choose a Services You Need: ");
            Console.WriteLine("1. Calculate Average");
            Console.WriteLine("2. Check if a Number is Even");
            Console.WriteLine("3.Find the Smallest Number ");
            Console.WriteLine("4. Count Positive and Negat ");
            Console.WriteLine("  Remove Duplicates from:");
            Console.WriteLine("6.Find A11 Drime Numhare");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        int count;
                        float sum = 0;
                        float number;
                        float average = 0;
                        Console.Write("Enter how many numbers: ");
                        count = int.Parse(Console.ReadLine());

                        if (count <= 0)
                        {
                            Console.WriteLine("Count must be greater than zero.");

                        }

                        for (int j = 1; j <= count; j++)
                        {
                            Console.Write("Enter number " + j + ": ");
                            number = float.Parse(Console.ReadLine());
                            sum += number;
                            Console.WriteLine(" the sum =" + sum);
                            Console.WriteLine("Average =" + average);
                            number = float.Parse(Console.ReadLine());
                            average += number;
                            Console.WriteLine(" the average  =" + average);
                        }
                    } break;

                case 2:
                    {
                        Console.Write("Enter a number: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                            Console.WriteLine("Even");
                        else
                            Console.WriteLine("Odd");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter the number of elements:");
                        int number3 = int.Parse(Console.ReadLine());
                        int[] numbers3 = new int[number3];
                        for (int i = 0; i < number3; i++)
                        {
                            Console.Write($"Enter number {i + 1}: ");

                            numbers3[i] = int.Parse(Console.ReadLine());
                        }
                        int min = numbers3[0];
                        for (int i = 1; i < number3; i++)
                            if (numbers3[i] < min) min = numbers3[i];
                        Console.WriteLine("Smallest number: " + min);
                    }
                    break;
                case 4:
                    {
                        Console.Write("Enter how many numbers: ");
                        int positive = 0, negative = 0;

                        for (var i = 0; i < i; i++)
                        {
                            Console.Write("Enter number " + (i + 1) + ": ");
                            int num = int.Parse(Console.ReadLine());

                            if (num > 0)
                                positive++;
                            else if (num < 0)
                                negative++;
                        }

                        Console.WriteLine("Positive count = " + positive);
                        Console.WriteLine("Negative count = " + negative);
                    }
                    break;

                case 5:
                    Console.WriteLine("Enter the number of elements:");
                    int N = int.Parse(Console.ReadLine());
                    int[] numbers = new int[n];
                    for (int i = 0; i < N; i++) ;

                    Console.Write("Unique numbers: ");

                    for (int i = 0; i < n; i++)
                    {
                        bool isDuplicate = false;
                        for (int j = 0; j < i; j++)
                        {
                            if (numbers[i] == numbers[j])
                            {
                                isDuplicate = true;
                            }
                        }
                        if (!isDuplicate)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        isDuplicate = true;
                    }

                    Console.ReadLine();

                    break;

                case 6:
                    {
                        Console.Write("Enter N: ");
                        int H = int.Parse(Console.ReadLine());

                        for (int i = 2; i <= H; i++)
                        {
                            bool prime = true;

                            for (int j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    prime = false;
                                }
                            }
                        }
                    }
                    break;


                case 7:
                    Console.Write("Enter number of elements in first list: ");
                    int n1 = int.Parse(Console.ReadLine());
                    int[] list1 = new int[n1];

                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write("Enter element {i + 1}: ");
                        list1[i] = int.Parse(Console.ReadLine());
                    }


                    Console.Write("Enter number of elements in second list: ");
                    int n2 = int.Parse(Console.ReadLine());
                    int[] list2 = new int[n2];

                    for (int i = 0; i < n2; i++)
                    {
                        Console.Write($"Enter element {i + 1}: ");
                        list2[i] = int.Parse(Console.ReadLine());
                    }

                    int[] merged = new int[n1 + n2];
                    int i1 = 0, i2 = 0, k = 0;

                    while (i1 < n1 && i2 < n2)
                    {
                        if (list1[i1] < list2[i2])
                        {
                            merged[k] = list1[i1];
                            i1++;
                        }
                        else
                        {
                            merged[k] = list2[i2];
                            i2++;
                        }
                        k++;
                    }

                    while (i1 < n1)
                    {
                        merged[k] = list1[i1];
                        i1++;
                        k++;
                    }

                    while (i2 < n2)
                    {
                        merged[k] = list2[i2];
                        i2++;
                        k++;
                    }


                    Console.Write("Merged list: ");
                    for (int i = 0; i < merged.Length; i++)
                    {
                        Console.Write(merged[i] + " ");
                    }

                    break;

                case 8:
                    {

                        Console.Write("Enter number of elements: ");

                        int H1 = int.Parse(Console.ReadLine());
                        int[] num = new int[H1];
                        for (int i = 0; i < H1; i++)

                        {

                            Console.Write($"Enter number {i + 1}: ");

                            num[i] = int.Parse(Console.ReadLine());

                        }

                        int largest = num[0];

                        int secondLargest = int.MinValue;
                        for (int i = 1; i < num.Length; i++)

                        {

                            if (num[i] > largest)

                            {

                                secondLargest = largest;

                                largest = num[i];

                            }

                            else if (num[i] > secondLargest && num[i] != largest)

                            {

                                secondLargest = num[i];

                            }

                        }

                        Console.WriteLine("Second Largest = " + secondLargest);
                    }
                    break;

                case 9:
                    {
                        Console.Write("Enter a string: ");
                        string s = Console.ReadLine();
                        string reversed = new string(s.Reverse().ToArray());

                        {
                            if (s == reversed)
                                Console.WriteLine("Palindrome");
                            else
                                Console.WriteLine("Not a Palindrome");
                        }
                    }
                    break;
                case 10:
                    {
                        Console.Write("Enter N: ");
                        int H = int.Parse(Console.ReadLine());

                        int first = 0, second = 1;
                        Console.Write(first + " " + second + " ");

                        for (int i = 3; i <= H; i++)
                        {
                            int next = first + second;
                            Console.Write(next + " ");
                            first = second;
                            second = next;
                        }
                    }
                    break;

                case 11:
                    {
                        Console.Write("Enter N: ");
                        int H = int.Parse(Console.ReadLine());
                        for (int row = 1; row <= H; row++)
                        {
                            for (int col = 1; col <= H; col++)
                            {
                                Console.Write(row * col + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                        break;
                    
                        







