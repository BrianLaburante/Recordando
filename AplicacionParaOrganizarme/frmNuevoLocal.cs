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
    public partial class frmNuevoLocal : Form
    {
        public frmNuevoLocal(frmPrincipal principal)
        {
            InitializeComponent();
            this.actual = principal;
        }
        //propiedades

        private frmPrincipal actual;
        private string paso;
        private int orden;

        //Funciones de utilidad

        public frmNuevoLocal(string Paso)
        {
            InitializeComponent();
            this.paso = Paso;
            this.Orden = 0;
        }
        public int Orden { get => orden; set => orden = value; }

        //eventos del formulario y los controles
        private void NuevoLocal_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(tbNuevoLocal.Text))
            {
                actual.Paso = tbNuevoLocal.Text;
                tbNuevoLocal.Text = string.Empty;
                this.Close();
            }
            else
            {
                MessageBox.Show("el nombre ingresado es invalido"); 
            }
        }
    }
}
