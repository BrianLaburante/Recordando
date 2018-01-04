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

        public ClsGlobal(string nombre)
        {
            this.nombreGlobal = nombre;
        }

        public ClsGlobal(string nombre, int prioridad)
        {
            this.nombreGlobal = nombre;
            this.prioridad = prioridad;
        }

        public ClsGlobal(string nombre, int prioridad, bool estado)
        {
            this.nombreGlobal = nombre;
            this.prioridad = prioridad;
            this.estado = estado;
        }

        public ClsGlobal(string nombre, bool estado)
        {
            this.nombreGlobal = nombre;
            this.estado = estado;
        } 
    }

    public class ClsLocal
    {
        private string nombreLocal;
        private int orden;
        private int idGlobal; 
        private bool EstadoCumplido; 
        private bool estado;



        public string NombreLocal { get => nombreLocal; set => nombreLocal = value; }
        public int Orden { get => orden; set => orden = value; }
        public bool Cumplida { get => EstadoCumplido; set => EstadoCumplido = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int IdGlobal { get => idGlobal; set => idGlobal = value; }

        public ClsLocal(int idGlobal, string nombreLocal, int orden)
        {
            IdGlobal = idGlobal;
            NombreLocal = nombreLocal ?? throw new ArgumentNullException(nameof(nombreLocal));
            Orden = orden;
        }

        public ClsLocal(int idGlobal, string nombreLocal, int orden, bool estado) : this(idGlobal, nombreLocal, orden)
        {
            Estado = estado;
        }
    }

    public class Archivos
    {
        private int idGlobal;
        private string nombreArchivo;
        private string extension;
        private bool carpetaRaiz;//si es true, debe ignorar la ubicacion y buscar en la capreta raiz
        private string ubicacion;
        private bool estado;

        public int IdGlobal { get => idGlobal; set => idGlobal = value; }
        public string NombreArchivo { get => nombreArchivo; set => nombreArchivo = value; }
        public string Extension
        {
            get => FormateoSalida( extension);
            set => extension = FormateoEntrada(value);
                
        }
        public bool CarpetaRaiz { get => carpetaRaiz; set => carpetaRaiz = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public bool Estado { get => estado; set => estado = value; }

        private string FormateoEntrada(string ruta)
        {
            char[] arreglo = new char[ruta.Length * 2];
            int index = 0;
            foreach( char a in ruta.ToArray<char>() )
            {
                if (a == '/')
                {
                    arreglo[index] = a;
                    arreglo[index + 1] = a;
                }
                else
                {
                    arreglo[index] = a;
                }
                index++;
            }
            string resultado = arreglo.ToString();
            return resultado;
        }

        private string FormateoSalida(string ruta)
        {
            char[] arreglo = new char[ruta.Length];int index = 0;bool repetido = false;
            foreach (char a in ruta.ToArray<char>())
            {
                if (a == '/')
                {
                    if (!repetido)
                    {
                        arreglo[index] = a;
                        repetido = true;
                    }
                    else
                    {
                        repetido = false;
                    }
                }
                else
                {
                    arreglo[index] = a;
                }
                index++;
            }
            string resultado = arreglo.ToString();
            return resultado;
        }


        public Archivos(string nombreArchivo, string extension, bool carpetaRaiz, string ubicacion, bool estado)
        {
            NombreArchivo = nombreArchivo ?? throw new ArgumentNullException(nameof(nombreArchivo));
            Extension = extension ?? throw new ArgumentNullException(nameof(extension));
            CarpetaRaiz = carpetaRaiz;
            Ubicacion = ubicacion ?? throw new ArgumentNullException(nameof(ubicacion));
            Estado = estado;
        }
    }

    public class RelacionGLA
    {
        private int idGlobal;
        private int idLocal;
        private int idArchivo;
        private bool estado;

        public int IdGlobal { get => idGlobal; set => idGlobal = value; }
        public int IdLocal { get => idLocal; set => idLocal = value; }
        public int IdArchivo { get => idArchivo; set => idArchivo = value; }
        public bool Estado { get => estado; set => estado = value; }

        public RelacionGLA(int idGlobal, int idLocal, int idArchivo, bool estado)
        {
            IdGlobal = idGlobal;
            IdLocal = idLocal;
            IdArchivo = idArchivo;
            Estado = estado;
        }
    }


    /*
     * 1 2 3 4
 Local ( Local.IdLocal , NombreLocal , Estado , Orden , EstadoCumplido ) 
Archivos ( Archivos.IdArchivo , nombreArchivo , Extension , Ubicacion , Estado , CarpetaRaiz ) 
Global ( Global.IdGlobal , NombreGlobal , Prioridad , Estado ) 
Relacion_GLA ( Estado , Local.IdLocal , Archivos.IdArchivo , Global.IdGlobal )  */

}
