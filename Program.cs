using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje6
{
    class Vozilo
    {
       private bool JeLiLeti, JeLiPlovi;

        public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
        public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }

        public string KudaVozi()
        {
            return ("Leti li: " + JeLiLeti+" Plovi li: "+ JeLiPlovi);
        }
    }
    class Brod : Vozilo 
    {

        public Brod()
        {
            JeLiLeti1 = false;
            JeLiPlovi1 = true;
        }
    }
    class Zrakoplov:Vozilo
    {

        public Zrakoplov()
        {
            JeLiLeti1 = true;
            JeLiPlovi1 = false;
        }
    }
    internal class Program
    {
        /*
         *  Definirajte klasu Vozilo sa sljedećim članicama:
• svojstva
JeLiLeti
JeLiPlovi
• metoda
KudaVozi() koja će ispisati vrijednost dviju varijabli članica

Definirajte klase Brod i Zrakoplov izvedene iz klase Vozilo, te im definirajte konstruktore u
kojima ćete varijablama JeLiLeti i JeLiPlovi dodijeliti odgovarajuću vrijednost.
Definirajte dva objekta tipa Brod i Zrakoplov, te ispišite vrijednosti varijabli JeLiLeti i
JeLiPlovi.

         * */
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov z = new Zrakoplov();
            Console.WriteLine("Brod: "+brod.KudaVozi());
            Console.WriteLine("Zrakoplov: "+z.KudaVozi());
            Console.ReadKey();
        }
       
    }
}
