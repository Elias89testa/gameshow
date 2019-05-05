using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_tercer_trimestre
{
    class Gestion
    {
        private static SqlConnection conectarBase()
        {
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias\source\repos\Practica_tercer_trimestre\Practica_tercer_trimestre\TiendaVideojuegos.mdf;Integrated Security=True";
            return new SqlConnection(connetionString);
        }
        public Clientes aniadirClientes(Clientes cliente)
        {
            
            SqlConnection cnn=Gestion.conectarBase();
           
            cnn.Open();


            String insertar = "INSERT INTO clientes (nombre,direccion,telefono,email) VALUES ('" + cliente.getNombre() + "', '" + cliente.getDireccion() + "', '" + cliente.getTelefono() + "', '" + cliente.getEmail() + "');";
            SqlCommand cmd = new SqlCommand(insertar,cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

            return cliente;
        }

        public List<Clientes> consultarClientes()
        {
            Clientes cliente = new Clientes();
            List<Clientes> list = new List<Clientes>();
            SqlConnection cnn = Gestion.conectarBase();

            cnn.Open();
            SqlDataReader reader;
            String consultar = "SELECT nombre,direccion,telefono,email FROM clientes ORDER BY nombre;";
            SqlCommand cmd = new SqlCommand(consultar, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cliente.setNombre(reader.GetString(0));
                cliente.setDireccion(reader.GetString(1));
                cliente.setTelefono(reader.GetString(2));
                cliente.setEmail(reader.GetString(3));
                list.Add(cliente);
            }

            
            cnn.Close();
            return list;

        }
    }
}
