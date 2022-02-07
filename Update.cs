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
    public partial class Update : Form
    {
        DataTable dt;
        SqlDataAdapter da_habitaciones;
        DataSet ds = new DataSet();
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
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

                dataGridHabitaciones.Columns[0].HeaderText = "Código Hotel";
                dataGridHabitaciones.Columns[1].HeaderText = "Num. Habitación";
                dataGridHabitaciones.Columns[2].HeaderText = "Capacidad";
                dataGridHabitaciones.Columns[3].HeaderText = "Precio/Día";
                dataGridHabitaciones.Columns[4].HeaderText = "Activa";

                con.Connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query = "SELECT * FROM habitaciones WHERE numHabitacion=" + numText.Text;
                da_habitaciones = new SqlDataAdapter(query, con.Connec);

                da_habitaciones.Fill(ds, "habitaciones");

                capacidadLabel.Text = "Capacidad: " + ds.Tables["habitaciones"].Rows[0]["capacidad"].ToString();
                precioLabel.Text = "Precio/día: " + ds.Tables["habitaciones"].Rows[0]["preciodia"].ToString();
                activaCheck.Checked = Convert.ToBoolean(ds.Tables["habitaciones"].Rows[0]["activa"]);


                ds.Clear();
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

                String query = "UPDATE habitaciones SET capacidad=@capacidad, preciodia=@preciodia, activa=@activa WHERE numHabitacion="+numText.Text;
                da_habitaciones = new SqlDataAdapter();
                da_habitaciones.UpdateCommand = new SqlCommand(query, con.Connec);

                da_habitaciones.UpdateCommand.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = capacidadText.Text;
                da_habitaciones.UpdateCommand.Parameters.Add("@preciodia", SqlDbType.Int).Value = precioText.Text;
                da_habitaciones.UpdateCommand.Parameters.Add("@activa", SqlDbType.TinyInt).Value = activaCheck.Checked;

                da_habitaciones.UpdateCommand.ExecuteNonQuery();

                con.Connec.Close();

                MessageBox.Show("Modificado correctamente");
                this.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
