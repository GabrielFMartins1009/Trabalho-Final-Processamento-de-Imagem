namespace ImageLoader
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
            this.btImgA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btImgB = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btExcluirImgB = new System.Windows.Forms.Button();
            this.btExcluirImgC = new System.Windows.Forms.Button();
            this.btExcluirImgA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
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
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(391, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btImgB
            // 
            this.btImgB.Location = new System.Drawing.Point(479, 308);
            this.btImgB.Name = "btImgB";
            this.btImgB.Size = new System.Drawing.Size(163, 37);
            this.btImgB.TabIndex = 3;
            this.btImgB.Text = "Carregar Imagem B";
            this.btImgB.UseVisualStyleBackColor = true;
            this.btImgB.Click += new System.EventHandler(this.btImgB_Click);
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(391, 394);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(147, 54);
            this.btSomar.TabIndex = 4;
            this.btSomar.Text = "Somar";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 290);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(391, 454);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(147, 54);
            this.btSubtrair.TabIndex = 6;
            this.btSubtrair.Text = "Subtrair";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(391, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(576, 410);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(576, 473);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(576, 533);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 10;
            // 
            // btExcluirImgB
            // 
            this.btExcluirImgB.ForeColor = System.Drawing.Color.Red;
            this.btExcluirImgB.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btExcluirImgB.Location = new System.Drawing.Point(684, 12);
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
            this.btExcluirImgC.Location = new System.Drawing.Point(305, 391);
            this.btExcluirImgC.Name = "btExcluirImgC";
            this.btExcluirImgC.Size = new System.Drawing.Size(26, 23);
            this.btExcluirImgC.TabIndex = 12;
            this.btExcluirImgC.Text = "X";
            this.btExcluirImgC.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 726);
            this.Controls.Add(this.btExcluirImgA);
            this.Controls.Add(this.btExcluirImgC);
            this.Controls.Add(this.btExcluirImgB);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btSomar);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btExcluirImgB;
        private System.Windows.Forms.Button btExcluirImgC;
        private System.Windows.Forms.Button btExcluirImgA;
    }
}

