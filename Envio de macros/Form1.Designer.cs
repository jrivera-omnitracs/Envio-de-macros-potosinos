namespace Envio_de_macros
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtListaEconomicos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEconomico = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.cbMacros = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtListaEconomicos);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtEconomico);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinatarios";
            // 
            // txtListaEconomicos
            // 
            this.txtListaEconomicos.BackColor = System.Drawing.SystemColors.Control;
            this.txtListaEconomicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListaEconomicos.Enabled = false;
            this.txtListaEconomicos.Location = new System.Drawing.Point(162, 17);
            this.txtListaEconomicos.Multiline = true;
            this.txtListaEconomicos.Name = "txtListaEconomicos";
            this.txtListaEconomicos.Size = new System.Drawing.Size(201, 53);
            this.txtListaEconomicos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(135, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(21, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEconomico
            // 
            this.txtEconomico.Location = new System.Drawing.Point(7, 20);
            this.txtEconomico.Name = "txtEconomico";
            this.txtEconomico.Size = new System.Drawing.Size(121, 20);
            this.txtEconomico.TabIndex = 1;
            this.txtEconomico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEconomico_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnIr);
            this.groupBox2.Controls.Add(this.cbMacros);
            this.groupBox2.Location = new System.Drawing.Point(13, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciona una macro";
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(225, 17);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 1;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // cbMacros
            // 
            this.cbMacros.FormattingEnabled = true;
            this.cbMacros.Items.AddRange(new object[] {
            "**** SELECCIONA UNA OPCIÓN ****",
            "MACRO 42",
            "MACRO 43"});
            this.cbMacros.Location = new System.Drawing.Point(7, 19);
            this.cbMacros.Name = "cbMacros";
            this.cbMacros.Size = new System.Drawing.Size(212, 21);
            this.cbMacros.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 160);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtListaEconomicos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEconomico;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.ComboBox cbMacros;
    }
}

