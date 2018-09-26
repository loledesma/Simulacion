namespace TP4BatallaNaval
{
    partial class Grafico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_tablero2 = new System.Windows.Forms.Label();
            this.lbl_tablero1 = new System.Windows.Forms.Label();
            this.tablero1 = new System.Windows.Forms.DataGridView();
            this.cb_avanzarmovs = new System.Windows.Forms.CheckBox();
            this.txt_cantmovs = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_cargar_barcos = new System.Windows.Forms.Button();
            this.tablero2 = new System.Windows.Forms.DataGridView();
            this.btn_estadistica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tablero2
            // 
            this.lbl_tablero2.AutoSize = true;
            this.lbl_tablero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tablero2.Location = new System.Drawing.Point(927, 9);
            this.lbl_tablero2.Name = "lbl_tablero2";
            this.lbl_tablero2.Size = new System.Drawing.Size(128, 13);
            this.lbl_tablero2.TabIndex = 13;
            this.lbl_tablero2.Text = "Tablero de Jugador 2";
            // 
            // lbl_tablero1
            // 
            this.lbl_tablero1.AutoSize = true;
            this.lbl_tablero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tablero1.Location = new System.Drawing.Point(268, 9);
            this.lbl_tablero1.Name = "lbl_tablero1";
            this.lbl_tablero1.Size = new System.Drawing.Size(128, 13);
            this.lbl_tablero1.TabIndex = 12;
            this.lbl_tablero1.Text = "Tablero de Jugador 1";
            // 
            // tablero1
            // 
            this.tablero1.AllowUserToAddRows = false;
            this.tablero1.AllowUserToDeleteRows = false;
            this.tablero1.AllowUserToResizeColumns = false;
            this.tablero1.AllowUserToResizeRows = false;
            this.tablero1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablero1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablero1.ColumnHeadersHeight = 10;
            this.tablero1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablero1.Location = new System.Drawing.Point(12, 30);
            this.tablero1.MultiSelect = false;
            this.tablero1.Name = "tablero1";
            this.tablero1.ReadOnly = true;
            this.tablero1.RowHeadersWidth = 10;
            this.tablero1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablero1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablero1.ShowEditingIcon = false;
            this.tablero1.Size = new System.Drawing.Size(653, 653);
            this.tablero1.TabIndex = 14;
            // 
            // cb_avanzarmovs
            // 
            this.cb_avanzarmovs.AutoSize = true;
            this.cb_avanzarmovs.Location = new System.Drawing.Point(338, 693);
            this.cb_avanzarmovs.Name = "cb_avanzarmovs";
            this.cb_avanzarmovs.Size = new System.Drawing.Size(127, 17);
            this.cb_avanzarmovs.TabIndex = 21;
            this.cb_avanzarmovs.Text = "Avanzar Movimientos";
            this.cb_avanzarmovs.UseVisualStyleBackColor = true;
            this.cb_avanzarmovs.CheckedChanged += new System.EventHandler(this.cb_avanzarmovs_CheckedChanged);
            // 
            // txt_cantmovs
            // 
            this.txt_cantmovs.Location = new System.Drawing.Point(471, 691);
            this.txt_cantmovs.Name = "txt_cantmovs";
            this.txt_cantmovs.Size = new System.Drawing.Size(50, 20);
            this.txt_cantmovs.TabIndex = 20;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1225, 689);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 25);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 689);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 25);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Limpiar Tablero";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(222, 689);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 25);
            this.btn_play.TabIndex = 17;
            this.btn_play.Text = "Jugar";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_cargar_barcos
            // 
            this.btn_cargar_barcos.Location = new System.Drawing.Point(117, 689);
            this.btn_cargar_barcos.Name = "btn_cargar_barcos";
            this.btn_cargar_barcos.Size = new System.Drawing.Size(100, 25);
            this.btn_cargar_barcos.TabIndex = 16;
            this.btn_cargar_barcos.Text = "Cargar Barcos";
            this.btn_cargar_barcos.UseVisualStyleBackColor = true;
            this.btn_cargar_barcos.Click += new System.EventHandler(this.btn_cargar_barcos_Click);
            // 
            // tablero2
            // 
            this.tablero2.AllowUserToAddRows = false;
            this.tablero2.AllowUserToDeleteRows = false;
            this.tablero2.AllowUserToResizeColumns = false;
            this.tablero2.AllowUserToResizeRows = false;
            this.tablero2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablero2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablero2.ColumnHeadersHeight = 10;
            this.tablero2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablero2.Location = new System.Drawing.Point(671, 30);
            this.tablero2.MultiSelect = false;
            this.tablero2.Name = "tablero2";
            this.tablero2.ReadOnly = true;
            this.tablero2.RowHeadersWidth = 10;
            this.tablero2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablero2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablero2.ShowEditingIcon = false;
            this.tablero2.Size = new System.Drawing.Size(653, 653);
            this.tablero2.TabIndex = 23;
            // 
            // btn_estadistica
            // 
            this.btn_estadistica.Location = new System.Drawing.Point(592, 689);
            this.btn_estadistica.Name = "btn_estadistica";
            this.btn_estadistica.Size = new System.Drawing.Size(150, 25);
            this.btn_estadistica.TabIndex = 24;
            this.btn_estadistica.Text = "Estadisticas del Juego";
            this.btn_estadistica.UseVisualStyleBackColor = true;
            this.btn_estadistica.Click += new System.EventHandler(this.btn_estadistica_Click);
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1336, 720);
            this.Controls.Add(this.btn_estadistica);
            this.Controls.Add(this.tablero2);
            this.Controls.Add(this.cb_avanzarmovs);
            this.Controls.Add(this.txt_cantmovs);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_cargar_barcos);
            this.Controls.Add(this.tablero1);
            this.Controls.Add(this.lbl_tablero2);
            this.Controls.Add(this.lbl_tablero1);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tablero2;
        private System.Windows.Forms.Label lbl_tablero1;
        private System.Windows.Forms.DataGridView tablero1;
        private System.Windows.Forms.CheckBox cb_avanzarmovs;
        private System.Windows.Forms.TextBox txt_cantmovs;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_cargar_barcos;
        private System.Windows.Forms.DataGridView tablero2;
        private System.Windows.Forms.Button btn_estadistica;
    }
}