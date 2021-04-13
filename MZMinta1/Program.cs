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
            public string tipus;
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


            //van e egy valamilyen -eldöntés 1- negálás
            int i = 0;
            while(i < N && !(T))
            {
                i++;
            }
            bool van = i < N;

            //mindenki valamilyen e -eldöntés 2 -nincs negálás
            i = 0;
            while (i < N && (T))
            {
                i++;
            }
            bool mind = i >= N;



            //hányféle van -HashSet<> szétválogatás; melyek ezek, hányféle érték a listában
            HashSet<int> ertekek = new HashSet<int>();
            foreach (Auto auto in autok)
            {
                ertekek.Add(auto.ertek);
            }
            //kiiras:
            foreach (int ertek in ertekek)
            {
                Console.WriteLine(ertek);
            }

            //melyikből mennyi van -Dictionary<string, int> melyik tipusból hány darab a listában
            Dictionary<string, int> tipusDb = new Dictionary<string, int>();
            foreach (Auto auto in autok)
            {
                string kulcs = auto.tipus;
                if (tipusDb.ContainsKey(kulcs))
                {
                    tipusDb[kulcs]++;
                }
                else
                {
                    tipusDb.Add(kulcs, 1);
                }
            }
            //kiiras:
            foreach (KeyValuePair<string, int> item in tipusDb)
            {
                Console.WriteLine($"{item.Key} típusból {item.Value} darab");
            }


            //filekiirás
        }
    }
}
