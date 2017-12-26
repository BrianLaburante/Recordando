namespace AplicacionParaOrganizarme
{
    partial class NuevoLocal
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
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tbNuevoLocal = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblnumPaso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.DarkRed;
            this.btFinalizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Replica Pro Bold Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btFinalizar.Location = new System.Drawing.Point(11, 196);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(236, 50);
            this.btFinalizar.TabIndex = 12;
            this.btFinalizar.Text = "finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.DarkRed;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Replica Pro Bold Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(11, 140);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(236, 50);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Agregar Otro";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // tbNuevoLocal
            // 
            this.tbNuevoLocal.Font = new System.Drawing.Font("Replica Pro Bold Italic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoLocal.Location = new System.Drawing.Point(12, 101);
            this.tbNuevoLocal.Name = "tbNuevoLocal";
            this.tbNuevoLocal.Size = new System.Drawing.Size(236, 33);
            this.tbNuevoLocal.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(5, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 33);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "paso Nº";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.DarkRed;
            this.lblnombre.Location = new System.Drawing.Point(12, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(91, 33);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "nombre";
            // 
            // lblnumPaso
            // 
            this.lblnumPaso.AutoSize = true;
            this.lblnumPaso.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumPaso.ForeColor = System.Drawing.Color.White;
            this.lblnumPaso.Location = new System.Drawing.Point(117, 16);
            this.lblnumPaso.Name = "lblnumPaso";
            this.lblnumPaso.Size = new System.Drawing.Size(120, 33);
            this.lblnumPaso.TabIndex = 14;
            this.lblnumPaso.Text = "indefinido";
            // 
            // NuevoLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(252, 251);
            this.Controls.Add(this.lblnumPaso);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tbNuevoLocal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NuevoLocal";
            this.Text = "NuevoLocal";
            this.Load += new System.EventHandler(this.NuevoLocal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox tbNuevoLocal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblnumPaso;
    }
}