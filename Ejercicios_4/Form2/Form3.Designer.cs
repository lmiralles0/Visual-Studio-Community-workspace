namespace Form2
{
    partial class Form3
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
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.boton_Saludo = new System.Windows.Forms.Button();
            this.letra_Apellido = new System.Windows.Forms.Label();
            this.letra_Nombre = new System.Windows.Forms.Label();
            this.box_Apellido = new System.Windows.Forms.TextBox();
            this.box_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMateria.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxMateria.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxMateria.Items.AddRange(new object[] {
            "Programacion II",
            "Estadistica ",
            "Metodologia",
            "Arquitectura y Sistemas Operativos"});
            this.comboBoxMateria.Location = new System.Drawing.Point(81, 130);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMateria.Size = new System.Drawing.Size(442, 23);
            this.comboBoxMateria.TabIndex = 16;
            this.comboBoxMateria.Text = "Seleccione una materia...";
            this.comboBoxMateria.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateria_SelectedIndexChanged);
            // 
            // boton_Saludo
            // 
            this.boton_Saludo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Saludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_Saludo.Location = new System.Drawing.Point(387, 173);
            this.boton_Saludo.Name = "boton_Saludo";
            this.boton_Saludo.Size = new System.Drawing.Size(136, 23);
            this.boton_Saludo.TabIndex = 14;
            this.boton_Saludo.Text = "Saludar";
            this.boton_Saludo.UseVisualStyleBackColor = false;
            this.boton_Saludo.Click += new System.EventHandler(this.boton_Saludo_Click);
            // 
            // letra_Apellido
            // 
            this.letra_Apellido.AutoSize = true;
            this.letra_Apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letra_Apellido.Location = new System.Drawing.Point(345, 43);
            this.letra_Apellido.Name = "letra_Apellido";
            this.letra_Apellido.Size = new System.Drawing.Size(52, 15);
            this.letra_Apellido.TabIndex = 13;
            this.letra_Apellido.Text = "Apellido";
            // 
            // letra_Nombre
            // 
            this.letra_Nombre.AutoSize = true;
            this.letra_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letra_Nombre.Location = new System.Drawing.Point(81, 43);
            this.letra_Nombre.Name = "letra_Nombre";
            this.letra_Nombre.Size = new System.Drawing.Size(53, 15);
            this.letra_Nombre.TabIndex = 12;
            this.letra_Nombre.Text = "Nombre";
            // 
            // box_Apellido
            // 
            this.box_Apellido.Location = new System.Drawing.Point(345, 61);
            this.box_Apellido.Name = "box_Apellido";
            this.box_Apellido.Size = new System.Drawing.Size(178, 23);
            this.box_Apellido.TabIndex = 11;
            // 
            // box_Nombre
            // 
            this.box_Nombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Nombre.Location = new System.Drawing.Point(81, 61);
            this.box_Nombre.Name = "box_Nombre";
            this.box_Nombre.Size = new System.Drawing.Size(154, 21);
            this.box_Nombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Materia favorita";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(649, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_Saludo);
            this.Controls.Add(this.letra_Apellido);
            this.Controls.Add(this.letra_Nombre);
            this.Controls.Add(this.box_Apellido);
            this.Controls.Add(this.box_Nombre);
            this.Controls.Add(this.comboBoxMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label letra_Apellido;
        private System.Windows.Forms.Label letra_Nombre;
        private System.Windows.Forms.TextBox box_Apellido;
        private System.Windows.Forms.TextBox box_Nombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxMateria;
        public System.Windows.Forms.Button boton_Saludo;
    }
}
