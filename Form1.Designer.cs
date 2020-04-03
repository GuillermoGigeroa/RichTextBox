namespace RichTextBox
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
            this.BotonNegrita = new System.Windows.Forms.Button();
            this.BotonSubrayado = new System.Windows.Forms.Button();
            this.BotonCursiva = new System.Windows.Forms.Button();
            this.BotonCentrado = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonNegrita
            // 
            this.BotonNegrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonNegrita.Location = new System.Drawing.Point(37, 12);
            this.BotonNegrita.Name = "BotonNegrita";
            this.BotonNegrita.Size = new System.Drawing.Size(135, 29);
            this.BotonNegrita.TabIndex = 0;
            this.BotonNegrita.Text = "Negrita";
            this.BotonNegrita.UseVisualStyleBackColor = true;
            this.BotonNegrita.Click += new System.EventHandler(this.BotonNegrita_Click);
            // 
            // BotonSubrayado
            // 
            this.BotonSubrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonSubrayado.Location = new System.Drawing.Point(231, 12);
            this.BotonSubrayado.Name = "BotonSubrayado";
            this.BotonSubrayado.Size = new System.Drawing.Size(135, 29);
            this.BotonSubrayado.TabIndex = 0;
            this.BotonSubrayado.Text = "Subrayado";
            this.BotonSubrayado.UseVisualStyleBackColor = true;
            this.BotonSubrayado.Click += new System.EventHandler(this.BotonSubrayado_Click);
            // 
            // BotonCursiva
            // 
            this.BotonCursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonCursiva.Location = new System.Drawing.Point(429, 12);
            this.BotonCursiva.Name = "BotonCursiva";
            this.BotonCursiva.Size = new System.Drawing.Size(135, 29);
            this.BotonCursiva.TabIndex = 0;
            this.BotonCursiva.Text = "Cursiva";
            this.BotonCursiva.UseVisualStyleBackColor = true;
            this.BotonCursiva.Click += new System.EventHandler(this.BotonCursiva_Click);
            // 
            // BotonCentrado
            // 
            this.BotonCentrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonCentrado.Location = new System.Drawing.Point(626, 12);
            this.BotonCentrado.Name = "BotonCentrado";
            this.BotonCentrado.Size = new System.Drawing.Size(135, 29);
            this.BotonCentrado.TabIndex = 0;
            this.BotonCentrado.Text = "Centrado";
            this.BotonCentrado.UseVisualStyleBackColor = true;
            this.BotonCentrado.Click += new System.EventHandler(this.BotonCentrado_Click);
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Location = new System.Drawing.Point(301, 63);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(79, 13);
            this.Etiqueta1.TabIndex = 1;
            this.Etiqueta1.Text = "Tamaño fuente";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(382, 60);
            this.txtTamanio.MaxLength = 3;
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(86, 20);
            this.txtTamanio.TabIndex = 2;
            this.txtTamanio.Text = "15";
            this.txtTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanio_KeyPress);
            this.txtTamanio.Validated += new System.EventHandler(this.txtTamanio_Validated);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(772, 410);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BotonGuardar.Location = new System.Drawing.Point(231, 520);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(135, 29);
            this.BotonGuardar.TabIndex = 0;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonAbrir
            // 
            this.BotonAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BotonAbrir.Location = new System.Drawing.Point(429, 520);
            this.BotonAbrir.Name = "BotonAbrir";
            this.BotonAbrir.Size = new System.Drawing.Size(135, 29);
            this.BotonAbrir.TabIndex = 0;
            this.BotonAbrir.Text = "Abrir";
            this.BotonAbrir.UseVisualStyleBackColor = true;
            this.BotonAbrir.Click += new System.EventHandler(this.BotonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.BotonCentrado);
            this.Controls.Add(this.BotonCursiva);
            this.Controls.Add(this.BotonAbrir);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BotonSubrayado);
            this.Controls.Add(this.BotonNegrita);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RichTextBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonNegrita;
        private System.Windows.Forms.Button BotonSubrayado;
        private System.Windows.Forms.Button BotonCursiva;
        private System.Windows.Forms.Button BotonCentrado;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonAbrir;
    }
}

