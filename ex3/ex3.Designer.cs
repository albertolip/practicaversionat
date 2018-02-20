namespace ex3
{
    partial class ex3
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
            this.textBox_suma = new System.Windows.Forms.TextBox();
            this.label_text1 = new System.Windows.Forms.Label();
            this.checkBox_resultatsparcials = new System.Windows.Forms.CheckBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.listBox_valors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_suma
            // 
            this.textBox_suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_suma.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_suma.Location = new System.Drawing.Point(280, 44);
            this.textBox_suma.Name = "textBox_suma";
            this.textBox_suma.Size = new System.Drawing.Size(100, 20);
            this.textBox_suma.TabIndex = 0;
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_text1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label_text1.Location = new System.Drawing.Point(123, 47);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(151, 13);
            this.label_text1.TabIndex = 1;
            this.label_text1.Text = "Calcular Suma desde 1 hasta: ";
            // 
            // checkBox_resultatsparcials
            // 
            this.checkBox_resultatsparcials.AutoSize = true;
            this.checkBox_resultatsparcials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_resultatsparcials.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.checkBox_resultatsparcials.Location = new System.Drawing.Point(130, 88);
            this.checkBox_resultatsparcials.Name = "checkBox_resultatsparcials";
            this.checkBox_resultatsparcials.Size = new System.Drawing.Size(144, 17);
            this.checkBox_resultatsparcials.TabIndex = 2;
            this.checkBox_resultatsparcials.Text = "Ver Resultados Parciales";
            this.checkBox_resultatsparcials.UseVisualStyleBackColor = false;
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_calcular.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button_calcular.Location = new System.Drawing.Point(191, 323);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(142, 27);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_calcular_MouseClick);
            // 
            // listBox_valors
            // 
            this.listBox_valors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_valors.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.listBox_valors.FormattingEnabled = true;
            this.listBox_valors.Location = new System.Drawing.Point(126, 135);
            this.listBox_valors.Name = "listBox_valors";
            this.listBox_valors.Size = new System.Drawing.Size(254, 173);
            this.listBox_valors.TabIndex = 5;
            // 
            // ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ex3.Properties.Resources.meme;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.Controls.Add(this.listBox_valors);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.checkBox_resultatsparcials);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.textBox_suma);
            this.Name = "ex3";
            this.Text = "EX3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_suma;
        private System.Windows.Forms.Label label_text1;
        private System.Windows.Forms.CheckBox checkBox_resultatsparcials;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.ListBox listBox_valors;
    }
}

