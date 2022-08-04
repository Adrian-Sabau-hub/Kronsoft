using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class InfoApa
    {
        int scor = 0;
        //bool input = false;
        int cantApaValidat = 0;

        public InfoApa()
        {

        }

    public void Run()
        {
            Console.WriteLine("Cata apa bei pe zi?");
            Console.WriteLine("1: 1 litri");
            Console.WriteLine("2: 2 litri");
            Console.WriteLine("3: 3-5 litri");

            var cantApaNevalidat = Console.ReadLine();

            
            //cantApaValidat = 

            while (!(int.TryParse(cantApaNevalidat, out cantApaValidat)) || Int32.Parse(cantApaNevalidat) < 1 || Int32.Parse(cantApaNevalidat) > 5)
            {
                Console.WriteLine("Introduceti un numar intreg intre 1 si 5");
                cantApaNevalidat = Console.ReadLine();
            }

            cantApaValidat = Int32.Parse(cantApaNevalidat);

            scor += cantApaValidat;
            //var water = Console.ReadLine();

            if (scor < 2)
            {
                Console.WriteLine("Mai bea apa");
            }
            else
            {
                Console.WriteLine("Esti bine");
            }
        }

        public bool IsConsoleInputValid(string cantApaNevalidat)
        {
            if(int.TryParse(cantApaNevalidat, out cantApaValidat)
                && Int32.Parse(cantApaNevalidat) > 0
                && Int32.Parse(cantApaNevalidat) < 6)
            {
                return true;
            }

            return false;
            
        }

    }
}
