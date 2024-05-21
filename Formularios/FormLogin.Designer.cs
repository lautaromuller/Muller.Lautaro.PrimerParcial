namespace Formularios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            txtContrasena = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblContrasena = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(134, 168);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(226, 28);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(133, 121);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(213, 23);
            txtContrasena.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(137, 72);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(205, 23);
            txtCorreo.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(87, 28);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(76, 103);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 246);
            Controls.Add(lblContrasena);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasena);
            Controls.Add(btnIngresar);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtContrasena;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label lblContrasena;
    }
}
