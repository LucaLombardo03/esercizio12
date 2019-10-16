using System;

namespace ScontiConcorrenza
{
    class Program
    {
        static void Main(string[] args)
        {
            double importo = 0;
            double sconto = 0;
            double importo_scontato = 0;
            Console.Write("Inserisci l'importo della spesa: ");
            importo = double.Parse(Console.ReadLine());
            if (importo <= 300)
            {
                sconto = (importo / 100) * 10;
                importo_scontato = importo - sconto;
                Console.WriteLine($"Lo sconto {sconto} e l'importo scontato è {importo_scontato}");
            }
            else if (importo > 300)
            {
                double importoOltre300 = importo - 300;
                sconto = (importoOltre300 / 100) * 20 + 30;
                importo_scontato = importo - sconto;
                Console.WriteLine($"Lo sconto {sconto} e l'importo scontato è {importo_scontato}");
            }
            Console.ReadLine();
        }
    }
}
