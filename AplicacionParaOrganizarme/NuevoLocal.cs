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
    public partial class NuevoLocal : Form
    {
        public NuevoLocal(string Paso, int numOrden)
        {
            InitializeComponent();
            this.paso = Paso;
            this.orden = numOrden;
        }

        public NuevoLocal(string Paso)
        {
            InitializeComponent();
            this.paso = Paso;
            this.orden = 0;
        }
        private string paso;
        private int orden; 
        
        
        private void NuevoLocal_Load(object sender, EventArgs e)
        {
           
        } 
    }
}
