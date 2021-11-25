
namespace softwareFactory.Front
{
    partial class frmClienteMenu
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
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labeL2 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerClientes.Location = new System.Drawing.Point(208, 25);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(62, 30);
            this.btnVerClientes.TabIndex = 0;
            this.btnVerClientes.Text = "Ver";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver Clientes";
            // 
            // labeL2
            // 
            this.labeL2.AutoSize = true;
            this.labeL2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeL2.Location = new System.Drawing.Point(28, 100);
            this.labeL2.Name = "labeL2";
            this.labeL2.Size = new System.Drawing.Size(144, 19);
            this.labeL2.TabIndex = 3;
            this.labeL2.Text = "Agregar Cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCliente.Location = new System.Drawing.Point(189, 100);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(81, 30);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(110, 153);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmClienteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 195);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.labeL2);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerClientes);
            this.Name = "frmClienteMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeL2;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCerrar;
    }
}