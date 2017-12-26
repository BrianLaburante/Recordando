using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionParaOrganizarme
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Propiedades y definicion de objetos

        private Form formularioGlobal;
        private Form FormularioLocal; 
        private List<string> ListaGlobal;
        private List<CheckedListBox> ListaPaso;
        private string global;
        private string paso;
        private bool HuboCambio;
        private enum TipoDeCambio
        {
            insertar,
            modificar,
            eliminar
        }

        //Metodos de encapsulacion y funciones del programa

        public string Paso
        {
            get { return paso; }
            set { paso = value; }
        }

        public string Global
        {
            get { return global; }
            set { global = value; }
        }

        private void ActualizarListaGlobal(TipoDeCambio accion)
        {
            switch (accion)
            {
                case TipoDeCambio.insertar: 
                    if (!string.IsNullOrWhiteSpace(Global))
                    {
                        ListaGlobal.Add(Global);
                        HuboCambio = true;
                        this.CargarLbGlobal(ListaGlobal);
                        Global = string.Empty;
                    }
                    else
                    {
                        HuboCambio = false;
                    } 
                 break;
                case TipoDeCambio.modificar: 
                    throw new Exception("Aun no se implemento la accion modificar"); break;
                case TipoDeCambio.eliminar: 
                    throw new Exception("Aun no se implemento la accion Eliminar"); break;
                default : throw new Exception("no se creo unas acciones para este Tipo de Cambio"); 
            }
        }

        private void CargarLbGlobal(List<string> Objetos)
        {
            if (HuboCambio)
            {
                foreach (string temp in Objetos)
                {
                    lbGlobal.Items.Add(temp);
                }
            }
        }
        // eventos de los controles y formularios

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Global = string.Empty;
            this.Paso = string.Empty;
            ListaGlobal = new List<string>();
            ListaPaso = new List<CheckedListBox>();
            formularioGlobal = new NuevoGlobal(this);
            FormularioLocal = new NuevoLocal(Paso);
        }

        private void btnNuevoGlobal_Click(object sender, EventArgs e)
        {
            formularioGlobal.ShowDialog();
            this.ActualizarListaGlobal(TipoDeCambio.insertar);
        }

        private void lbGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
