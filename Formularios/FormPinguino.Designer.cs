namespace Formularios
{
    partial class FormPinguino
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblHabitat = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtEspecie = new TextBox();
            cbHabitat = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(113, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblHabitat
            // 
            lblHabitat.AutoSize = true;
            lblHabitat.Location = new Point(20, 54);
            lblHabitat.Name = "lblHabitat";
            lblHabitat.Size = new Size(46, 15);
            lblHabitat.TabIndex = 5;
            lblHabitat.Text = "Habitat";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(20, 187);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 25);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(126, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 83);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 12;
            label1.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(88, 80);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(113, 23);
            txtEdad.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 112);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 14;
            label2.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 15;
            label3.Text = "Especie";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(88, 109);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(113, 23);
            txtPeso.TabIndex = 16;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(88, 138);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(113, 23);
            txtEspecie.TabIndex = 17;
            // 
            // cbHabitat
            // 
            cbHabitat.FormattingEnabled = true;
            cbHabitat.Location = new Point(88, 51);
            cbHabitat.Name = "cbHabitat";
            cbHabitat.Size = new Size(113, 23);
            cbHabitat.TabIndex = 18;
            // 
            // FormPinguino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 226);
            Controls.Add(cbHabitat);
            Controls.Add(txtEspecie);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblHabitat);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "FormPinguino";
            Text = "FormPinguino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblHabitat;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtEdad;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtEspecie;
        private ComboBox cbHabitat;
    }
}