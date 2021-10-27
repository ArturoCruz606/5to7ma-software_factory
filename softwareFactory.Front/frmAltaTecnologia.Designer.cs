
namespace softwareFactory.Front
{
    partial class frmAltaTecnologia
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
            this.txtTecnologia = new System.Windows.Forms.TextBox();
            this.lblTecnologia = new System.Windows.Forms.Label();
            this.lblCostoBase = new System.Windows.Forms.Label();
            this.txtCostoBase = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTecnologia
            // 
            this.txtTecnologia.Location = new System.Drawing.Point(146, 25);
            this.txtTecnologia.Name = "txtTecnologia";
            this.txtTecnologia.Size = new System.Drawing.Size(164, 23);
            this.txtTecnologia.TabIndex = 0;
            // 
            // lblTecnologia
            // 
            this.lblTecnologia.AutoSize = true;
            this.lblTecnologia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTecnologia.Location = new System.Drawing.Point(12, 25);
            this.lblTecnologia.Name = "lblTecnologia";
            this.lblTecnologia.Size = new System.Drawing.Size(110, 22);
            this.lblTecnologia.TabIndex = 1;
            this.lblTecnologia.Text = "Tecnologia";
            // 
            // lblCostoBase
            // 
            this.lblCostoBase.AutoSize = true;
            this.lblCostoBase.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoBase.Location = new System.Drawing.Point(12, 96);
            this.lblCostoBase.Name = "lblCostoBase";
            this.lblCostoBase.Size = new System.Drawing.Size(110, 22);
            this.lblCostoBase.TabIndex = 2;
            this.lblCostoBase.Text = "Costo Base";
            // 
            // txtCostoBase
            // 
            this.txtCostoBase.Location = new System.Drawing.Point(146, 95);
            this.txtCostoBase.Name = "txtCostoBase";
            this.txtCostoBase.Size = new System.Drawing.Size(164, 23);
            this.txtCostoBase.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(112, 139);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(125, 46);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // frmTecnologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 197);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCostoBase);
            this.Controls.Add(this.lblCostoBase);
            this.Controls.Add(this.lblTecnologia);
            this.Controls.Add(this.txtTecnologia);
            this.Name = "frmTecnologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tecnologia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTecnologia;
        private System.Windows.Forms.Label lblTecnologia;
        private System.Windows.Forms.Label lblCostoBase;
        private System.Windows.Forms.TextBox txtCostoBase;
        private System.Windows.Forms.Button btnIngresar;
    }
}