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
            label4 = new Label();
            label5 = new Label();
            txtEnvergadura = new TextBox();
            txtRangoCaza = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 113);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Envergadura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 142);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Rango de caza";
            // 
            // txtEnvergadura
            // 
            txtEnvergadura.Location = new Point(121, 110);
            txtEnvergadura.Name = "txtEnvergadura";
            txtEnvergadura.Size = new Size(162, 23);
            txtEnvergadura.TabIndex = 3;
            // 
            // txtRangoCaza
            // 
            txtRangoCaza.Location = new Point(121, 139);
            txtRangoCaza.Name = "txtRangoCaza";
            txtRangoCaza.Size = new Size(162, 23);
            txtRangoCaza.TabIndex = 4;
            // 
            // FormHalcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 376);
            Controls.Add(txtRangoCaza);
            Controls.Add(txtEnvergadura);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "FormHalcon";
            Text = "FormHalcon";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(cbHabitat, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtEnvergadura, 0);
            Controls.SetChildIndex(txtRangoCaza, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox txtEnvergadura;
        private TextBox txtRangoCaza;
    }
}