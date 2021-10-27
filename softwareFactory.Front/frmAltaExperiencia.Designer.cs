
namespace softwareFactory.Front
{
    partial class frmAltaExperiencia
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
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtTecnologia = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuil.Location = new System.Drawing.Point(22, 20);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(50, 22);
            this.lblCuil.TabIndex = 0;
            this.lblCuil.Text = "Cuil";
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTecnologia.Location = new System.Drawing.Point(22, 62);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(110, 22);
            this.lblTecnologia.TabIndex = 1;
            this.lblTecnologia.Text = "Tecnologia";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalificacion.Location = new System.Drawing.Point(22, 115);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(130, 22);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(165, 20);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(141, 23);
            this.txtCuil.TabIndex = 3;
            // 
            // txtTecnologia
            // 
            this.txtTecnologia.Location = new System.Drawing.Point(165, 64);
            this.txtTecnologia.Name = "txtTecnologia";
            this.txtTecnologia.Size = new System.Drawing.Size(141, 23);
            this.txtTecnologia.TabIndex = 4;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(165, 117);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(141, 23);
            this.txtCalificacion.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(118, 168);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(110, 38);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // frmAltaExperiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 227);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtTecnologia);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblTecnologia);
            this.Controls.Add(this.lblCuil);
            this.Name = "frmAltaExperiencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaExperiencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtTecnologia;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnIngresar;
    }
}