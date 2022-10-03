using System.Windows.Forms;

namespace TPPAV
{
    partial class NuevoVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoDocVendedor = new System.Windows.Forms.TextBox();
            this.txtFechaIngresoVendedor = new System.Windows.Forms.TextBox();
            this.txtFechaNacimientoVendedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoVendedor = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtApellidoVendedor = new System.Windows.Forms.TextBox();
            this.txtComisionVendedor = new System.Windows.Forms.TextBox();
            this.btnCargarVendedor = new System.Windows.Forms.Button();
            this.btnLimpiarCamposVendedor = new System.Windows.Forms.Button();
            this.txtNumeroDocVendedor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(73, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(130, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(129, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(130, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(122, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Comisión:";
            // 
            // txtTipoDocVendedor
            // 
            this.txtTipoDocVendedor.Location = new System.Drawing.Point(205, 116);
            this.txtTipoDocVendedor.Name = "txtTipoDocVendedor";
            this.txtTipoDocVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtTipoDocVendedor.TabIndex = 11;
            // 
            // txtFechaIngresoVendedor
            // 
            this.txtFechaIngresoVendedor.Location = new System.Drawing.Point(205, 158);
            this.txtFechaIngresoVendedor.Name = "txtFechaIngresoVendedor";
            this.txtFechaIngresoVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtFechaIngresoVendedor.TabIndex = 12;
            // 
            // txtFechaNacimientoVendedor
            // 
            this.txtFechaNacimientoVendedor.Location = new System.Drawing.Point(206, 208);
            this.txtFechaNacimientoVendedor.Name = "txtFechaNacimientoVendedor";
            this.txtFechaNacimientoVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtFechaNacimientoVendedor.TabIndex = 13;
            // 
            // txtTelefonoVendedor
            // 
            this.txtTelefonoVendedor.Location = new System.Drawing.Point(205, 254);
            this.txtTelefonoVendedor.Name = "txtTelefonoVendedor";
            this.txtTelefonoVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtTelefonoVendedor.TabIndex = 14;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(206, 300);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtNombreVendedor.TabIndex = 15;
            // 
            // txtApellidoVendedor
            // 
            this.txtApellidoVendedor.Location = new System.Drawing.Point(206, 345);
            this.txtApellidoVendedor.Name = "txtApellidoVendedor";
            this.txtApellidoVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoVendedor.TabIndex = 16;
            // 
            // txtComisionVendedor
            // 
            this.txtComisionVendedor.Location = new System.Drawing.Point(205, 392);
            this.txtComisionVendedor.Name = "txtComisionVendedor";
            this.txtComisionVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtComisionVendedor.TabIndex = 17;
            // 
            // btnCargarVendedor
            // 
            this.btnCargarVendedor.Location = new System.Drawing.Point(339, 450);
            this.btnCargarVendedor.Name = "btnCargarVendedor";
            this.btnCargarVendedor.Size = new System.Drawing.Size(75, 56);
            this.btnCargarVendedor.TabIndex = 18;
            this.btnCargarVendedor.Text = "Cargar Vendedor";
            this.btnCargarVendedor.UseVisualStyleBackColor = true;
            this.btnCargarVendedor.Click += new System.EventHandler(this.btnCargarVendedor_Click);
            // 
            // btnLimpiarCamposVendedor
            // 
            this.btnLimpiarCamposVendedor.Location = new System.Drawing.Point(177, 450);
            this.btnLimpiarCamposVendedor.Name = "btnLimpiarCamposVendedor";
            this.btnLimpiarCamposVendedor.Size = new System.Drawing.Size(75, 56);
            this.btnLimpiarCamposVendedor.TabIndex = 19;
            this.btnLimpiarCamposVendedor.Text = "Limpiar Campos";
            this.btnLimpiarCamposVendedor.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposVendedor.Click += new System.EventHandler(this.btnLimpiarCamposVendedor_Click);
            // 
            // txtNumeroDocVendedor
            // 
            this.txtNumeroDocVendedor.Location = new System.Drawing.Point(206, 70);
            this.txtNumeroDocVendedor.Mask = "99999999";
            this.txtNumeroDocVendedor.Name = "txtNumeroDocVendedor";
            this.txtNumeroDocVendedor.PromptChar = 'ㅤ';
            this.txtNumeroDocVendedor.Size = new System.Drawing.Size(208, 23);
            this.txtNumeroDocVendedor.TabIndex = 20;
            this.txtNumeroDocVendedor.ValidatingType = typeof(int);
            // 
            // NuevoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 534);
            this.Controls.Add(this.txtNumeroDocVendedor);
            this.Controls.Add(this.btnLimpiarCamposVendedor);
            this.Controls.Add(this.btnCargarVendedor);
            this.Controls.Add(this.txtComisionVendedor);
            this.Controls.Add(this.txtApellidoVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.txtTelefonoVendedor);
            this.Controls.Add(this.txtFechaNacimientoVendedor);
            this.Controls.Add(this.txtFechaIngresoVendedor);
            this.Controls.Add(this.txtTipoDocVendedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoVendedor";
            this.Load += new System.EventHandler(this.NuevoVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTipoDocVendedor;
        private TextBox txtFechaIngresoVendedor;
        private TextBox txtFechaNacimientoVendedor;
        private TextBox txtTelefonoVendedor;
        private TextBox txtNombreVendedor;
        private TextBox txtApellidoVendedor;
        private TextBox txtComisionVendedor;
        private Button btnCargarVendedor;
        private Button btnLimpiarCamposVendedor;
        private MaskedTextBox txtNumeroDocVendedor;
    }
}