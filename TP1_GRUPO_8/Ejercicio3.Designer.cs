namespace TP1_GRUPO_8
{
    partial class Ejercicio3
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
            this.clbOficio = new System.Windows.Forms.CheckedListBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.gbOficios = new System.Windows.Forms.GroupBox();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.gbOficios.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbOficio
            // 
            this.clbOficio.AccessibleName = "";
            this.clbOficio.BackColor = System.Drawing.SystemColors.Info;
            this.clbOficio.CheckOnClick = true;
            this.clbOficio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbOficio.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbOficio.FormattingEnabled = true;
            this.clbOficio.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficio.Location = new System.Drawing.Point(7, 23);
            this.clbOficio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbOficio.Name = "clbOficio";
            this.clbOficio.Size = new System.Drawing.Size(251, 94);
            this.clbOficio.TabIndex = 0;
            this.clbOficio.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.LightGray;
            this.btnSeleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.ForeColor = System.Drawing.Color.DimGray;
            this.btnSeleccion.Location = new System.Drawing.Point(227, 228);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(299, 43);
            this.btnSeleccion.TabIndex = 4;
            this.btnSeleccion.Text = "Mostrar lo que se seleccionó";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            this.btnSeleccion.MouseLeave += new System.EventHandler(this.btnSeleccion_MouseLeave);
            this.btnSeleccion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSeleccion_MouseMove);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(61, 12);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbSexo.Size = new System.Drawing.Size(129, 108);
            this.gbSexo.TabIndex = 8;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            this.gbSexo.Enter += new System.EventHandler(this.gbSexo_Enter);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMasculino.Location = new System.Drawing.Point(10, 64);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(100, 23);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemenino.Location = new System.Drawing.Point(10, 39);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(99, 23);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstadoCivil.Location = new System.Drawing.Point(576, 12);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEstadoCivil.Size = new System.Drawing.Size(134, 108);
            this.gbEstadoCivil.TabIndex = 9;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSoltero.Location = new System.Drawing.Point(8, 64);
            this.rbSoltero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(81, 23);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCasado.Location = new System.Drawing.Point(8, 39);
            this.rbCasado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(81, 23);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(237, 304);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(0, 19);
            this.lblSeleccion.TabIndex = 10;
            // 
            // gbOficios
            // 
            this.gbOficios.Controls.Add(this.clbOficio);
            this.gbOficios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOficios.Location = new System.Drawing.Point(241, 76);
            this.gbOficios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOficios.Name = "gbOficios";
            this.gbOficios.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOficios.Size = new System.Drawing.Size(270, 132);
            this.gbOficios.TabIndex = 11;
            this.gbOficios.TabStop = false;
            this.gbOficios.Text = "Oficios";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(789, 520);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.gbOficios);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.gbOficios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbOficio;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.GroupBox gbOficios;
    }
}