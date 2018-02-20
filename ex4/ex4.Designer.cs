namespace ex4
{
    partial class ex4
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
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.button_suma = new System.Windows.Forms.Button();
            this.button_resta = new System.Windows.Forms.Button();
            this.button_divisio = new System.Windows.Forms.Button();
            this.button_multiplicacio = new System.Windows.Forms.Button();
            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.label_valor1 = new System.Windows.Forms.Label();
            this.label_valor2 = new System.Windows.Forms.Label();
            this.label_resultat = new System.Windows.Forms.Label();
            this.button_neteja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(76, 121);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor1.TabIndex = 0;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(76, 188);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor2.TabIndex = 1;
            // 
            // button_suma
            // 
            this.button_suma.BackColor = System.Drawing.SystemColors.Menu;
            this.button_suma.BackgroundImage = global::ex4.Properties.Resources.doge_600;
            this.button_suma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suma.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_suma.Location = new System.Drawing.Point(206, 70);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(114, 43);
            this.button_suma.TabIndex = 2;
            this.button_suma.Text = "Suma";
            this.button_suma.UseVisualStyleBackColor = false;
            this.button_suma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_suma_MouseClick);
            // 
            // button_resta
            // 
            this.button_resta.BackgroundImage = global::ex4.Properties.Resources.doge_600;
            this.button_resta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_resta.Location = new System.Drawing.Point(206, 121);
            this.button_resta.Name = "button_resta";
            this.button_resta.Size = new System.Drawing.Size(114, 40);
            this.button_resta.TabIndex = 3;
            this.button_resta.Text = "Resta";
            this.button_resta.UseVisualStyleBackColor = true;
            this.button_resta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_resta_MouseClick);
            // 
            // button_divisio
            // 
            this.button_divisio.BackgroundImage = global::ex4.Properties.Resources.doge_600;
            this.button_divisio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_divisio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divisio.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_divisio.Location = new System.Drawing.Point(206, 167);
            this.button_divisio.Name = "button_divisio";
            this.button_divisio.Size = new System.Drawing.Size(114, 41);
            this.button_divisio.TabIndex = 4;
            this.button_divisio.Text = "Divisio";
            this.button_divisio.UseVisualStyleBackColor = true;
            this.button_divisio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_divisio_MouseClick);
            // 
            // button_multiplicacio
            // 
            this.button_multiplicacio.BackgroundImage = global::ex4.Properties.Resources.doge_600;
            this.button_multiplicacio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_multiplicacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplicacio.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_multiplicacio.Location = new System.Drawing.Point(206, 216);
            this.button_multiplicacio.Name = "button_multiplicacio";
            this.button_multiplicacio.Size = new System.Drawing.Size(114, 43);
            this.button_multiplicacio.TabIndex = 5;
            this.button_multiplicacio.Text = "Multiplicació";
            this.button_multiplicacio.UseVisualStyleBackColor = true;
            this.button_multiplicacio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_multiplicacio_MouseClick);
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resultat.Location = new System.Drawing.Point(451, 147);
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.ReadOnly = true;
            this.textBox_resultat.Size = new System.Drawing.Size(92, 26);
            this.textBox_resultat.TabIndex = 6;
            // 
            // label_valor1
            // 
            this.label_valor1.AutoSize = true;
            this.label_valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor1.Location = new System.Drawing.Point(73, 97);
            this.label_valor1.Name = "label_valor1";
            this.label_valor1.Size = new System.Drawing.Size(87, 16);
            this.label_valor1.TabIndex = 7;
            this.label_valor1.Text = "Entra Valor 1 ";
            // 
            // label_valor2
            // 
            this.label_valor2.AutoSize = true;
            this.label_valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor2.Location = new System.Drawing.Point(73, 167);
            this.label_valor2.Name = "label_valor2";
            this.label_valor2.Size = new System.Drawing.Size(84, 16);
            this.label_valor2.TabIndex = 8;
            this.label_valor2.Text = "Entra Valor 2";
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultat.Location = new System.Drawing.Point(343, 150);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(102, 16);
            this.label_resultat.TabIndex = 9;
            this.label_resultat.Text = "El resultat és -->";
            // 
            // button_neteja
            // 
            this.button_neteja.Location = new System.Drawing.Point(346, 292);
            this.button_neteja.Name = "button_neteja";
            this.button_neteja.Size = new System.Drawing.Size(197, 25);
            this.button_neteja.TabIndex = 10;
            this.button_neteja.Text = "Neteja";
            this.button_neteja.UseVisualStyleBackColor = true;
            this.button_neteja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_neteja_MouseClick);
            // 
            // ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.button_neteja);
            this.Controls.Add(this.label_resultat);
            this.Controls.Add(this.label_valor2);
            this.Controls.Add(this.label_valor1);
            this.Controls.Add(this.textBox_resultat);
            this.Controls.Add(this.button_multiplicacio);
            this.Controls.Add(this.button_divisio);
            this.Controls.Add(this.button_resta);
            this.Controls.Add(this.button_suma);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Name = "ex4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.Button button_resta;
        private System.Windows.Forms.Button button_divisio;
        private System.Windows.Forms.Button button_multiplicacio;
        private System.Windows.Forms.TextBox textBox_resultat;
        private System.Windows.Forms.Label label_valor1;
        private System.Windows.Forms.Label label_valor2;
        private System.Windows.Forms.Label label_resultat;
        private System.Windows.Forms.Button button_neteja;
    }
}

