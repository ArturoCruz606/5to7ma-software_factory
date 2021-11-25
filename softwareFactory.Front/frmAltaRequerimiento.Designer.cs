
namespace softwareFactory.Front
{
    partial class frmAltaRequerimiento
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblComplejidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtComplejidad = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(115, 188);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 42);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(22, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 22);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblComplejidad
            // 
            this.lblComplejidad.AutoSize = true;
            this.lblComplejidad.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplejidad.Location = new System.Drawing.Point(22, 146);
            this.lblComplejidad.Name = "lblComplejidad";
            this.lblComplejidad.Size = new System.Drawing.Size(120, 22);
            this.lblComplejidad.TabIndex = 2;
            this.lblComplejidad.Text = "Complejidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(148, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(162, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtComplejidad
            // 
            this.txtComplejidad.Location = new System.Drawing.Point(148, 145);
            this.txtComplejidad.Name = "txtComplejidad";
            this.txtComplejidad.Size = new System.Drawing.Size(162, 23);
            this.txtComplejidad.TabIndex = 4;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProyecto.Location = new System.Drawing.Point(22, 30);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(90, 22);
            this.lblProyecto.TabIndex = 5;
            this.lblProyecto.Text = "Proyecto";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(148, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 23);
            this.textBox1.TabIndex = 6;
            // 
            // frmAltaRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 242);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtComplejidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblComplejidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frmAltaRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requerimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblComplejidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtComplejidad;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox textBox1;
    }
}