namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bMensaje = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bMensaje
            // 
            this.bMensaje.Location = new System.Drawing.Point(32, 28);
            this.bMensaje.Name = "bMensaje";
            this.bMensaje.Size = new System.Drawing.Size(141, 63);
            this.bMensaje.TabIndex = 0;
            this.bMensaje.Text = "MENSAJE";
            this.bMensaje.UseVisualStyleBackColor = true;
            this.bMensaje.Click += new System.EventHandler(this.bMensaje_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "PRIMERA",
            "SEGUNDA",
            "TERCERA",
            "CUARTA",
            "QUINTA"});
            this.listBox1.Location = new System.Drawing.Point(221, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMensaje;
        private System.Windows.Forms.ListBox listBox1;
    }
}

