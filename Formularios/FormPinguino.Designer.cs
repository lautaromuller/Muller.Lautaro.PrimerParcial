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
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtEspecie = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 176);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 14;
            label2.Text = "Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 205);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 15;
            label3.Text = "Especie";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(89, 173);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(113, 23);
            txtPeso.TabIndex = 16;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(89, 202);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(113, 23);
            txtEspecie.TabIndex = 17;
            // 
            // FormPinguino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 406);
            Controls.Add(txtEspecie);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormPinguino";
            Text = "FormPinguino";
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPeso, 0);
            Controls.SetChildIndex(txtEspecie, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtEspecie;
    }
}