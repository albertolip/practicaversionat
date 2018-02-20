namespace FormP2
{
    partial class ex0
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
            this.label_valor1 = new System.Windows.Forms.Label();
            this.label_valor2 = new System.Windows.Forms.Label();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.button_suma = new System.Windows.Forms.Button();
            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_valor1
            // 
            this.label_valor1.AutoSize = true;
            this.label_valor1.Location = new System.Drawing.Point(83, 78);
            this.label_valor1.Name = "label_valor1";
            this.label_valor1.Size = new System.Drawing.Size(40, 13);
            this.label_valor1.TabIndex = 0;
            this.label_valor1.Text = "Valor 1";
            // 
            // label_valor2
            // 
            this.label_valor2.AutoSize = true;
            this.label_valor2.Location = new System.Drawing.Point(83, 153);
            this.label_valor2.Name = "label_valor2";
            this.label_valor2.Size = new System.Drawing.Size(40, 13);
            this.label_valor2.TabIndex = 1;
            this.label_valor2.Text = "Valor 2";
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(187, 71);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor1.TabIndex = 2;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(187, 150);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor2.TabIndex = 3;
            // 
            // button_suma
            // 
            this.button_suma.Location = new System.Drawing.Point(86, 214);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(125, 40);
            this.button_suma.TabIndex = 4;
            this.button_suma.Text = "Sumar";
            this.button_suma.UseVisualStyleBackColor = true;
            this.button_suma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_suma_MouseClick);
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.Location = new System.Drawing.Point(86, 273);
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.ReadOnly = true;
            this.textBox_resultat.Size = new System.Drawing.Size(125, 20);
            this.textBox_resultat.TabIndex = 5;
            // 
            // ex0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormP2.Properties.Resources.uganda;
            this.ClientSize = new System.Drawing.Size(591, 474);
            this.Controls.Add(this.textBox_resultat);
            this.Controls.Add(this.button_suma);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.label_valor2);
            this.Controls.Add(this.label_valor1);
            this.Name = "ex0";
            this.Text = "EX0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_valor1;
        private System.Windows.Forms.Label label_valor2;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.TextBox textBox_resultat;
    }
}

