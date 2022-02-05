namespace vsAdo_CristoChacon
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manipulateButton = new System.Windows.Forms.Button();
            this.comboButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboHabButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manipular los registros de las diferentes tablas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cristo Chacón Hernández";
            // 
            // manipulateButton
            // 
            this.manipulateButton.Location = new System.Drawing.Point(251, 49);
            this.manipulateButton.Name = "manipulateButton";
            this.manipulateButton.Size = new System.Drawing.Size(75, 23);
            this.manipulateButton.TabIndex = 4;
            this.manipulateButton.Text = "Ejecutar";
            this.manipulateButton.UseVisualStyleBackColor = true;
            this.manipulateButton.Click += new System.EventHandler(this.manipulateButton_Click);
            // 
            // comboButton
            // 
            this.comboButton.Location = new System.Drawing.Point(251, 78);
            this.comboButton.Name = "comboButton";
            this.comboButton.Size = new System.Drawing.Size(75, 23);
            this.comboButton.TabIndex = 6;
            this.comboButton.Text = "Ejecutar";
            this.comboButton.UseVisualStyleBackColor = true;
            this.comboButton.Click += new System.EventHandler(this.comboButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mostrar en un Combo Hotel y habitaciones:";
            // 
            // comboHabButton
            // 
            this.comboHabButton.Location = new System.Drawing.Point(251, 107);
            this.comboHabButton.Name = "comboHabButton";
            this.comboHabButton.Size = new System.Drawing.Size(75, 23);
            this.comboHabButton.TabIndex = 8;
            this.comboHabButton.Text = "Ejecutar";
            this.comboHabButton.UseVisualStyleBackColor = true;
            this.comboHabButton.Click += new System.EventHandler(this.comboHabButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mostrar las habitaciones del hotel seleccionado:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(251, 136);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "Ejecutar";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insertar una habitación:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(251, 165);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Ejecutar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Borrar una habitación:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboHabButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.manipulateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manipulateButton;
        private System.Windows.Forms.Button comboButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button comboHabButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label6;
    }
}

