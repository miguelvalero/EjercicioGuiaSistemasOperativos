namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.altura = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.numForm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(204, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(116, 91);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(166, 17);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(116, 119);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(98, 17);
            this.altura.TabIndex = 7;
            this.altura.TabStop = true;
            this.altura.Text = "Dime si soy alto";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura";
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(15, 110);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(62, 20);
            this.alturaBox.TabIndex = 9;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(116, 68);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(156, 17);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // numForm
            // 
            this.numForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numForm.Location = new System.Drawing.Point(30, 181);
            this.numForm.Name = "numForm";
            this.numForm.Size = new System.Drawing.Size(98, 92);
            this.numForm.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.numForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label numForm;
    }
}