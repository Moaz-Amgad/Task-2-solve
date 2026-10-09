namespace Try
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>();

            char choice = ' ';

            while (choice != 'q' && choice != 'Q')
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean");
                Console.WriteLine("S - Display smallest number");
                Console.WriteLine("L - Display largest number");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine());
                //انا كده بدات اكتب الجزء اللى هيظهر اول لما يفتح 

                switch (choice)
                {
                    case 'p':
                    case 'P': // انا كتبتها مرتين علشان الحرف مره كابتل ومره عادى بحيث يشتغل ع الاتنين  

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");  //علشان اقدر انى احط الرقم ف قوسين  

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }

                            Console.WriteLine("]");  //كده الرقم هيتحط بين الاقواس عادى
                        }

                        break;

                    case 'a':
                    case 'A':

                        Console.Write("Enter an integer num to add: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        numbers.Add(num);

                        Console.WriteLine($"{num} added");

                        break;

                    case 'm':
                    case 'M':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine(" Unable to calculate ");
                        }
                        else
                        {
                            int sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }

                            double mean = (double)sum / numbers.Count; //انا استخدمت ال دابل علشان الكسور عادى استخدم ال انتجر بس هيشيل كسور

                            Console.WriteLine($"The mean is {mean}");
                        }

                        break;

                    case 's':
                    case 'S':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }

                            Console.WriteLine($"The smallest number is {smallest}");
                        }

                        break;

                    case 'l':
                    case 'L':

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];

                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }

                            Console.WriteLine($"The largest number is {largest}");
                        }

                        break;

                    case 'q':
                    case 'Q':

                        Console.WriteLine(" Goodbye ");

                        break;

                    default:

                        Console.WriteLine(" Unknown , please try again ");

                        break;
                } //فى الكود كامل تم اتسخدام بعض افكار من الذكاء الاصطناعى وتم استخدام طريقه انا تسهل لى الفهم 
            }
        }
    }
}


