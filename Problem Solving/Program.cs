namespace Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C# Basics
            Problem01();
            Problem02();
            Problem03();
            Problem04();
            Problem05();
            Problem06();
            Problem07();
            Problem08();
            Problem09();
            Problem10();
            Problem11();
            #endregion

            #region Conditions
            Problem12();
            Problem13();
            Problem14();
            Problem15();
            Problem16();
            Problem17();
            #endregion

            #region Loops
            Problem18();
            Problem19();
            Problem20();
            Problem21();
            Problem22();
            Problem23();
            Problem24();
            Problem25();
            Problem26();
            Problem27();
            Problem28();
            #endregion

            #region Arrays & Strings
            Problem29();
            Problem30();
            Problem31();
            Problem32();
            Problem33();
            Problem34();
            Problem35();
            Problem36();
            Problem37();
            #endregion

            #region Functions
            Problem38();
            Problem39();
            Problem40();
            Problem41();
            Problem42();
            Problem43();
            Problem44();
            Problem45();
            #endregion
        }

        static void Problem01()
        {
            Console.Write("Enter a number : ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"You entered: {num}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static void Problem02()
        {
            string text = "Ziad";

            try
            {
                int result = int.Parse(text); // Throw Exception
            }
            catch (FormatException)
            {
                Console.WriteLine($"Cannot convert '{text}' to an integer.");
            }
        }

        static void Problem03()
        {
            decimal a = 0.1m, b = 0.2m;
            Console.WriteLine($"0.1 + 0.2 = {a + b}");
        }

        static void Problem04()
        {
            string text = "Ziad Ahmed Yehia";

            string Ziad = text.Substring(0, 4);
            string Ahmed = text.Substring(5, 5);
            string Yehia = text.Substring(11);

            Console.WriteLine($"Extracted substring: {Ziad}, {Ahmed}, {Yehia}");
        }

        static void Problem05()
        {
            int x = 10;
            int y = x;
            y = 20;

            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void Problem06()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 99;

            Console.WriteLine($"arr1[0] = {arr1[0]}, arr2[0] = {arr2[0]}");
        }

        static void Problem07()
        {
            string first = "Hello";
            string second = "Ziad";

            Console.WriteLine($"{first} {second}");
        }

        static void Problem08()
        {
            Console.Write("Enter Principal : ");
            double principal = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Rate : ");
            double rate = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Time : ");
            double time = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Simple Interest = {(principal * rate * time) / 100}");
        }

        static void Problem09()
        {
            Console.Write("Enter Weight (kg) : ");
            double weight = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Height (m) : ");
            double height = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"BMI = {weight / (height * height)}");
        }

        static void Problem10()
        {
            Console.Write("Enter temperature: ");
            int temp = int.Parse(Console.ReadLine() ?? "0");

            string status = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            Console.WriteLine(status);
        }

        static void Problem11()
        {
            Console.Write("Enter day : ");
            int d = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter month : ");
            int m = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter year : ");
            int y = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Today's date : {string.Join(" / ", d, m, y)}");
            Console.WriteLine($"Today's date : {string.Join(" - ", d, m, y)}");
            Console.WriteLine($"Today's date : {string.Join(" , ", d, m, y)}");
        }

        static void Problem12()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(num % 12 == 0 ? "Yes" : "No");
        }

        static void Problem13()
        {
            Console.Write("Enter an integer : ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(num < 0 ? "Negative" : "Positive");
        }

        static void Problem14()
        {
            Console.Write("Enter 3 integers separated by space : ");
            string[] parts = Console.ReadLine()?.Split() ?? new string[3];

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");
        }

        static void Problem15()
        {
            Console.Write("Enter an integer : ");
            int num = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }

        static void Problem16()
        {
            Console.Write("Enter a character : ");
            string ch = Console.ReadLine()?.Trim().ToLower() ?? "";
            
            Console.WriteLine("aeiou".Contains(ch) ? "Vowel" : "Consonant");
        }

        static void Problem17()
        {
            Console.Write("Enter Month Number : ");

            int month = int.Parse(Console.ReadLine() ?? "0");

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;
                case 2:
                    Console.WriteLine("Days in Month: 28");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
        }

        static void Problem18()
        {
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + (i < n ? " " : "\n"));
            }
        }

        static void Problem19()
        {
            Console.Write("Enter an integer : ");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{num} * {i} = {num * i} ");
            }
            Console.WriteLine();
        }

        static void Problem20()
        {
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 2; i <= n; i += 2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void Problem21()
        {
            Console.Write("Enter Base: ");
            int baseNum = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Exponent: ");
            int exp = int.Parse(Console.ReadLine()!);

            long result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"Result = {result}");
        }

        static void Problem22()
        {
            Console.Write("Enter marks of 5 subjects separated by space: ");
            string[] inputs = Console.ReadLine()?.Split() ?? new string[5];

            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += double.Parse(inputs[i]);
            }

            double average = total / 5.0;
            double percentage = (total / 500.0) * 100.0;

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}%");
        }

        static void Problem23()
        {
            Console.Write("Enter a String : ");
            string str = Console.ReadLine()!;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }

        static void Problem24()
        {
            Console.Write("Enter an integer : ");
            int num = int.Parse(Console.ReadLine()!);

            int reversed = 0;

            while (num != 0)
            {
                reversed = reversed * 10 + (num % 10);
                num /= 10;
            }

            Console.WriteLine($"Reversed Integer : {reversed}");
        }

        static void Problem25()
        {
            Console.Write("Start Range : ");
            int start = int.Parse(Console.ReadLine()!);

            Console.Write("End Range : ");
            int end = int.Parse(Console.ReadLine()!);

            Console.Write($"The prime numbers between {start} and {end} are: ");

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;

                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        static void Problem26()
        {
            Console.Write("Enter a number to convert : ");
            int num = int.Parse(Console.ReadLine()!);

            int original = num;
            long binary = 0;
            long place = 1;

            while (num > 0)
            {
                int rem = num % 2;
                binary += rem * place;
                place *= 10;
                num /= 2;
            }

            Console.WriteLine($"The Binary of {original} is {binary}");
        }

        static void Problem27()
        {
            Console.Write("Enter x1 y1: ");
            var p1 = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            Console.Write("Enter x2 y2: ");
            var p2 = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            Console.Write("Enter x3 y3: ");
            var p3 = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            double slopeCheck1 = (p2[1] - p1[1]) * (p3[0] - p2[0]);
            double slopeCheck2 = (p3[1] - p2[1]) * (p2[0] - p1[0]);

            if (Math.Abs(slopeCheck1 - slopeCheck2) < 1e-9)
                Console.WriteLine("The points lie on a single straight line.");
            else
                Console.WriteLine("The points don't lie on a single straight line.");
        }

        static void Problem28()
        {
            Console.Write("Enter Number : ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }

        static void Problem29()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Sum of elements = {arr.Sum()}");
        }

        static void Problem30()
        {
            int[] arr1 = { 1, 5, 9 };
            int[] arr2 = { 2, 4, 8 };

            int[] merged = new int[arr1.Length + arr2.Length];

            arr1.CopyTo(merged, 0);
            arr2.CopyTo(merged, arr1.Length);

            Array.Sort(merged);

            Console.WriteLine("Merged sorted array: " + string.Join(" ", merged));
        }

        static void Problem31()
        {
            int[] arr = { 2, 3, 2, 5, 3, 2, 7 };
            int[] frequency = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                frequency[arr[i]]++;
            }

            for(int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine($"{arr[i]} occurs {frequency[i]} times");
            }
        }

        static void Problem32()
        {
            int[] arr = { 45, 12, 88, 3, 67 };
            int max = arr[0], min = arr[0];

            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }
            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        static void Problem33()
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            Console.WriteLine($"Second largest element = {secondLargest}");
        }

        static void Problem34()
        {
            Console.Write("Enter array size : ");
            int size = int.Parse(Console.ReadLine()!);

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            int maxDistance = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance) maxDistance = distance;
                        break;
                    }
                }
            }
            Console.WriteLine($"Longest distance = {maxDistance}");
        }

        static void Problem35()
        {
            Console.Write("Enter words separated by spaces : ");
            string[] words = Console.ReadLine()!.Split();

            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }

        static void Problem36()
        {
            Console.Write("Enter rows and columns : ");
            var dims = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int rows = dims[0], cols = dims[1];

            int[,] first = new int[rows, cols];
            int[,] second = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i},{j}] : ");
                    first[i, j] = int.Parse(Console.ReadLine() ?? "0");
                    second[i, j] = first[i, j];
                }
            }

            Console.WriteLine("Second array elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{second[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Problem37()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        static void Problem38()
        {
            int a = 5, b = 5;

            ByValue(a);
            ByRef(ref b);

            Console.WriteLine($"After ByValue: a = {a}, After ByRef: b = {b}");

            void ByValue(int x) => x = 100;
            void ByRef(ref int x) => x = 100;
        }

        static void Problem39()
        {
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 1, 2 };

            RefTypeByVal(arr1);
            RefTypeByRef(ref arr2);

            Console.WriteLine($"RefTypeByVal arr1[0] = {arr1[0]}");
            Console.WriteLine($"RefTypeByRef arr2[0] = {arr2[0]}");

            void RefTypeByVal(int[] a) => a = new int[] { 99, 100 };
            void RefTypeByRef(ref int[] a) => a = new int[] { 99, 100 };
        }

        static void Problem40()
        {
            var result = CalculatePairs(10, 20, 50, 15);
            Console.WriteLine($"Sum of first pair = {result.sum}, Difference of second pair = {result.diff}");

            (int sum, int diff) CalculatePairs(int n1, int n2, int n3, int n4)
            {
                return (n1 + n2, n3 - n4);
            }
        }

        static void Problem41()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");

            int SumOfDigits(int n)
            {
                n = Math.Abs(n);

                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }
        }

        static void Problem42()
        {
            Console.Write("Enter a number to check prime: ");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"IsPrime({num}) = {IsPrime(num)}");

            bool IsPrime(int number)
            {
                if (number <= 1) return false;

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
        }

        static void Problem43()
        {
            int[] numbers = { 15, 4, 92, 23, 8 };
            int min = 0, max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine($"Min = {min}, Max = {max}");

            void MinMaxArray(int[] arr, ref int minVal, ref int maxVal)
            {
                minVal = arr[0];
                maxVal = arr[0];
                foreach (int item in arr)
                {
                    if (item < minVal) minVal = item;
                    if (item > maxVal) maxVal = item;
                }
            }
        }

        static void Problem44()
        {
            Console.Write("Enter a number for factorial : ");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Factorial of {num} = {Factorial(num)}");

            long Factorial(int n)
            {
                long fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }

        static void Problem45()
        {
            string word = "Hello";
            string updated = ChangeChar(word, 1, 'e');

            Console.WriteLine($"Updated string: {updated}");

            string ChangeChar(string input, int index, char newChar)
            {
                if (index < 0 || index >= input.Length) return input;

                char[] chars = input.ToCharArray();
                chars[index] = newChar;

                return new string(chars);
            }
        }
    }
}