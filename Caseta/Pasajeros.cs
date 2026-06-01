using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Caseta
{
    internal class Pasajeros:Vehiculo
    {
        private int Plazas;

        public int plazas
        {
            get { return Plazas; }
            set { Plazas = value; }
        }

        public Pasajeros():base()
        {
            Plazas = 0;
        }

        public Pasajeros(string _placa, int _ejes, float _cuota, int _plazas) : base(_placa, _ejes, _cuota)
        {
            Plazas = _plazas;
        }

        public override string PasoVehicular()
        {
            return "Autobús de Pasajeros Placa: "+ Placa +" con capacidad para "+Plazas+" personas.";
        }
    }
}
