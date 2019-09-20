using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pelicula
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
            Pelicula p1 = new Pelicula();
            p1.titulo ("La La Land");
            p1.año (2016);

            Pelicula p2 = new Pelicula ();
            p2.Titulo ("Guerra de las Galacias")
            p2.año (1978)



            console.WriteLine("{0} {1}", p1.titulo, p1.año);
            console.WriteLine("{0} {1}", p2.titulo, p2.año);
        }
    }
}
