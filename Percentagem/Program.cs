using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Insere 4 números reais entre 0 e 1:");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        string input4 = Console.ReadLine();
        
        float input11 = float.Parse(input1);
        float input22 = float.Parse(input2);
        float input33 = float.Parse(input3);
        float input44 = float.Parse(input4);

        Console.WriteLine(input11);
        Console.WriteLine(input22);
        Console.WriteLine(input33);
        Console.WriteLine(input44);

        double input111 = input11;
        double input222 = input22;   
        double input333 = input33;   
        double input444 = input44;
        Console.WriteLine(input111.ToString("P", CultureInfo.InvariantCulture));
        Console.WriteLine(input222.ToString("P", CultureInfo.InvariantCulture));
        Console.WriteLine(input333.ToString("P", CultureInfo.InvariantCulture));
        Console.WriteLine(input444.ToString("P", CultureInfo.InvariantCulture));




        

        

        }
    }
}
