using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineP_V1
{
    class Pelicula
    {
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula P1 = new Pelicula();
            P1.titulo = "La La Land";
            P1.año = 2016;

            
            Console.WriteLine("{0}{1}",P1.titulo, P1.año);
            Console.ReadLine();
        }
    }
}
