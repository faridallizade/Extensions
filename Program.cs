using System.Threading.Channels;

namespace Week05Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter what you want : ");
            //var example = Console.ReadLine();
            //bool check = example.CustomContains();
            //Console.WriteLine(check);

            //Console.Write("Enter the number what you want to check : ");
            //int number = Convert.ToInt32(Console.ReadLine());    
            //bool checkPrime = number.IsPrime();
            //Console.WriteLine(checkPrime);

            Console.Write("Enter the number to check : ");
            int powerNumber = Convert.ToInt32(Console.ReadLine());
            bool CheckPower = powerNumber.IsPowOfTwo();
            Console.WriteLine(CheckPower);
        }
    }
}