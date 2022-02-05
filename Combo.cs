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
    public partial class Combo : Form
    {

        /*Creamos el DataSet y los DataAdapter de todas las tablas*/

        DataSet ds = new DataSet();
        SqlDataAdapter da_Hotel, da_Habitaciones;

        public Combo()
        {
            InitializeComponent();
        }

        private void saveHotel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cbHotel = new SqlCommandBuilder(da_Hotel);
                da_Hotel.Update(ds.Tables["hoteles"]);

                SqlCommandBuilder cbHabitaciones = new SqlCommandBuilder(da_Habitaciones);
                da_Habitaciones.Update(ds.Tables["habitaciones"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void Combo_Load(object sender, EventArgs e)
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
                dataGridHotel.DataSource = dv_hoteles;

                dataGridHotel.Columns[0].HeaderText = "codHotel";
                dataGridHotel.Columns[1].HeaderText = "nomHotel";

                countHotel.Text = "Cantidad de hoteles: " + ds.Tables["hoteles"].Rows.Count.ToString();

                /* Tabla habitaciones*/
                query = "SELECT * FROM habitaciones";
                da_Habitaciones = new SqlDataAdapter(query, con.Connec);
                da_Habitaciones.Fill(ds, "habitaciones");

                DataView dv_habitaciones = new DataView(ds.Tables["habitaciones"]);
                dataGridHabitaciones.DataSource = dv_habitaciones;

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.DataPropertyName = "codHotel";
                comboBoxColumn.DisplayMember = "nomHotel";
                comboBoxColumn.ValueMember = "codHotel";
                comboBoxColumn.DataSource = dv_hoteles;

                dataGridHabitaciones.Columns.Add(comboBoxColumn);

                dataGridHabitaciones.Columns[0].HeaderText = "codHotel";
                dataGridHabitaciones.Columns[1].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[2].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[4].HeaderText = "activa";

                DataColumn parentColumn = ds.Tables["hoteles"].Columns["codHotel"];
                DataColumn childColumn = ds.Tables["habitaciones"].Columns["codHotel"];
                DataRelation relHotHab = new DataRelation("Hotelhabitaciones", parentColumn, childColumn);
                ds.Relations.Add(relHotHab);

                countHab.Text = "Cantidad de habitaciones: " + ds.Tables["habitaciones"].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
