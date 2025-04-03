using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap imgResultado;

        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;




        public Form1()
        {
            InitializeComponent();
        }

        private void btImgA_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    img2 = new Bitmap(img1.Width, img1.Height);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                }
            }
        }
        private void ConverterParaEscalaDeCinza()
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem antes de converter!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar a imagem de saída do mesmo tamanho
            imgResultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    // Usa a média ponderada para uma melhor conversão
                    byte pixelIntensity = (byte)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);

                    Color corCinza = Color.FromArgb(pixelIntensity, pixelIntensity, pixelIntensity);

                    imgResultado.SetPixel(i, j, corCinza);
                }
            }

            // Exibe o resultado no PictureBox3
            pictureBox3.Image = imgResultado;
        }



        private void btImgB_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                if (bLoadImgOK)
                {
                    pictureBox2.Image = img2;
                }
            }
        }

        public static Bitmap SomarImagens(Bitmap img1, Bitmap img2)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                throw new ArgumentException("As imagens devem ter as mesmas dimensões!");

            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Soma os valores RGB dos dois pixels e trata overflow
                    int r = Math.Min(p1.R + p2.R, 255);
                    int g = Math.Min(p1.G + p2.G, 255);
                    int b = Math.Min(p1.B + p2.B, 255);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }

        public static Bitmap AumentarBrilho(Bitmap img, int valor)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // Adiciona o valor constante e limita para 255 (overflow)
                    int r = Math.Min(pixel.R + valor, 255);
                    int g = Math.Min(pixel.G + valor, 255);
                    int b = Math.Min(pixel.B + valor, 255);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }


        private void btSomar_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue pelo menos a imagem A antes de prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int valorConstante = (int)numericUpDown1.Value;

            if (img2 == null)
            {
                // Se a imagem B não existir, soma o valor constante em cada pixel de A
                imgResultado = AumentarBrilho(img1, valorConstante);
            }
            else
            {
                // Se ambas as imagens existirem, soma pixel a pixel
                imgResultado = SomarImagens(img1, img2);
            }

            pictureBox3.Image = imgResultado;
        }

        private void btExcluirImgA_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                img1.Dispose(); // Libera a memória da imagem
                img1 = null;
                pictureBox1.Image = null; // Remove a imagem da interface

                MessageBox.Show("Imagem A removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem A carregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btExcluirImgB_Click(object sender, EventArgs e)
        {
            if (img2 != null)
            {
                img2.Dispose(); // Libera a memória da imagem
                img2 = null;
                pictureBox2.Image = null; // Remove a imagem da interface

                MessageBox.Show("Imagem B removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem B carregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btExcluirImgC_Click(object sender, EventArgs e)
        {
            if (imgResultado != null)
            {
                imgResultado.Dispose(); // Libera a memória da imagem
                imgResultado = null;
               
            }

            if (pictureBox3.Image != null)
            {
                imgResultado?.Dispose();
                imgResultado = null;
                pictureBox3.Image = null;
                pictureBox3.Refresh();

                MessageBox.Show("Imagem C removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem C carregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public static Bitmap DiminuirBrilho(Bitmap img, int valor)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // Tratamento de underflow: impede valores abaixo de 0
                    int r = Math.Max(pixel.R - valor, 0);
                    int g = Math.Max(pixel.G - valor, 0);
                    int b = Math.Max(pixel.B - valor, 0);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }
        public static Bitmap SubtrairImagens(Bitmap img1, Bitmap img2)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                throw new ArgumentException("As imagens devem ter as mesmas dimensões!");

            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Tratamento de underflow: impede valores abaixo de 0
                    int r = Math.Max(p1.R - p2.R, 0);
                    int g = Math.Max(p1.G - p2.G, 0);
                    int b = Math.Max(p1.B - p2.B, 0);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }
        private void btSubtrair_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue pelo menos a imagem A antes de prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int valorConstante = (int)numericUpDown1.Value;

            if (img2 == null)
            {
                // Se a imagem B não existir, subtrai o valor constante de A
                imgResultado = DiminuirBrilho(img1, valorConstante);
            }
            else
            {
                // Se ambas as imagens existirem, subtrai pixel a pixel
                imgResultado = SubtrairImagens(img1, img2);
            }

            pictureBox3.Image = imgResultado; // Exibir a imagem resultante
        }

        public static Bitmap MultiplicarImagem(Bitmap img, float fator)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // Multiplica os valores RGB pelo fator e trata overflow/underflow
                    int r = Math.Min(Math.Max((int)(pixel.R * fator), 0), 255);
                    int g = Math.Min(Math.Max((int)(pixel.G * fator), 0), 255);
                    int b = Math.Min(Math.Max((int)(pixel.B * fator), 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;
        }

        public static Bitmap DividirImagem(Bitmap img, float valor)
        {
            if (valor <= 0) // Evita divisão por 0 e valores negativos
            {
                throw new ArgumentException("O divisor deve ser maior que zero!");
            }

            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // Divide os valores RGB garantindo que fiquem no intervalo de 0 a 255
                    int r = Math.Max(0, Math.Min(255, (int)(pixel.R / valor)));
                    int g = Math.Max(0, Math.Min(255, (int)(pixel.G / valor)));
                    int b = Math.Max(0, Math.Min(255, (int)(pixel.B / valor)));

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;
        } 




        private void btMult_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem antes de processar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float fatorMultiplicacao = 1.5f; // Aumenta contraste em 50%

            Bitmap imgMultiplicada = MultiplicarImagem(img1, fatorMultiplicacao);
           
            pictureBox3.Image = imgMultiplicada; // Exibe imagem com mais contraste
           
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem A antes de prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float valorDivisao = (float)numericUpDown1.Value;

            if (valorDivisao <= 0)
            {
                MessageBox.Show("O valor da divisão deve ser maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                imgResultado = DividirImagem(img1, valorDivisao);
                pictureBox3.Image = imgResultado; // Atualiza PictureBox C
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao dividir a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
            private void btSalvar_Click(object sender, EventArgs e)
        {
            if (imgResultado == null)
            {
                MessageBox.Show("Nenhuma imagem resultante para salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp|TIFF Image|*.tif";
            saveFileDialog.Title = "Salvar Imagem";
            saveFileDialog.FileName = "ImagemResultante";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminho = saveFileDialog.FileName;
                    ImageFormat formato = ImageFormat.Png; // Define PNG como padrão

                    // Verifica a extensão para escolher o formato correto
                    if (caminho.EndsWith(".jpg"))
                        formato = ImageFormat.Jpeg;
                    else if (caminho.EndsWith(".bmp"))
                        formato = ImageFormat.Bmp;
                    else if (caminho.EndsWith(".tif"))
                        formato = ImageFormat.Tiff;

                    imgResultado.Save(caminho, formato);
                    MessageBox.Show("Imagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btConverterEscalaCinza_Click(object sender, EventArgs e)
        {
            ConverterParaEscalaDeCinza();
        }

    }
}

