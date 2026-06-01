using Materias.Caseta;
using Materias.Ejemplo1;
using System.Runtime.CompilerServices;

namespace Materias
{
    internal class Program
    {
        /*public void caseta()
        {
            
        }*/
        static void Main(string[] args)
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            lista.Add(new Carga("HHGTT", 5, 150, 17));
            lista.Add(new Carga("GGVZT", 9, 150, 37));
            lista.Add(new Carga("HHGTT", 5, 150, 5));
            lista.Add(new Pasajeros("TTFFGG", 6, 200, 41));
            lista.Add(new Pasajeros("TTFFGG", 2, 200, 19));
            lista.Add(new Pasajeros("TTFFGG", 6, 200, 42));

            float total = 0;
            foreach (Vehiculo unidad in lista)
            {
                
                Console.WriteLine(unidad.PasoVehicular());
                if (unidad is Carga car && car.capacidad >= 15)
                {
                    Console.WriteLine("Alesta revision de vascula por sobrepeso");
                }
                total = total + unidad.CalculoPeaje();
            }

            Console.WriteLine("Total recaudado : "+total);

        }

        
    }
}
