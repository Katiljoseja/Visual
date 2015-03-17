namespace acierto
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numerador1 = new System.Windows.Forms.TextBox();
            this.numerador2 = new System.Windows.Forms.TextBox();
            this.denominador2 = new System.Windows.Forms.TextBox();
            this.deniminador1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.equivalente = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.acierto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numerador1
            // 
            this.numerador1.Location = new System.Drawing.Point(12, 59);
            this.numerador1.Name = "numerador1";
            this.numerador1.Size = new System.Drawing.Size(100, 20);
            this.numerador1.TabIndex = 0;
            this.numerador1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numerador2
            // 
            this.numerador2.Location = new System.Drawing.Point(206, 59);
            this.numerador2.Name = "numerador2";
            this.numerador2.Size = new System.Drawing.Size(100, 20);
            this.numerador2.TabIndex = 1;
            this.numerador2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // denominador2
            // 
            this.denominador2.Location = new System.Drawing.Point(206, 110);
            this.denominador2.Name = "denominador2";
            this.denominador2.Size = new System.Drawing.Size(100, 20);
            this.denominador2.TabIndex = 2;
            this.denominador2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // deniminador1
            // 
            this.deniminador1.Location = new System.Drawing.Point(12, 110);
            this.deniminador1.Name = "deniminador1";
            this.deniminador1.Size = new System.Drawing.Size(100, 20);
            this.deniminador1.TabIndex = 3;
            this.deniminador1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numerador 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denominador 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numerador 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Denominador 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(21, 149);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 49);
            this.multiplicar.TabIndex = 8;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(122, 149);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 49);
            this.dividir.TabIndex = 9;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.button2_Click);
            // 
            // equivalente
            // 
            this.equivalente.Location = new System.Drawing.Point(213, 149);
            this.equivalente.Name = "equivalente";
            this.equivalente.Size = new System.Drawing.Size(84, 49);
            this.equivalente.TabIndex = 10;
            this.equivalente.Text = "Equivalentes";
            this.equivalente.UseVisualStyleBackColor = true;
            this.equivalente.Click += new System.EventHandler(this.button3_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(222, 226);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 23);
            this.igual.TabIndex = 11;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.button4_Click);
            // 
            // acierto
            // 
            this.acierto.Location = new System.Drawing.Point(20, 229);
            this.acierto.Name = "acierto";
            this.acierto.Size = new System.Drawing.Size(75, 20);
            this.acierto.TabIndex = 12;
            this.acierto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "¿?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acierto);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.equivalente);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deniminador1);
            this.Controls.Add(this.denominador2);
            this.Controls.Add(this.numerador2);
            this.Controls.Add(this.numerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numerador1;
        private System.Windows.Forms.TextBox numerador2;
        private System.Windows.Forms.TextBox denominador2;
        private System.Windows.Forms.TextBox deniminador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button equivalente;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.TextBox acierto;
        private System.Windows.Forms.Label label5;
    }
}

