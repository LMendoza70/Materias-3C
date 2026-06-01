using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.Caseta
{
    internal class Carga:Vehiculo
    {
        private float Capacidad;

        public float capacidad
        {
            get { return Capacidad; }
            set { Capacidad = value; }
        }

        public Carga():base()
        {
            Capacidad=0.0f;
        }

        public Carga(string _placas, int _ejes, float _cuota ,float _capacidad) : base(_placas, _ejes, _cuota)
        {
            Capacidad = _capacidad;
        }

        public override string PasoVehicular()
        {
            return "Camión  de Carga Placa:"+ Placa+" de "+ Ejes +" ejes transportando "+ Capacidad +" toneladas.";
        }
    }
}
