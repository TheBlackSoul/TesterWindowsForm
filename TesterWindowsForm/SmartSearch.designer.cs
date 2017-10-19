namespace Capa_Diseño2_B
{
    partial class SmartSearch
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_operaciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_campos = new System.Windows.Forms.ComboBox();
            this.Btn_agregarcam = new System.Windows.Forms.Button();
            this.Txt_alias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_operadorcondiciones = new System.Windows.Forms.ComboBox();
            this.Txt_condicion1 = new System.Windows.Forms.TextBox();
            this.Txt_condicion2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_agregarcond = new System.Windows.Forms.Button();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Dgv_resultado = new System.Windows.Forms.DataGridView();
            this.Btn_creacampos = new System.Windows.Forms.Button();
            this.Btn_creacond = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Txt_operador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Sobre Campos:";
            // 
            // Cmb_operaciones
            // 
            this.Cmb_operaciones.FormattingEnabled = true;
            this.Cmb_operaciones.Items.AddRange(new object[] {
            "SUMAR",
            "CONTAR",
            "PROMEDIAR",
            "MINIMO",
            "MAXIMO"});
            this.Cmb_operaciones.Location = new System.Drawing.Point(0, 16);
            this.Cmb_operaciones.Name = "Cmb_operaciones";
            this.Cmb_operaciones.Size = new System.Drawing.Size(139, 21);
            this.Cmb_operaciones.TabIndex = 1;
            this.Cmb_operaciones.SelectedIndexChanged += new System.EventHandler(this.Cmb_operaciones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campos De Tabla:";
            // 
            // Cmb_campos
            // 
            this.Cmb_campos.FormattingEnabled = true;
            this.Cmb_campos.Location = new System.Drawing.Point(199, 16);
            this.Cmb_campos.Name = "Cmb_campos";
            this.Cmb_campos.Size = new System.Drawing.Size(134, 21);
            this.Cmb_campos.TabIndex = 3;
            this.Cmb_campos.SelectedIndexChanged += new System.EventHandler(this.Cmb_campos_SelectedIndexChanged);
            // 
            // Btn_agregarcam
            // 
            this.Btn_agregarcam.Location = new System.Drawing.Point(0, 93);
            this.Btn_agregarcam.Name = "Btn_agregarcam";
            this.Btn_agregarcam.Size = new System.Drawing.Size(160, 23);
            this.Btn_agregarcam.TabIndex = 4;
            this.Btn_agregarcam.Text = "Crear Campos";
            this.Btn_agregarcam.UseVisualStyleBackColor = true;
            this.Btn_agregarcam.Click += new System.EventHandler(this.Btn_agregarcam_Click);
            // 
            // Txt_alias
            // 
            this.Txt_alias.Location = new System.Drawing.Point(0, 67);
            this.Txt_alias.Name = "Txt_alias";
            this.Txt_alias.Size = new System.Drawing.Size(333, 20);
            this.Txt_alias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombe Personalizado del campo a mostra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operador de Condiciones";
            // 
            // Cmb_operadorcondiciones
            // 
            this.Cmb_operadorcondiciones.FormattingEnabled = true;
            this.Cmb_operadorcondiciones.Items.AddRange(new object[] {
            "MAYOR QUE",
            "MENOR QUE",
            "IGUAL",
            "MENOR O IGUAL",
            "MAYOR O IGUAL",
            "DIFERENTE",
            "Y",
            "O"});
            this.Cmb_operadorcondiciones.Location = new System.Drawing.Point(109, 152);
            this.Cmb_operadorcondiciones.Name = "Cmb_operadorcondiciones";
            this.Cmb_operadorcondiciones.Size = new System.Drawing.Size(117, 21);
            this.Cmb_operadorcondiciones.TabIndex = 8;
            this.Cmb_operadorcondiciones.SelectedIndexChanged += new System.EventHandler(this.Cmb_operadorcondiciones_SelectedIndexChanged);
            // 
            // Txt_condicion1
            // 
            this.Txt_condicion1.Location = new System.Drawing.Point(3, 190);
            this.Txt_condicion1.Name = "Txt_condicion1";
            this.Txt_condicion1.Size = new System.Drawing.Size(100, 20);
            this.Txt_condicion1.TabIndex = 9;
            // 
            // Txt_condicion2
            // 
            this.Txt_condicion2.Location = new System.Drawing.Point(232, 190);
            this.Txt_condicion2.Name = "Txt_condicion2";
            this.Txt_condicion2.Size = new System.Drawing.Size(100, 20);
            this.Txt_condicion2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Condición 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Condición 2:";
            // 
            // Btn_agregarcond
            // 
            this.Btn_agregarcond.Location = new System.Drawing.Point(0, 216);
            this.Btn_agregarcond.Name = "Btn_agregarcond";
            this.Btn_agregarcond.Size = new System.Drawing.Size(149, 23);
            this.Btn_agregarcond.TabIndex = 13;
            this.Btn_agregarcond.Text = "Crear Condiciones";
            this.Btn_agregarcond.UseVisualStyleBackColor = true;
            this.Btn_agregarcond.Click += new System.EventHandler(this.Btn_agregarcond_Click);
            // 
            // Btn_crear
            // 
            this.Btn_crear.Location = new System.Drawing.Point(-1, 245);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(334, 23);
            this.Btn_crear.TabIndex = 14;
            this.Btn_crear.Text = "Crear Consulta";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Dgv_resultado
            // 
            this.Dgv_resultado.AllowUserToAddRows = false;
            this.Dgv_resultado.AllowUserToDeleteRows = false;
            this.Dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_resultado.Location = new System.Drawing.Point(0, 303);
            this.Dgv_resultado.Name = "Dgv_resultado";
            this.Dgv_resultado.ReadOnly = true;
            this.Dgv_resultado.Size = new System.Drawing.Size(333, 91);
            this.Dgv_resultado.TabIndex = 15;
            // 
            // Btn_creacampos
            // 
            this.Btn_creacampos.Location = new System.Drawing.Point(172, 93);
            this.Btn_creacampos.Name = "Btn_creacampos";
            this.Btn_creacampos.Size = new System.Drawing.Size(160, 23);
            this.Btn_creacampos.TabIndex = 16;
            this.Btn_creacampos.Text = "Agregar Campos";
            this.Btn_creacampos.UseVisualStyleBackColor = true;
            this.Btn_creacampos.Click += new System.EventHandler(this.Btn_creacampos_Click);
            // 
            // Btn_creacond
            // 
            this.Btn_creacond.Location = new System.Drawing.Point(184, 216);
            this.Btn_creacond.Name = "Btn_creacond";
            this.Btn_creacond.Size = new System.Drawing.Size(149, 23);
            this.Btn_creacond.TabIndex = 17;
            this.Btn_creacond.Text = "Agregar Condiciones";
            this.Btn_creacond.UseVisualStyleBackColor = true;
            this.Btn_creacond.Click += new System.EventHandler(this.Btn_creacond_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Location = new System.Drawing.Point(-1, 274);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(333, 23);
            this.Btn_nuevo.TabIndex = 18;
            this.Btn_nuevo.Text = "Nueva Consulta";
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Txt_operador
            // 
            this.Txt_operador.Location = new System.Drawing.Point(109, 190);
            this.Txt_operador.Name = "Txt_operador";
            this.Txt_operador.Size = new System.Drawing.Size(117, 20);
            this.Txt_operador.TabIndex = 20;
            // 
            // SmartSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_operador);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_creacond);
            this.Controls.Add(this.Btn_creacampos);
            this.Controls.Add(this.Dgv_resultado);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Btn_agregarcond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_condicion2);
            this.Controls.Add(this.Txt_condicion1);
            this.Controls.Add(this.Cmb_operadorcondiciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_alias);
            this.Controls.Add(this.Btn_agregarcam);
            this.Controls.Add(this.Cmb_campos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_operaciones);
            this.Controls.Add(this.label1);
            this.Name = "SmartSearch";
            this.Size = new System.Drawing.Size(335, 399);
            this.Load += new System.EventHandler(this.SmartSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_operaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_campos;
        private System.Windows.Forms.Button Btn_agregarcam;
        private System.Windows.Forms.TextBox Txt_alias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_operadorcondiciones;
        private System.Windows.Forms.TextBox Txt_condicion1;
        private System.Windows.Forms.TextBox Txt_condicion2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_agregarcond;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.DataGridView Dgv_resultado;
        private System.Windows.Forms.Button Btn_creacampos;
        private System.Windows.Forms.Button Btn_creacond;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.TextBox Txt_operador;
    }
}
