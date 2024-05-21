namespace Formularios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtColorPlumas = new TextBox();
            txtVelocidadVuelo = new TextBox();
            cbHabitat = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 73);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 44);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 1;
            label3.Text = "Habitat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 102);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 2;
            label4.Text = "Color de las plumas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 131);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 3;
            label5.Text = "Velocidad de vuelo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(70, 70);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(171, 23);
            txtEdad.TabIndex = 5;
            // 
            // txtColorPlumas
            // 
            txtColorPlumas.Location = new Point(141, 99);
            txtColorPlumas.Name = "txtColorPlumas";
            txtColorPlumas.Size = new Size(100, 23);
            txtColorPlumas.TabIndex = 6;
            // 
            // txtVelocidadVuelo
            // 
            txtVelocidadVuelo.Location = new Point(141, 128);
            txtVelocidadVuelo.Name = "txtVelocidadVuelo";
            txtVelocidadVuelo.Size = new Size(100, 23);
            txtVelocidadVuelo.TabIndex = 7;
            // 
            // cbHabitat
            // 
            cbHabitat.FormattingEnabled = true;
            cbHabitat.Location = new Point(70, 41);
            cbHabitat.Name = "cbHabitat";
            cbHabitat.Size = new Size(171, 23);
            cbHabitat.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(13, 180);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 25);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(141, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 25);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormColibri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 214);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbHabitat);
            Controls.Add(txtVelocidadVuelo);
            Controls.Add(txtColorPlumas);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormColibri";
            Text = "FormColibri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtColorPlumas;
        private TextBox txtVelocidadVuelo;
        private ComboBox cbHabitat;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}