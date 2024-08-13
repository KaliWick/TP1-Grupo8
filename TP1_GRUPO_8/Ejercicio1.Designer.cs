namespace TP1_GRUPO_8
{
    partial class Ejercicio1
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
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombres1 = new System.Windows.Forms.ListBox();
            this.lbNombres2 = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnAll_Right = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAll_Left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(81, 71);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(165, 20);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(619, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 21);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres1
            // 
            this.lbNombres1.FormattingEnabled = true;
            this.lbNombres1.Location = new System.Drawing.Point(85, 110);
            this.lbNombres1.Name = "lbNombres1";
            this.lbNombres1.Size = new System.Drawing.Size(183, 290);
            this.lbNombres1.TabIndex = 3;
            // 
            // lbNombres2
            // 
            this.lbNombres2.FormattingEnabled = true;
            this.lbNombres2.Location = new System.Drawing.Point(511, 110);
            this.lbNombres2.Name = "lbNombres2";
            this.lbNombres2.Size = new System.Drawing.Size(183, 290);
            this.lbNombres2.TabIndex = 4;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(366, 153);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnAll_Right
            // 
            this.btnAll_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll_Right.Location = new System.Drawing.Point(366, 182);
            this.btnAll_Right.Name = "btnAll_Right";
            this.btnAll_Right.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Right.TabIndex = 6;
            this.btnAll_Right.Text = "> >";
            this.btnAll_Right.UseVisualStyleBackColor = true;
            this.btnAll_Right.Click += new System.EventHandler(this.btnAll_Right_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(366, 299);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAll_Left
            // 
            this.btnAll_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll_Left.Location = new System.Drawing.Point(366, 328);
            this.btnAll_Left.Name = "btnAll_Left";
            this.btnAll_Left.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Left.TabIndex = 8;
            this.btnAll_Left.Text = "<<";
            this.btnAll_Left.UseVisualStyleBackColor = true;
            this.btnAll_Left.Click += new System.EventHandler(this.btnAll_Left_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAll_Left);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnAll_Right);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbNombres2);
            this.Controls.Add(this.lbNombres1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngresarNombre);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombres1;
        private System.Windows.Forms.ListBox lbNombres2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnAll_Right;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAll_Left;
    }
}