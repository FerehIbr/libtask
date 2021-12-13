using ClassLibrary1;
using System;


namespace libtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Toplama = 6 + 3;
            calculator.Cixma = 6 - 3;
            calculator.Vurma = 6 * 3;
            calculator.Bolme = 6 / 3;


            Console.WriteLine(calculator.Toplama);
            Console.WriteLine(calculator.Bolme);
            Console.WriteLine(calculator.Vurma);
            Console.WriteLine(calculator.Bolme);

        }
        
    }
}
