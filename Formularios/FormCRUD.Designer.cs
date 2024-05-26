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
            menuStrip1 = new MenuStrip();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem1 = new ToolStripMenuItem();
            ordNombreAscendente = new ToolStripMenuItem();
            ordNombreDescendente = new ToolStripMenuItem();
            edadToolStripMenuItem = new ToolStripMenuItem();
            ordEdadAscendente = new ToolStripMenuItem();
            ordEdadDescendente = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(403, 259);
            listBox1.TabIndex = 0;
            // 
            // btnPinguino
            // 
            btnPinguino.Location = new Point(421, 27);
            btnPinguino.Name = "btnPinguino";
            btnPinguino.Size = new Size(170, 47);
            btnPinguino.TabIndex = 1;
            btnPinguino.Text = "Agregar Pinguino";
            btnPinguino.UseVisualStyleBackColor = true;
            btnPinguino.Click += btnPinguino_Click;
            // 
            // btnColibri
            // 
            btnColibri.Location = new Point(421, 80);
            btnColibri.Name = "btnColibri";
            btnColibri.Size = new Size(170, 47);
            btnColibri.TabIndex = 2;
            btnColibri.Text = "Agregar Colibrí";
            btnColibri.UseVisualStyleBackColor = true;
            btnColibri.Click += btnColibri_Click;
            // 
            // btnHalcon
            // 
            btnHalcon.Location = new Point(421, 133);
            btnHalcon.Name = "btnHalcon";
            btnHalcon.Size = new Size(170, 47);
            btnHalcon.TabIndex = 3;
            btnHalcon.Text = "Agregar Halcón";
            btnHalcon.UseVisualStyleBackColor = true;
            btnHalcon.Click += btnHalcon_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(421, 186);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 47);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(421, 239);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 47);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ordenarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(602, 24);
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
            nombreToolStripMenuItem1.Size = new Size(180, 22);
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
            edadToolStripMenuItem.Size = new Size(180, 22);
            edadToolStripMenuItem.Text = "Edad";
            // 
            // ordEdadAscendente
            // 
            ordEdadAscendente.Name = "ordEdadAscendente";
            ordEdadAscendente.Size = new Size(180, 22);
            ordEdadAscendente.Text = "Ascendente";
            ordEdadAscendente.Click += ordEdadAscendente_Click;
            // 
            // ordEdadDescendente
            // 
            ordEdadDescendente.Name = "ordEdadDescendente";
            ordEdadDescendente.Size = new Size(180, 22);
            ordEdadDescendente.Text = "Descendente";
            ordEdadDescendente.Click += ordEdadDescendente_Click;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 297);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnHalcon);
            Controls.Add(btnColibri);
            Controls.Add(btnPinguino);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormCRUD";
            Text = "FormCRUD";
            Load += FormCRUD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
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
    }
}