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

                dataGridHotel.Columns[0].HeaderText = "Código Hotel";
                dataGridHotel.Columns[1].HeaderText = "Nombre Hotel";

                countHotel.Text = "Cantidad de hoteles: " + ds.Tables["hoteles"].Rows.Count.ToString();


                /* Tabla habitaciones*/
                query = "SELECT * FROM habitaciones";
                da_Habitaciones = new SqlDataAdapter(query, con.Connec);
                da_Habitaciones.Fill(ds, "habitaciones");

                DataView dv_habitaciones = new DataView(ds.Tables["habitaciones"]);
                dataGridHabitaciones.DataSource = dv_habitaciones;

                dataGridHabitaciones.Columns[0].HeaderText = "Código Hotel";
                dataGridHabitaciones.Columns[1].HeaderText = "Num. Habitación";
                dataGridHabitaciones.Columns[2].HeaderText = "Capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "Precio/Díaa";
                dataGridHabitaciones.Columns[4].HeaderText = "Activa";

                countHab.Text = "Cantidad de habitaciones: " + ds.Tables["habitaciones"].Rows.Count.ToString();


                /* Tabla estancias*/
                query = "SELECT * FROM estancias";
                da_Estancias = new SqlDataAdapter(query, con.Connec);
                da_Estancias.Fill(ds, "estancias");

                DataView dv_estancias = new DataView(ds.Tables["estancias"]);
                dataGridEstancias.DataSource = dv_estancias;


                dataGridEstancias.Columns[0].HeaderText = "Código Estancia";
                dataGridEstancias.Columns[1].HeaderText = "DNI/NIE";
                dataGridEstancias.Columns[2].HeaderText = "Código Hotel";
                dataGridEstancias.Columns[3].HeaderText = "Num. Habitación";
                dataGridEstancias.Columns[4].HeaderText = "FechaInicio";
                dataGridEstancias.Columns[5].HeaderText = "FechaFin";
                dataGridEstancias.Columns[6].HeaderText = "Cod. Regimen";
                dataGridEstancias.Columns[7].HeaderText = "Ocupantes";
                dataGridEstancias.Columns[8].HeaderText = "Precio/estancia";
                dataGridEstancias.Columns[9].HeaderText = "Pagado";

                countEstancias.Text = "Cantidad de estancias: " + ds.Tables["estancias"].Rows.Count.ToString();

                /* Tabla clientes*/
                query = "SELECT * FROM clientes";
                da_Clientes = new SqlDataAdapter(query, con.Connec);
                da_Clientes.Fill(ds, "clientes");

                DataView dv_clientes = new DataView(ds.Tables["clientes"]);
                dataGridClientes.DataSource = dv_clientes;

                dataGridClientes.Columns[0].HeaderText = "DNI/NIE";
                dataGridClientes.Columns[1].HeaderText = "Nombre";
                dataGridClientes.Columns[2].HeaderText = "Nacionalidad";

                countClient.Text = "Cantidad de clientes: " + ds.Tables["clientes"].Rows.Count.ToString();



                /* Tabla regimenes*/
                query = "SELECT * FROM regimenes";
                da_Regimenes = new SqlDataAdapter(query, con.Connec);
                da_Regimenes.Fill(ds, "regimenes");

                DataView dv_regimenes = new DataView(ds.Tables["regimenes"]);
                dataGridRegimenes.DataSource = dv_regimenes;

                dataGridRegimenes.Columns[0].HeaderText = "Cod. Regimen";
                dataGridRegimenes.Columns[1].HeaderText = "Código Hotel";
                dataGridRegimenes.Columns[2].HeaderText = "Tipo";
                dataGridRegimenes.Columns[3].HeaderText = "Precio";

                countRegimen.Text = "Cantidad de regimenes: " + ds.Tables["regimenes"].Rows.Count.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
