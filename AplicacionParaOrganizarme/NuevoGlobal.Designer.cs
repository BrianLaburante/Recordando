namespace AplicacionParaOrganizarme
{
    partial class NuevoGlobal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbNombreGlobal = new System.Windows.Forms.TextBox();
            this.btnNuevoGlobal = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrioridad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Nombre global";
            // 
            // tbNombreGlobal
            // 
            this.tbNombreGlobal.Font = new System.Drawing.Font("Replica Pro Bold Italic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreGlobal.Location = new System.Drawing.Point(18, 45);
            this.tbNombreGlobal.Name = "tbNombreGlobal";
            this.tbNombreGlobal.Size = new System.Drawing.Size(236, 33);
            this.tbNombreGlobal.TabIndex = 2;
            // 
            // btnNuevoGlobal
            // 
            this.btnNuevoGlobal.BackColor = System.Drawing.Color.DarkRed;
            this.btnNuevoGlobal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNuevoGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoGlobal.Font = new System.Drawing.Font("Replica Pro Bold Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoGlobal.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoGlobal.Location = new System.Drawing.Point(18, 156);
            this.btnNuevoGlobal.Name = "btnNuevoGlobal";
            this.btnNuevoGlobal.Size = new System.Drawing.Size(236, 50);
            this.btnNuevoGlobal.TabIndex = 5;
            this.btnNuevoGlobal.Text = "Aceptar";
            this.btnNuevoGlobal.UseVisualStyleBackColor = false;
            this.btnNuevoGlobal.Click += new System.EventHandler(this.btnNuevoGlobal_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Replica Pro Bold Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(18, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(236, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prioridad";
            // 
            // tbPrioridad
            // 
            this.tbPrioridad.Font = new System.Drawing.Font("Replica Pro Bold Italic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrioridad.Location = new System.Drawing.Point(18, 117);
            this.tbPrioridad.Name = "tbPrioridad";
            this.tbPrioridad.Size = new System.Drawing.Size(236, 33);
            this.tbPrioridad.TabIndex = 8;
            // 
            // NuevoGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(265, 284);
            this.Controls.Add(this.tbPrioridad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoGlobal);
            this.Controls.Add(this.tbNombreGlobal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NuevoGlobal";
            this.Text = "NuevoGlobal";
            this.Load += new System.EventHandler(this.NuevoGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbNombreGlobal;
        private System.Windows.Forms.Button btnNuevoGlobal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrioridad;
    }
}