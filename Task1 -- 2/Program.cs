using System;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task15();
        }

        public static void Task1()
        {
            string userInput = Console.ReadLine();

            Console.WriteLine(userInput);
        }

        public static void Task2()
        {
            double floatnum = 99.77;
            string str = "Hello World";
            char ch = 'A';
            bool isTrue = true;
            int num = 5;
            const double pi = 3.14;

            Console.WriteLine("Double: " + floatnum);
            Console.WriteLine("String: " + str);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Bool: " + isTrue);
            Console.WriteLine("Int: " + num);
            Console.WriteLine("Constant: " + pi);
        }

        public static void Task3()
        {
            string[] cars = { "Toyota", "Honda", "Ford", "Kia", "Tesla" };

            // Print all the cars
            Console.WriteLine("List of Cars:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\nNumber of Cars: " + cars.Length);
        }

        public static void Task4()
        {
            Console.Write("Input your firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Input your lastname: ");
            string lastName = Console.ReadLine();

            Console.Write("Input your year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            

            // Display names and year sequentially
            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");

        }

        public static void Task5()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void Task6()
        {
            int[] arr = new int[3]; 

            // Input elements into the array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());   
            }

            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }

        public static void Task7()
        {
            Console.Write("Enter the first integer: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNum>secondNum ? secondNum : firstNum);
        }

        public static void Task8()
        {
            Console.Write("Enter the integer: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num > 0 ? "+"  : "-");
        }

        public static void Task9()
        {
            Console.Write("Enter the integer: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the integer: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the integer: ");
            int lastNum = int.Parse(Console.ReadLine());

            List<int> lstOfNum = new List<int>() { firstNum, secondNum, lastNum };

            lstOfNum.Sort();

            foreach (int i in lstOfNum)
            {
                Console.WriteLine(i);
            }


        }

        public static void Task10()
        {
            int[] nums = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter the integer: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            int max = nums[0];
            foreach (int i in nums)
            {
                if (i>max)
                    max= i;
            }
            Console.WriteLine(max);
        }

        public static void Task11()
        {
            Console.Write("Enter the speed: ");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine(speed * 0.621371192);
        }

        public static void Task12()
        {
            Console.Write("Enter the hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter the min: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine(min + hours * 60);
        }

        public static void Task13()
        {
            Console.Write("Enter the min: ");
            int min = int.Parse(Console.ReadLine());

            int hours = min / 60;
            min = min % 60;

            Console.WriteLine($"{hours} Hours , {min} Minutes");
        }

        public static void Task14()
        {
            string[] sentences = new string[]
            {
                "Lorem ipsum dolor sit amet.",
                "Lorem ipsum dolor sit amet, consectetur.",
                "Lorem ipsum dolor sit amet, consectetur adipiscing.",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque."
            };
            int len = 45;
            char ch = '*';
            foreach (string sentence in sentences)
            {
                if (sentence.Length > len)
                    Console.WriteLine(sentence.Substring(0, len));
                else
                    Console.WriteLine(sentence.PadLeft(len, ch));
            }
        }

        public static void Task15()
        {
            string str = Console.ReadLine();
            string[] word = str.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Length % 2 == 1)
                {
                    char[] ch = word[i].ToCharArray();
                    Array.Reverse(ch);
                    word[i] = new string(ch);
                }
            }
            string result = string.Join(" ", word);
            Console.WriteLine(result);
        }
    }
}
