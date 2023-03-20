
namespace EmpleadoDepartamentoSolucion
{
    partial class frmPrincipal
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
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.ListBox();
            this.pbDepartamento = new System.Windows.Forms.PictureBox();
            this.btnCambioDepartamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(128, 27);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(143, 21);
            this.cbDepartamento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado:";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.FormattingEnabled = true;
            this.lbEmpleado.Location = new System.Drawing.Point(128, 180);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(142, 95);
            this.lbEmpleado.TabIndex = 3;
            // 
            // pbDepartamento
            // 
            this.pbDepartamento.Location = new System.Drawing.Point(39, 66);
            this.pbDepartamento.Name = "pbDepartamento";
            this.pbDepartamento.Size = new System.Drawing.Size(232, 90);
            this.pbDepartamento.TabIndex = 4;
            this.pbDepartamento.TabStop = false;
            // 
            // btnCambioDepartamento
            // 
            this.btnCambioDepartamento.Location = new System.Drawing.Point(94, 296);
            this.btnCambioDepartamento.Name = "btnCambioDepartamento";
            this.btnCambioDepartamento.Size = new System.Drawing.Size(98, 43);
            this.btnCambioDepartamento.TabIndex = 5;
            this.btnCambioDepartamento.Text = "Cambiar Departamento";
            this.btnCambioDepartamento.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 357);
            this.Controls.Add(this.btnCambioDepartamento);
            this.Controls.Add(this.pbDepartamento);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDepartamento);
            this.Name = "frmPrincipal";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEmpleado;
        private System.Windows.Forms.PictureBox pbDepartamento;
        private System.Windows.Forms.Button btnCambioDepartamento;
    }
}

