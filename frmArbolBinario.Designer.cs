﻿namespace PryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoInordendes = new System.Windows.Forms.RadioButton();
            this.rdoPostorden = new System.Windows.Forms.RadioButton();
            this.rdoPreorden = new System.Windows.Forms.RadioButton();
            this.rdoInorden = new System.Windows.Forms.RadioButton();
            this.dgvGrillaArbol = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.tvwArbolBinario = new System.Windows.Forms.TreeView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaArbol)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoInordendes);
            this.groupBox3.Controls.Add(this.rdoPostorden);
            this.groupBox3.Controls.Add(this.rdoPreorden);
            this.groupBox3.Controls.Add(this.rdoInorden);
            this.groupBox3.Controls.Add(this.dgvGrillaArbol);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 213);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado del árbol";
            // 
            // rdoInordendes
            // 
            this.rdoInordendes.AutoSize = true;
            this.rdoInordendes.Location = new System.Drawing.Point(22, 87);
            this.rdoInordendes.Name = "rdoInordendes";
            this.rdoInordendes.Size = new System.Drawing.Size(170, 21);
            this.rdoInordendes.TabIndex = 5;
            this.rdoInordendes.Text = "In-Orden Descendente";
            this.rdoInordendes.UseVisualStyleBackColor = true;
            this.rdoInordendes.CheckedChanged += new System.EventHandler(this.rdoInordendes_CheckedChanged);
            // 
            // rdoPostorden
            // 
            this.rdoPostorden.AutoSize = true;
            this.rdoPostorden.Location = new System.Drawing.Point(22, 163);
            this.rdoPostorden.Name = "rdoPostorden";
            this.rdoPostorden.Size = new System.Drawing.Size(99, 21);
            this.rdoPostorden.TabIndex = 4;
            this.rdoPostorden.Text = "Post-Orden";
            this.rdoPostorden.UseVisualStyleBackColor = true;
            this.rdoPostorden.CheckedChanged += new System.EventHandler(this.rdoPostorden_CheckedChanged);
            // 
            // rdoPreorden
            // 
            this.rdoPreorden.AutoSize = true;
            this.rdoPreorden.Location = new System.Drawing.Point(22, 125);
            this.rdoPreorden.Name = "rdoPreorden";
            this.rdoPreorden.Size = new System.Drawing.Size(93, 21);
            this.rdoPreorden.TabIndex = 3;
            this.rdoPreorden.Text = "Pre-Orden";
            this.rdoPreorden.UseVisualStyleBackColor = true;
            this.rdoPreorden.CheckedChanged += new System.EventHandler(this.rdoPreorden_CheckedChanged);
            // 
            // rdoInorden
            // 
            this.rdoInorden.AutoSize = true;
            this.rdoInorden.Checked = true;
            this.rdoInorden.Location = new System.Drawing.Point(22, 51);
            this.rdoInorden.Name = "rdoInorden";
            this.rdoInorden.Size = new System.Drawing.Size(161, 21);
            this.rdoInorden.TabIndex = 2;
            this.rdoInorden.TabStop = true;
            this.rdoInorden.Text = "In-Orden Ascendente";
            this.rdoInorden.UseVisualStyleBackColor = true;
            this.rdoInorden.CheckedChanged += new System.EventHandler(this.rdoInorden_CheckedChanged);
            // 
            // dgvGrillaArbol
            // 
            this.dgvGrillaArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Trámite});
            this.dgvGrillaArbol.Location = new System.Drawing.Point(204, 29);
            this.dgvGrillaArbol.Name = "dgvGrillaArbol";
            this.dgvGrillaArbol.Size = new System.Drawing.Size(427, 164);
            this.dgvGrillaArbol.TabIndex = 1;
            this.dgvGrillaArbol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaArbol_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            this.Trámite.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboEliminar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // cboEliminar
            // 
            this.cboEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEliminar.FormattingEnabled = true;
            this.cboEliminar.Location = new System.Drawing.Point(82, 27);
            this.cboEliminar.Name = "cboEliminar";
            this.cboEliminar.Size = new System.Drawing.Size(119, 24);
            this.cboEliminar.TabIndex = 8;
            this.cboEliminar.SelectedIndexChanged += new System.EventHandler(this.cboEliminar_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 47);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(88, 104);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(114, 23);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 151);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(196, 47);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(444, 163);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(196, 47);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // tvwArbolBinario
            // 
            this.tvwArbolBinario.Location = new System.Drawing.Point(16, 18);
            this.tvwArbolBinario.Name = "tvwArbolBinario";
            this.tvwArbolBinario.Size = new System.Drawing.Size(193, 197);
            this.tvwArbolBinario.TabIndex = 15;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 461);
            this.Controls.Add(this.tvwArbolBinario);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaArbol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPostorden;
        private System.Windows.Forms.RadioButton rdoPreorden;
        private System.Windows.Forms.RadioButton rdoInorden;
        private System.Windows.Forms.DataGridView dgvGrillaArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView tvwArbolBinario;
        private System.Windows.Forms.RadioButton rdoInordendes;
    }
}