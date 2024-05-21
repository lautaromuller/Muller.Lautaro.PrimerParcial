namespace Formularios
{
    partial class FormHalcon
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
            txtEnvergadura = new TextBox();
            txtRangoCaza = new TextBox();
            cbHabitat = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Habitat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Envergadura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Rango de caza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(69, 64);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(136, 23);
            txtEdad.TabIndex = 6;
            // 
            // txtEnvergadura
            // 
            txtEnvergadura.Location = new Point(105, 93);
            txtEnvergadura.Name = "txtEnvergadura";
            txtEnvergadura.Size = new Size(100, 23);
            txtEnvergadura.TabIndex = 7;
            // 
            // txtRangoCaza
            // 
            txtRangoCaza.Location = new Point(105, 122);
            txtRangoCaza.Name = "txtRangoCaza";
            txtRangoCaza.Size = new Size(100, 23);
            txtRangoCaza.TabIndex = 8;
            // 
            // cbHabitat
            // 
            cbHabitat.FormattingEnabled = true;
            cbHabitat.Location = new Point(69, 35);
            cbHabitat.Name = "cbHabitat";
            cbHabitat.Size = new Size(136, 23);
            cbHabitat.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(15, 166);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(80, 25);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 166);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 25);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormHalcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 203);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbHabitat);
            Controls.Add(txtRangoCaza);
            Controls.Add(txtEnvergadura);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHalcon";
            Text = "FormHalcon";
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
        private TextBox txtEnvergadura;
        private TextBox txtRangoCaza;
        private ComboBox cbHabitat;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}