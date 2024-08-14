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
            this.lblIngresarNombre.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(81, 53);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(151, 19);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Location = new System.Drawing.Point(252, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(598, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // lbNombres1
            // 
            this.lbNombres1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbNombres1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres1.ForeColor = System.Drawing.Color.Green;
            this.lbNombres1.FormattingEnabled = true;
            this.lbNombres1.ItemHeight = 16;
            this.lbNombres1.Location = new System.Drawing.Point(85, 110);
            this.lbNombres1.Name = "lbNombres1";
            this.lbNombres1.Size = new System.Drawing.Size(183, 276);
            this.lbNombres1.Sorted = true;
            this.lbNombres1.TabIndex = 3;
            // 
            // lbNombres2
            // 
            this.lbNombres2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbNombres2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres2.ForeColor = System.Drawing.Color.Red;
            this.lbNombres2.FormattingEnabled = true;
            this.lbNombres2.ItemHeight = 16;
            this.lbNombres2.Location = new System.Drawing.Point(511, 110);
            this.lbNombres2.Name = "lbNombres2";
            this.lbNombres2.Size = new System.Drawing.Size(183, 276);
            this.lbNombres2.Sorted = true;
            this.lbNombres2.TabIndex = 4;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(366, 153);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseLeave += new System.EventHandler(this.btnRight_MouseLeave);
            this.btnRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseMove_1);
            // 
            // btnAll_Right
            // 
            this.btnAll_Right.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAll_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll_Right.Location = new System.Drawing.Point(366, 182);
            this.btnAll_Right.Name = "btnAll_Right";
            this.btnAll_Right.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Right.TabIndex = 6;
            this.btnAll_Right.Text = "> >";
            this.btnAll_Right.UseVisualStyleBackColor = false;
            this.btnAll_Right.Click += new System.EventHandler(this.btnAll_Right_Click);
            this.btnAll_Right.MouseLeave += new System.EventHandler(this.btnAll_Right_MouseLeave);
            this.btnAll_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_Right_MouseMove);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(366, 299);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseLeave += new System.EventHandler(this.btnLeft_MouseLeave);
            this.btnLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseMove);
            // 
            // btnAll_Left
            // 
            this.btnAll_Left.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAll_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll_Left.Location = new System.Drawing.Point(366, 328);
            this.btnAll_Left.Name = "btnAll_Left";
            this.btnAll_Left.Size = new System.Drawing.Size(75, 23);
            this.btnAll_Left.TabIndex = 8;
            this.btnAll_Left.Text = "<<";
            this.btnAll_Left.UseVisualStyleBackColor = false;
            this.btnAll_Left.Click += new System.EventHandler(this.btnAll_Left_Click);
            this.btnAll_Left.MouseLeave += new System.EventHandler(this.btnAll_Left_MouseLeave);
            this.btnAll_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_Left_MouseMove);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
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