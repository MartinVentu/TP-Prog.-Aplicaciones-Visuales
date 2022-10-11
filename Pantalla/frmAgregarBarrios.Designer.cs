namespace TPPAV.Pantalla
{
    partial class frmAgregarBarrios
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
            this.pnlBarrio = new System.Windows.Forms.Panel();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarrio
            // 
            this.pnlBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarrio.Controls.Add(this.btnCancelar);
            this.pnlBarrio.Controls.Add(this.btnRegistrar);
            this.pnlBarrio.Controls.Add(this.txtBarrio);
            this.pnlBarrio.Controls.Add(this.lblBarrio);
            this.pnlBarrio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarrio.Location = new System.Drawing.Point(0, 0);
            this.pnlBarrio.Name = "pnlBarrio";
            this.pnlBarrio.Size = new System.Drawing.Size(273, 95);
            this.pnlBarrio.TabIndex = 0;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(12, 21);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 13);
            this.lblBarrio.TabIndex = 0;
            this.lblBarrio.Text = "Nombre:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(65, 21);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(186, 20);
            this.txtBarrio.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(175, 60);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(94, 60);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 95);
            this.Controls.Add(this.pnlBarrio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBarrios";
            this.Text = "frmBarrios";
            this.pnlBarrio.ResumeLayout(false);
            this.pnlBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarrio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblBarrio;
    }
}