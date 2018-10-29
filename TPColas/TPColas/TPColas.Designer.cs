﻿namespace TPColas
{
    partial class TPColas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TPColas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_actual = new System.Windows.Forms.GroupBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.gb_datos_iniciales = new System.Windows.Forms.GroupBox();
            this.gb_recalibracion = new System.Windows.Forms.GroupBox();
            this.txt_recalibracion_varianza = new System.Windows.Forms.TextBox();
            this.lbl_recalibracion_varianza = new System.Windows.Forms.Label();
            this.txt_recalibracion_media = new System.Windows.Forms.TextBox();
            this.lbl_recalibracion_media = new System.Windows.Forms.Label();
            this.gb_darsenas = new System.Windows.Forms.GroupBox();
            this.txt_darsenas_b = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_b = new System.Windows.Forms.Label();
            this.txt_darsenas_a = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_a = new System.Windows.Forms.Label();
            this.gb_balanza = new System.Windows.Forms.GroupBox();
            this.txt_balanza_b = new System.Windows.Forms.TextBox();
            this.lbl_balanza_b = new System.Windows.Forms.Label();
            this.txt_balanza_a = new System.Windows.Forms.TextBox();
            this.lbl_balanza_a = new System.Windows.Forms.Label();
            this.gb_recepcion = new System.Windows.Forms.GroupBox();
            this.txt_recepcion_b = new System.Windows.Forms.TextBox();
            this.lbl_recepcion_b = new System.Windows.Forms.Label();
            this.txt_recepcion_a = new System.Windows.Forms.TextBox();
            this.lbl_recepcion_a = new System.Windows.Forms.Label();
            this.gb_llegadas = new System.Windows.Forms.GroupBox();
            this.txt_llegadas_lambda = new System.Windows.Forms.TextBox();
            this.lbl_llegadas_lambda = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.rb_estrategia_b = new System.Windows.Forms.RadioButton();
            this.rb_estrategia_a = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_estrategias = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_permanencia_b = new System.Windows.Forms.TextBox();
            this.txt_permanencia_a = new System.Windows.Forms.TextBox();
            this.lbl_permanencia = new System.Windows.Forms.Label();
            this.txt_no_atendidos_b = new System.Windows.Forms.TextBox();
            this.txt_no_atendidos_a = new System.Windows.Forms.TextBox();
            this.lbl_no_atendidos = new System.Windows.Forms.Label();
            this.txt_atendidos_b = new System.Windows.Forms.TextBox();
            this.txt_atendidos_a = new System.Windows.Forms.TextBox();
            this.lbl_atendidos = new System.Windows.Forms.Label();
            this.dgv_simulaciones = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_darsenas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_atendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin_atender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_actual.SuspendLayout();
            this.gb_datos_iniciales.SuspendLayout();
            this.gb_recalibracion.SuspendLayout();
            this.gb_darsenas.SuspendLayout();
            this.gb_balanza.SuspendLayout();
            this.gb_recepcion.SuspendLayout();
            this.gb_llegadas.SuspendLayout();
            this.gb_estrategias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_actual
            // 
            this.gb_actual.Controls.Add(this.txt_evento);
            this.gb_actual.Controls.Add(this.txt_hora);
            this.gb_actual.Controls.Add(this.txt_dia);
            this.gb_actual.Controls.Add(this.lbl_evento);
            this.gb_actual.Controls.Add(this.lbl_hora);
            this.gb_actual.Controls.Add(this.lbl_dia);
            this.gb_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_actual.Location = new System.Drawing.Point(944, 12);
            this.gb_actual.Name = "gb_actual";
            this.gb_actual.Size = new System.Drawing.Size(155, 114);
            this.gb_actual.TabIndex = 14;
            this.gb_actual.TabStop = false;
            this.gb_actual.Text = "Simulación:";
            // 
            // txt_evento
            // 
            this.txt_evento.CausesValidation = false;
            this.txt_evento.Enabled = false;
            this.txt_evento.Location = new System.Drawing.Point(50, 80);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.ReadOnly = true;
            this.txt_evento.Size = new System.Drawing.Size(89, 20);
            this.txt_evento.TabIndex = 5;
            // 
            // txt_hora
            // 
            this.txt_hora.CausesValidation = false;
            this.txt_hora.Enabled = false;
            this.txt_hora.Location = new System.Drawing.Point(50, 50);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.ReadOnly = true;
            this.txt_hora.Size = new System.Drawing.Size(84, 20);
            this.txt_hora.TabIndex = 4;
            // 
            // txt_dia
            // 
            this.txt_dia.CausesValidation = false;
            this.txt_dia.Enabled = false;
            this.txt_dia.Location = new System.Drawing.Point(50, 23);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.ReadOnly = true;
            this.txt_dia.Size = new System.Drawing.Size(37, 20);
            this.txt_dia.TabIndex = 3;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(6, 84);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(51, 13);
            this.lbl_evento.TabIndex = 2;
            this.lbl_evento.Text = "Evento:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(6, 53);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(38, 13);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora:";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(6, 30);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(32, 13);
            this.lbl_dia.TabIndex = 0;
            this.lbl_dia.Text = "Día:";
            // 
            // gb_datos_iniciales
            // 
            this.gb_datos_iniciales.Controls.Add(this.gb_recalibracion);
            this.gb_datos_iniciales.Controls.Add(this.gb_darsenas);
            this.gb_datos_iniciales.Controls.Add(this.gb_balanza);
            this.gb_datos_iniciales.Controls.Add(this.gb_recepcion);
            this.gb_datos_iniciales.Controls.Add(this.gb_llegadas);
            this.gb_datos_iniciales.Controls.Add(this.txt_hasta);
            this.gb_datos_iniciales.Controls.Add(this.txt_desde);
            this.gb_datos_iniciales.Controls.Add(this.txt_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_hasta);
            this.gb_datos_iniciales.Controls.Add(this.lbl_desde);
            this.gb_datos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_iniciales.Location = new System.Drawing.Point(12, 12);
            this.gb_datos_iniciales.Name = "gb_datos_iniciales";
            this.gb_datos_iniciales.Size = new System.Drawing.Size(926, 114);
            this.gb_datos_iniciales.TabIndex = 15;
            this.gb_datos_iniciales.TabStop = false;
            this.gb_datos_iniciales.Text = "Datos Iniciales:";
            // 
            // gb_recalibracion
            // 
            this.gb_recalibracion.Controls.Add(this.txt_recalibracion_varianza);
            this.gb_recalibracion.Controls.Add(this.lbl_recalibracion_varianza);
            this.gb_recalibracion.Controls.Add(this.txt_recalibracion_media);
            this.gb_recalibracion.Controls.Add(this.lbl_recalibracion_media);
            this.gb_recalibracion.Location = new System.Drawing.Point(795, 19);
            this.gb_recalibracion.Name = "gb_recalibracion";
            this.gb_recalibracion.Size = new System.Drawing.Size(125, 85);
            this.gb_recalibracion.TabIndex = 17;
            this.gb_recalibracion.TabStop = false;
            this.gb_recalibracion.Text = "Recalibración:";
            // 
            // txt_recalibracion_varianza
            // 
            this.txt_recalibracion_varianza.Location = new System.Drawing.Point(71, 48);
            this.txt_recalibracion_varianza.Name = "txt_recalibracion_varianza";
            this.txt_recalibracion_varianza.Size = new System.Drawing.Size(37, 20);
            this.txt_recalibracion_varianza.TabIndex = 3;
            this.txt_recalibracion_varianza.Text = "1.2";
            // 
            // lbl_recalibracion_varianza
            // 
            this.lbl_recalibracion_varianza.AutoSize = true;
            this.lbl_recalibracion_varianza.Location = new System.Drawing.Point(17, 51);
            this.lbl_recalibracion_varianza.Name = "lbl_recalibracion_varianza";
            this.lbl_recalibracion_varianza.Size = new System.Drawing.Size(60, 13);
            this.lbl_recalibracion_varianza.TabIndex = 2;
            this.lbl_recalibracion_varianza.Text = "Varianza:";
            // 
            // txt_recalibracion_media
            // 
            this.txt_recalibracion_media.Location = new System.Drawing.Point(71, 22);
            this.txt_recalibracion_media.Name = "txt_recalibracion_media";
            this.txt_recalibracion_media.Size = new System.Drawing.Size(37, 20);
            this.txt_recalibracion_media.TabIndex = 1;
            this.txt_recalibracion_media.Text = "10";
            // 
            // lbl_recalibracion_media
            // 
            this.lbl_recalibracion_media.AutoSize = true;
            this.lbl_recalibracion_media.Location = new System.Drawing.Point(17, 25);
            this.lbl_recalibracion_media.Name = "lbl_recalibracion_media";
            this.lbl_recalibracion_media.Size = new System.Drawing.Size(45, 13);
            this.lbl_recalibracion_media.TabIndex = 0;
            this.lbl_recalibracion_media.Text = "Media:";
            // 
            // gb_darsenas
            // 
            this.gb_darsenas.Controls.Add(this.txt_darsenas_b);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_b);
            this.gb_darsenas.Controls.Add(this.txt_darsenas_a);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_a);
            this.gb_darsenas.Location = new System.Drawing.Point(652, 19);
            this.gb_darsenas.Name = "gb_darsenas";
            this.gb_darsenas.Size = new System.Drawing.Size(125, 85);
            this.gb_darsenas.TabIndex = 16;
            this.gb_darsenas.TabStop = false;
            this.gb_darsenas.Text = "Dársenas:";
            // 
            // txt_darsenas_b
            // 
            this.txt_darsenas_b.Location = new System.Drawing.Point(71, 48);
            this.txt_darsenas_b.Name = "txt_darsenas_b";
            this.txt_darsenas_b.Size = new System.Drawing.Size(37, 20);
            this.txt_darsenas_b.TabIndex = 3;
            this.txt_darsenas_b.Text = "25";
            // 
            // lbl_darsenas_b
            // 
            this.lbl_darsenas_b.AutoSize = true;
            this.lbl_darsenas_b.Location = new System.Drawing.Point(17, 51);
            this.lbl_darsenas_b.Name = "lbl_darsenas_b";
            this.lbl_darsenas_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_b.TabIndex = 2;
            this.lbl_darsenas_b.Text = "B:";
            // 
            // txt_darsenas_a
            // 
            this.txt_darsenas_a.Location = new System.Drawing.Point(71, 22);
            this.txt_darsenas_a.Name = "txt_darsenas_a";
            this.txt_darsenas_a.Size = new System.Drawing.Size(37, 20);
            this.txt_darsenas_a.TabIndex = 1;
            this.txt_darsenas_a.Text = "20";
            // 
            // lbl_darsenas_a
            // 
            this.lbl_darsenas_a.AutoSize = true;
            this.lbl_darsenas_a.Location = new System.Drawing.Point(17, 25);
            this.lbl_darsenas_a.Name = "lbl_darsenas_a";
            this.lbl_darsenas_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_a.TabIndex = 0;
            this.lbl_darsenas_a.Text = "A:";
            // 
            // gb_balanza
            // 
            this.gb_balanza.Controls.Add(this.txt_balanza_b);
            this.gb_balanza.Controls.Add(this.lbl_balanza_b);
            this.gb_balanza.Controls.Add(this.txt_balanza_a);
            this.gb_balanza.Controls.Add(this.lbl_balanza_a);
            this.gb_balanza.Location = new System.Drawing.Point(504, 19);
            this.gb_balanza.Name = "gb_balanza";
            this.gb_balanza.Size = new System.Drawing.Size(125, 85);
            this.gb_balanza.TabIndex = 8;
            this.gb_balanza.TabStop = false;
            this.gb_balanza.Text = "Pesado:";
            // 
            // txt_balanza_b
            // 
            this.txt_balanza_b.Location = new System.Drawing.Point(71, 48);
            this.txt_balanza_b.Name = "txt_balanza_b";
            this.txt_balanza_b.Size = new System.Drawing.Size(37, 20);
            this.txt_balanza_b.TabIndex = 3;
            this.txt_balanza_b.Text = "7";
            // 
            // lbl_balanza_b
            // 
            this.lbl_balanza_b.AutoSize = true;
            this.lbl_balanza_b.Location = new System.Drawing.Point(17, 51);
            this.lbl_balanza_b.Name = "lbl_balanza_b";
            this.lbl_balanza_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_b.TabIndex = 2;
            this.lbl_balanza_b.Text = "B:";
            // 
            // txt_balanza_a
            // 
            this.txt_balanza_a.Location = new System.Drawing.Point(71, 22);
            this.txt_balanza_a.Name = "txt_balanza_a";
            this.txt_balanza_a.Size = new System.Drawing.Size(37, 20);
            this.txt_balanza_a.TabIndex = 1;
            this.txt_balanza_a.Text = "5";
            // 
            // lbl_balanza_a
            // 
            this.lbl_balanza_a.AutoSize = true;
            this.lbl_balanza_a.Location = new System.Drawing.Point(17, 25);
            this.lbl_balanza_a.Name = "lbl_balanza_a";
            this.lbl_balanza_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_a.TabIndex = 0;
            this.lbl_balanza_a.Text = "A:";
            // 
            // gb_recepcion
            // 
            this.gb_recepcion.Controls.Add(this.txt_recepcion_b);
            this.gb_recepcion.Controls.Add(this.lbl_recepcion_b);
            this.gb_recepcion.Controls.Add(this.txt_recepcion_a);
            this.gb_recepcion.Controls.Add(this.lbl_recepcion_a);
            this.gb_recepcion.Location = new System.Drawing.Point(339, 19);
            this.gb_recepcion.Name = "gb_recepcion";
            this.gb_recepcion.Size = new System.Drawing.Size(148, 85);
            this.gb_recepcion.TabIndex = 7;
            this.gb_recepcion.TabStop = false;
            this.gb_recepcion.Text = "Recepción de camiones:";
            // 
            // txt_recepcion_b
            // 
            this.txt_recepcion_b.Location = new System.Drawing.Point(71, 48);
            this.txt_recepcion_b.Name = "txt_recepcion_b";
            this.txt_recepcion_b.Size = new System.Drawing.Size(37, 20);
            this.txt_recepcion_b.TabIndex = 3;
            this.txt_recepcion_b.Text = "7";
            // 
            // lbl_recepcion_b
            // 
            this.lbl_recepcion_b.AutoSize = true;
            this.lbl_recepcion_b.Location = new System.Drawing.Point(17, 51);
            this.lbl_recepcion_b.Name = "lbl_recepcion_b";
            this.lbl_recepcion_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_recepcion_b.TabIndex = 2;
            this.lbl_recepcion_b.Text = "B:";
            // 
            // txt_recepcion_a
            // 
            this.txt_recepcion_a.Location = new System.Drawing.Point(71, 22);
            this.txt_recepcion_a.Name = "txt_recepcion_a";
            this.txt_recepcion_a.Size = new System.Drawing.Size(37, 20);
            this.txt_recepcion_a.TabIndex = 1;
            this.txt_recepcion_a.Text = "3";
            // 
            // lbl_recepcion_a
            // 
            this.lbl_recepcion_a.AutoSize = true;
            this.lbl_recepcion_a.Location = new System.Drawing.Point(17, 25);
            this.lbl_recepcion_a.Name = "lbl_recepcion_a";
            this.lbl_recepcion_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_recepcion_a.TabIndex = 0;
            this.lbl_recepcion_a.Text = "A:";
            // 
            // gb_llegadas
            // 
            this.gb_llegadas.Controls.Add(this.txt_llegadas_lambda);
            this.gb_llegadas.Controls.Add(this.lbl_llegadas_lambda);
            this.gb_llegadas.Location = new System.Drawing.Point(196, 19);
            this.gb_llegadas.Name = "gb_llegadas";
            this.gb_llegadas.Size = new System.Drawing.Size(137, 85);
            this.gb_llegadas.TabIndex = 6;
            this.gb_llegadas.TabStop = false;
            this.gb_llegadas.Text = "Llegadas (A):";
            // 
            // txt_llegadas_lambda
            // 
            this.txt_llegadas_lambda.Location = new System.Drawing.Point(71, 22);
            this.txt_llegadas_lambda.Name = "txt_llegadas_lambda";
            this.txt_llegadas_lambda.Size = new System.Drawing.Size(37, 20);
            this.txt_llegadas_lambda.TabIndex = 1;
            this.txt_llegadas_lambda.Text = "7.5";
            // 
            // lbl_llegadas_lambda
            // 
            this.lbl_llegadas_lambda.AutoSize = true;
            this.lbl_llegadas_lambda.Location = new System.Drawing.Point(17, 25);
            this.lbl_llegadas_lambda.Name = "lbl_llegadas_lambda";
            this.lbl_llegadas_lambda.Size = new System.Drawing.Size(55, 13);
            this.lbl_llegadas_lambda.TabIndex = 0;
            this.lbl_llegadas_lambda.Text = "Lambda:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(124, 77);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(37, 20);
            this.txt_hasta.TabIndex = 5;
            this.txt_hasta.Text = "100";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(124, 52);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(37, 20);
            this.txt_desde.TabIndex = 4;
            this.txt_desde.Text = "1";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(124, 27);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(37, 20);
            this.txt_dias.TabIndex = 3;
            this.txt_dias.Text = "30";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(21, 30);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(38, 13);
            this.lbl_dias.TabIndex = 2;
            this.lbl_dias.Text = "Días:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(21, 79);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(88, 13);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(21, 55);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(91, 13);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.Location = new System.Drawing.Point(587, 165);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(80, 33);
            this.btn_detener.TabIndex = 18;
            this.btn_detener.Text = "PARAR";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Enabled = false;
            this.btn_simular.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(506, 165);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 33);
            this.btn_simular.TabIndex = 16;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // rb_estrategia_b
            // 
            this.rb_estrategia_b.AutoSize = true;
            this.rb_estrategia_b.Location = new System.Drawing.Point(628, 132);
            this.rb_estrategia_b.Name = "rb_estrategia_b";
            this.rb_estrategia_b.Size = new System.Drawing.Size(14, 13);
            this.rb_estrategia_b.TabIndex = 23;
            this.rb_estrategia_b.TabStop = true;
            this.rb_estrategia_b.UseVisualStyleBackColor = true;
            this.rb_estrategia_b.CheckedChanged += new System.EventHandler(this.rb_estrategia_b_CheckedChanged);
            // 
            // rb_estrategia_a
            // 
            this.rb_estrategia_a.AutoSize = true;
            this.rb_estrategia_a.Location = new System.Drawing.Point(382, 132);
            this.rb_estrategia_a.Name = "rb_estrategia_a";
            this.rb_estrategia_a.Size = new System.Drawing.Size(14, 13);
            this.rb_estrategia_a.TabIndex = 22;
            this.rb_estrategia_a.TabStop = true;
            this.rb_estrategia_a.UseVisualStyleBackColor = true;
            this.rb_estrategia_a.CheckedChanged += new System.EventHandler(this.rb_estrategia_a_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estrategia A: Llegada entre 5 y 7";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 33);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estrategia B: Llegada entre 7 y 8";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(944, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 103);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gb_estrategias
            // 
            this.gb_estrategias.Controls.Add(this.label2);
            this.gb_estrategias.Controls.Add(this.label1);
            this.gb_estrategias.Controls.Add(this.txt_permanencia_b);
            this.gb_estrategias.Controls.Add(this.txt_permanencia_a);
            this.gb_estrategias.Controls.Add(this.lbl_permanencia);
            this.gb_estrategias.Controls.Add(this.txt_no_atendidos_b);
            this.gb_estrategias.Controls.Add(this.txt_no_atendidos_a);
            this.gb_estrategias.Controls.Add(this.lbl_no_atendidos);
            this.gb_estrategias.Controls.Add(this.txt_atendidos_b);
            this.gb_estrategias.Controls.Add(this.txt_atendidos_a);
            this.gb_estrategias.Controls.Add(this.lbl_atendidos);
            this.gb_estrategias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_estrategias.Location = new System.Drawing.Point(351, 487);
            this.gb_estrategias.Name = "gb_estrategias";
            this.gb_estrategias.Size = new System.Drawing.Size(474, 136);
            this.gb_estrategias.TabIndex = 27;
            this.gb_estrategias.TabStop = false;
            this.gb_estrategias.Text = "SOLUCION:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(83, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estrategia B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estrategia A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_permanencia_b
            // 
            this.txt_permanencia_b.Enabled = false;
            this.txt_permanencia_b.Location = new System.Drawing.Point(378, 76);
            this.txt_permanencia_b.Name = "txt_permanencia_b";
            this.txt_permanencia_b.Size = new System.Drawing.Size(64, 20);
            this.txt_permanencia_b.TabIndex = 12;
            // 
            // txt_permanencia_a
            // 
            this.txt_permanencia_a.Enabled = false;
            this.txt_permanencia_a.Location = new System.Drawing.Point(378, 49);
            this.txt_permanencia_a.Name = "txt_permanencia_a";
            this.txt_permanencia_a.Size = new System.Drawing.Size(64, 20);
            this.txt_permanencia_a.TabIndex = 11;
            // 
            // lbl_permanencia
            // 
            this.lbl_permanencia.Location = new System.Drawing.Point(369, 13);
            this.lbl_permanencia.Name = "lbl_permanencia";
            this.lbl_permanencia.Size = new System.Drawing.Size(81, 33);
            this.lbl_permanencia.TabIndex = 10;
            this.lbl_permanencia.Text = "Permanencia promedio:";
            this.lbl_permanencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_no_atendidos_b
            // 
            this.txt_no_atendidos_b.Enabled = false;
            this.txt_no_atendidos_b.Location = new System.Drawing.Point(284, 76);
            this.txt_no_atendidos_b.Name = "txt_no_atendidos_b";
            this.txt_no_atendidos_b.Size = new System.Drawing.Size(64, 20);
            this.txt_no_atendidos_b.TabIndex = 9;
            // 
            // txt_no_atendidos_a
            // 
            this.txt_no_atendidos_a.Enabled = false;
            this.txt_no_atendidos_a.Location = new System.Drawing.Point(284, 49);
            this.txt_no_atendidos_a.Name = "txt_no_atendidos_a";
            this.txt_no_atendidos_a.Size = new System.Drawing.Size(64, 20);
            this.txt_no_atendidos_a.TabIndex = 8;
            // 
            // lbl_no_atendidos
            // 
            this.lbl_no_atendidos.Location = new System.Drawing.Point(266, 13);
            this.lbl_no_atendidos.Name = "lbl_no_atendidos";
            this.lbl_no_atendidos.Size = new System.Drawing.Size(97, 33);
            this.lbl_no_atendidos.TabIndex = 7;
            this.lbl_no_atendidos.Text = "Camiones no atendidos:";
            this.lbl_no_atendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_atendidos_b
            // 
            this.txt_atendidos_b.Enabled = false;
            this.txt_atendidos_b.Location = new System.Drawing.Point(188, 76);
            this.txt_atendidos_b.Name = "txt_atendidos_b";
            this.txt_atendidos_b.Size = new System.Drawing.Size(64, 20);
            this.txt_atendidos_b.TabIndex = 6;
            // 
            // txt_atendidos_a
            // 
            this.txt_atendidos_a.Enabled = false;
            this.txt_atendidos_a.Location = new System.Drawing.Point(188, 49);
            this.txt_atendidos_a.Name = "txt_atendidos_a";
            this.txt_atendidos_a.Size = new System.Drawing.Size(64, 20);
            this.txt_atendidos_a.TabIndex = 5;
            // 
            // lbl_atendidos
            // 
            this.lbl_atendidos.Location = new System.Drawing.Point(185, 13);
            this.lbl_atendidos.Name = "lbl_atendidos";
            this.lbl_atendidos.Size = new System.Drawing.Size(67, 33);
            this.lbl_atendidos.TabIndex = 4;
            this.lbl_atendidos.Text = "Camiones atendidos:";
            this.lbl_atendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_simulaciones
            // 
            this.dgv_simulaciones.AllowUserToAddRows = false;
            this.dgv_simulaciones.AllowUserToDeleteRows = false;
            this.dgv_simulaciones.AllowUserToResizeColumns = false;
            this.dgv_simulaciones.AllowUserToResizeRows = false;
            this.dgv_simulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_simulaciones.CausesValidation = false;
            this.dgv_simulaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_simulaciones.ColumnHeadersHeight = 41;
            this.dgv_simulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_simulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.proxima_llegada,
            this.cola_recepcion,
            this.estado_recepcion,
            this.proximo_fin_recepcion,
            this.cola_balanza,
            this.estado_balanza,
            this.proximo_fin_balanza,
            this.cola_darsenas,
            this.estado_darsena_1,
            this.proximo_fin_darsena_1,
            this.atendidos_darsena_1,
            this.estado_darsena_2,
            this.proximo_fin_darsena_2,
            this.atendidos_darsena_2,
            this.total_atendidos,
            this.sin_atender,
            this.permanencia});
            this.dgv_simulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_simulaciones.EnableHeadersVisualStyles = false;
            this.dgv_simulaciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_simulaciones.Location = new System.Drawing.Point(3, 204);
            this.dgv_simulaciones.Name = "dgv_simulaciones";
            this.dgv_simulaciones.ReadOnly = true;
            this.dgv_simulaciones.RowHeadersVisible = false;
            this.dgv_simulaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulaciones.RowTemplate.ReadOnly = true;
            this.dgv_simulaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulaciones.ShowCellErrors = false;
            this.dgv_simulaciones.ShowCellToolTips = false;
            this.dgv_simulaciones.ShowEditingIcon = false;
            this.dgv_simulaciones.ShowRowErrors = false;
            this.dgv_simulaciones.Size = new System.Drawing.Size(1087, 259);
            this.dgv_simulaciones.TabIndex = 28;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reloj.Width = 55;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.evento.FillWeight = 1F;
            this.evento.Frozen = true;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 80;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.ReadOnly = true;
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // cola_recepcion
            // 
            this.cola_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_recepcion.FillWeight = 1F;
            this.cola_recepcion.HeaderText = "Cola Recepción";
            this.cola_recepcion.Name = "cola_recepcion";
            this.cola_recepcion.ReadOnly = true;
            this.cola_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_recepcion.Width = 70;
            // 
            // estado_recepcion
            // 
            this.estado_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_recepcion.FillWeight = 1F;
            this.estado_recepcion.HeaderText = "Estado Recepción";
            this.estado_recepcion.Name = "estado_recepcion";
            this.estado_recepcion.ReadOnly = true;
            this.estado_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_recepcion.Width = 140;
            // 
            // proximo_fin_recepcion
            // 
            this.proximo_fin_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_recepcion.FillWeight = 1F;
            this.proximo_fin_recepcion.HeaderText = "Próximo Fin Recepción";
            this.proximo_fin_recepcion.Name = "proximo_fin_recepcion";
            this.proximo_fin_recepcion.ReadOnly = true;
            this.proximo_fin_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_recepcion.Width = 85;
            // 
            // cola_balanza
            // 
            this.cola_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_balanza.FillWeight = 1F;
            this.cola_balanza.HeaderText = "Cola Balanza";
            this.cola_balanza.Name = "cola_balanza";
            this.cola_balanza.ReadOnly = true;
            this.cola_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_balanza.Width = 60;
            // 
            // estado_balanza
            // 
            this.estado_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_balanza.FillWeight = 1F;
            this.estado_balanza.HeaderText = "Estado Balanza";
            this.estado_balanza.Name = "estado_balanza";
            this.estado_balanza.ReadOnly = true;
            this.estado_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_balanza.Width = 140;
            // 
            // proximo_fin_balanza
            // 
            this.proximo_fin_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_balanza.FillWeight = 1F;
            this.proximo_fin_balanza.HeaderText = "Próximo Fin Balanza";
            this.proximo_fin_balanza.Name = "proximo_fin_balanza";
            this.proximo_fin_balanza.ReadOnly = true;
            this.proximo_fin_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_balanza.Width = 85;
            // 
            // cola_darsenas
            // 
            this.cola_darsenas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_darsenas.FillWeight = 1F;
            this.cola_darsenas.HeaderText = "Cola Dársenas";
            this.cola_darsenas.Name = "cola_darsenas";
            this.cola_darsenas.ReadOnly = true;
            this.cola_darsenas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_darsenas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_darsenas.Width = 70;
            // 
            // estado_darsena_1
            // 
            this.estado_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_1.FillWeight = 1F;
            this.estado_darsena_1.HeaderText = "Estado Dársena 1";
            this.estado_darsena_1.Name = "estado_darsena_1";
            this.estado_darsena_1.ReadOnly = true;
            this.estado_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_1.Width = 140;
            // 
            // proximo_fin_darsena_1
            // 
            this.proximo_fin_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_1.FillWeight = 1F;
            this.proximo_fin_darsena_1.HeaderText = "Próximo Fin Dársena 1";
            this.proximo_fin_darsena_1.Name = "proximo_fin_darsena_1";
            this.proximo_fin_darsena_1.ReadOnly = true;
            this.proximo_fin_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_1.Width = 85;
            // 
            // atendidos_darsena_1
            // 
            this.atendidos_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_1.FillWeight = 1F;
            this.atendidos_darsena_1.HeaderText = "Atendidos Dársena 1";
            this.atendidos_darsena_1.Name = "atendidos_darsena_1";
            this.atendidos_darsena_1.ReadOnly = true;
            this.atendidos_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_1.Width = 80;
            // 
            // estado_darsena_2
            // 
            this.estado_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_2.FillWeight = 1F;
            this.estado_darsena_2.HeaderText = "Estado Dársena 2";
            this.estado_darsena_2.Name = "estado_darsena_2";
            this.estado_darsena_2.ReadOnly = true;
            this.estado_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_2.Width = 140;
            // 
            // proximo_fin_darsena_2
            // 
            this.proximo_fin_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_2.FillWeight = 1F;
            this.proximo_fin_darsena_2.HeaderText = "Próximo Fin Dársena 2";
            this.proximo_fin_darsena_2.Name = "proximo_fin_darsena_2";
            this.proximo_fin_darsena_2.ReadOnly = true;
            this.proximo_fin_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_2.Width = 85;
            // 
            // atendidos_darsena_2
            // 
            this.atendidos_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_2.FillWeight = 1F;
            this.atendidos_darsena_2.HeaderText = "Atendidos Dársena 2";
            this.atendidos_darsena_2.Name = "atendidos_darsena_2";
            this.atendidos_darsena_2.ReadOnly = true;
            this.atendidos_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_2.Width = 80;
            // 
            // total_atendidos
            // 
            this.total_atendidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_atendidos.FillWeight = 1F;
            this.total_atendidos.HeaderText = "Total Atendidos";
            this.total_atendidos.Name = "total_atendidos";
            this.total_atendidos.ReadOnly = true;
            this.total_atendidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_atendidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_atendidos.Width = 70;
            // 
            // sin_atender
            // 
            this.sin_atender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sin_atender.FillWeight = 1F;
            this.sin_atender.HeaderText = "Total Sin Atender";
            this.sin_atender.Name = "sin_atender";
            this.sin_atender.ReadOnly = true;
            this.sin_atender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sin_atender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sin_atender.Width = 70;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.permanencia.FillWeight = 1F;
            this.permanencia.HeaderText = "Permanencia Promedio";
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permanencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.permanencia.Width = 90;
            // 
            // TPColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1102, 681);
            this.Controls.Add(this.dgv_simulaciones);
            this.Controls.Add(this.gb_estrategias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_estrategia_b);
            this.Controls.Add(this.rb_estrategia_a);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.gb_datos_iniciales);
            this.Controls.Add(this.gb_actual);
            this.Name = "TPColas";
            this.Text = "TRABAJO PRACTICO COLAS : Arancibia - Forcada - Ledesma - Maldonado";
            this.gb_actual.ResumeLayout(false);
            this.gb_actual.PerformLayout();
            this.gb_datos_iniciales.ResumeLayout(false);
            this.gb_datos_iniciales.PerformLayout();
            this.gb_recalibracion.ResumeLayout(false);
            this.gb_recalibracion.PerformLayout();
            this.gb_darsenas.ResumeLayout(false);
            this.gb_darsenas.PerformLayout();
            this.gb_balanza.ResumeLayout(false);
            this.gb_balanza.PerformLayout();
            this.gb_recepcion.ResumeLayout(false);
            this.gb_recepcion.PerformLayout();
            this.gb_llegadas.ResumeLayout(false);
            this.gb_llegadas.PerformLayout();
            this.gb_estrategias.ResumeLayout(false);
            this.gb_estrategias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_actual;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.GroupBox gb_datos_iniciales;
        private System.Windows.Forms.GroupBox gb_recalibracion;
        private System.Windows.Forms.TextBox txt_recalibracion_varianza;
        private System.Windows.Forms.Label lbl_recalibracion_varianza;
        private System.Windows.Forms.TextBox txt_recalibracion_media;
        private System.Windows.Forms.Label lbl_recalibracion_media;
        private System.Windows.Forms.GroupBox gb_darsenas;
        private System.Windows.Forms.TextBox txt_darsenas_b;
        private System.Windows.Forms.Label lbl_darsenas_b;
        private System.Windows.Forms.TextBox txt_darsenas_a;
        private System.Windows.Forms.Label lbl_darsenas_a;
        private System.Windows.Forms.GroupBox gb_balanza;
        private System.Windows.Forms.TextBox txt_balanza_b;
        private System.Windows.Forms.Label lbl_balanza_b;
        private System.Windows.Forms.TextBox txt_balanza_a;
        private System.Windows.Forms.Label lbl_balanza_a;
        private System.Windows.Forms.GroupBox gb_recepcion;
        private System.Windows.Forms.TextBox txt_recepcion_b;
        private System.Windows.Forms.Label lbl_recepcion_b;
        private System.Windows.Forms.TextBox txt_recepcion_a;
        private System.Windows.Forms.Label lbl_recepcion_a;
        private System.Windows.Forms.GroupBox gb_llegadas;
        private System.Windows.Forms.TextBox txt_llegadas_lambda;
        private System.Windows.Forms.Label lbl_llegadas_lambda;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.RadioButton rb_estrategia_b;
        private System.Windows.Forms.RadioButton rb_estrategia_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_estrategias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_permanencia_b;
        private System.Windows.Forms.TextBox txt_permanencia_a;
        private System.Windows.Forms.Label lbl_permanencia;
        private System.Windows.Forms.TextBox txt_no_atendidos_b;
        private System.Windows.Forms.TextBox txt_no_atendidos_a;
        private System.Windows.Forms.Label lbl_no_atendidos;
        private System.Windows.Forms.TextBox txt_atendidos_b;
        private System.Windows.Forms.TextBox txt_atendidos_a;
        private System.Windows.Forms.Label lbl_atendidos;
        private System.Windows.Forms.DataGridView dgv_simulaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_darsenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_atendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sin_atender;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
    }
}