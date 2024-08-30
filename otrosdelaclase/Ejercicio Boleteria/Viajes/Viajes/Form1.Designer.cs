namespace Viajes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bConsultar = new System.Windows.Forms.Button();
            this.cBdestinos = new System.Windows.Forms.ComboBox();
            this.lBdisponibles = new System.Windows.Forms.ListBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lBhorarios = new System.Windows.Forms.ListBox();
            this.lCmicros = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.bConsultar);
            this.groupBox1.Controls.Add(this.cBdestinos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viajes";
            // 
            // bConsultar
            // 
            this.bConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConsultar.Location = new System.Drawing.Point(278, 19);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(75, 23);
            this.bConsultar.TabIndex = 2;
            this.bConsultar.Text = "Consultar";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // cBdestinos
            // 
            this.cBdestinos.FormattingEnabled = true;
            this.cBdestinos.Location = new System.Drawing.Point(10, 20);
            this.cBdestinos.Name = "cBdestinos";
            this.cBdestinos.Size = new System.Drawing.Size(248, 21);
            this.cBdestinos.Sorted = true;
            this.cBdestinos.TabIndex = 1;
            // 
            // lBdisponibles
            // 
            this.lBdisponibles.FormattingEnabled = true;
            this.lBdisponibles.Location = new System.Drawing.Point(290, 71);
            this.lBdisponibles.Name = "lBdisponibles";
            this.lBdisponibles.Size = new System.Drawing.Size(86, 95);
            this.lBdisponibles.TabIndex = 2;
            this.lBdisponibles.SelectedIndexChanged += new System.EventHandler(this.lBdisponibles_SelectedIndexChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAgregar.Image = global::Viajes.Properties.Resources.micro;
            this.bAgregar.Location = new System.Drawing.Point(12, 72);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(84, 69);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lBhorarios
            // 
            this.lBhorarios.FormattingEnabled = true;
            this.lBhorarios.Location = new System.Drawing.Point(102, 71);
            this.lBhorarios.Name = "lBhorarios";
            this.lBhorarios.Size = new System.Drawing.Size(176, 95);
            this.lBhorarios.TabIndex = 3;
            this.lBhorarios.SelectedIndexChanged += new System.EventHandler(this.lBhorarios_SelectedIndexChanged);
            // 
            // lCmicros
            // 
            this.lCmicros.AutoSize = true;
            this.lCmicros.Location = new System.Drawing.Point(15, 152);
            this.lCmicros.Name = "lCmicros";
            this.lCmicros.Size = new System.Drawing.Size(0, 13);
            this.lCmicros.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 189);
            this.Controls.Add(this.lCmicros);
            this.Controls.Add(this.lBhorarios);
            this.Controls.Add(this.lBdisponibles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAgregar);
            this.Name = "Form1";
            this.Text = "Plataforma 3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bConsultar;
        private System.Windows.Forms.ComboBox cBdestinos;
        private System.Windows.Forms.ListBox lBdisponibles;
        private System.Windows.Forms.ListBox lBhorarios;
        private System.Windows.Forms.Label lCmicros;
    }
}

