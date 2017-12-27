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
    public partial class NuevoGlobal : Form
    {
        public NuevoGlobal(frmPrincipal nuevo)
        {
            InitializeComponent();
            this.principal = nuevo; 
        }


        //definicion de objetos
        private string agregado;
        private frmPrincipal principal;

        //funciones de encapsulamiento y otras de uso comun
        public string Agregado
        {
            get { return agregado; }
            set { agregado = value; }
        }
        private void SeleccionarGlobal()
        {
            if (!string.IsNullOrWhiteSpace(tbNombreGlobal.Text))
            {
                principal.Global = this.tbNombreGlobal.Text;
                tbNombreGlobal.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("debe ingresar un nombre valido");
            }
        }
        //eventos de los controles y los formularios
        private void NuevoGlobal_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnNuevoGlobal_Click(object sender, EventArgs e)
        {
            this.SeleccionarGlobal();
            this.Close();
        }
    }
}
