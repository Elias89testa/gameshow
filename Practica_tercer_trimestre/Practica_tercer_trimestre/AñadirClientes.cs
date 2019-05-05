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
    public partial class AñadirClientes : Form
    {
        public AñadirClientes()
        {
            InitializeComponent();
        }

        private void AñadirClientes_Load(object sender, EventArgs e)
        {

        }

        private void bAñadirCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.setNombre(textNombre.Text);
            cliente.setDireccion(textDireccion.Text);
            cliente.setTelefono(textTelefono.Text);
            cliente.setEmail(textEmail.Text);
            Gestion nuevaGestion = new Gestion();
            nuevaGestion.aniadirClientes(cliente);
            


        }
    }
}
