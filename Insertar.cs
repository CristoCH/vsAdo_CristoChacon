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
    public partial class Form1 : Form
    {
        /*Creamos el DataSet y los DataAdapter de todas las tablas*/

        DataSet ds = new DataSet();
        SqlDataAdapter da_Hotel, da_Habitaciones;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            /* Establecemos conexión */
            Connection con = new Connection();
            try
            {
                con.Connec.Open();
                String query;

                query = "SELECT * FROM hoteles";
                da_Hotel = new SqlDataAdapter(query, con.Connec);
                da_Hotel.Fill(ds, "hoteles");

                DataView dv_hoteles = new DataView(ds.Tables["hoteles"]);
                codComboBox.DisplayMember = "nomHotel";
                codComboBox.ValueMember = "codHotel";
                codComboBox.DataSource = dv_hoteles;

                con.Connec.Close();
                
                codComboBox.SelectedIndex = 0;



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
                String query;

                query = "INSERT INTO habitaciones VALUES (@codHotel,@numHabitacion,@capacidad,@preciodia,@activa)";


                da_Habitaciones = new SqlDataAdapter();
                da_Habitaciones.InsertCommand = new SqlCommand(query, con.Connec);

                da_Habitaciones.InsertCommand.Parameters.Add("@codHotel", SqlDbType.Char, 6).Value = codComboBox.SelectedValue;
                da_Habitaciones.InsertCommand.Parameters.Add("@numHabitacion", SqlDbType.Char, 4).Value = numText.Text;
                da_Habitaciones.InsertCommand.Parameters.Add("@capacidad", SqlDbType.SmallInt).Value = capacidadText.Text;
                da_Habitaciones.InsertCommand.Parameters.Add("@preciodia", SqlDbType.Int).Value = precioText.Text;
                da_Habitaciones.InsertCommand.Parameters.Add("@activa", SqlDbType.TinyInt).Value = activaCheck.Checked;

                da_Habitaciones.InsertCommand.ExecuteNonQuery();

                con.Connec.Close();

                MessageBox.Show("Insertado Correctamente");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
