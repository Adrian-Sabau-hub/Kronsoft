using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2022.Alimente
{
    public class Alimente
    {
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public DateTime DataExpirare { get; set; }
        public decimal Pret { get; set; }

        public Alimente(string nume, string descriere, DateTime dataDeExpirare, decimal pret)
        {
            
            this.Nume = nume;
            this.Descriere = descriere;
            this.DataExpirare = dataDeExpirare;
            this.Pret = pret * AplicaReducereInainteDeExpirare(dataDeExpirare);
            
        }

        public decimal AplicaReducereInainteDeExpirare(DateTime dataDeExpirare)
        {
            DateTime acum = DateTime.Now;
            long acumUnixTime = ((DateTimeOffset)acum).ToUnixTimeSeconds();
            Console.WriteLine("Data acum este " + acumUnixTime);
            //dataDeExpirare = DateTime.ParseExact("04.08.2022", "dd.MM.yyyy", null)
            long dataDeExpirareUnixTime = ((DateTimeOffset)dataDeExpirare).ToUnixTimeSeconds();
            Console.WriteLine("Data expirare este " + dataDeExpirareUnixTime);
            long diferentaTimp = dataDeExpirareUnixTime - acumUnixTime;
            Console.WriteLine("Diferenta este " + diferentaTimp);

            if (dataDeExpirareUnixTime - acumUnixTime < 60 * 60 * 24 * 3)
            {
                return 0.5M;
            }
            else return 1;
        }
    }
        
    }

