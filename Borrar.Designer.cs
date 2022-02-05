namespace vsAdo_CristoChacon
{
    partial class Borrar
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
            this.borrarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.capacidadLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.activaCheck = new System.Windows.Forms.CheckBox();
            this.confirmarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(486, 337);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(121, 23);
            this.borrarButton.TabIndex = 27;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cristo Chacón Hernández";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ejemplo de borrado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Habitaciones:";
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(48, 92);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.Size = new System.Drawing.Size(559, 228);
            this.dataGridHabitaciones.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Introduzca el número de habitación que desea borrar:";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(313, 339);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(123, 20);
            this.numText.TabIndex = 33;
            // 
            // capacidadLabel
            // 
            this.capacidadLabel.AutoSize = true;
            this.capacidadLabel.Location = new System.Drawing.Point(45, 373);
            this.capacidadLabel.Name = "capacidadLabel";
            this.capacidadLabel.Size = new System.Drawing.Size(61, 13);
            this.capacidadLabel.TabIndex = 34;
            this.capacidadLabel.Text = "Capacidad:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Location = new System.Drawing.Point(45, 408);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(67, 13);
            this.precioLabel.TabIndex = 35;
            this.precioLabel.Text = "Precio / día:";
            // 
            // activaCheck
            // 
            this.activaCheck.AutoSize = true;
            this.activaCheck.Location = new System.Drawing.Point(48, 441);
            this.activaCheck.Name = "activaCheck";
            this.activaCheck.Size = new System.Drawing.Size(56, 17);
            this.activaCheck.TabIndex = 36;
            this.activaCheck.Text = "Activa";
            this.activaCheck.UseVisualStyleBackColor = true;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(48, 481);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(98, 23);
            this.confirmarButton.TabIndex = 37;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 579);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.activaCheck);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.capacidadLabel);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridHabitaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.label3);
            this.Name = "Borrar";
            this.Text = "Borrar";
            this.Load += new System.EventHandler(this.Borrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.Label capacidadLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.CheckBox activaCheck;
        private System.Windows.Forms.Button confirmarButton;
    }
}