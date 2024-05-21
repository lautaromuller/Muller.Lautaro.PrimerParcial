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
            Raza = new GroupBox();
            rbRazaPinguino = new RadioButton();
            rbRazaHalcon = new RadioButton();
            rbRazaColibri = new RadioButton();
            txtNombre = new TextBox();
            txtHabitat = new TextBox();
            PuedeVolar = new GroupBox();
            lblNombre = new Label();
            lblHabitat = new Label();
            rbVuelaSi = new RadioButton();
            rbVuelaNo = new RadioButton();
            txtTipo = new TextBox();
            leGustaElFrio = new GroupBox();
            viveManada = new GroupBox();
            lblTipo = new Label();
            rbFrioSi = new RadioButton();
            rbFrioNo = new RadioButton();
            rbManadaSi = new RadioButton();
            rbManadaNo = new RadioButton();
            btnAceptar = new Button();
            btnCancelar = new Button();
            Raza.SuspendLayout();
            PuedeVolar.SuspendLayout();
            leGustaElFrio.SuspendLayout();
            viveManada.SuspendLayout();
            SuspendLayout();
            // 
            // Raza
            // 
            Raza.Controls.Add(rbRazaColibri);
            Raza.Controls.Add(rbRazaHalcon);
            Raza.Controls.Add(rbRazaPinguino);
            Raza.Location = new Point(9, 10);
            Raza.Name = "Raza";
            Raza.Size = new Size(274, 75);
            Raza.TabIndex = 0;
            Raza.TabStop = false;
            Raza.Text = "Raza";
            // 
            // rbRazaPinguino
            // 
            rbRazaPinguino.AutoSize = true;
            rbRazaPinguino.Location = new Point(19, 33);
            rbRazaPinguino.Name = "rbRazaPinguino";
            rbRazaPinguino.Size = new Size(73, 19);
            rbRazaPinguino.TabIndex = 0;
            rbRazaPinguino.TabStop = true;
            rbRazaPinguino.Text = "Pinguino";
            rbRazaPinguino.UseVisualStyleBackColor = true;
            // 
            // rbRazaHalcon
            // 
            rbRazaHalcon.AutoSize = true;
            rbRazaHalcon.Location = new Point(111, 31);
            rbRazaHalcon.Name = "rbRazaHalcon";
            rbRazaHalcon.Size = new Size(63, 19);
            rbRazaHalcon.TabIndex = 1;
            rbRazaHalcon.TabStop = true;
            rbRazaHalcon.Text = "Halcón";
            rbRazaHalcon.UseVisualStyleBackColor = true;
            // 
            // rbRazaColibri
            // 
            rbRazaColibri.AutoSize = true;
            rbRazaColibri.Location = new Point(189, 33);
            rbRazaColibri.Name = "rbRazaColibri";
            rbRazaColibri.Size = new Size(60, 19);
            rbRazaColibri.TabIndex = 2;
            rbRazaColibri.TabStop = true;
            rbRazaColibri.Text = "Colibrí";
            rbRazaColibri.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtHabitat
            // 
            txtHabitat.Location = new Point(96, 120);
            txtHabitat.Name = "txtHabitat";
            txtHabitat.Size = new Size(187, 23);
            txtHabitat.TabIndex = 2;
            // 
            // PuedeVolar
            // 
            PuedeVolar.Controls.Add(rbVuelaNo);
            PuedeVolar.Controls.Add(rbVuelaSi);
            PuedeVolar.Location = new Point(10, 160);
            PuedeVolar.Name = "PuedeVolar";
            PuedeVolar.Size = new Size(271, 48);
            PuedeVolar.TabIndex = 3;
            PuedeVolar.TabStop = false;
            PuedeVolar.Text = "Vuela";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblHabitat
            // 
            lblHabitat.AutoSize = true;
            lblHabitat.Location = new Point(20, 131);
            lblHabitat.Name = "lblHabitat";
            lblHabitat.Size = new Size(46, 15);
            lblHabitat.TabIndex = 5;
            lblHabitat.Text = "Habitat";
            // 
            // rbVuelaSi
            // 
            rbVuelaSi.AutoSize = true;
            rbVuelaSi.Location = new Point(72, 24);
            rbVuelaSi.Name = "rbVuelaSi";
            rbVuelaSi.Size = new Size(34, 19);
            rbVuelaSi.TabIndex = 0;
            rbVuelaSi.TabStop = true;
            rbVuelaSi.Text = "Si";
            rbVuelaSi.UseVisualStyleBackColor = true;
            // 
            // rbVuelaNo
            // 
            rbVuelaNo.AutoSize = true;
            rbVuelaNo.Location = new Point(112, 22);
            rbVuelaNo.Name = "rbVuelaNo";
            rbVuelaNo.Size = new Size(41, 19);
            rbVuelaNo.TabIndex = 1;
            rbVuelaNo.TabStop = true;
            rbVuelaNo.Text = "No";
            rbVuelaNo.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(107, 214);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(163, 23);
            txtTipo.TabIndex = 6;
            // 
            // leGustaElFrio
            // 
            leGustaElFrio.Controls.Add(rbFrioNo);
            leGustaElFrio.Controls.Add(rbFrioSi);
            leGustaElFrio.Location = new Point(20, 243);
            leGustaElFrio.Name = "leGustaElFrio";
            leGustaElFrio.Size = new Size(257, 43);
            leGustaElFrio.TabIndex = 7;
            leGustaElFrio.TabStop = false;
            leGustaElFrio.Text = "Le gusta el frio";
            // 
            // viveManada
            // 
            viveManada.Controls.Add(rbManadaNo);
            viveManada.Controls.Add(rbManadaSi);
            viveManada.Location = new Point(20, 292);
            viveManada.Name = "viveManada";
            viveManada.Size = new Size(261, 49);
            viveManada.TabIndex = 8;
            viveManada.TabStop = false;
            viveManada.Text = "Vive en manada";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 225);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo";
            // 
            // rbFrioSi
            // 
            rbFrioSi.AutoSize = true;
            rbFrioSi.Location = new Point(65, 18);
            rbFrioSi.Name = "rbFrioSi";
            rbFrioSi.Size = new Size(34, 19);
            rbFrioSi.TabIndex = 0;
            rbFrioSi.TabStop = true;
            rbFrioSi.Text = "Si";
            rbFrioSi.UseVisualStyleBackColor = true;
            // 
            // rbFrioNo
            // 
            rbFrioNo.AutoSize = true;
            rbFrioNo.Location = new Point(122, 18);
            rbFrioNo.Name = "rbFrioNo";
            rbFrioNo.Size = new Size(41, 19);
            rbFrioNo.TabIndex = 1;
            rbFrioNo.TabStop = true;
            rbFrioNo.Text = "No";
            rbFrioNo.UseVisualStyleBackColor = true;
            // 
            // rbManadaSi
            // 
            rbManadaSi.AutoSize = true;
            rbManadaSi.Location = new Point(52, 25);
            rbManadaSi.Name = "rbManadaSi";
            rbManadaSi.Size = new Size(34, 19);
            rbManadaSi.TabIndex = 0;
            rbManadaSi.TabStop = true;
            rbManadaSi.Text = "Si";
            rbManadaSi.UseVisualStyleBackColor = true;
            // 
            // rbManadaNo
            // 
            rbManadaNo.AutoSize = true;
            rbManadaNo.Location = new Point(160, 22);
            rbManadaNo.Name = "rbManadaNo";
            rbManadaNo.Size = new Size(41, 19);
            rbManadaNo.TabIndex = 1;
            rbManadaNo.TabStop = true;
            rbManadaNo.Text = "No";
            rbManadaNo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(26, 350);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(134, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPinguino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 382);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTipo);
            Controls.Add(viveManada);
            Controls.Add(leGustaElFrio);
            Controls.Add(txtTipo);
            Controls.Add(lblHabitat);
            Controls.Add(lblNombre);
            Controls.Add(PuedeVolar);
            Controls.Add(txtHabitat);
            Controls.Add(txtNombre);
            Controls.Add(Raza);
            Name = "FormPinguino";
            Text = "FormPinguino";
            Raza.ResumeLayout(false);
            Raza.PerformLayout();
            PuedeVolar.ResumeLayout(false);
            PuedeVolar.PerformLayout();
            leGustaElFrio.ResumeLayout(false);
            leGustaElFrio.PerformLayout();
            viveManada.ResumeLayout(false);
            viveManada.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Raza;
        private RadioButton rbRazaColibri;
        private RadioButton rbRazaHalcon;
        private RadioButton rbRazaPinguino;
        private TextBox txtNombre;
        private TextBox txtHabitat;
        private GroupBox PuedeVolar;
        private RadioButton rbVuelaNo;
        private RadioButton rbVuelaSi;
        private Label lblNombre;
        private Label lblHabitat;
        private TextBox txtTipo;
        private GroupBox leGustaElFrio;
        private GroupBox viveManada;
        private Label lblTipo;
        private RadioButton rbFrioNo;
        private RadioButton rbFrioSi;
        private RadioButton rbManadaNo;
        private RadioButton rbManadaSi;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}