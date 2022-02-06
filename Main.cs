using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsAdo_CristoChacon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void manipulateButton_Click(object sender, EventArgs e)
        {
            Manipulate manipulate = new Manipulate();
            manipulate.Show();
        }

        private void comboButton_Click(object sender, EventArgs e)
        {
            Combo combo = new Combo();
            combo.Show();
        }

        private void comboHabButton_Click(object sender, EventArgs e)
        {
            ComboHab comboHab = new ComboHab();
            comboHab.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Form1 insert = new Form1();
            insert.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Borrar borrar = new Borrar();
            borrar.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void relationButton_Click(object sender, EventArgs e)
        {
            Relation relation = new Relation();
            relation.Show();
        }

        private void funButton_Click(object sender, EventArgs e)
        {
            Funpro funpro = new Funpro();
            funpro.Show();
        }
    }
}
