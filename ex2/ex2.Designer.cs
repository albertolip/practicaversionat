namespace ex2
{
    partial class ex2
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
            this.radioButton_boto1 = new System.Windows.Forms.RadioButton();
            this.radioButton_boto2 = new System.Windows.Forms.RadioButton();
            this.radioButton_boto3 = new System.Windows.Forms.RadioButton();
            this.label_text2 = new System.Windows.Forms.Label();
            this.checkBox_email = new System.Windows.Forms.CheckBox();
            this.checkBox_telefono = new System.Windows.Forms.CheckBox();
            this.checkBox_fax = new System.Windows.Forms.CheckBox();
            this.label_text1 = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_boto1
            // 
            this.radioButton_boto1.AutoSize = true;
            this.radioButton_boto1.Location = new System.Drawing.Point(46, 52);
            this.radioButton_boto1.Name = "radioButton_boto1";
            this.radioButton_boto1.Size = new System.Drawing.Size(135, 17);
            this.radioButton_boto1.TabIndex = 0;
            this.radioButton_boto1.TabStop = true;
            this.radioButton_boto1.Text = "Por correo normal (50€)";
            this.radioButton_boto1.UseVisualStyleBackColor = true;
            // 
            // radioButton_boto2
            // 
            this.radioButton_boto2.AutoSize = true;
            this.radioButton_boto2.Location = new System.Drawing.Point(46, 89);
            this.radioButton_boto2.Name = "radioButton_boto2";
            this.radioButton_boto2.Size = new System.Drawing.Size(161, 17);
            this.radioButton_boto2.TabIndex = 1;
            this.radioButton_boto2.TabStop = true;
            this.radioButton_boto2.Text = "Por paqueteria normal (100€)";
            this.radioButton_boto2.UseVisualStyleBackColor = true;
            // 
            // radioButton_boto3
            // 
            this.radioButton_boto3.AutoSize = true;
            this.radioButton_boto3.Location = new System.Drawing.Point(46, 126);
            this.radioButton_boto3.Name = "radioButton_boto3";
            this.radioButton_boto3.Size = new System.Drawing.Size(166, 17);
            this.radioButton_boto3.TabIndex = 2;
            this.radioButton_boto3.TabStop = true;
            this.radioButton_boto3.Text = "Por paqueteria urgente (150€)";
            this.radioButton_boto3.UseVisualStyleBackColor = true;
            // 
            // label_text2
            // 
            this.label_text2.AutoSize = true;
            this.label_text2.Location = new System.Drawing.Point(43, 160);
            this.label_text2.Name = "label_text2";
            this.label_text2.Size = new System.Drawing.Size(349, 13);
            this.label_text2.TabIndex = 3;
            this.label_text2.Text = "Como desea ser notificado del envio? (Marcar todas las que se apliquen)";
            // 
            // checkBox_email
            // 
            this.checkBox_email.AutoSize = true;
            this.checkBox_email.Location = new System.Drawing.Point(46, 193);
            this.checkBox_email.Name = "checkBox_email";
            this.checkBox_email.Size = new System.Drawing.Size(91, 17);
            this.checkBox_email.TabIndex = 4;
            this.checkBox_email.Text = "Por Email (5€)";
            this.checkBox_email.UseVisualStyleBackColor = true;
            // 
            // checkBox_telefono
            // 
            this.checkBox_telefono.AutoSize = true;
            this.checkBox_telefono.Location = new System.Drawing.Point(46, 226);
            this.checkBox_telefono.Name = "checkBox_telefono";
            this.checkBox_telefono.Size = new System.Drawing.Size(114, 17);
            this.checkBox_telefono.TabIndex = 5;
            this.checkBox_telefono.Text = "Por Telefono (15€)";
            this.checkBox_telefono.UseVisualStyleBackColor = true;
            // 
            // checkBox_fax
            // 
            this.checkBox_fax.AutoSize = true;
            this.checkBox_fax.Location = new System.Drawing.Point(46, 259);
            this.checkBox_fax.Name = "checkBox_fax";
            this.checkBox_fax.Size = new System.Drawing.Size(89, 17);
            this.checkBox_fax.TabIndex = 6;
            this.checkBox_fax.Text = "Por Fax (20€)";
            this.checkBox_fax.UseVisualStyleBackColor = true;
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.Location = new System.Drawing.Point(43, 27);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(349, 13);
            this.label_text1.TabIndex = 7;
            this.label_text1.Text = "Como desea ser notificado del envio? (Marcar todas las que se apliquen)";
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(87, 282);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(261, 23);
            this.button_calcular.TabIndex = 8;
            this.button_calcular.Text = "Calcular Gastos De Envio";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_calcular_MouseClick);
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 328);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.checkBox_fax);
            this.Controls.Add(this.checkBox_telefono);
            this.Controls.Add(this.checkBox_email);
            this.Controls.Add(this.label_text2);
            this.Controls.Add(this.radioButton_boto3);
            this.Controls.Add(this.radioButton_boto2);
            this.Controls.Add(this.radioButton_boto1);
            this.Name = "ex2";
            this.Text = "Detalles Del Envio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_boto1;
        private System.Windows.Forms.RadioButton radioButton_boto2;
        private System.Windows.Forms.RadioButton radioButton_boto3;
        private System.Windows.Forms.Label label_text2;
        private System.Windows.Forms.CheckBox checkBox_email;
        private System.Windows.Forms.CheckBox checkBox_telefono;
        private System.Windows.Forms.CheckBox checkBox_fax;
        private System.Windows.Forms.Label label_text1;
        private System.Windows.Forms.Button button_calcular;
    }
}

