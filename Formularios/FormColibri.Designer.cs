﻿namespace Formularios
{
    partial class FormColibri
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
            label4 = new Label();
            label5 = new Label();
            txtColorPlumas = new TextBox();
            txtVelocidadVuelo = new TextBox();
            SuspendLayout();
            // 
            // cbHabitat
            // 
            cbHabitat.Items.AddRange(new object[] { Entidades.Habitat.Bosque, Entidades.Habitat.Desierto, Entidades.Habitat.Montaña, Entidades.Habitat.Antartida, Entidades.Habitat.Ciudad });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 108);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 2;
            label4.Text = "Color de las plumas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 137);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 3;
            label5.Text = "Velocidad de vuelo";
            // 
            // txtColorPlumas
            // 
            txtColorPlumas.Location = new Point(145, 105);
            txtColorPlumas.Name = "txtColorPlumas";
            txtColorPlumas.Size = new Size(120, 23);
            txtColorPlumas.TabIndex = 3;
            // 
            // txtVelocidadVuelo
            // 
            txtVelocidadVuelo.Location = new Point(145, 134);
            txtVelocidadVuelo.Name = "txtVelocidadVuelo";
            txtVelocidadVuelo.Size = new Size(120, 23);
            txtVelocidadVuelo.TabIndex = 4;
            // 
            // FormColibri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 221);
            Controls.Add(txtVelocidadVuelo);
            Controls.Add(txtColorPlumas);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "FormColibri";
            Text = "Cargar Colibrí";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(cbHabitat, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtColorPlumas, 0);
            Controls.SetChildIndex(txtVelocidadVuelo, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox txtColorPlumas;
        private TextBox txtVelocidadVuelo;
    }
}