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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*se ha de averiguar si la ventana no esta abierta*/
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Registrar")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                /*se va a abrir la ventana de empleados pero como hija de la ventana prioncipal*/
                /*se ha de declarar una variable del tipo de ventana que se desea abrir*/
                RegistrarCompras vRegistrar = new RegistrarCompras();
                /*ante de abrir la ventana se ha de esoecificar que esta ventana es hija de la que estamos codificando*/
                vRegistrar.MdiParent = this;
                /*esta mostrando la ventana con show*/
                vRegistrar.Show();
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*se ha de averiguar si la ventana no esta abierta*/
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Consultar")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                /*se va a abrir la ventana de empleados pero como hija de la ventana prioncipal*/
                /*se ha de declarar una variable del tipo de ventana que se desea abrir*/
                ConsultarCompras vConsultar = new ConsultarCompras();
                /*ante de abrir la ventana se ha de esoecificar que esta ventana es hija de la que estamos codificando*/
                vConsultar.MdiParent = this;
                /*esta mostrando la ventana con show*/
                vConsultar.Show();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*se ha de averiguar si la ventana no esta abierta*/
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Borrar")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                /*se va a abrir la ventana de empleados pero como hija de la ventana prioncipal*/
                /*se ha de declarar una variable del tipo de ventana que se desea abrir*/
                BorrarCompras vBorrar = new BorrarCompras();
                /*ante de abrir la ventana se ha de esoecificar que esta ventana es hija de la que estamos codificando*/
                vBorrar.MdiParent = this;
                /*esta mostrando la ventana con show*/
                vBorrar.Show();
            }
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool estaAbierta = false;

            foreach (Form v in Application.OpenForms)
            {
                if (v.Text == "Añadir")
                {
                    estaAbierta = true;
                }
            }

            if (!estaAbierta)
            {
                /*se va a abrir la ventana de empleados pero como hija de la ventana prioncipal*/
                /*se ha de declarar una variable del tipo de ventana que se desea abrir*/
                AñadirClientes vAñadir = new AñadirClientes();
                /*ante de abrir la ventana se ha de esoecificar que esta ventana es hija de la que estamos codificando*/
                vAñadir.MdiParent = this;
                /*esta mostrando la ventana con show*/
                vAñadir.Show();
            }
        }
    }
}
