namespace Pacientes_EstrucDeDatos
{
    partial class frmPaciente
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
            this.lblPaci = new System.Windows.Forms.Label();
            this.lblNombreApell = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaci
            // 
            this.lblPaci.AutoSize = true;
            this.lblPaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaci.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPaci.Location = new System.Drawing.Point(91, 61);
            this.lblPaci.Name = "lblPaci";
            this.lblPaci.Size = new System.Drawing.Size(150, 39);
            this.lblPaci.TabIndex = 0;
            this.lblPaci.Text = "Paciente";
            // 
            // lblNombreApell
            // 
            this.lblNombreApell.AutoSize = true;
            this.lblNombreApell.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApell.Location = new System.Drawing.Point(23, 133);
            this.lblNombreApell.Name = "lblNombreApell";
            this.lblNombreApell.Size = new System.Drawing.Size(297, 32);
            this.lblNombreApell.TabIndex = 1;
            this.lblNombreApell.Text = "Apellido, Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consultorio 1";
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(342, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreApell);
            this.Controls.Add(this.lblPaci);
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPaciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaci;
        private System.Windows.Forms.Label lblNombreApell;
        private System.Windows.Forms.Label label3;
    }
}