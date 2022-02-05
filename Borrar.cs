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
    public partial class Borrar : Form
    {
        DataTable dt;
        SqlDataAdapter da_habitaciones;
        DataSet ds = new DataSet();

        public Borrar()
        {
            InitializeComponent();
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query = "SELECT * FROM habitaciones WHERE numHabitacion="+numText.Text;
                da_habitaciones = new SqlDataAdapter(query, con.Connec);

                da_habitaciones.Fill(ds, "habitaciones");

                capacidadLabel.Text = "Capacidad: "+ds.Tables["habitaciones"].Rows[0]["capacidad"].ToString();
                precioLabel.Text = "Precio/día: "+ ds.Tables["habitaciones"].Rows[0]["preciodia"].ToString();
                activaCheck.Checked = Convert.ToBoolean(ds.Tables["habitaciones"].Rows[0]["activa"]);

                ds.Clear();
                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Borrar_Load(object sender, EventArgs e)
        {
            try
            {
                /* Muestro los datos de la tabla usando un dataReader */
                Connection con = new Connection();
                con.Connec.Open();

                String query = "SELECT * FROM habitaciones";
                SqlCommand command = new SqlCommand(query, con.Connec);

                SqlDataReader reader = command.ExecuteReader();
                dt = new DataTable();

                dt.Load(reader);

                dataGridHabitaciones.DataSource = dt;

                dataGridHabitaciones.Columns[0].HeaderText = "codHotel";
                dataGridHabitaciones.Columns[1].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[2].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[4].HeaderText = "activa";


                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query = "DELETE FROM habitaciones WHERE numHabitacion=@numHabitacion";
                da_habitaciones = new SqlDataAdapter(query, con.Connec);
                da_habitaciones.DeleteCommand = new SqlCommand(query, con.Connec);

                da_habitaciones.DeleteCommand.Parameters.Add("@numHabitacion", SqlDbType.Char, 4).Value = numText.Text;
                da_habitaciones.DeleteCommand.ExecuteNonQuery();

                con.Connec.Close();
                MessageBox.Show("Borrado correctamente");

                capacidadLabel.Text = "";
                precioLabel.Text = "";
                activaCheck.Checked = false;

                ds.Clear();
                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
