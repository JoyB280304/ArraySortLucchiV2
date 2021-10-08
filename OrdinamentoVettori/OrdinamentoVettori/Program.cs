using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18}; //creazione e riempimento del vettore

            ordina(vettore); //richiamo il metodo "ordina" che si occupa del sort dell'array

            for (int i = 0; i < 10; i++) //faccio un for per stampare ogni elemento dell'array
            {
                Console.WriteLine(vettore[i]); 
            }

            Console.ReadKey();
        }

        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }
    }
}
