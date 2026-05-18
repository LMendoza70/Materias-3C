using Materias.Ejemplo1;

namespace Materias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creamos una materia en blanco");
            Materia POO = new Materia();
            Materia Base = new Materia("Base de datos", 9, 10, 8);

            Console.WriteLine( POO.Imoresion());
            Console.WriteLine( Base.Imoresion());


        }
    }
}
