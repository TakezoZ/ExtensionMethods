using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 11, 01, 09, 11, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}