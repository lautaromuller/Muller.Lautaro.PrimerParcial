namespace Formularios
{
    partial class FormCRUD
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
            listBox1 = new ListBox();
            btnPinguino = new Button();
            btnColibri = new Button();
            btnHalcon = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 199);
            listBox1.TabIndex = 0;
            // 
            // btnPinguino
            // 
            btnPinguino.Location = new Point(275, 12);
            btnPinguino.Name = "btnPinguino";
            btnPinguino.Size = new Size(176, 34);
            btnPinguino.TabIndex = 1;
            btnPinguino.Text = "Agregar Pinguino";
            btnPinguino.UseVisualStyleBackColor = true;
            btnPinguino.Click += btnPinguino_Click;
            // 
            // btnColibri
            // 
            btnColibri.Location = new Point(275, 52);
            btnColibri.Name = "btnColibri";
            btnColibri.Size = new Size(176, 34);
            btnColibri.TabIndex = 2;
            btnColibri.Text = "Agregar Colibrí";
            btnColibri.UseVisualStyleBackColor = true;
            btnColibri.Click += btnColibri_Click;
            // 
            // btnHalcon
            // 
            btnHalcon.Location = new Point(275, 92);
            btnHalcon.Name = "btnHalcon";
            btnHalcon.Size = new Size(176, 34);
            btnHalcon.TabIndex = 3;
            btnHalcon.Text = "Agregar Halcón";
            btnHalcon.UseVisualStyleBackColor = true;
            btnHalcon.Click += btnHalcon_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(275, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(176, 34);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(275, 172);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 228);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnHalcon);
            Controls.Add(btnColibri);
            Controls.Add(btnPinguino);
            Controls.Add(listBox1);
            Name = "FormCRUD";
            Text = "FormCRUD";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnPinguino;
        private Button btnColibri;
        private Button btnHalcon;
        private Button btnModificar;
        private Button btnEliminar;
    }
}