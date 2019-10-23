using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommeDiDenaro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il valore del denaro");
            double valore = double.Parse(Console.ReadLine());
            double imposta;
            if (valore <= 5000)
            {
                imposta = (valore * 5) / 100;
            }
            else if (valore >= 5001 && valore <= 15000)
            {
                imposta = (valore * 8) / 100;
            }
            else if (valore >= 15001 && valore <= 35000)
            {
                imposta = (valore * 24) / 100;
            }
            else if (valore > 35000)
            {
                imposta = (valore * 36) / 100;
            }
            Console.ReadLine();
        }
    }
}
                    
           
        


