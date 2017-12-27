using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class ClsGlobal
    {
        private int idGlobal;
        private string nombreGlobal;
        private int prioridad;
        private bool estado;

        public int IdGlobal { get => idGlobal; set => idGlobal = value; }
        public string NombreGlobal { get => nombreGlobal; set => nombreGlobal = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public bool Estado { get => estado; set => estado = value; }

        public ClsGlobal()
        {
        }
    }
}
