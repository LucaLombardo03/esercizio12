using System;

namespace sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto = 0;
            Console.WriteLine("Inserisci l'importo:  ");
            double importo = double.Parse(Console.ReadLine());
            if (importo < 300)
            {
                sconto = (importo / 100) * 10;
                importo = importo - sconto;
            }
            else if (importo >= 300)
            {
                
            }
        }
    }
}
