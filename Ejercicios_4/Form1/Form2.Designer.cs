namespace Form1
{
    partial class Form2
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
            this.saludo_form = new System.Windows.Forms.Label();
            this.saludo_nya = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saludo_form
            // 
            this.saludo_form.AutoSize = true;
            this.saludo_form.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.saludo_form.Location = new System.Drawing.Point(64, 42);
            this.saludo_form.Name = "saludo_form";
            this.saludo_form.Size = new System.Drawing.Size(219, 25);
            this.saludo_form.TabIndex = 1;
            this.saludo_form.Text = "¡Hola, Windows Forms!";
            // 
            // saludo_nya
            // 
            this.saludo_nya.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saludo_nya.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.saludo_nya.Location = new System.Drawing.Point(64, 95);
            this.saludo_nya.Name = "saludo_nya";
            this.saludo_nya.Size = new System.Drawing.Size(247, 23);
            this.saludo_nya.TabIndex = 0;
            this.saludo_nya.Text = "Soy ";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(649, 218);
            this.Controls.Add(this.saludo_form);
            this.Controls.Add(this.saludo_nya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo_form;
        public System.Windows.Forms.Label saludo_nya;
    }
}