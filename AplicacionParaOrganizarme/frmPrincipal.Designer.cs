namespace AplicacionParaOrganizarme
{
    partial class frmPrincipal
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
            this.btnAgregarPaso = new System.Windows.Forms.Button();
            this.clbPasos = new System.Windows.Forms.CheckedListBox();
            this.lbGlobal = new System.Windows.Forms.ListBox();
            this.btnNuevoGlobal = new System.Windows.Forms.Button();
            this.btnFinalizarGlobal = new System.Windows.Forms.Button();
            this.btnPrioridad = new System.Windows.Forms.Button();
            this.lblVPriori = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.BtnEliminarPaso = new System.Windows.Forms.Button();
            this.btnEditarPaso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(34, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tareas Globales";
            // 
            // btnAgregarPaso
            // 
            this.btnAgregarPaso.BackColor = System.Drawing.Color.DarkRed;
            this.btnAgregarPaso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregarPaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaso.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPaso.Location = new System.Drawing.Point(886, 528);
            this.btnAgregarPaso.Name = "btnAgregarPaso";
            this.btnAgregarPaso.Size = new System.Drawing.Size(113, 50);
            this.btnAgregarPaso.TabIndex = 1;
            this.btnAgregarPaso.Text = "Agregar Checkbox";
            this.btnAgregarPaso.UseVisualStyleBackColor = false;
            this.btnAgregarPaso.Click += new System.EventHandler(this.BtnAgregarPaso_Click);
            // 
            // clbPasos
            // 
            this.clbPasos.FormattingEnabled = true;
            this.clbPasos.Location = new System.Drawing.Point(598, 20);
            this.clbPasos.Name = "clbPasos";
            this.clbPasos.Size = new System.Drawing.Size(401, 499);
            this.clbPasos.TabIndex = 2;
            // 
            // lbGlobal
            // 
            this.lbGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGlobal.FormattingEnabled = true;
            this.lbGlobal.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.lbGlobal.ItemHeight = 24;
            this.lbGlobal.Location = new System.Drawing.Point(12, 56);
            this.lbGlobal.Name = "lbGlobal";
            this.lbGlobal.Size = new System.Drawing.Size(580, 268);
            this.lbGlobal.TabIndex = 3;
            this.lbGlobal.SelectedIndexChanged += new System.EventHandler(this.LbGlobal_SelectedIndexChanged);
            // 
            // btnNuevoGlobal
            // 
            this.btnNuevoGlobal.BackColor = System.Drawing.Color.DarkRed;
            this.btnNuevoGlobal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNuevoGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoGlobal.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoGlobal.Location = new System.Drawing.Point(12, 352);
            this.btnNuevoGlobal.Name = "btnNuevoGlobal";
            this.btnNuevoGlobal.Size = new System.Drawing.Size(222, 50);
            this.btnNuevoGlobal.TabIndex = 4;
            this.btnNuevoGlobal.Text = "Nueva tarea";
            this.btnNuevoGlobal.UseVisualStyleBackColor = false;
            this.btnNuevoGlobal.Click += new System.EventHandler(this.BtnNuevoGlobal_Click);
            // 
            // btnFinalizarGlobal
            // 
            this.btnFinalizarGlobal.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinalizarGlobal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFinalizarGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarGlobal.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarGlobal.Location = new System.Drawing.Point(12, 408);
            this.btnFinalizarGlobal.Name = "btnFinalizarGlobal";
            this.btnFinalizarGlobal.Size = new System.Drawing.Size(222, 50);
            this.btnFinalizarGlobal.TabIndex = 5;
            this.btnFinalizarGlobal.Text = "Finalizar tarea";
            this.btnFinalizarGlobal.UseVisualStyleBackColor = false;
            // 
            // btnPrioridad
            // 
            this.btnPrioridad.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrioridad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrioridad.ForeColor = System.Drawing.Color.Black;
            this.btnPrioridad.Location = new System.Drawing.Point(12, 464);
            this.btnPrioridad.Name = "btnPrioridad";
            this.btnPrioridad.Size = new System.Drawing.Size(222, 50);
            this.btnPrioridad.TabIndex = 6;
            this.btnPrioridad.Text = "Prioridad";
            this.btnPrioridad.UseVisualStyleBackColor = false;
            // 
            // lblVPriori
            // 
            this.lblVPriori.AutoSize = true;
            this.lblVPriori.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVPriori.ForeColor = System.Drawing.Color.White;
            this.lblVPriori.Location = new System.Drawing.Point(411, 361);
            this.lblVPriori.Name = "lblVPriori";
            this.lblVPriori.Size = new System.Drawing.Size(144, 27);
            this.lblVPriori.TabIndex = 7;
            this.lblVPriori.Text = "No definida";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrioridad.Location = new System.Drawing.Point(264, 361);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(127, 33);
            this.lblPrioridad.TabIndex = 8;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // BtnEliminarPaso
            // 
            this.BtnEliminarPaso.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEliminarPaso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnEliminarPaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPaso.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarPaso.Location = new System.Drawing.Point(598, 525);
            this.BtnEliminarPaso.Name = "BtnEliminarPaso";
            this.BtnEliminarPaso.Size = new System.Drawing.Size(113, 50);
            this.BtnEliminarPaso.TabIndex = 9;
            this.BtnEliminarPaso.Text = "Eliminar Checkbox";
            this.BtnEliminarPaso.UseVisualStyleBackColor = false;
            // 
            // btnEditarPaso
            // 
            this.btnEditarPaso.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarPaso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEditarPaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaso.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPaso.Location = new System.Drawing.Point(751, 528);
            this.btnEditarPaso.Name = "btnEditarPaso";
            this.btnEditarPaso.Size = new System.Drawing.Size(113, 50);
            this.btnEditarPaso.TabIndex = 10;
            this.btnEditarPaso.Text = "Editar Checkbox";
            this.btnEditarPaso.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1011, 589);
            this.Controls.Add(this.btnEditarPaso);
            this.Controls.Add(this.BtnEliminarPaso);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblVPriori);
            this.Controls.Add(this.btnPrioridad);
            this.Controls.Add(this.btnFinalizarGlobal);
            this.Controls.Add(this.btnNuevoGlobal);
            this.Controls.Add(this.lbGlobal);
            this.Controls.Add(this.clbPasos);
            this.Controls.Add(this.btnAgregarPaso);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.Text = "Para llevar al dia las tareas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarPaso;
        private System.Windows.Forms.CheckedListBox clbPasos;
        private System.Windows.Forms.ListBox lbGlobal;
        private System.Windows.Forms.Button btnNuevoGlobal;
        private System.Windows.Forms.Button btnFinalizarGlobal;
        private System.Windows.Forms.Button btnPrioridad;
        private System.Windows.Forms.Label lblVPriori;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Button BtnEliminarPaso;
        private System.Windows.Forms.Button btnEditarPaso;
    }
}

