using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsAdo_CristoChacon
{
    public partial class Funpro : Form
    {

        DataSet ds = new DataSet();
        SqlDataAdapter da_funpro;

        public Funpro()
        {
            InitializeComponent();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                
                ds.Clear(); //para limpiar la tabla

                String query = "EXEC sp_listaHabitac @nomHotel= '" + nomHotelText.Text + "'";
                da_funpro = new SqlDataAdapter(query, con.Connec);
                da_funpro.Fill(ds, "habitaciones");

                DataView dv_funpro = new DataView(ds.Tables["habitaciones"]);
                dataGridHabitaciones.DataSource = dv_funpro;

                dataGridHabitaciones.Columns[0].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[1].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[1].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[2].HeaderText = "activa";

                con.Connec.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                
                SqlCommand query = new SqlCommand("sp_inseHabitac",con.Connec);
                query.CommandType = CommandType.StoredProcedure;



                query.Parameters.AddWithValue("@codHotel", codText.Text);
                query.Parameters.AddWithValue("@numHabitacion", numText.Text);
                query.Parameters.AddWithValue("@capacidad", capacidadText.Text);
                query.Parameters.AddWithValue("@precio", precioText.Text);
                query.Parameters.AddWithValue("@activa", activaCheck.Checked);

                SqlParameter salida1 = new SqlParameter();
                salida1.ParameterName = "@Salida1";
                salida1.Direction = ParameterDirection.Output;
                salida1.SqlDbType = SqlDbType.Int;
                query.Parameters.Add(salida1);

                SqlParameter salida2 = new SqlParameter();
                salida2.ParameterName = "@Salida2";
                salida2.Direction = ParameterDirection.Output;
                salida2.SqlDbType = SqlDbType.Int;
                query.Parameters.Add(salida2);

                query.ExecuteNonQuery();

                string Out1 = salida1.Value.ToString();
                string Out2 = salida2.Value.ToString();

                existLabel.Text = "El Hotel existe: " + Out1;
                insertLabel.Text = "Se ha insertado: " + Out2;

                con.Connec.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verButton_Click(object sender, EventArgs e)
        {

            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();

                SqlCommand query = new SqlCommand("sp_indicHotel", con.Connec);
                query.CommandType = CommandType.StoredProcedure;



                query.Parameters.AddWithValue("@nombreHotel", nomText2.Text);
                query.Parameters.AddWithValue("@precio", precioText2.Text);

                SqlParameter salida1 = new SqlParameter();
                salida1.ParameterName = "@salidad1";
                salida1.Direction = ParameterDirection.Output;
                salida1.SqlDbType = SqlDbType.Int;
                query.Parameters.Add(salida1);

                SqlParameter salida2 = new SqlParameter();
                salida2.ParameterName = "@salida2";
                salida2.Direction = ParameterDirection.Output;
                salida2.SqlDbType = SqlDbType.Int;
                query.Parameters.Add(salida2);

                query.ExecuteNonQuery();

                string Out1 = salida1.Value.ToString();
                string Out2 = salida2.Value.ToString();

                totalLabel.Text = "Cantidad de habitaciones de ese hotel: " + Out1;
                underLabel.Text = "Cantidad de habitaciones por debajo del precio: " + Out2;

                con.Connec.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verCantidadButton_Click(object sender, EventArgs e)
        {
            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();

                String query = "SELECT dbo.dniCliente ('" + dniText.Text + "')";
                SqlCommand command = new SqlCommand(query, con.Connec);

                pagaText.Text = "Cantidad: "+ command.ExecuteScalar() + " €";

                con.Connec.Close();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
