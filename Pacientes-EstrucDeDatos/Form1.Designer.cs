namespace Pacientes_EstrucDeDatos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApell = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(43, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(55, 104);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(55, 138);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApell
            // 
            this.txtApell.Location = new System.Drawing.Point(93, 68);
            this.txtApell.Name = "txtApell";
            this.txtApell.Size = new System.Drawing.Size(100, 20);
            this.txtApell.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(93, 101);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(93, 135);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(100, 227);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(0, 13);
            this.lblNro.TabIndex = 9;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(46, 267);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(181, 25);
            this.btnAtender.TabIndex = 10;
            this.btnAtender.Text = "&Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "pacientes en espera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApell);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sacar turno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApell;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

