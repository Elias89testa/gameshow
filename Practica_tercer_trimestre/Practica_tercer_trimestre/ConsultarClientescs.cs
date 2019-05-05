using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_tercer_trimestre
{
    public partial class ConsultarClientescs : Form
    {
        public ConsultarClientescs()
        {
            InitializeComponent();
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            Gestion nueva = new Gestion();
            List<Clientes> list = nueva.consultarClientes();


        }
    }
}
