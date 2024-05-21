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
            btnAgregarPinguino = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 154);
            listBox1.TabIndex = 0;
            // 
            // btnAgregarPinguino
            // 
            btnAgregarPinguino.Location = new Point(308, 35);
            btnAgregarPinguino.Name = "btnAgregarPinguino";
            btnAgregarPinguino.Size = new Size(176, 34);
            btnAgregarPinguino.TabIndex = 1;
            btnAgregarPinguino.Text = "Agregar Pinguino";
            btnAgregarPinguino.UseVisualStyleBackColor = true;
            btnAgregarPinguino.Click += btnAgregarPinguino_Click;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 302);
            Controls.Add(btnAgregarPinguino);
            Controls.Add(listBox1);
            Name = "FormCRUD";
            Text = "FormCRUD";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAgregarPinguino;
    }
}