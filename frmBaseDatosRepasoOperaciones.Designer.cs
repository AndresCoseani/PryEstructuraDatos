namespace PryEstructuraDatos
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.dgvRepasoBaseDeDatos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cboRepaso = new System.Windows.Forms.ComboBox();
            this.lblCaso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepasoBaseDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepasoBaseDeDatos
            // 
            this.dgvRepasoBaseDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepasoBaseDeDatos.Location = new System.Drawing.Point(12, 197);
            this.dgvRepasoBaseDeDatos.Name = "dgvRepasoBaseDeDatos";
            this.dgvRepasoBaseDeDatos.Size = new System.Drawing.Size(825, 249);
            this.dgvRepasoBaseDeDatos.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(739, 21);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 31);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(12, 31);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(270, 17);
            this.lblOperacion.TabIndex = 4;
            this.lblOperacion.Text = "Operación a realizar en la base de datos:";
            // 
            // cboRepaso
            // 
            this.cboRepaso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRepaso.FormattingEnabled = true;
            this.cboRepaso.Items.AddRange(new object[] {
            "Union",
            "Intersección ",
            "Diferencia",
            "Seleccion Simple",
            "Seleccion Multiple (Intersección)",
            "Seleccion Multiple (Convulsion)",
            "Orden",
            "Proyección por un Atributo",
            "Proyeccion por Multiatributo",
            "Juntar",
            "Union",
            "Intersección ",
            "Diferencia",
            "Seleccion Simple",
            "Seleccion Multiple (Intersección)",
            "Seleccion Multiple (Convulsion)",
            "Orden",
            "Proyección por un Atributo",
            "Proyeccion por Multiatributo",
            "Juntar",
            ""});
            this.cboRepaso.Location = new System.Drawing.Point(284, 25);
            this.cboRepaso.Name = "cboRepaso";
            this.cboRepaso.Size = new System.Drawing.Size(432, 24);
            this.cboRepaso.TabIndex = 8;
            // 
            // lblCaso
            // 
            this.lblCaso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaso.Location = new System.Drawing.Point(13, 55);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(824, 122);
            this.lblCaso.TabIndex = 10;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.lblCaso);
            this.Controls.Add(this.cboRepaso);
            this.Controls.Add(this.dgvRepasoBaseDeDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblOperacion);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepasoBaseDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepasoBaseDeDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cboRepaso;
        private System.Windows.Forms.Label lblCaso;
    }
}