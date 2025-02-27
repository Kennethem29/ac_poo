namespace uzuuchi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnumero2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.Sumar = new System.Windows.Forms.CheckBox();
            this.Restar = new System.Windows.Forms.CheckBox();
            this.Multiplicar = new System.Windows.Forms.CheckBox();
            this.Dividir = new System.Windows.Forms.CheckBox();
            this.Modulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero1";
            // 
            // tbnumero1
            // 
            this.tbnumero1.Location = new System.Drawing.Point(342, 106);
            this.tbnumero1.Name = "tbnumero1";
            this.tbnumero1.Size = new System.Drawing.Size(100, 20);
            this.tbnumero1.TabIndex = 2;
            this.tbnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbnumero2
            // 
            this.tbnumero2.Location = new System.Drawing.Point(342, 197);
            this.tbnumero2.Name = "tbnumero2";
            this.tbnumero2.Size = new System.Drawing.Size(100, 20);
            this.tbnumero2.TabIndex = 4;
            this.tbnumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(367, 369);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 49);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Sumar
            // 
            this.Sumar.AutoSize = true;
            this.Sumar.Location = new System.Drawing.Point(315, 250);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(32, 17);
            this.Sumar.TabIndex = 6;
            this.Sumar.Text = "+";
            this.Sumar.UseVisualStyleBackColor = true;
            // 
            // Restar
            // 
            this.Restar.AutoSize = true;
            this.Restar.Location = new System.Drawing.Point(425, 250);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(29, 17);
            this.Restar.TabIndex = 7;
            this.Restar.Text = "-";
            this.Restar.UseVisualStyleBackColor = true;
            // 
            // Multiplicar
            // 
            this.Multiplicar.AutoSize = true;
            this.Multiplicar.Location = new System.Drawing.Point(299, 294);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(30, 17);
            this.Multiplicar.TabIndex = 8;
            this.Multiplicar.Text = "*";
            this.Multiplicar.UseVisualStyleBackColor = true;
            // 
            // Dividir
            // 
            this.Dividir.AutoSize = true;
            this.Dividir.Location = new System.Drawing.Point(438, 294);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(31, 17);
            this.Dividir.TabIndex = 9;
            this.Dividir.Text = "/";
            this.Dividir.UseVisualStyleBackColor = true;
            // 
            // Modulo
            // 
            this.Modulo.AutoSize = true;
            this.Modulo.Location = new System.Drawing.Point(361, 330);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(34, 17);
            this.Modulo.TabIndex = 10;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(766, 442);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.tbnumero2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnumero2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.CheckBox Sumar;
        private System.Windows.Forms.CheckBox Restar;
        private System.Windows.Forms.CheckBox Multiplicar;
        private System.Windows.Forms.CheckBox Dividir;
        private System.Windows.Forms.CheckBox Modulo;
    }
}

