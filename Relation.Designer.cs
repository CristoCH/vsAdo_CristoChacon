namespace vsAdo_CristoChacon
{
    partial class Relation
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
            this.countHab = new System.Windows.Forms.Label();
            this.countHotel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridHotel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // countHab
            // 
            this.countHab.AutoSize = true;
            this.countHab.Location = new System.Drawing.Point(341, 322);
            this.countHab.Name = "countHab";
            this.countHab.Size = new System.Drawing.Size(130, 13);
            this.countHab.TabIndex = 29;
            this.countHab.Text = "Cantidad de habitaciones:";
            // 
            // countHotel
            // 
            this.countHotel.AutoSize = true;
            this.countHotel.Location = new System.Drawing.Point(40, 322);
            this.countHotel.Name = "countHotel";
            this.countHotel.Size = new System.Drawing.Size(104, 13);
            this.countHotel.TabIndex = 28;
            this.countHotel.Text = "Cantidad de hoteles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Habitaciones:";
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(344, 82);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.Size = new System.Drawing.Size(559, 228);
            this.dataGridHabitaciones.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cristo Chacón Hernández";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hoteles:";
            // 
            // dataGridHotel
            // 
            this.dataGridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotel.Location = new System.Drawing.Point(43, 82);
            this.dataGridHotel.Name = "dataGridHotel";
            this.dataGridHotel.Size = new System.Drawing.Size(246, 228);
            this.dataGridHotel.TabIndex = 21;
            this.dataGridHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHotel_CellContentClick);
            // 
            // Relation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 396);
            this.Controls.Add(this.countHab);
            this.Controls.Add(this.countHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridHabitaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHotel);
            this.Name = "Relation";
            this.Text = "Relation";
            this.Load += new System.EventHandler(this.Relation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countHab;
        private System.Windows.Forms.Label countHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridHotel;
    }
}