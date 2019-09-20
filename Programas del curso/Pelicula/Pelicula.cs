using System;

namespace CineP
{
    class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;
        

        public string Ti
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int A
        {
            get { return año; }
            set { año = value; }
        }   

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
              p1.Ti = ("La La Land");
              p1.A= (2016);

            Console.WriteLine("{0} {1}", p1.Ti, p1.A);

            Pelicula p2 = new Pelicula();
            p2.Ti = ("Guerra de las Galaxias");
            p2.A = (1978);

            Console.WriteLine("{0} {1}", p2.Ti, p2.A);

            Console.ReadKey();
        }
    }
}
