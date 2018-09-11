namespace TP4BatallaNaval
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdb_automatico = new System.Windows.Forms.RadioButton();
            this.rdb_semiautomatico = new System.Windows.Forms.RadioButton();
            this.txt_cant_simulaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdb_automatico
            // 
            this.rdb_automatico.AutoSize = true;
            this.rdb_automatico.Location = new System.Drawing.Point(29, 16);
            this.rdb_automatico.Name = "rdb_automatico";
            this.rdb_automatico.Size = new System.Drawing.Size(78, 17);
            this.rdb_automatico.TabIndex = 1;
            this.rdb_automatico.TabStop = true;
            this.rdb_automatico.Text = "Automatico";
            this.rdb_automatico.UseVisualStyleBackColor = true;
            // 
            // rdb_semiautomatico
            // 
            this.rdb_semiautomatico.AutoSize = true;
            this.rdb_semiautomatico.Location = new System.Drawing.Point(29, 39);
            this.rdb_semiautomatico.Name = "rdb_semiautomatico";
            this.rdb_semiautomatico.Size = new System.Drawing.Size(104, 17);
            this.rdb_semiautomatico.TabIndex = 2;
            this.rdb_semiautomatico.TabStop = true;
            this.rdb_semiautomatico.Text = "Semi Automatico";
            this.rdb_semiautomatico.UseVisualStyleBackColor = true;
            // 
            // txt_cant_simulaciones
            // 
            this.txt_cant_simulaciones.Location = new System.Drawing.Point(207, 66);
            this.txt_cant_simulaciones.Name = "txt_cant_simulaciones";
            this.txt_cant_simulaciones.Size = new System.Drawing.Size(100, 20);
            this.txt_cant_simulaciones.TabIndex = 3;
            this.txt_cant_simulaciones.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de Simulaciones";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cant_simulaciones);
            this.Controls.Add(this.rdb_semiautomatico);
            this.Controls.Add(this.rdb_automatico);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdb_automatico;
        private System.Windows.Forms.RadioButton rdb_semiautomatico;
        private System.Windows.Forms.TextBox txt_cant_simulaciones;
        private System.Windows.Forms.Label label1;
    }
}