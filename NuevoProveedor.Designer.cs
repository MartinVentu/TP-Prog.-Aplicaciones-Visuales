using System.Windows.Forms;

namespace TPPAV
{
    partial class NuevoProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtBarrioProveedor = new System.Windows.Forms.TextBox();
            this.txtNumeroCalleProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarProveedor = new System.Windows.Forms.Button();
            this.txtCalleProveedor = new System.Windows.Forms.TextBox();
            this.btnLimpiarCamposProveedor = new System.Windows.Forms.Button();
            this.txtCuilProveedor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuil.Location = new System.Drawing.Point(94, 90);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(40, 21);
            this.lblCuil.TabIndex = 0;
            this.lblCuil.Text = "Cuil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barrio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nro de Calle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Teléfono:";
            // 
            // txtApellidoProveedor
            // 
            this.txtApellidoProveedor.Location = new System.Drawing.Point(143, 138);
            this.txtApellidoProveedor.Name = "txtApellidoProveedor";
            this.txtApellidoProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtApellidoProveedor.TabIndex = 8;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(143, 184);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtNombreProveedor.TabIndex = 9;
            // 
            // txtBarrioProveedor
            // 
            this.txtBarrioProveedor.Location = new System.Drawing.Point(143, 232);
            this.txtBarrioProveedor.Name = "txtBarrioProveedor";
            this.txtBarrioProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtBarrioProveedor.TabIndex = 10;
            // 
            // txtNumeroCalleProveedor
            // 
            this.txtNumeroCalleProveedor.Location = new System.Drawing.Point(143, 326);
            this.txtNumeroCalleProveedor.Name = "txtNumeroCalleProveedor";
            this.txtNumeroCalleProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtNumeroCalleProveedor.TabIndex = 12;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(143, 372);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtTelefonoProveedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(410, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingrese los datos del nuevo proveedor";
            // 
            // btnCargarProveedor
            // 
            this.btnCargarProveedor.Location = new System.Drawing.Point(276, 441);
            this.btnCargarProveedor.Name = "btnCargarProveedor";
            this.btnCargarProveedor.Size = new System.Drawing.Size(75, 56);
            this.btnCargarProveedor.TabIndex = 19;
            this.btnCargarProveedor.Text = "Cargar Proveedor";
            this.btnCargarProveedor.UseVisualStyleBackColor = true;
            this.btnCargarProveedor.Click += new System.EventHandler(this.btnCargarProveedor_Click);
            // 
            // txtCalleProveedor
            // 
            this.txtCalleProveedor.Location = new System.Drawing.Point(143, 279);
            this.txtCalleProveedor.Name = "txtCalleProveedor";
            this.txtCalleProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtCalleProveedor.TabIndex = 11;
            // 
            // btnLimpiarCamposProveedor
            // 
            this.btnLimpiarCamposProveedor.Location = new System.Drawing.Point(116, 441);
            this.btnLimpiarCamposProveedor.Name = "btnLimpiarCamposProveedor";
            this.btnLimpiarCamposProveedor.Size = new System.Drawing.Size(75, 56);
            this.btnLimpiarCamposProveedor.TabIndex = 20;
            this.btnLimpiarCamposProveedor.Text = "Limpiar Campos";
            this.btnLimpiarCamposProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposProveedor.Click += new System.EventHandler(this.btnLimpiarCamposProveedor_Click);
            // 
            // txtCuilProveedor
            // 
            this.txtCuilProveedor.Location = new System.Drawing.Point(143, 88);
            this.txtCuilProveedor.Mask = "99999999999";
            this.txtCuilProveedor.Name = "txtCuilProveedor";
            this.txtCuilProveedor.PromptChar = 'ㅤ';
            this.txtCuilProveedor.Size = new System.Drawing.Size(208, 23);
            this.txtCuilProveedor.TabIndex = 21;
            this.txtCuilProveedor.ValidatingType = typeof(int);
            // 
            // NuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 534);
            this.Controls.Add(this.txtCuilProveedor);
            this.Controls.Add(this.btnLimpiarCamposProveedor);
            this.Controls.Add(this.btnCargarProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.txtNumeroCalleProveedor);
            this.Controls.Add(this.txtCalleProveedor);
            this.Controls.Add(this.txtBarrioProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtApellidoProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuil);
            this.Name = "NuevoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProveedor";
            this.Load += new System.EventHandler(this.NuevoProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCuil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtApellidoProveedor;
        private TextBox txtNombreProveedor;
        private TextBox txtBarrioProveedor;
        private TextBox txtNumeroCalleProveedor;
        private TextBox txtTelefonoProveedor;
        private Label label7;
        private Button btnCargarProveedor;
        private TextBox txtCalleProveedor;
        private Button btnLimpiarCamposProveedor;
        private MaskedTextBox txtCuilProveedor;
    }
}