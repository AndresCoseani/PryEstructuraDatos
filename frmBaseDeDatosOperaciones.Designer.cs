namespace PryEstructuraDatos
{
    partial class frmBaseDeDatosOperaciones
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
            this.dgvBaseDeDatosOperaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProMulti = new System.Windows.Forms.Button();
            this.btnProSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelecConvulcion = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInteseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatosOperaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDeDatosOperaciones
            // 
            this.dgvBaseDeDatosOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDeDatosOperaciones.Location = new System.Drawing.Point(8, 6);
            this.dgvBaseDeDatosOperaciones.Name = "dgvBaseDeDatosOperaciones";
            this.dgvBaseDeDatosOperaciones.Size = new System.Drawing.Size(819, 306);
            this.dgvBaseDeDatosOperaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProMulti);
            this.groupBox1.Controls.Add(this.btnProSimple);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(29, 84);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(214, 26);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProMulti
            // 
            this.btnProMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProMulti.Location = new System.Drawing.Point(29, 52);
            this.btnProMulti.Name = "btnProMulti";
            this.btnProMulti.Size = new System.Drawing.Size(214, 26);
            this.btnProMulti.TabIndex = 1;
            this.btnProMulti.Text = "Proyección Multiatributo";
            this.btnProMulti.UseVisualStyleBackColor = true;
            this.btnProMulti.Click += new System.EventHandler(this.btnProMulti_Click);
            // 
            // btnProSimple
            // 
            this.btnProSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProSimple.Location = new System.Drawing.Point(29, 20);
            this.btnProSimple.Name = "btnProSimple";
            this.btnProSimple.Size = new System.Drawing.Size(214, 26);
            this.btnProSimple.TabIndex = 0;
            this.btnProSimple.Text = "Proyección Simple";
            this.btnProSimple.UseVisualStyleBackColor = true;
            this.btnProSimple.Click += new System.EventHandler(this.btnProSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelecConvulcion);
            this.groupBox2.Controls.Add(this.btnSelecMulti);
            this.groupBox2.Controls.Add(this.btnSelecSimple);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelecConvulcion
            // 
            this.btnSelecConvulcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecConvulcion.Location = new System.Drawing.Point(23, 84);
            this.btnSelecConvulcion.Name = "btnSelecConvulcion";
            this.btnSelecConvulcion.Size = new System.Drawing.Size(214, 26);
            this.btnSelecConvulcion.TabIndex = 5;
            this.btnSelecConvulcion.Text = "Selección por convulción";
            this.btnSelecConvulcion.UseVisualStyleBackColor = true;
            this.btnSelecConvulcion.Click += new System.EventHandler(this.btnSelecConvulcion_Click);
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecMulti.Location = new System.Drawing.Point(23, 52);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(214, 26);
            this.btnSelecMulti.TabIndex = 4;
            this.btnSelecMulti.Text = "Selección Multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            this.btnSelecMulti.Click += new System.EventHandler(this.btnSelecMulti_Click);
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecSimple.Location = new System.Drawing.Point(23, 20);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(214, 26);
            this.btnSelecSimple.TabIndex = 3;
            this.btnSelecSimple.Text = "Selección Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            this.btnSelecSimple.Click += new System.EventHandler(this.btnSelecSimple_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInteseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(557, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebricas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiferencia.Location = new System.Drawing.Point(35, 84);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(214, 26);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInteseccion
            // 
            this.btnInteseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteseccion.Location = new System.Drawing.Point(35, 52);
            this.btnInteseccion.Name = "btnInteseccion";
            this.btnInteseccion.Size = new System.Drawing.Size(214, 26);
            this.btnInteseccion.TabIndex = 7;
            this.btnInteseccion.Text = "Intersección";
            this.btnInteseccion.UseVisualStyleBackColor = true;
            this.btnInteseccion.Click += new System.EventHandler(this.btnInteseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnion.Location = new System.Drawing.Point(35, 20);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(214, 26);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBaseDeDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(839, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDeDatosOperaciones);
            this.Name = "frmBaseDeDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeDatosOperaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDeDatosOperaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMulti;
        private System.Windows.Forms.Button btnProSimple;
        private System.Windows.Forms.Button btnSelecConvulcion;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInteseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}