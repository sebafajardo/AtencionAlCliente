using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
    }

    public class Negocio
    {
        private Negocio()
        {
          

        }

        public Negocio (string nombre)
        {

        }
    }

    public class PuestoAtencion
    {
        PuestoAtencion() {
            numeroActual = 0;
        }

        PuestoAtencion(Puesto puesto)
        {
            numeroActual = 0;
        }


        private static int numeroActual;
        private Puesto puesto;
        public enum Puesto
        {
            Caja1, Caja2
        }



        public bool Atender(Cliente cli)
        {

        }

        public int NumeroActual
        {
            get {
                return numeroActual;
            }
        }


    }
}
