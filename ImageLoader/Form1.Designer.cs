﻿namespace ImageLoader
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btImgA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btImgB = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btExcluirImgB = new System.Windows.Forms.Button();
            this.btExcluirImgC = new System.Windows.Forms.Button();
            this.btExcluirImgA = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEscalaCinza = new System.Windows.Forms.Button();
            this.btInverterHor = new System.Windows.Forms.Button();
            this.btInverterVer = new System.Windows.Forms.Button();
            this.Diferenca = new System.Windows.Forms.Button();
            this.btBlending = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.btMedia = new System.Windows.Forms.Button();
            this.chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btEqualizar = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnLimiar = new System.Windows.Forms.Button();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFiltros = new System.Windows.Forms.ComboBox();
            this.btnSalPimenta = new System.Windows.Forms.Button();
            this.btnSalPimentaOrdem = new System.Windows.Forms.Button();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.btnSalPimentaSuavizacao = new System.Windows.Forms.Button();
            this.btnFiltroGaussiano = new System.Windows.Forms.Button();
            this.numericUpDownKernel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrewitt = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnLaplaciano = new System.Windows.Forms.Button();
            this.comboBoxLaplaciano = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFechamentoAbertura = new System.Windows.Forms.Button();
            this.comboBoxAbertura = new System.Windows.Forms.ComboBox();
            this.comboBoxErosao = new System.Windows.Forms.ComboBox();
            this.comboBoxSE = new System.Windows.Forms.ComboBox();
            this.btnContorno = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.btnAbertura = new System.Windows.Forms.Button();
            this.btnErosao = new System.Windows.Forms.Button();
            this.btnDilatacao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImgA
            // 
            this.btImgA.Location = new System.Drawing.Point(83, 308);
            this.btImgA.Name = "btImgA";
            this.btImgA.Size = new System.Drawing.Size(163, 37);
            this.btImgA.TabIndex = 0;
            this.btImgA.Text = "Carregar Imagem A";
            this.btImgA.UseVisualStyleBackColor = true;
            this.btImgA.Click += new System.EventHandler(this.btImgA_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(548, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btImgB
            // 
            this.btImgB.Location = new System.Drawing.Point(636, 308);
            this.btImgB.Name = "btImgB";
            this.btImgB.Size = new System.Drawing.Size(163, 37);
            this.btImgB.TabIndex = 3;
            this.btImgB.Text = "Carregar Imagem B";
            this.btImgB.UseVisualStyleBackColor = true;
            this.btImgB.Click += new System.EventHandler(this.btImgB_Click);
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(6, 60);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(147, 54);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "Somar";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox3.Location = new System.Drawing.Point(965, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 290);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(6, 120);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(147, 54);
            this.btSubtrair.TabIndex = 6;
            this.btSubtrair.Text = "Subtrair";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(6, 180);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(147, 54);
            this.btMult.TabIndex = 7;
            this.btMult.Text = "Multiplicar";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(159, 79);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(159, 139);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(159, 199);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown3.TabIndex = 10;
            // 
            // btExcluirImgB
            // 
            this.btExcluirImgB.ForeColor = System.Drawing.Color.Red;
            this.btExcluirImgB.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btExcluirImgB.Location = new System.Drawing.Point(841, 12);
            this.btExcluirImgB.Name = "btExcluirImgB";
            this.btExcluirImgB.Size = new System.Drawing.Size(26, 23);
            this.btExcluirImgB.TabIndex = 11;
            this.btExcluirImgB.Text = "X";
            this.btExcluirImgB.UseVisualStyleBackColor = true;
            this.btExcluirImgB.Click += new System.EventHandler(this.btExcluirImgB_Click);
            // 
            // btExcluirImgC
            // 
            this.btExcluirImgC.ForeColor = System.Drawing.Color.Red;
            this.btExcluirImgC.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btExcluirImgC.Location = new System.Drawing.Point(1258, 12);
            this.btExcluirImgC.Name = "btExcluirImgC";
            this.btExcluirImgC.Size = new System.Drawing.Size(26, 23);
            this.btExcluirImgC.TabIndex = 12;
            this.btExcluirImgC.Text = "X";
            this.btExcluirImgC.UseVisualStyleBackColor = true;
            this.btExcluirImgC.Click += new System.EventHandler(this.btExcluirImgC_Click);
            // 
            // btExcluirImgA
            // 
            this.btExcluirImgA.ForeColor = System.Drawing.Color.Red;
            this.btExcluirImgA.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btExcluirImgA.Location = new System.Drawing.Point(305, 12);
            this.btExcluirImgA.Name = "btExcluirImgA";
            this.btExcluirImgA.Size = new System.Drawing.Size(26, 23);
            this.btExcluirImgA.TabIndex = 13;
            this.btExcluirImgA.Text = "X";
            this.btExcluirImgA.UseVisualStyleBackColor = true;
            this.btExcluirImgA.Click += new System.EventHandler(this.btExcluirImgA_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(6, 240);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(147, 54);
            this.btDiv.TabIndex = 14;
            this.btDiv.Text = "Dividir";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown4.Location = new System.Drawing.Point(159, 259);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown4.TabIndex = 15;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(363, 12);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(147, 54);
            this.btSalvar.TabIndex = 16;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEscalaCinza
            // 
            this.btEscalaCinza.Location = new System.Drawing.Point(363, 72);
            this.btEscalaCinza.Name = "btEscalaCinza";
            this.btEscalaCinza.Size = new System.Drawing.Size(147, 54);
            this.btEscalaCinza.TabIndex = 17;
            this.btEscalaCinza.Text = "Escala Cinza";
            this.btEscalaCinza.UseVisualStyleBackColor = true;
            this.btEscalaCinza.Click += new System.EventHandler(this.btConverterEscalaCinza_Click);
            // 
            // btInverterHor
            // 
            this.btInverterHor.Location = new System.Drawing.Point(363, 132);
            this.btInverterHor.Name = "btInverterHor";
            this.btInverterHor.Size = new System.Drawing.Size(147, 54);
            this.btInverterHor.TabIndex = 18;
            this.btInverterHor.Text = "Inverter Horizontalmente ";
            this.btInverterHor.UseVisualStyleBackColor = true;
            this.btInverterHor.Click += new System.EventHandler(this.btInverterHor_Click);
            // 
            // btInverterVer
            // 
            this.btInverterVer.Location = new System.Drawing.Point(363, 192);
            this.btInverterVer.Name = "btInverterVer";
            this.btInverterVer.Size = new System.Drawing.Size(147, 54);
            this.btInverterVer.TabIndex = 19;
            this.btInverterVer.Text = "Inverter Verticalmente";
            this.btInverterVer.UseVisualStyleBackColor = true;
            this.btInverterVer.Click += new System.EventHandler(this.btInverterVer_Click);
            // 
            // Diferenca
            // 
            this.Diferenca.Location = new System.Drawing.Point(363, 252);
            this.Diferenca.Name = "Diferenca";
            this.Diferenca.Size = new System.Drawing.Size(147, 54);
            this.Diferenca.TabIndex = 20;
            this.Diferenca.Text = "Diferença entre Imagens";
            this.Diferenca.UseVisualStyleBackColor = true;
            this.Diferenca.Click += new System.EventHandler(this.Diferenca_Click);
            // 
            // btBlending
            // 
            this.btBlending.Location = new System.Drawing.Point(6, 300);
            this.btBlending.Name = "btBlending";
            this.btBlending.Size = new System.Drawing.Size(147, 54);
            this.btBlending.TabIndex = 21;
            this.btBlending.Text = "Blending";
            this.btBlending.UseVisualStyleBackColor = true;
            this.btBlending.Click += new System.EventHandler(this.btBlending_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(868, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Resultado =";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(159, 319);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown5.TabIndex = 23;
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(22, 63);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(147, 54);
            this.btMedia.TabIndex = 24;
            this.btMedia.Text = "Media";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // chartHistograma
            // 
            this.chartHistograma.BackColor = System.Drawing.Color.DarkGray;
            this.chartHistograma.BorderlineColor = System.Drawing.Color.Red;
            chartArea6.Name = "Histograma";
            this.chartHistograma.ChartAreas.Add(chartArea6);
            this.chartHistograma.Location = new System.Drawing.Point(14, 714);
            this.chartHistograma.Name = "chartHistograma";
            this.chartHistograma.Size = new System.Drawing.Size(368, 245);
            this.chartHistograma.TabIndex = 25;
            // 
            // btEqualizar
            // 
            this.btEqualizar.Location = new System.Drawing.Point(7, 19);
            this.btEqualizar.Name = "btEqualizar";
            this.btEqualizar.Size = new System.Drawing.Size(147, 54);
            this.btEqualizar.TabIndex = 26;
            this.btEqualizar.Text = "Equalizar";
            this.btEqualizar.UseVisualStyleBackColor = true;
            this.btEqualizar.Click += new System.EventHandler(this.btEqualizar_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(22, 123);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(147, 54);
            this.btnNot.TabIndex = 27;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(22, 183);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(147, 54);
            this.btnAnd.TabIndex = 28;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(22, 243);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(147, 54);
            this.btnOr.TabIndex = 29;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnXor
            // 
            this.btnXor.Location = new System.Drawing.Point(22, 303);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(147, 54);
            this.btnXor.TabIndex = 30;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // btnLimiar
            // 
            this.btnLimiar.Location = new System.Drawing.Point(7, 79);
            this.btnLimiar.Name = "btnLimiar";
            this.btnLimiar.Size = new System.Drawing.Size(147, 54);
            this.btnLimiar.TabIndex = 31;
            this.btnLimiar.Text = "Limiarização";
            this.btnLimiar.UseVisualStyleBackColor = true;
            this.btnLimiar.Click += new System.EventHandler(this.btnLimiar_Click);
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(160, 98);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownThreshold.TabIndex = 32;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltros.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxFiltros.FormattingEnabled = true;
            this.comboBoxFiltros.Items.AddRange(new object[] {
            "MAX",
            "MIN",
            "MEAN"});
            this.comboBoxFiltros.Location = new System.Drawing.Point(22, 63);
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(147, 21);
            this.comboBoxFiltros.TabIndex = 33;
            this.comboBoxFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltros_SelectedIndexChanged);
            // 
            // btnSalPimenta
            // 
            this.btnSalPimenta.Location = new System.Drawing.Point(22, 172);
            this.btnSalPimenta.Name = "btnSalPimenta";
            this.btnSalPimenta.Size = new System.Drawing.Size(147, 54);
            this.btnSalPimenta.TabIndex = 34;
            this.btnSalPimenta.Text = "Sal Pimenta - Mediana";
            this.btnSalPimenta.UseVisualStyleBackColor = true;
            this.btnSalPimenta.Click += new System.EventHandler(this.btnSalPimenta_Click);
            // 
            // btnSalPimentaOrdem
            // 
            this.btnSalPimentaOrdem.Location = new System.Drawing.Point(22, 232);
            this.btnSalPimentaOrdem.Name = "btnSalPimentaOrdem";
            this.btnSalPimentaOrdem.Size = new System.Drawing.Size(147, 54);
            this.btnSalPimentaOrdem.TabIndex = 35;
            this.btnSalPimentaOrdem.Text = "Sal Pimenta - Ordem";
            this.btnSalPimentaOrdem.UseVisualStyleBackColor = true;
            this.btnSalPimentaOrdem.Click += new System.EventHandler(this.btnSalPimentaOrdem_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(175, 251);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown6.TabIndex = 36;
            this.numericUpDown6.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnSalPimentaSuavizacao
            // 
            this.btnSalPimentaSuavizacao.Location = new System.Drawing.Point(22, 292);
            this.btnSalPimentaSuavizacao.Name = "btnSalPimentaSuavizacao";
            this.btnSalPimentaSuavizacao.Size = new System.Drawing.Size(147, 54);
            this.btnSalPimentaSuavizacao.TabIndex = 37;
            this.btnSalPimentaSuavizacao.Text = "Sal Pimenta - Suavização";
            this.btnSalPimentaSuavizacao.UseVisualStyleBackColor = true;
            this.btnSalPimentaSuavizacao.Click += new System.EventHandler(this.btnSalPimentaSuavizacao_Click);
            // 
            // btnFiltroGaussiano
            // 
            this.btnFiltroGaussiano.Location = new System.Drawing.Point(22, 105);
            this.btnFiltroGaussiano.Name = "btnFiltroGaussiano";
            this.btnFiltroGaussiano.Size = new System.Drawing.Size(147, 54);
            this.btnFiltroGaussiano.TabIndex = 38;
            this.btnFiltroGaussiano.Text = "Gaussiano";
            this.btnFiltroGaussiano.UseVisualStyleBackColor = true;
            this.btnFiltroGaussiano.Click += new System.EventHandler(this.btnFiltroGaussiano_Click);
            // 
            // numericUpDownKernel
            // 
            this.numericUpDownKernel.DecimalPlaces = 1;
            this.numericUpDownKernel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDownKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownKernel.Location = new System.Drawing.Point(171, 139);
            this.numericUpDownKernel.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownKernel.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownKernel.Name = "numericUpDownKernel";
            this.numericUpDownKernel.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownKernel.TabIndex = 39;
            this.numericUpDownKernel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.DecimalPlaces = 1;
            this.numericUpDownSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSigma.Location = new System.Drawing.Point(171, 105);
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownSigma.TabIndex = 40;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kernel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sigma";
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.Location = new System.Drawing.Point(6, 60);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(147, 54);
            this.btnPrewitt.TabIndex = 43;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = true;
            this.btnPrewitt.Click += new System.EventHandler(this.btnPrewitt_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(7, 120);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(147, 54);
            this.btnSobel.TabIndex = 44;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnLaplaciano
            // 
            this.btnLaplaciano.Location = new System.Drawing.Point(7, 180);
            this.btnLaplaciano.Name = "btnLaplaciano";
            this.btnLaplaciano.Size = new System.Drawing.Size(147, 54);
            this.btnLaplaciano.TabIndex = 45;
            this.btnLaplaciano.Text = "Laplaciano";
            this.btnLaplaciano.UseVisualStyleBackColor = true;
            this.btnLaplaciano.Click += new System.EventHandler(this.btnLaplaciano_Click);
            // 
            // comboBoxLaplaciano
            // 
            this.comboBoxLaplaciano.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxLaplaciano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaplaciano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxLaplaciano.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxLaplaciano.FormattingEnabled = true;
            this.comboBoxLaplaciano.Items.AddRange(new object[] {
            "4-vizinhos",
            "8-vizinhos"});
            this.comboBoxLaplaciano.Location = new System.Drawing.Point(160, 199);
            this.comboBoxLaplaciano.Name = "comboBoxLaplaciano";
            this.comboBoxLaplaciano.Size = new System.Drawing.Size(120, 21);
            this.comboBoxLaplaciano.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFechamentoAbertura);
            this.groupBox1.Controls.Add(this.comboBoxAbertura);
            this.groupBox1.Controls.Add(this.comboBoxErosao);
            this.groupBox1.Controls.Add(this.comboBoxSE);
            this.groupBox1.Controls.Add(this.btnContorno);
            this.groupBox1.Controls.Add(this.btnFechamento);
            this.groupBox1.Controls.Add(this.btnAbertura);
            this.groupBox1.Controls.Add(this.btnErosao);
            this.groupBox1.Controls.Add(this.btnDilatacao);
            this.groupBox1.Location = new System.Drawing.Point(1053, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 401);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Mofológicas";
            // 
            // btnFechamentoAbertura
            // 
            this.btnFechamentoAbertura.Location = new System.Drawing.Point(159, 248);
            this.btnFechamentoAbertura.Name = "btnFechamentoAbertura";
            this.btnFechamentoAbertura.Size = new System.Drawing.Size(110, 54);
            this.btnFechamentoAbertura.TabIndex = 8;
            this.btnFechamentoAbertura.Text = "+ Abertura";
            this.btnFechamentoAbertura.UseVisualStyleBackColor = true;
            // 
            // comboBoxAbertura
            // 
            this.comboBoxAbertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAbertura.FormattingEnabled = true;
            this.comboBoxAbertura.Items.AddRange(new object[] {
            "Diamante 3x3",
            "Quadrado 3x3",
            "Linha Horizontal"});
            this.comboBoxAbertura.Location = new System.Drawing.Point(159, 206);
            this.comboBoxAbertura.Name = "comboBoxAbertura";
            this.comboBoxAbertura.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAbertura.TabIndex = 7;
            // 
            // comboBoxErosao
            // 
            this.comboBoxErosao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxErosao.FormattingEnabled = true;
            this.comboBoxErosao.Items.AddRange(new object[] {
            "Quadrado 3x3",
            "Diamante 5x5",
            "Linha"});
            this.comboBoxErosao.Location = new System.Drawing.Point(159, 143);
            this.comboBoxErosao.Name = "comboBoxErosao";
            this.comboBoxErosao.Size = new System.Drawing.Size(110, 21);
            this.comboBoxErosao.TabIndex = 6;
            // 
            // comboBoxSE
            // 
            this.comboBoxSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSE.FormattingEnabled = true;
            this.comboBoxSE.Items.AddRange(new object[] {
            "Quadrado 3x3",
            "Cruz",
            "Circular",
            "Linha Horizontal",
            "Linha Vertical"});
            this.comboBoxSE.Location = new System.Drawing.Point(159, 72);
            this.comboBoxSE.Name = "comboBoxSE";
            this.comboBoxSE.Size = new System.Drawing.Size(110, 21);
            this.comboBoxSE.TabIndex = 5;
            // 
            // btnContorno
            // 
            this.btnContorno.Location = new System.Drawing.Point(6, 309);
            this.btnContorno.Name = "btnContorno";
            this.btnContorno.Size = new System.Drawing.Size(147, 54);
            this.btnContorno.TabIndex = 4;
            this.btnContorno.Text = "Contorno";
            this.btnContorno.UseVisualStyleBackColor = true;
            this.btnContorno.Click += new System.EventHandler(this.btnContorno_Click);
            // 
            // btnFechamento
            // 
            this.btnFechamento.Location = new System.Drawing.Point(6, 248);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(147, 54);
            this.btnFechamento.TabIndex = 3;
            this.btnFechamento.Text = "Fechamento";
            this.btnFechamento.UseVisualStyleBackColor = true;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // btnAbertura
            // 
            this.btnAbertura.Location = new System.Drawing.Point(6, 188);
            this.btnAbertura.Name = "btnAbertura";
            this.btnAbertura.Size = new System.Drawing.Size(147, 54);
            this.btnAbertura.TabIndex = 2;
            this.btnAbertura.Text = "Abertura";
            this.btnAbertura.UseVisualStyleBackColor = true;
            this.btnAbertura.Click += new System.EventHandler(this.btnAbertura_Click);
            // 
            // btnErosao
            // 
            this.btnErosao.Location = new System.Drawing.Point(6, 125);
            this.btnErosao.Name = "btnErosao";
            this.btnErosao.Size = new System.Drawing.Size(147, 54);
            this.btnErosao.TabIndex = 1;
            this.btnErosao.Text = "Erosão";
            this.btnErosao.UseVisualStyleBackColor = true;
            this.btnErosao.Click += new System.EventHandler(this.btnErosao_Click);
            // 
            // btnDilatacao
            // 
            this.btnDilatacao.Location = new System.Drawing.Point(6, 58);
            this.btnDilatacao.Name = "btnDilatacao";
            this.btnDilatacao.Size = new System.Drawing.Size(147, 54);
            this.btnDilatacao.TabIndex = 0;
            this.btnDilatacao.Text = "Dilatação";
            this.btnDilatacao.UseVisualStyleBackColor = true;
            this.btnDilatacao.Click += new System.EventHandler(this.btnDilatacao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDiv);
            this.groupBox2.Controls.Add(this.btSomar);
            this.groupBox2.Controls.Add(this.btSubtrair);
            this.groupBox2.Controls.Add(this.btMult);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.btBlending);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Location = new System.Drawing.Point(14, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 357);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações Básicas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOr);
            this.groupBox3.Controls.Add(this.btMedia);
            this.groupBox3.Controls.Add(this.btnNot);
            this.groupBox3.Controls.Add(this.btnAnd);
            this.groupBox3.Controls.Add(this.btnXor);
            this.groupBox3.Location = new System.Drawing.Point(252, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 357);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações Lógicas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btEqualizar);
            this.groupBox4.Controls.Add(this.btnLimiar);
            this.groupBox4.Controls.Add(this.numericUpDownThreshold);
            this.groupBox4.Location = new System.Drawing.Point(748, 612);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 140);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equalização";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFiltroGaussiano);
            this.groupBox5.Controls.Add(this.comboBoxFiltros);
            this.groupBox5.Controls.Add(this.btnSalPimenta);
            this.groupBox5.Controls.Add(this.btnSalPimentaOrdem);
            this.groupBox5.Controls.Add(this.numericUpDown6);
            this.groupBox5.Controls.Add(this.btnSalPimentaSuavizacao);
            this.groupBox5.Controls.Add(this.numericUpDownKernel);
            this.groupBox5.Controls.Add(this.numericUpDownSigma);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(458, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 357);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtros Passa-Baixa";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPrewitt);
            this.groupBox6.Controls.Add(this.btnSobel);
            this.groupBox6.Controls.Add(this.btnLaplaciano);
            this.groupBox6.Controls.Add(this.comboBoxLaplaciano);
            this.groupBox6.Location = new System.Drawing.Point(748, 351);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(299, 255);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtros Passa-Alta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 970);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartHistograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diferenca);
            this.Controls.Add(this.btInverterVer);
            this.Controls.Add(this.btInverterHor);
            this.Controls.Add(this.btEscalaCinza);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluirImgA);
            this.Controls.Add(this.btExcluirImgC);
            this.Controls.Add(this.btExcluirImgB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btImgB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btImgA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImgA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btImgB;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btExcluirImgB;
        private System.Windows.Forms.Button btExcluirImgC;
        private System.Windows.Forms.Button btExcluirImgA;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEscalaCinza;
        private System.Windows.Forms.Button btInverterHor;
        private System.Windows.Forms.Button btInverterVer;
        private System.Windows.Forms.Button Diferenca;
        private System.Windows.Forms.Button btBlending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
        private System.Windows.Forms.Button btEqualizar;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Button btnLimiar;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.ComboBox comboBoxFiltros;
        private System.Windows.Forms.Button btnSalPimenta;
        private System.Windows.Forms.Button btnSalPimentaOrdem;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button btnSalPimentaSuavizacao;
        private System.Windows.Forms.Button btnFiltroGaussiano;
        private System.Windows.Forms.NumericUpDown numericUpDownKernel;
        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrewitt;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnLaplaciano;
        private System.Windows.Forms.ComboBox comboBoxLaplaciano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDilatacao;
        private System.Windows.Forms.Button btnAbertura;
        private System.Windows.Forms.Button btnErosao;
        private System.Windows.Forms.Button btnContorno;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.ComboBox comboBoxSE;
        private System.Windows.Forms.ComboBox comboBoxErosao;
        private System.Windows.Forms.ComboBox comboBoxAbertura;
        private System.Windows.Forms.Button btnFechamentoAbertura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

