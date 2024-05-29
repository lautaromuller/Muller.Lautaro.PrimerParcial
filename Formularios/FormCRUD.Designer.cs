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
            btnPinguino = new Button();
            btnColibri = new Button();
            btnHalcon = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            menuStrip1 = new MenuStrip();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem1 = new ToolStripMenuItem();
            ordNombreAscendente = new ToolStripMenuItem();
            ordNombreDescendente = new ToolStripMenuItem();
            edadToolStripMenuItem = new ToolStripMenuItem();
            ordEdadAscendente = new ToolStripMenuItem();
            ordEdadDescendente = new ToolStripMenuItem();
            guardar = new ToolStripMenuItem();
            cargar = new ToolStripMenuItem();
            logins = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusStrip = new ToolStripStatusLabel();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPinguino
            // 
            btnPinguino.BackColor = Color.FromArgb(13, 110, 90);
            btnPinguino.FlatAppearance.BorderSize = 0;
            btnPinguino.FlatStyle = FlatStyle.Flat;
            btnPinguino.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPinguino.ForeColor = Color.White;
            btnPinguino.Location = new Point(452, 50);
            btnPinguino.Name = "btnPinguino";
            btnPinguino.Size = new Size(170, 47);
            btnPinguino.TabIndex = 0;
            btnPinguino.Text = "Agregar Pinguino";
            btnPinguino.UseVisualStyleBackColor = false;
            btnPinguino.Click += btnPinguino_Click;
            // 
            // btnColibri
            // 
            btnColibri.BackColor = Color.FromArgb(13, 110, 90);
            btnColibri.FlatAppearance.BorderSize = 0;
            btnColibri.FlatStyle = FlatStyle.Flat;
            btnColibri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnColibri.ForeColor = Color.White;
            btnColibri.Location = new Point(452, 103);
            btnColibri.Name = "btnColibri";
            btnColibri.Size = new Size(170, 47);
            btnColibri.TabIndex = 1;
            btnColibri.Text = "Agregar Colibrí";
            btnColibri.UseVisualStyleBackColor = false;
            btnColibri.Click += btnColibri_Click;
            // 
            // btnHalcon
            // 
            btnHalcon.BackColor = Color.FromArgb(13, 110, 90);
            btnHalcon.FlatAppearance.BorderSize = 0;
            btnHalcon.FlatStyle = FlatStyle.Flat;
            btnHalcon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHalcon.ForeColor = Color.White;
            btnHalcon.Location = new Point(452, 156);
            btnHalcon.Name = "btnHalcon";
            btnHalcon.Size = new Size(170, 47);
            btnHalcon.TabIndex = 2;
            btnHalcon.Text = "Agregar Halcón";
            btnHalcon.UseVisualStyleBackColor = false;
            btnHalcon.Click += btnHalcon_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(95, 150, 180);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(452, 209);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 47);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(235, 90, 90);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(452, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 47);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ordenarToolStripMenuItem, guardar, cargar, logins });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ordenarToolStripMenuItem
            // 
            ordenarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem1, edadToolStripMenuItem });
            ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            ordenarToolStripMenuItem.Size = new Size(62, 20);
            ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // nombreToolStripMenuItem1
            // 
            nombreToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ordNombreAscendente, ordNombreDescendente });
            nombreToolStripMenuItem1.Name = "nombreToolStripMenuItem1";
            nombreToolStripMenuItem1.Size = new Size(118, 22);
            nombreToolStripMenuItem1.Text = "Nombre";
            // 
            // ordNombreAscendente
            // 
            ordNombreAscendente.Name = "ordNombreAscendente";
            ordNombreAscendente.Size = new Size(142, 22);
            ordNombreAscendente.Text = "Ascendente";
            ordNombreAscendente.Click += ordNombreAscendente_Click;
            // 
            // ordNombreDescendente
            // 
            ordNombreDescendente.Name = "ordNombreDescendente";
            ordNombreDescendente.Size = new Size(142, 22);
            ordNombreDescendente.Text = "Descendente";
            ordNombreDescendente.Click += ordNombreDescendente_Click;
            // 
            // edadToolStripMenuItem
            // 
            edadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordEdadAscendente, ordEdadDescendente });
            edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            edadToolStripMenuItem.Size = new Size(118, 22);
            edadToolStripMenuItem.Text = "Edad";
            // 
            // ordEdadAscendente
            // 
            ordEdadAscendente.Name = "ordEdadAscendente";
            ordEdadAscendente.Size = new Size(142, 22);
            ordEdadAscendente.Text = "Ascendente";
            ordEdadAscendente.Click += ordEdadAscendente_Click;
            // 
            // ordEdadDescendente
            // 
            ordEdadDescendente.Name = "ordEdadDescendente";
            ordEdadDescendente.Size = new Size(142, 22);
            ordEdadDescendente.Text = "Descendente";
            ordEdadDescendente.Click += ordEdadDescendente_Click;
            // 
            // guardar
            // 
            guardar.Name = "guardar";
            guardar.Size = new Size(61, 20);
            guardar.Text = "Guardar";
            guardar.Click += guardar_Click;
            // 
            // cargar
            // 
            cargar.Name = "cargar";
            cargar.Size = new Size(54, 20);
            cargar.Text = "Cargar";
            cargar.Click += cargar_Click;
            // 
            // logins
            // 
            logins.Name = "logins";
            logins.Size = new Size(114, 20);
            logins.Text = "Historial de logins";
            logins.Click += logins_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(64, 64, 64);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusStrip });
            statusStrip1.Location = new Point(0, 331);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(651, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusStrip
            // 
            lblStatusStrip.BackColor = Color.FromArgb(64, 64, 64);
            lblStatusStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusStrip.ForeColor = Color.White;
            lblStatusStrip.Margin = new Padding(5, 1, 0, 2);
            lblStatusStrip.Name = "lblStatusStrip";
            lblStatusStrip.Size = new Size(88, 19);
            lblStatusStrip.Text = "usuario | fecha";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 259);
            listBox1.TabIndex = 8;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(651, 353);
            Controls.Add(listBox1);
            Controls.Add(statusStrip1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnHalcon);
            Controls.Add(btnColibri);
            Controls.Add(btnPinguino);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormCRUD";
            Text = "FormCRUD";
            FormClosing += FormCRUD_FormClosing;
            Load += FormCRUD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPinguino;
        private Button btnColibri;
        private Button btnHalcon;
        private Button btnModificar;
        private Button btnEliminar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem1;
        private ToolStripMenuItem edadToolStripMenuItem;
        private ToolStripMenuItem ordEdadAscendente;
        private ToolStripMenuItem ordEdadDescendente;
        private ToolStripMenuItem ordNombreAscendente;
        private ToolStripMenuItem ordNombreDescendente;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusStrip;
        private ToolStripMenuItem guardar;
        private ToolStripMenuItem cargar;
        private ToolStripMenuItem logins;
        private ListBox listBox1;
    }
}