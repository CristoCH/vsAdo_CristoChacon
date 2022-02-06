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
    public partial class Manipulate : Form
    {
        /*Creamos el DataSet y los DataAdapter de todas las tablas*/

        DataSet ds = new DataSet();
        SqlDataAdapter da_Hotel, da_Habitaciones, da_Estancias, da_Clientes, da_Regimenes;


        /* update buttons */
        private void saveEstancia_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(da_Estancias);
                da_Estancias.Update(ds.Tables["estancias"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(da_Clientes);
                da_Clientes.Update(ds.Tables["clientes"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveRegimen_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(da_Regimenes);
                da_Regimenes.Update(ds.Tables["regimenes"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridHotel_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridHotel.Columns[dataGridHotel.CurrentCell.ColumnIndex].HeaderText = "newHeaderText";
            
        }

        private void saveHab_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(da_Habitaciones);
                da_Habitaciones.Update(ds.Tables["habitaciones"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveHotel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(da_Hotel);
                da_Hotel.Update(ds.Tables["hoteles"]);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Manipulate()
        {
            InitializeComponent();
        }

        private void Maniplate_Load(object sender, EventArgs e)
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

                dataGridHabitaciones.Columns[0].HeaderText = "codHotel";
                dataGridHabitaciones.Columns[1].HeaderText = "numHabitacion";
                dataGridHabitaciones.Columns[2].HeaderText = "capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "preciodia";
                dataGridHabitaciones.Columns[4].HeaderText = "activa";

                countHab.Text = "Cantidad de habitaciones: " + ds.Tables["habitaciones"].Rows.Count.ToString();


                /* Tabla estancias*/
                query = "SELECT * FROM estancias";
                da_Estancias = new SqlDataAdapter(query, con.Connec);
                da_Estancias.Fill(ds, "estancias");

                DataView dv_estancias = new DataView(ds.Tables["estancias"]);
                dataGridEstancias.DataSource = dv_estancias;


                dataGridEstancias.Columns[0].HeaderText = "codestancia";
                dataGridEstancias.Columns[1].HeaderText = "coddnionie";
                dataGridEstancias.Columns[2].HeaderText = "codHotel";
                dataGridEstancias.Columns[3].HeaderText = "numHabitaciones";
                dataGridEstancias.Columns[4].HeaderText = "fechaInicio";
                dataGridEstancias.Columns[5].HeaderText = "fechaFin";
                dataGridEstancias.Columns[6].HeaderText = "codregimen";
                dataGridEstancias.Columns[7].HeaderText = "ocupantes";
                dataGridEstancias.Columns[8].HeaderText = "precioestancia";
                dataGridEstancias.Columns[9].HeaderText = "pagado";

                countEstancias.Text = "Cantidad de estancias: " + ds.Tables["estancias"].Rows.Count.ToString();

                /* Tabla clientes*/
                query = "SELECT * FROM clientes";
                da_Clientes = new SqlDataAdapter(query, con.Connec);
                da_Clientes.Fill(ds, "clientes");

                DataView dv_clientes = new DataView(ds.Tables["clientes"]);
                dataGridClientes.DataSource = dv_clientes;

                dataGridClientes.Columns[0].HeaderText = "coddnionie";
                dataGridClientes.Columns[1].HeaderText = "nombre";
                dataGridClientes.Columns[2].HeaderText = "nacionalidad";

                countClient.Text = "Cantidad de clientes: " + ds.Tables["clientes"].Rows.Count.ToString();



                /* Tabla regimenes*/
                query = "SELECT * FROM regimenes";
                da_Regimenes = new SqlDataAdapter(query, con.Connec);
                da_Regimenes.Fill(ds, "regimenes");

                DataView dv_regimenes = new DataView(ds.Tables["regimenes"]);
                dataGridRegimenes.DataSource = dv_regimenes;

                dataGridRegimenes.Columns[0].HeaderText = "codregimen";
                dataGridRegimenes.Columns[1].HeaderText = "codHotel";
                dataGridRegimenes.Columns[2].HeaderText = "tipo";
                dataGridRegimenes.Columns[3].HeaderText = "precio";

                countRegimen.Text = "Cantidad de regimenes: " + ds.Tables["regimenes"].Rows.Count.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
