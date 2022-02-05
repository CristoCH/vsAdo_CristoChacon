namespace vsAdo_CristoChacon
{
    partial class Manipulate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridHotel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveHotel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridEstancias = new System.Windows.Forms.DataGridView();
            this.saveCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridRegimenes = new System.Windows.Forms.DataGridView();
            this.saveHab = new System.Windows.Forms.Button();
            this.saveEstancia = new System.Windows.Forms.Button();
            this.saveRegimen = new System.Windows.Forms.Button();
            this.countHotel = new System.Windows.Forms.Label();
            this.countHab = new System.Windows.Forms.Label();
            this.countEstancias = new System.Windows.Forms.Label();
            this.countClient = new System.Windows.Forms.Label();
            this.countRegimen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegimenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHotel
            // 
            this.dataGridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotel.Location = new System.Drawing.Point(30, 75);
            this.dataGridHotel.Name = "dataGridHotel";
            this.dataGridHotel.Size = new System.Drawing.Size(246, 228);
            this.dataGridHotel.TabIndex = 0;
            this.dataGridHotel.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridHotel_ColumnHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoteles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cristo Chacón Hernández";
            // 
            // saveHotel
            // 
            this.saveHotel.Location = new System.Drawing.Point(30, 309);
            this.saveHotel.Name = "saveHotel";
            this.saveHotel.Size = new System.Drawing.Size(154, 23);
            this.saveHotel.TabIndex = 4;
            this.saveHotel.Text = "Guardar Cambios";
            this.saveHotel.UseVisualStyleBackColor = true;
            this.saveHotel.Click += new System.EventHandler(this.saveHotel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Habitaciones:";
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(497, 75);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.Size = new System.Drawing.Size(559, 228);
            this.dataGridHabitaciones.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estancias:";
            // 
            // dataGridEstancias
            // 
            this.dataGridEstancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstancias.Location = new System.Drawing.Point(30, 380);
            this.dataGridEstancias.Name = "dataGridEstancias";
            this.dataGridEstancias.Size = new System.Drawing.Size(1026, 199);
            this.dataGridEstancias.TabIndex = 8;
            // 
            // saveCliente
            // 
            this.saveCliente.Location = new System.Drawing.Point(30, 878);
            this.saveCliente.Name = "saveCliente";
            this.saveCliente.Size = new System.Drawing.Size(154, 23);
            this.saveCliente.TabIndex = 13;
            this.saveCliente.Text = "Guardar Cambios";
            this.saveCliente.UseVisualStyleBackColor = true;
            this.saveCliente.Click += new System.EventHandler(this.saveCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clientes:";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(30, 678);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(348, 194);
            this.dataGridClientes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Regimenes:";
            // 
            // dataGridRegimenes
            // 
            this.dataGridRegimenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegimenes.Location = new System.Drawing.Point(611, 678);
            this.dataGridRegimenes.Name = "dataGridRegimenes";
            this.dataGridRegimenes.Size = new System.Drawing.Size(445, 194);
            this.dataGridRegimenes.TabIndex = 14;
            // 
            // saveHab
            // 
            this.saveHab.Location = new System.Drawing.Point(497, 309);
            this.saveHab.Name = "saveHab";
            this.saveHab.Size = new System.Drawing.Size(154, 23);
            this.saveHab.TabIndex = 16;
            this.saveHab.Text = "Guardar Cambios";
            this.saveHab.UseVisualStyleBackColor = true;
            this.saveHab.Click += new System.EventHandler(this.saveHab_Click);
            // 
            // saveEstancia
            // 
            this.saveEstancia.Location = new System.Drawing.Point(30, 585);
            this.saveEstancia.Name = "saveEstancia";
            this.saveEstancia.Size = new System.Drawing.Size(154, 23);
            this.saveEstancia.TabIndex = 17;
            this.saveEstancia.Text = "Guardar Cambios";
            this.saveEstancia.UseVisualStyleBackColor = true;
            this.saveEstancia.Click += new System.EventHandler(this.saveEstancia_Click);
            // 
            // saveRegimen
            // 
            this.saveRegimen.Location = new System.Drawing.Point(611, 878);
            this.saveRegimen.Name = "saveRegimen";
            this.saveRegimen.Size = new System.Drawing.Size(154, 23);
            this.saveRegimen.TabIndex = 18;
            this.saveRegimen.Text = "Guardar Cambios";
            this.saveRegimen.UseVisualStyleBackColor = true;
            this.saveRegimen.Click += new System.EventHandler(this.saveRegimen_Click);
            // 
            // countHotel
            // 
            this.countHotel.AutoSize = true;
            this.countHotel.Location = new System.Drawing.Point(30, 339);
            this.countHotel.Name = "countHotel";
            this.countHotel.Size = new System.Drawing.Size(104, 13);
            this.countHotel.TabIndex = 19;
            this.countHotel.Text = "Cantidad de hoteles:";
            // 
            // countHab
            // 
            this.countHab.AutoSize = true;
            this.countHab.Location = new System.Drawing.Point(494, 335);
            this.countHab.Name = "countHab";
            this.countHab.Size = new System.Drawing.Size(130, 13);
            this.countHab.TabIndex = 20;
            this.countHab.Text = "Cantidad de habitaciones:";
            // 
            // countEstancias
            // 
            this.countEstancias.AutoSize = true;
            this.countEstancias.Location = new System.Drawing.Point(30, 611);
            this.countEstancias.Name = "countEstancias";
            this.countEstancias.Size = new System.Drawing.Size(115, 13);
            this.countEstancias.TabIndex = 21;
            this.countEstancias.Text = "Cantidad de estancias:";
            // 
            // countClient
            // 
            this.countClient.AutoSize = true;
            this.countClient.Location = new System.Drawing.Point(30, 904);
            this.countClient.Name = "countClient";
            this.countClient.Size = new System.Drawing.Size(106, 13);
            this.countClient.TabIndex = 22;
            this.countClient.Text = "Cantidad de clientes:";
            // 
            // countRegimen
            // 
            this.countRegimen.AutoSize = true;
            this.countRegimen.Location = new System.Drawing.Point(608, 904);
            this.countRegimen.Name = "countRegimen";
            this.countRegimen.Size = new System.Drawing.Size(118, 13);
            this.countRegimen.TabIndex = 23;
            this.countRegimen.Text = "Cantidad de regimenes:";
            // 
            // Manipulate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 1006);
            this.Controls.Add(this.countRegimen);
            this.Controls.Add(this.countClient);
            this.Controls.Add(this.countEstancias);
            this.Controls.Add(this.countHab);
            this.Controls.Add(this.countHotel);
            this.Controls.Add(this.saveRegimen);
            this.Controls.Add(this.saveEstancia);
            this.Controls.Add(this.saveHab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridRegimenes);
            this.Controls.Add(this.saveCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridEstancias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridHabitaciones);
            this.Controls.Add(this.saveHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHotel);
            this.Name = "Manipulate";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Maniplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegimenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridEstancias;
        private System.Windows.Forms.Button saveCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridRegimenes;
        private System.Windows.Forms.Button saveHab;
        private System.Windows.Forms.Button saveEstancia;
        private System.Windows.Forms.Button saveRegimen;
        private System.Windows.Forms.Label countHotel;
        private System.Windows.Forms.Label countHab;
        private System.Windows.Forms.Label countEstancias;
        private System.Windows.Forms.Label countClient;
        private System.Windows.Forms.Label countRegimen;
        public System.Windows.Forms.DataGridView dataGridHotel;
    }
}