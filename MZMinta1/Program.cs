using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZMinta1
{
    class Program
    {
        class Auto 
        {
            public int ertek;
        }
        static void Main(string[] args)
        {
            //file beolvasás
            string [] sorok = File.ReadAllLines("forras.csv");
            List<Auto> autok = new List<Auto>();
            foreach (var sor in sorok.Skip(1)) //ha van fejléc
            {
                autok.Add(new Auto());
            }

            //adatok száma
            int N = autok.Count;//ha fejléc van akkor -1

            //legvalamilyenebb -szélőérték
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < N; i++)
            {
                if (autok[i].ertek > autok[maxIndex].ertek)
                {
                    maxIndex = i;
                }
                if (autok[i].ertek < autok[minIndex].ertek)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"a legnagyobb: {autok[maxIndex]}) : a legkisebb:{autok[minIndex]}");


            //van e egy valamilyen

            //mindenki valamilyen e

            //hányféle van

            //melyikből mennyi van

            //filekiirás
        }
    }
}
