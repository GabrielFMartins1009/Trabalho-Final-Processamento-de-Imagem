﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageLoader
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap imgResultado;
        Bitmap imgOriginal;

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
                    // img2 = new Bitmap(img1.Width, img1.Height);
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
            imgOriginal = new Bitmap(pictureBox1.Image);
            ExibirHistograma(imgOriginal, chartHistograma, "Original");
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

            // Exibe o resultado no Resultado
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

        private Bitmap SomarImagens(Bitmap img1, Bitmap img2)
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

                    Color corFinal = Color.FromArgb(r, g, b);

                    result.SetPixel(x, y, corFinal);
                }
            }
            return result;
        }

        private Bitmap AumentarBrilho(Bitmap img, int valor)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            // Garantir que o valor de brilho seja positivo e tenha impacto visual
            valor = Math.Max(valor, 1);  // Garante que o valor de brilho seja no mínimo 1

            Console.WriteLine($"Brilho a ser aplicado: {valor}"); // Log do valor aplicado

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

            Console.WriteLine($"Valor de brilho: {valorConstante}");  // Verifica o valor do brilho

            if (img2 == null)
            {
                // Se a imagem B não existir, soma o valor constante em cada pixel de A
                Console.WriteLine("Aplicando aumento de brilho...");
                imgResultado = AumentarBrilho(img1, valorConstante);
            }
            else
            {
                // Se ambas as imagens existirem, soma pixel a pixel
                imgResultado = SomarImagens(img1, img2);
            }

            pictureBox3.Image = imgResultado;
            pictureBox3.Refresh();  // Garante que a imagem seja atualizada no PictureBox
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

                MessageBox.Show("Imagem Resultado removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem Resultado carregada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public static Bitmap DiminuirBrilho(Bitmap img, int valor)
        {
            // Cria uma nova imagem com as mesmas dimensões
            Bitmap result = new Bitmap(img.Width, img.Height);

            // Percorre todos os pixels da imagem
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // Subtrai o valor de cada componente RGB, garantindo que o valor mínimo seja 0 (evita underflow)
                    int r = Math.Max(pixel.R - valor, 0);
                    int g = Math.Max(pixel.G - valor, 0);
                    int b = Math.Max(pixel.B - valor, 0);

                    // Define a nova cor no pixel de saída
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
            // Verifica se a imagem A foi carregada
            if (img1 == null)
            {
                MessageBox.Show("Carregue pelo menos a imagem A antes de prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Captura o valor do NumericUpDown
            int valorConstante = (int)numericUpDown2.Value;

            // Verifica se a imagem B está carregada
            if (img2 == null)
            {
                // Se a imagem B não foi carregada, aplica a redução de brilho (escurecimento)
                imgResultado = DiminuirBrilho(img1, valorConstante);
            }
            else
            {
                // Se as duas imagens foram carregadas, subtrai pixel a pixel
                imgResultado = SubtrairImagens(img1, img2);
            }

            // Mostra o resultado no PictureBox
            pictureBox3.Image = imgResultado;
            pictureBox3.Refresh();
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

        public static Bitmap DividirImagem(Bitmap img, float fator)
        {
            if (fator <= 0)
            {
                throw new ArgumentException("O fator deve ser maior que zero!");
            }

            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    int r = Math.Max(0, Math.Min(255, (int)(pixel.R * fator)));
                    int g = Math.Max(0, Math.Min(255, (int)(pixel.G * fator)));
                    int b = Math.Max(0, Math.Min(255, (int)(pixel.B * fator)));

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

            float fator = (float)numericUpDown4.Value;

            if (fator <= 0 || fator > 1)
            {
                MessageBox.Show("O fator deve estar entre 0.01 e 1!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                imgResultado = DividirImagem(img1, fator);
                pictureBox3.Image = imgResultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escurecer a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Bitmap InverterHorizontalmente(Bitmap img1)
        {
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);

                    // Define o pixel na posição espelhada
                    result.SetPixel(img1.Width - x - 1, y, p1);
                }
            }

            return result;
        }

        private void btInverterHor_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = InverterHorizontalmente(img1);
        }
        private Bitmap InverterVerticalmente(Bitmap img1)
        {
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);

                    // Define o pixel na posição espelhada verticalmente
                    result.SetPixel(x, img1.Height - y - 1, p1);
                }
            }

            return result;
        }

        private void btInverterVer_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = InverterVerticalmente(img1);

        }
        private void MostrarDiferencaFinal()
        {
            // Verifica se as imagens foram carregadas
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro!");
                return;
            }

            // Verifica se as dimensões são iguais
            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter as mesmas dimensões!");
                return;
            }

            // C = img1 - img2
            Bitmap imgC = SubtrairImagens(img1, img2);

            // D = img2 - img1
            Bitmap imgD = SubtrairImagens(img2, img1);

            // E = C + D
            Bitmap imgE = SomarImagens(imgC, imgD);

            // Exibe o resultado no resultado
            pictureBox3.Image = imgE;
        }


        private void Diferenca_Click(object sender, EventArgs e)
        {
            MostrarDiferencaFinal();

        }

        public Bitmap Blending(Bitmap img1, Bitmap img2, double c)
        {
            // Verifica se as imagens têm o mesmo tamanho
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                throw new ArgumentException("As imagens devem ter o mesmo tamanho.");

            // Cria uma nova imagem com o mesmo tamanho das imagens de entrada
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            // Percorre cada linha (y) da imagem
            for (int y = 0; y < img1.Height; y++)
            {
                // Percorre cada coluna (x) da imagem
                for (int x = 0; x < img1.Width; x++)
                {
                    // Obtém a cor do pixel atual da primeira imagem
                    Color pixel1 = img1.GetPixel(x, y);

                    // Obtém a cor do pixel atual da segunda imagem
                    Color pixel2 = img2.GetPixel(x, y);

                    // Aplica a fórmula de blending para cada canal de cor (R, G, B)
                    int r = (int)(c * pixel1.R + (1 - c) * pixel2.R); // Canal vermelho
                    int g = (int)(c * pixel1.G + (1 - c) * pixel2.G); // Canal verde
                    int b = (int)(c * pixel1.B + (1 - c) * pixel2.B); // Canal azul

                    // Garante que os valores estejam dentro do intervalo válido [0, 255]
                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    // Define o pixel (x,y) da imagem resultado com a nova cor calculada
                    resultado.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            // Retorna a imagem resultante do blending
            return resultado;
        }

        private void btBlending_Click(object sender, EventArgs e)
        {
            // Verifica se há imagens carregadas na imagem A e B
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Carregue as duas imagens antes de aplicar o blending.");
                return;
            }

            // Converte as imagens para Bitmap
            Bitmap img1 = new Bitmap(pictureBox1.Image);
            Bitmap img2 = new Bitmap(pictureBox2.Image);

            // Pega o valor de C do NumericUpDown (ex: 0 a 100) e converte para [0,1]
            double c = (double)numericUpDown5.Value / 100.0;

            // Chama a função de blending
            Bitmap resultado = Blending(img1, img2, c);

            // Exibe o resultado no resultado
            pictureBox3.Image = resultado;
        }

        public Bitmap MediaImagens(Bitmap img1, Bitmap img2)
        {
            // Verifica se as imagens têm o mesmo tamanho (necessário para o cálculo)
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                throw new ArgumentException("As imagens devem ter o mesmo tamanho.");

            // Cria um novo Bitmap para armazenar a imagem resultante
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            // Percorre cada pixel da imagem
            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    // Obtém o pixel da imagem 1
                    Color pixel1 = img1.GetPixel(x, y);

                    // Obtém o pixel da imagem 2
                    Color pixel2 = img2.GetPixel(x, y);

                    // Calcula a média dos valores RGB
                    int r = (pixel1.R + pixel2.R) / 2;
                    int g = (pixel1.G + pixel2.G) / 2;
                    int b = (pixel1.B + pixel2.B) / 2;

                    // Define o pixel resultante na nova imagem
                    resultado.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            // Retorna a imagem resultante
            return resultado;
        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            // Verifica se as duas imagens foram carregadas
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Carregue as duas imagens antes de calcular a média.");
                return;
            }

            // Converte as imagens dos PictureBoxes para Bitmap
            Bitmap img1 = new Bitmap(pictureBox1.Image);
            Bitmap img2 = new Bitmap(pictureBox2.Image);

            // Chama a função que calcula a média das imagens
            Bitmap resultado = MediaImagens(img1, img2);

            // Exibe a imagem resultante no PictureBox de saída
            pictureBox3.Image = resultado;
        }

        public Bitmap EqualizarHistograma(Bitmap imagemOriginal)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;
            Bitmap imagemEqualizada = new Bitmap(largura, altura);

            int[] histograma = new int[256];
            int[] cdf = new int[256];
            int[] mapeamento = new int[256];
            int numPixels = largura * altura;

            // 1. Calcular o histograma
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    int intensidade = imagemOriginal.GetPixel(x, y).R; // grayscale
                    histograma[intensidade]++;
                }
            }

            // 2. Calcular a distribuição cumulativa de frequência (CDF)
            cdf[0] = histograma[0];
            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histograma[i];
            }

            // 3. Encontrar o menor valor de CDF diferente de zero
            int cdfMin = cdf.First(value => value > 0);

            // 4. Calcular o novo valor de cada intensidade
            for (int i = 0; i < 256; i++)
            {
                mapeamento[i] = (int)Math.Floor(((double)(cdf[i] - cdfMin) / (numPixels - cdfMin)) * 255);
            }

            // 5. Aplicar o mapeamento na imagem
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    int intensidade = imagemOriginal.GetPixel(x, y).R;
                    int novaIntensidade = mapeamento[intensidade];
                    Color novaCor = Color.FromArgb(novaIntensidade, novaIntensidade, novaIntensidade);
                    imagemEqualizada.SetPixel(x, y, novaCor);
                }
            }

            return imagemEqualizada;
        }

        public void ExibirHistograma(Bitmap imagem, Chart chart, string tipo = "Original")
        {
            int[] histograma = new int[256];

            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    int intensidade = imagem.GetPixel(x, y).R;
                    histograma[intensidade]++;
                }
            }

            // Limpa gráfico: áreas, séries e títulos
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();

            // Adiciona área de plotagem
            chart.ChartAreas.Add(new ChartArea("Histograma"));

            // Define o título do gráfico
            chart.Titles.Add(tipo); // Isso coloca "Original" ou "Equalizado"

            // Cria a série com cor baseada no tipo
            Series serie = new Series(tipo);
            serie.ChartType = SeriesChartType.Column;
            serie.Color = tipo == "Original" ? Color.Blue : Color.Red;
            serie.BorderWidth = 1;

            for (int i = 0; i < 256; i++)
            {
                serie.Points.AddXY(i, histograma[i]);
            }

            chart.Series.Add(serie);
        }



        private void btEqualizar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Carregue uma imagem no PictureBox1 primeiro.");
                return;
            }

            // Converte imagem original para Bitmap
            Bitmap imagemOriginal = new Bitmap(pictureBox1.Image);

            // Exibe o histograma da imagem original
            ExibirHistograma(imagemOriginal, chartHistograma, "Original");

            // Aplica a equalização
            Bitmap imagemEqualizada = EqualizarHistograma(imagemOriginal);

            // Mostra a imagem equalizada no PictureBox3
            pictureBox3.Image = imagemEqualizada;

            // Exibe o histograma da imagem equalizada
            ExibirHistograma(imagemEqualizada, chartHistograma, "Equalizado");
        }

        public Bitmap NotOperation(Bitmap image)
        {

            Bitmap result = new Bitmap(image.Width, image.Height);

            // Percorre todos os pixels da imagem
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Lê a cor do pixel atual
                    Color pixel = image.GetPixel(x, y);

                    // Se for preto (0), vira branco (255); senão, vira preto
                    Color inverted = (pixel.R == 0) ? Color.White : Color.Black;

                    // Define o pixel invertido na nova imagem
                    result.SetPixel(x, y, inverted);
                }
            }

            // Retorna a imagem invertida
            return result;
        }


        private void btnNot_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                Bitmap result = NotOperation(img);
                pictureBox3.Image = result;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem binária primeiro.");
            }
        }



        public Bitmap AndOperation(Bitmap img1, Bitmap img2)
        {

            Bitmap result = new Bitmap(img1.Width, img1.Height);

            // Percorre todos os pixels
            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    // Lê o pixel de cada imagem
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Se ambos forem brancos, o resultado é branco; senão, preto
                    Color output = (p1.R == 255 && p2.R == 255) ? Color.White : Color.Black;

                    // Define o pixel na imagem resultado
                    result.SetPixel(x, y, output);
                }
            }

            // Retorna a imagem resultante
            return result;
        }


        private void btnAnd_Click(object sender, EventArgs e)
        {
            if (img1 != null && img2 != null)
            {
                Bitmap result = AndOperation(img1, img2);
                pictureBox3.Image = result;
            }
            else
            {
                MessageBox.Show("Carregue duas imagens binárias.");
            }
        }

        public Bitmap OrOperation(Bitmap img1, Bitmap img2)
        {
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Se pelo menos um pixel for branco, o resultado é branco
                    Color output = (p1.R == 255 || p2.R == 255) ? Color.White : Color.Black;

                    result.SetPixel(x, y, output);
                }
            }

            return result;
        }


        private void btnOr_Click(object sender, EventArgs e)
        {
            if (img1 != null && img2 != null)
            {
                Bitmap result = OrOperation(img1, img2);
                pictureBox3.Image = result;
            }
            else
            {
                MessageBox.Show("Carregue duas imagens binárias.");
            }
        }



        public Bitmap XorOperation(Bitmap img1, Bitmap img2)
        {
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Define se os pixels são brancos (true) ou pretos (false)
                    bool isWhite1 = (p1.R == 255);
                    bool isWhite2 = (p2.R == 255);

                    // XOR: verdadeiro se os valores forem diferentes
                    Color output = (isWhite1 ^ isWhite2) ? Color.White : Color.Black;

                    result.SetPixel(x, y, output);
                }
            }

            return result;
        }


        private void btnXor_Click(object sender, EventArgs e)
        {
            if (img1 != null && img2 != null)
            {
                Bitmap result = XorOperation(img1, img2);
                pictureBox3.Image = result;
            }
            else
            {
                MessageBox.Show("Carregue duas imagens binárias.");
            }
        }

        private Bitmap Threshold(Bitmap img, int limiar)
        {

            Bitmap resultado = new Bitmap(img.Width, img.Height);

            // Percorre todos os pixels da imagem
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    // Pega a cor do pixel atual
                    Color pixel = img.GetPixel(i, j);

                    // Converte o pixel para escala de cinza (média dos canais R, G e B)
                    int valor = (pixel.R + pixel.G + pixel.B) / 3;

                    // Se o valor for maior ou igual ao limiar, define como branco (255)
                    // Senão, define como preto (0)
                    if (valor >= limiar)
                        resultado.SetPixel(i, j, Color.White);  // Branco
                    else
                        resultado.SetPixel(i, j, Color.Black);  // Preto
                }
            }

            // Retorna a imagem binarizada
            return resultado;
        }


        private void btnLimiar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                int limiar = (int)numericUpDownThreshold.Value;

                Bitmap resultado = Threshold(original, limiar);
                pictureBox3.Image = resultado;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem em escala de cinza na Imagem A.");
            }
        }
        private Bitmap AplicarFiltro(Bitmap imagemOriginal, string tipoFiltro)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            // Cria imagem final com mesma dimensão
            Bitmap imagemFiltrada = new Bitmap(largura, altura);

            // Percorre cada pixel da imagem
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // Listas para guardar valores dos canais da vizinhança
                    List<int> valoresR = new List<int>();
                    List<int> valoresG = new List<int>();
                    List<int> valoresB = new List<int>();

                    // Percorre a vizinhança 3x3
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            int vizinhoX = x + i;
                            int vizinhoY = y + j;

                            // Tratamento de borda: replica o pixel mais próximo
                            if (vizinhoX < 0) vizinhoX = 0;
                            if (vizinhoY < 0) vizinhoY = 0;
                            if (vizinhoX >= largura) vizinhoX = largura - 1;
                            if (vizinhoY >= altura) vizinhoY = altura - 1;

                            Color corVizinho = imagemOriginal.GetPixel(vizinhoX, vizinhoY);

                            valoresR.Add(corVizinho.R);
                            valoresG.Add(corVizinho.G);
                            valoresB.Add(corVizinho.B);
                        }
                    }

                    // Calcula novo valor com base no tipo de filtro
                    int novoR = 0, novoG = 0, novoB = 0;

                    if (tipoFiltro == "MIN")
                    {
                        novoR = valoresR.Min();
                        novoG = valoresG.Min();
                        novoB = valoresB.Min();
                    }
                    else if (tipoFiltro == "MAX")
                    {
                        novoR = valoresR.Max();
                        novoG = valoresG.Max();
                        novoB = valoresB.Max();
                    }
                    else if (tipoFiltro == "MEAN")
                    {
                        novoR = (int)valoresR.Average();
                        novoG = (int)valoresG.Average();
                        novoB = (int)valoresB.Average();
                    }

                    // Aplica o novo pixel na imagem filtrada
                    imagemFiltrada.SetPixel(x, y, Color.FromArgb(novoR, novoG, novoB));
                }
            }

            return imagemFiltrada;
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (img1 != null && comboBoxFiltros.SelectedItem != null)
            {
                string tipoFiltro = comboBoxFiltros.SelectedItem.ToString();
                Bitmap novaImagem = AplicarFiltro(img1, tipoFiltro);
                pictureBox3.Image = novaImagem;
            }
        }
        public Bitmap FiltroSalPimentaMediana(Bitmap imagemOriginal)
        {
            // Cria uma nova imagem do mesmo tamanho para armazenar o resultado do filtro
            Bitmap imagemFiltrada = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);

            // Percorre a imagem, ignorando a borda (evita sair dos limites na janela 3x3)
            for (int y = 1; y < imagemOriginal.Height - 1; y++)
            {
                for (int x = 1; x < imagemOriginal.Width - 1; x++)
                {
                    // Listas para armazenar os valores dos canais R, G e B dos pixels vizinhos
                    List<byte> valoresR = new List<byte>();
                    List<byte> valoresG = new List<byte>();
                    List<byte> valoresB = new List<byte>();

                    // Percorre a vizinhança 3x3 ao redor do pixel (x, y)
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            // Obtém a cor do pixel vizinho
                            Color pixel = imagemOriginal.GetPixel(x + i, y + j);

                            // Adiciona os valores de R, G e B às respectivas listas
                            valoresR.Add(pixel.R);
                            valoresG.Add(pixel.G);
                            valoresB.Add(pixel.B);
                        }
                    }

                    // Ordena as listas de valores dos canais
                    valoresR.Sort();
                    valoresG.Sort();
                    valoresB.Sort();

                    // A mediana é o valor que está na posição central (5ª posição de 0 a 8)
                    byte medianaR = valoresR[4];
                    byte medianaG = valoresG[4];
                    byte medianaB = valoresB[4];

                    // Cria uma nova cor com os valores medianos
                    Color novaCor = Color.FromArgb(medianaR, medianaG, medianaB);

                    // Define essa nova cor no pixel correspondente da imagem filtrada
                    imagemFiltrada.SetPixel(x, y, novaCor);
                }
            }

            // Retorna a imagem com o filtro de mediana aplicado
            return imagemFiltrada;
        }

        private void btnSalPimenta_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap resultado = FiltroSalPimentaMediana(original);
                pictureBox3.Image = resultado;
            }


        }
        public Bitmap FiltroSalPimentaOrdem(Bitmap imagemOriginal, int ordem)
        {
            // Cria uma nova imagem para armazenar o resultado do filtro
            Bitmap imagemFiltrada = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);

            // Percorre todos os pixels, exceto a borda (por causa da vizinhança 3x3)
            for (int y = 1; y < imagemOriginal.Height - 1; y++)
            {
                for (int x = 1; x < imagemOriginal.Width - 1; x++)
                {
                    // Listas para armazenar os valores R, G e B da vizinhança
                    List<byte> valoresR = new List<byte>();
                    List<byte> valoresG = new List<byte>();
                    List<byte> valoresB = new List<byte>();

                    // Percorre a vizinhança 3x3
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = imagemOriginal.GetPixel(x + i, y + j);

                            // Adiciona os canais à lista
                            valoresR.Add(pixel.R);
                            valoresG.Add(pixel.G);
                            valoresB.Add(pixel.B);
                        }
                    }

                    // Ordena os valores da vizinhança
                    valoresR.Sort();
                    valoresG.Sort();
                    valoresB.Sort();

                    // Ajusta o índice da ordem (1 = menor, 9 = maior)
                    int indice = ordem - 1;
                    if (indice < 0) indice = 0;
                    if (indice > 8) indice = 8;


                    // Seleciona o valor da ordem desejada
                    byte valorR = valoresR[indice];
                    byte valorG = valoresG[indice];
                    byte valorB = valoresB[indice];

                    // Cria a nova cor e define no pixel da imagem filtrada
                    Color novaCor = Color.FromArgb(valorR, valorG, valorB);
                    imagemFiltrada.SetPixel(x, y, novaCor);
                }
            }

            // Retorna a nova imagem com o filtro aplicado
            return imagemFiltrada;
        }

        private void btnSalPimentaOrdem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                // Obtém o valor da ordem escolhido pelo usuário (1 a 9)
                int ordem = (int)numericUpDown6.Value;

                // Criando imagem Original
                Bitmap ImagemOriginal = new Bitmap(pictureBox1.Image);

                // Aplica o filtro de ordem
                Bitmap imagemFiltrada = FiltroSalPimentaOrdem(ImagemOriginal, ordem);

                // Exibe a imagem filtrada
                pictureBox3.Image = imagemFiltrada;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
            }
        }

        public Bitmap FitroSalPimentaSuavizacao(Bitmap img)
        {
            Bitmap novaImg = new Bitmap(img.Width, img.Height);

            for (int y = 1; y < img.Height - 1; y++)
            {
                for (int x = 1; x < img.Width - 1; x++)
                {
                    List<byte> vizinhosR = new List<byte>();
                    List<byte> vizinhosG = new List<byte>();
                    List<byte> vizinhosB = new List<byte>();

                    // Percorre os 8 vizinhos (3x3, excluindo o pixel central)
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (i == 0 && j == 0) continue; // Pula o centro
                            Color corVizinho = img.GetPixel(x + i, y + j);
                            vizinhosR.Add(corVizinho.R);
                            vizinhosG.Add(corVizinho.G);
                            vizinhosB.Add(corVizinho.B);
                        }
                    }

                    // Pega o pixel central
                    Color pixelCentral = img.GetPixel(x, y);

                    // Aplica a lógica do filtro para cada canal
                    byte r = ClampConservador(pixelCentral.R, vizinhosR);
                    byte g = ClampConservador(pixelCentral.G, vizinhosG);
                    byte b = ClampConservador(pixelCentral.B, vizinhosB);

                    novaImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return novaImg;
        }

        // Função auxiliar para aplicar o filtro conservador a um canal
        private byte ClampConservador(byte valorCentral, List<byte> vizinhos)
        {
            byte min = vizinhos.Min();
            byte max = vizinhos.Max();

            if (valorCentral < min) return min;
            if (valorCentral > max) return max;
            return valorCentral;
        }

        private void btnSalPimentaSuavizacao_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap resultado = FitroSalPimentaSuavizacao(img1);
                pictureBox3.Image = resultado;
            }
        }


        private Bitmap FiltroGaussiano(Bitmap imagem, int tamanhoKernel, double sigma)
        {
            // Cria a imagem de saída com as mesmas dimensões da original
            Bitmap imagemFiltrada = new Bitmap(imagem.Width, imagem.Height);

            // Cria o kernel Gaussiano com base nos parâmetros
            double[,] kernel = GerarKernelGaussiano(tamanhoKernel, sigma);

            int offset = tamanhoKernel / 2; // Para posicionar o centro do kernel

            // Percorre cada pixel da imagem original
            for (int y = offset; y < imagem.Height - offset; y++)
            {
                for (int x = offset; x < imagem.Width - offset; x++)
                {
                    double somaR = 0, somaG = 0, somaB = 0;

                    // Percorre o kernel ao redor do pixel atual
                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            // Pega o pixel vizinho
                            Color pixel = imagem.GetPixel(x + kx, y + ky);

                            // Pega o peso do kernel correspondente
                            double peso = kernel[ky + offset, kx + offset];

                            // Aplica o peso a cada canal (R, G, B)
                            somaR += pixel.R * peso;
                            somaG += pixel.G * peso;
                            somaB += pixel.B * peso;
                        }
                    }

                    // Clampeia os valores para o intervalo [0, 255] e converte para inteiro
                    int r = Math.Min(255, Math.Max(0, (int)Math.Round(somaR)));
                    int g = Math.Min(255, Math.Max(0, (int)Math.Round(somaG)));
                    int b = Math.Min(255, Math.Max(0, (int)Math.Round(somaB)));

                    // Define o pixel filtrado na imagem de saída
                    imagemFiltrada.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return imagemFiltrada; // Retorna a imagem suavizada
        }
        private double[,] GerarKernelGaussiano(int tamanho, double sigma)
        {
            double[,] kernel = new double[tamanho, tamanho];
            double soma = 0;

            int offset = tamanho / 2;
            double constante = 1.0 / (2 * Math.PI * sigma * sigma);

            // Preenche o kernel com os valores da fórmula gaussiana
            for (int y = -offset; y <= offset; y++)
            {
                for (int x = -offset; x <= offset; x++)
                {
                    double expoente = -(x * x + y * y) / (2 * sigma * sigma);
                    double valor = constante * Math.Exp(expoente);
                    kernel[y + offset, x + offset] = valor;
                    soma += valor; // Soma total para normalização
                }
            }

            // Normaliza os valores para que a soma do kernel seja 1
            for (int y = 0; y < tamanho; y++)
            {
                for (int x = 0; x < tamanho; x++)
                {
                    kernel[y, x] /= soma;
                }
            }

            return kernel;
        }

        private void btnFiltroGaussiano_Click(object sender, EventArgs e)
        {
            // Verifica se a imagem original foi carregada
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return; // Sai da função se não houver imagem
            }

            // Obtém o valor do tamanho do kernel a partir do controle NumericUpDown do Kernel
            int tamanhoKernel = (int)numericUpDownKernel.Value;

            // Obtém o valor do desvio-padrão sigma a partir do controle NumericUpDown do Sigma
            double sigma = (double)numericUpDownSigma.Value;

            // Verifica se o tamanho do kernel é ímpar (obrigatório para ter um centro)
            if (tamanhoKernel % 2 == 0)
            {
                MessageBox.Show("O tamanho do kernel deve ser ímpar.");
                return; // Sai da função se o valor for par
            }

            // Aplica o filtro Gaussiano na imagem original usando os parâmetros escolhidos
            Bitmap imagemFiltrada = FiltroGaussiano(img1, tamanhoKernel, sigma);

            // Exibe a imagem filtrada no PictureBox3
            pictureBox3.Image = imagemFiltrada;
        }

        public Bitmap FiltroPrimeiraOrdem(Bitmap imagem, int[,] kernelX, int[,] kernelY)
        {
            int largura = imagem.Width;
            int altura = imagem.Height;
            Bitmap imagemSaida = new Bitmap(largura, altura);

            int offset = 1; // porque os kernels são 3x3

            for (int y = offset; y < altura - offset; y++)
            {
                for (int x = offset; x < largura - offset; x++)
                {
                    int somaX = 0;
                    int somaY = 0;

                    // Aplica os kernels
                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            Color cor = imagem.GetPixel(x + kx, y + ky);
                            int intensidade = (cor.R + cor.G + cor.B) / 3;

                            somaX += intensidade * kernelX[ky + offset, kx + offset];
                            somaY += intensidade * kernelY[ky + offset, kx + offset];
                        }
                    }

                    // Magnitude do gradiente
                    int magnitude = (int)Math.Sqrt(somaX * somaX + somaY * somaY);

                    // Limita entre 0 e 255
                    magnitude = Math.Max(0, Math.Min(255, magnitude));

                    Color corNova = Color.FromArgb(magnitude, magnitude, magnitude);
                    imagemSaida.SetPixel(x, y, corNova);
                }
            }

            return imagemSaida;
        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            int[,] prewittX = new int[3, 3] {
                 { -1, 0, 1 },
                 { -1, 0, 1 },
                 { -1, 0, 1 }
    };

            int[,] prewittY = new int[3, 3] {
                 {  1,  1,  1 },
                 {  0,  0,  0 },
                 { -1, -1, -1 }
    };

            if (img1 != null)
            {
                Bitmap resultado = FiltroPrimeiraOrdem(img1, prewittX, prewittY);
                pictureBox3.Image = resultado;
            }
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            int[,] sobelX = new int[3, 3] {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
    };

            int[,] sobelY = new int[3, 3] {
                {  1,  2,  1 },
                {  0,  0,  0 },
                { -1, -2, -1 }
    };

            if (img1 != null)
            {
                Bitmap resultado = FiltroPrimeiraOrdem(img1, sobelX, sobelY);
                pictureBox3.Image = resultado;
            }
        }
        public Bitmap FiltroSegundaOrdem(Bitmap imagem, int[,] laplaciano)
        {
            int largura = imagem.Width;
            int altura = imagem.Height;

            // Cria uma nova imagem para armazenar o resultado
            Bitmap imagemFiltrada = new Bitmap(largura, altura);

            int offset = 1; // Porque a máscara é 3x3, o centro é 1 pixel longe da borda

            // Percorre cada pixel da imagem, ignorando as bordas
            for (int y = offset; y < altura - offset; y++)
            {
                for (int x = offset; x < largura - offset; x++)
                {
                    int soma = 0;

                    // Aplica a convolução: percorre a vizinhança 3x3 ao redor do pixel (x, y)
                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            // Captura a cor do pixel vizinho
                            Color corVizinho = imagem.GetPixel(x + kx, y + ky);

                            // Converte para tons de cinza usando média dos canais RGB
                            int intensidade = (corVizinho.R + corVizinho.G + corVizinho.B) / 3;

                            // Multiplica a intensidade pelo peso do kernel
                            soma += intensidade * laplaciano[ky + offset, kx + offset];
                        }
                    }

                    // Usa valor absoluto para garantir que o resultado esteja entre 0 e 255
                    soma = Math.Abs(soma);
                    soma = Math.Min(255, Math.Max(0, soma)); // Clampeia para faixa válida

                    // Cria a nova cor em tons de cinza
                    Color novaCor = Color.FromArgb(soma, soma, soma);

                    // Define o pixel filtrado na imagem final
                    imagemFiltrada.SetPixel(x, y, novaCor);
                }
            }

            return imagemFiltrada; // Retorna a imagem com as bordas detectadas
        }


        private void btnLaplaciano_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                // Verifica qual máscara foi selecionada no ComboBox
                int[,] laplaciano;

                if (comboBoxLaplaciano.SelectedItem.ToString() == "4-vizinhos")
                {
                    // Máscara com 4 vizinhos (sem diagonais)
                    laplaciano = new int[3, 3]
                    {
                {  0, -1,  0 },
                { -1,  4, -1 },
                {  0, -1,  0 }
                    };
                }
                else
                {
                    // Máscara com 8 vizinhos (com diagonais)
                    laplaciano = new int[3, 3]
                    {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
                    };
                }

                // Aplica o filtro com a máscara escolhida
                Bitmap resultado = FiltroSegundaOrdem(img1, laplaciano);

                // Exibe no PictureBox3
                pictureBox3.Image = resultado;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
            }
        }

        public Bitmap Dilatacao(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            // Inicializa a imagem de saída com fundo preto
            Bitmap imagemDilatada = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(imagemDilatada))
            {
                g.Clear(Color.Black);
            }

            int seAltura = elementoEstruturante.GetLength(0);
            int seLargura = elementoEstruturante.GetLength(1);
            int offsetY = seAltura / 2;
            int offsetX = seLargura / 2;

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Color cor = imagemOriginal.GetPixel(x, y);
                    int valorPixel = (cor.R == 255) ? 1 : 0;

                    if (valorPixel == 1) // pixel branco ativo
                    {
                        // Aplica o elemento estruturante
                        for (int j = 0; j < seAltura; j++)
                        {
                            for (int i = 0; i < seLargura; i++)
                            {
                                if (elementoEstruturante[j, i] == 1)
                                {
                                    int nx = x + i - offsetX;
                                    int ny = y + j - offsetY;

                                    // Se dentro da imagem, pinta de branco
                                    if (nx >= 0 && nx < largura && ny >= 0 && ny < altura)
                                    {
                                        imagemDilatada.SetPixel(nx, ny, Color.White);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return imagemDilatada;
        }


        private void btnDilatacao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem binária primeiro.");
                return;
            }

            // Definição do elemento estruturante de acordo com o ComboBox
            int[,] SE;

            switch (comboBoxSE.SelectedItem.ToString())
            {
                case "Quadrado 3x3":
                    SE = new int[3, 3]
                    {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
                    };
                    break;

                case "Cruz":
                    SE = new int[3, 3]
                    {
            { 0, 1, 0 },
            { 1, 1, 1 },
            { 0, 1, 0 }
                    };
                    break;

                case "Circular":
                    SE = new int[5, 5]
                    {
            { 0, 0, 1, 0, 0 },
            { 0, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 0 },
            { 0, 0, 1, 0, 0 }
                    };
                    break;

                case "Linha Horizontal":
                    SE = new int[1, 5]
                    {
            { 1, 1, 1, 1, 1 }
                    };
                    break;

                case "Linha Vertical":
                    SE = new int[5, 1]
                    {
            { 1 },
            { 1 },
            { 1 },
            { 1 },
            { 1 }
                    };
                    break;

                default:
                    MessageBox.Show("Selecione um elemento estruturante válido.");
                    return;
            }

            // Aplica a dilatação diretamente sobre a imagem carregada
            Bitmap resultado = Dilatacao(img1, SE);

            // Exibe o resultado no PictureBox3
            pictureBox3.Image = resultado;
        }
        public Bitmap Erosao(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            // Cria imagem de saída com fundo preto (tudo 0 inicialmente)
            Bitmap imagemErodida = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(imagemErodida))
            {
                g.Clear(Color.Black);
            }

            int seAltura = elementoEstruturante.GetLength(0);
            int seLargura = elementoEstruturante.GetLength(1);
            int offsetY = seAltura / 2;
            int offsetX = seLargura / 2;

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    bool match = true; // Suponha que vai ser branco

                    // Verifica toda a vizinhança do elemento estruturante
                    for (int j = 0; j < seAltura; j++)
                    {
                        for (int i = 0; i < seLargura; i++)
                        {
                            if (elementoEstruturante[j, i] == 1)
                            {
                                int nx = x + i - offsetX;
                                int ny = y + j - offsetY;

                                // Verifica se está dentro da imagem
                                if (nx >= 0 && nx < largura && ny >= 0 && ny < altura)
                                {
                                    Color cor = imagemOriginal.GetPixel(nx, ny);
                                    int valorPixel = (cor.R == 255) ? 1 : 0;

                                    if (valorPixel == 0) // Se houver um preto, falha
                                    {
                                        match = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // Fora da imagem, considera preto (falha)
                                    match = false;
                                    break;
                                }
                            }
                        }
                        if (!match) break;
                    }

                    if (match)
                    {
                        // Mantém branco
                        imagemErodida.SetPixel(x, y, Color.White);
                    }
                }
            }

            return imagemErodida;
        }


        private void btnErosao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem binária primeiro.");
                return;
            }

            int[,] SE;

            switch (comboBoxErosao.SelectedItem.ToString())
            {
                case "Quadrado 3x3":
                    SE = new int[3, 3]
                    {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
                    };
                    break;

                case "Diamante 5x5":
                    SE = new int[5, 5]
                    {
                     { 0, 0, 1, 0, 0 },
                     { 0, 1, 1, 1, 0 },
                     { 1, 1, 1, 1, 1 },
                     { 0, 1, 1, 1, 0 },
                     { 0, 0, 1, 0, 0 }
                         };
                    break;

                case "Linha":
                    SE = new int[1, 9]
                    {
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1 }
                    };
                    break;

                default:
                    MessageBox.Show("Selecione um elemento estruturante válido.");
                    return;
            }

            // Aplica a Erosão e mostra no PictureBox3
            Bitmap resultado = Erosao(img1, SE);
            pictureBox3.Image = resultado;
        }
        public Bitmap Abertura(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            // Aplica Erosão primeiro
            Bitmap erodida = Erosao(imagemOriginal, elementoEstruturante);

            // Depois aplica Dilatação sobre a imagem erodida
            Bitmap resultado = Dilatacao(erodida, elementoEstruturante);

            return resultado;
        }

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem binária primeiro.");
                return;
            }

            int[,] SE;

            // Define o elemento estruturante conforme ComboBox
            switch (comboBoxAbertura.SelectedItem.ToString())
            {
                case "Diamante 3x3":
                    SE = new int[3, 3]
                    {
                { 0, 1, 0 },
                { 1, 1, 1 },
                { 0, 1, 0 }
                    };
                    break;

                case "Quadrado 3x3":
                    SE = new int[3, 3]
                    {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
                    };
                    break;

                case "Linha Horizontal":
                    SE = new int[1, 7]
                    {
                { 1, 1, 1, 1, 1, 1, 1 }
                    };
                    break;

                default:
                    MessageBox.Show("Selecione um elemento estruturante válido.");
                    return;
            }

            // Aplica Abertura e exibe no PictureBox3
            Bitmap resultado = Abertura(img1, SE);
            pictureBox3.Image = resultado;
        }

        // Função de Fechamento Morfológico
        public Bitmap Fechamento(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            // Primeiro aplica a Dilatação na imagem
            Bitmap imagemDilatada = Dilatacao(imagemOriginal, elementoEstruturante);

            // Depois aplica a Erosão na imagem dilatada
            Bitmap imagemFechada = Erosao(imagemDilatada, elementoEstruturante);

            // Retorna a imagem resultante do fechamento
            return imagemFechada;
        }


        private void btnFechamento_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
                //Definir aqui o elemento estruturante que deseja usar.
                // Exemplo: Elemento estruturante Quadrado 3x3
                int[,] elementoEstruturante = new int[,]
                {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
                };

                // Executa a operação de Fechamento
                Bitmap resultado = Fechamento(imgOriginal, elementoEstruturante);

                // Exibe a imagem resultante no PictureBox3
                pictureBox3.Image = resultado;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
            }
        }

        public Bitmap FechamentoAbertura(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            //Primeiro aplica o Fechamento: Dilatação -> Erosão
            Bitmap imagemFechada = Fechamento(imagemOriginal, elementoEstruturante);

            //Depois aplica a Abertura: Erosão -> Dilatação
            Bitmap resultado = Abertura(imagemFechada, elementoEstruturante);

            return resultado;
        }
        private void btnFechamentoAbertura_Click(object sender, EventArgs e)
        {
            if (imgOriginal != null)
            {
               
              
                int[,] elementoEstruturante = new int[,]
                {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
                };

                // Executa Fechamento seguido de Abertura
                Bitmap resultado = FechamentoAbertura(imgOriginal, elementoEstruturante);

                // Mostra o resultado no PictureBox3
                pictureBox3.Image = resultado;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
            }
        }
        public Bitmap Contorno(Bitmap imagemOriginal, int[,] elementoEstruturante)
        {
            // Aplica a erosão na imagem original
            Bitmap imagemErodida = Erosao(imagemOriginal, elementoEstruturante);

            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            // Cria imagem de saída
            Bitmap imagemContorno = new Bitmap(largura, altura);

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // Pega o pixel da imagem original
                    Color corOriginal = imagemOriginal.GetPixel(x, y);
                    int valorOriginal = (corOriginal.R == 255) ? 1 : 0;

                    // Pega o pixel da imagem erodida
                    Color corErodida = imagemErodida.GetPixel(x, y);
                    int valorErodido = (corErodida.R == 255) ? 1 : 0;

                    // Faz a subtração: Original - Erosão
                    int valorContorno = valorOriginal - valorErodido;

                    if (valorContorno == 1)
                    {
                        imagemContorno.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        imagemContorno.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return imagemContorno;
        }

        private void btnContorno_Click(object sender, EventArgs e)
        {
            if (imgOriginal == null)
            {
                MessageBox.Show("Por favor, carregue uma imagem primeiro.");
                return;
            }

            
            int[,] elementoEstruturante = new int[,]
            {
        {1,1,1},
        {1,1,1},
        {1,1,1}
            };

            // Aplica o contorno
            Bitmap resultado = Contorno(imgOriginal, elementoEstruturante);

            // Mostra o resultado no PictureBox3
            pictureBox3.Image = resultado;
        }
    }

}




