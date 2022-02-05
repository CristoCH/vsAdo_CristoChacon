namespace vsAdo_CristoChacon
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.activaCheck = new System.Windows.Forms.CheckBox();
            this.numText = new System.Windows.Forms.TextBox();
            this.codComboBox = new System.Windows.Forms.ComboBox();
            this.capacidadText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cristo Chacón Hernández";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Va a insertar una habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código del Hotel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de habitación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preciodia:";
            // 
            // activaCheck
            // 
            this.activaCheck.AutoSize = true;
            this.activaCheck.Location = new System.Drawing.Point(15, 211);
            this.activaCheck.Name = "activaCheck";
            this.activaCheck.Size = new System.Drawing.Size(56, 17);
            this.activaCheck.TabIndex = 10;
            this.activaCheck.Text = "Activa";
            this.activaCheck.UseVisualStyleBackColor = true;
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(132, 110);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(121, 20);
            this.numText.TabIndex = 11;
            // 
            // codComboBox
            // 
            this.codComboBox.FormattingEnabled = true;
            this.codComboBox.Location = new System.Drawing.Point(132, 82);
            this.codComboBox.Name = "codComboBox";
            this.codComboBox.Size = new System.Drawing.Size(121, 21);
            this.codComboBox.TabIndex = 12;
            // 
            // capacidadText
            // 
            this.capacidadText.Location = new System.Drawing.Point(132, 142);
            this.capacidadText.Name = "capacidadText";
            this.capacidadText.Size = new System.Drawing.Size(121, 20);
            this.capacidadText.TabIndex = 13;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(132, 175);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(121, 20);
            this.precioText.TabIndex = 14;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(132, 205);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(121, 23);
            this.insertButton.TabIndex = 15;
            this.insertButton.Text = "Insertar";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 279);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.capacidadText);
            this.Controls.Add(this.codComboBox);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.activaCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox activaCheck;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.ComboBox codComboBox;
        private System.Windows.Forms.TextBox capacidadText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.Button insertButton;
    }
}