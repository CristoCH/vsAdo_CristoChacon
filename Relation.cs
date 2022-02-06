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
    public partial class Relation : Form
    {

        DataSet ds = new DataSet();
        SqlDataAdapter da_Hotel, da_Habitaciones;
        DataView dv_hoteles = new DataView();
        DataRowView currentRowView;

        public Relation()
        {
            InitializeComponent();
        }

        private void dataGridHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();

                currentRowView =  dv_hoteles[dataGridHotel.CurrentRow.Index];
                dataGridHabitaciones.DataSource = currentRowView.CreateChildView("HotelHabitaciones");

                countHab.Text = "Cantidad de habitaciones: " + (dataGridHabitaciones.RowCount-1).ToString();

                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Relation_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();

                String query;

                /* Tabla Hoteles */
                query = "SELECT * FROM hoteles";
                da_Hotel = new SqlDataAdapter(query, con.Connec);
                da_Hotel.Fill(ds, "hoteles");

                /* Tabla habitaciones*/
                query = "SELECT * FROM habitaciones";
                da_Habitaciones = new SqlDataAdapter(query, con.Connec);
                da_Habitaciones.Fill(ds, "habitaciones");


                /* Relation */
                DataColumn parentColumn = ds.Tables["hoteles"].Columns["codHotel"];
                DataColumn childColumn = ds.Tables["habitaciones"].Columns["codHotel"];
                DataRelation relParChi;
                relParChi = new DataRelation("HotelHabitaciones", parentColumn, childColumn);
                ds.Relations.Add(relParChi);



                /* Hoteles */

                dv_hoteles = new DataView(ds.Tables["hoteles"]);
                dataGridHotel.DataSource = dv_hoteles;

                currentRowView = dv_hoteles[dataGridHotel.CurrentRow.Index];

                dataGridHotel.Columns[0].HeaderText = "codHotel";
                dataGridHotel.Columns[1].HeaderText = "nomHotel";


                countHotel.Text = "Cantidad de hoteles: " + ds.Tables["hoteles"].Rows.Count.ToString();

                /* Habitaciones */

                dataGridHabitaciones.DataSource = currentRowView.CreateChildView("HotelHabitaciones");

                dataGridHabitaciones.Columns[0].HeaderText = "codHotel";
                dataGridHabitaciones.Columns[1].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[2].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[4].HeaderText = "activa";

                countHab.Text = "Cantidad total de habitaciones registradas: " + ds.Tables["habitaciones"].Rows.Count.ToString();

                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
