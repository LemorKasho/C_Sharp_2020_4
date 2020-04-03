using System;
namespace C_Sharp_2020_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserAnswer;
            do
            {
                Console.Clear();

                Console.WriteLine("Please Enter Your Number");
                float Number1 = Convert.ToSingle(Console.ReadLine());
                float Result = Number1;

            OperationAgain:
                Console.WriteLine("Please Enter Your  Operation : + , - , * , /");
                char Operation = char.Parse(Console.ReadLine());

                float Number;
                switch (Operation)
                {
                    case '+':
                        Console.WriteLine("Please Enter Your Number");
                        Number = Convert.ToSingle(Console.ReadLine());
                        Result += Number;
                        goto OperationAgain;

                    case '-':
                        Console.WriteLine("Please Enter Your Number");
                        Number = Convert.ToSingle(Console.ReadLine());
                        Result -= Number;
                        goto OperationAgain;

                    case '*':
                        Console.WriteLine("Please Enter Your Number");
                        Number = Convert.ToSingle(Console.ReadLine());
                        Result *= Number;
                        goto OperationAgain;

                    case '/':
                        Console.WriteLine("Please Enter Your Number");
                        Number = Convert.ToSingle(Console.ReadLine());
                        Result /= Number;
                        goto OperationAgain;

                    case '=':
                        Console.WriteLine("Result = {0}", Result);
                        break;
                    default:
                        goto OperationAgain;
                }
                do
                {
                    Console.WriteLine("Do You Want Try Again ?? YES or NO");
                    UserAnswer = Console.ReadLine().ToUpper();

                } while (UserAnswer != "YES" && UserAnswer != "NO");
            } while (UserAnswer == "YES");
            Console.Clear();
            Console.WriteLine("Welcom, Byee Byee");
        }
    }
}