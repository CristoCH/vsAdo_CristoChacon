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
    public partial class ComboHab : Form
    {

        /*Creamos el DataSet y los DataAdapter de todas las tablas*/

        DataSet ds = new DataSet();
        SqlDataAdapter da_Hotel, da_Habitaciones;

        public ComboHab()
        {
            InitializeComponent();
        }

        private void hotelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query;

                if(ds.Tables["habitaciones"] != null)
                {
                    ds.Tables["habitaciones"].Clear();
                }

                /* Tabla habitaciones*/
                query = "SELECT * FROM habitaciones";
                da_Habitaciones = new SqlDataAdapter(query, con.Connec);
                da_Habitaciones.Fill(ds, "habitaciones");

                DataView dv_habitaciones = new DataView(ds.Tables["habitaciones"]);
                dv_habitaciones.RowFilter = "codHotel = '" + hotelComboBox.SelectedValue + "'";     /* filtramos el dataView con el value del hotel seleccionado, ese value será el codHotel */
                dataGridHabitaciones.DataSource = dv_habitaciones;

                dataGridHabitaciones.Columns[0].HeaderText = "codHotel";
                dataGridHabitaciones.Columns[1].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[2].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[4].HeaderText = "activa";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ComboHab_Load(object sender, EventArgs e)
        {

            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query;

                /* Tabla Hoteles */
                query = "SELECT * FROM hoteles";
                da_Hotel = new SqlDataAdapter(query, con.Connec);
                da_Hotel.Fill(ds, "hoteles");

                DataView dv_hoteles = new DataView(ds.Tables["hoteles"]);
                hotelComboBox.DataSource = dv_hoteles;

                hotelComboBox.DisplayMember = "nomHotel";
                hotelComboBox.ValueMember = "codHotel";
                hotelComboBox.DataSource = dv_hoteles;

                con.Connec.Close();

                hotelComboBox.SelectedIndex = 0;
                hotelComboBox_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
