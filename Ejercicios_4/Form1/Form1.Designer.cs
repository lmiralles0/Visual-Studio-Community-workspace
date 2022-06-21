namespace Form1
{
    partial class Form1
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
            this.box_Nombre = new System.Windows.Forms.TextBox();
            this.box_Apellido = new System.Windows.Forms.TextBox();
            this.letra_Nombre = new System.Windows.Forms.Label();
            this.letra_Apellido = new System.Windows.Forms.Label();
            this.boton_Saludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_Nombre
            // 
            this.box_Nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Nombre.Location = new System.Drawing.Point(65, 53);
            this.box_Nombre.Name = "box_Nombre";
            this.box_Nombre.Size = new System.Drawing.Size(154, 21);
            this.box_Nombre.TabIndex = 1;
            
            // 
            // box_Apellido
            // 
            this.box_Apellido.Location = new System.Drawing.Point(324, 53);
            this.box_Apellido.Name = "box_Apellido";
            this.box_Apellido.Size = new System.Drawing.Size(178, 23);
            this.box_Apellido.TabIndex = 3;
            // 
            // letra_Nombre
            // 
            this.letra_Nombre.AutoSize = true;
            this.letra_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letra_Nombre.Location = new System.Drawing.Point(65, 35);
            this.letra_Nombre.Name = "letra_Nombre";
            this.letra_Nombre.Size = new System.Drawing.Size(53, 15);
            this.letra_Nombre.TabIndex = 5;
            this.letra_Nombre.Text = "Nombre";
            // 
            // letra_Apellido
            // 
            this.letra_Apellido.AutoSize = true;
            this.letra_Apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letra_Apellido.Location = new System.Drawing.Point(324, 35);
            this.letra_Apellido.Name = "letra_Apellido";
            this.letra_Apellido.Size = new System.Drawing.Size(52, 15);
            this.letra_Apellido.TabIndex = 7;
            this.letra_Apellido.Text = "Apellido";
            // 
            // boton_Saludo
            // 
            this.boton_Saludo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Saludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_Saludo.Location = new System.Drawing.Point(366, 148);
            this.boton_Saludo.Name = "boton_Saludo";
            this.boton_Saludo.Size = new System.Drawing.Size(136, 23);
            this.boton_Saludo.TabIndex = 9;
            this.boton_Saludo.Text = "Saludar";
            this.boton_Saludo.UseVisualStyleBackColor = false;
            this.boton_Saludo.Click += new System.EventHandler(this.boton_Saludo_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(649, 218);
            this.Controls.Add(this.boton_Saludo);
            this.Controls.Add(this.letra_Apellido);
            this.Controls.Add(this.letra_Nombre);
            this.Controls.Add(this.box_Apellido);
            this.Controls.Add(this.box_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_Nombre;
        private System.Windows.Forms.TextBox box_Apellido;
        private System.Windows.Forms.Label letra_Nombre;
        private System.Windows.Forms.Label letra_Apellido;
        private System.Windows.Forms.Button boton_Saludo;
    }
}
