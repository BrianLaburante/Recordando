using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_de_Clases;

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
        private List<ClsGlobal> ListaGlobal;
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
                        ListaGlobal.Add(new ClsGlobal(Global));
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
        private void CargarLbGlobal(List<ClsGlobal> Objetos)
        {
            if (HuboCambio)
            {
                lbGlobal.Items.Clear();
                foreach (ClsGlobal temp in Objetos)
                {
                    lbGlobal.Items.Add(item: temp.NombreGlobal);
                }
            }
        }
        // eventos de los controles y formularios

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Global = string.Empty;
            this.Paso = string.Empty;
            ListaGlobal = new List<ClsGlobal>();
            ListaPaso = new List<CheckedListBox>();
            formularioGlobal = new FrmNuevoGlobal(this);
            FormularioLocal = new frmNuevoLocal(Paso);
        }
        private void BtnNuevoGlobal_Click(object sender, EventArgs e)
        {
            formularioGlobal.ShowDialog();
            this.ActualizarListaGlobal(TipoDeCambio.insertar);
        }
        private void LbGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnAgregarPaso_Click(object sender, EventArgs e)
        {
            FormularioLocal.ShowDialog(); 
    
        }
    }
}
