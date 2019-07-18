using Joguinho.Enums;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Joguinho
{

    public partial class FormPrincipal : Form
    {
        int totalBatidas;
        int seg;
        int min;
        bool pausado = false;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private static void ExecutarMusica(string caminho)
        {
            using (var audio = new SoundPlayer(caminho))
            {
                audio.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_tempo.Enabled = true;
            ExecutarMusica("../../Musica/sonic.wav");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pausado)
            {
                if (e.KeyCode.ToString() == "Right")
                {
                    if (ptb_entregador.Left <= 217)
                    {
                        ptb_entregador.Left = ptb_entregador.Left + 5;
                    }
                }
                else if (e.KeyCode.ToString() == "Left")
                {
                    if (ptb_entregador.Left >= 62)
                    {
                        ptb_entregador.Left = ptb_entregador.Left - 5;
                    }
                }
                else if (e.KeyCode.ToString() == "Down")
                {
                    ptb_entregador.Top = ptb_entregador.Top + 5;
                }
                else if (e.KeyCode.ToString() == "Up")
                {
                    ptb_entregador.Top = ptb_entregador.Top - 5;
                }
            }
        }

        public static int RetornaPosicaoRandomica()
        {
            var random = new Random();
            var valor = Convert.ToInt32(random.NextDouble() * (ActiveForm.Size.Height - ActiveForm.Size.Width) + ActiveForm.Size.Width);
            return valor;
        }

        public static void TrocarPersonagem(Personagem personagem)
        {
            switch (personagem)
            {
                case Personagem.Temer:
                    break;
                case Personagem.Bolsonaro:
                    break;
                case Personagem.Lula:
                    break;
                case Personagem.Aecio:
                    break;
                case Personagem.Moro:
                    break;
                case Personagem.Amoedo:
                    break;
                default:
                    break;
            }
        }

        public static void DefinirPosicoes()
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Linha que detecta se pegou o dinheiro
            if (ptb_entregador.Top >= 154 && ptb_entregador.Top <= 207 && ptb_entregador.Left >= 98 && ptb_entregador.Left <= 144 && (ptb_item.Bounds.IntersectsWith(ptb_entregador.Bounds)))
            {

                timer1.Enabled = false;
                timer_tempo.Enabled = false;
                var resposta = MessageBox.Show("Você pegou a propina,agora à entregue!");
                if (resposta == DialogResult.OK)
                {

                    ptb_entregador.ImageLocation = ("../../Imagens/temerwithmoney.png");
                    ptb_entregador.Left = 138;
                    ptb_entregador.Top = 369;
                    ptb_obstaculo1.Top = 78;
                    ptb_obstaculo1.Left = 50;
                    ptb_obstaculo2.Top = 0;
                    ptb_obstaculo2.Left = 100;
                    ptb_obstaculo3.Top = 33;
                    ptb_obstaculo1.Left = 144;
                    timer_tempo.Enabled = true;
                    var pt = new Point(300, 183);

                    this.ptb_item.Location = pt;


                    timer1.Enabled = true;
                }


            }
            ptb_obstaculo1.Top = ptb_obstaculo1.Top + 2;
            if (ptb_obstaculo1.Top >= 540)
            {
                ptb_obstaculo1.Top = 26;
            }
            ptb_obstaculo2.Top = ptb_obstaculo2.Top + 2;
            if (ptb_obstaculo2.Top >= 540)
            {
                ptb_obstaculo2.Top = 26;
            }
            ptb_obstaculo3.Top = ptb_obstaculo3.Top + 2;
            if (ptb_obstaculo3.Top >= 540)
            {
                ptb_obstaculo3.Top = 26;
            }
            ptb_recebedor.Left = ptb_recebedor.Left + 2;
            if (ptb_recebedor.Left >= 191)
            {
                ptb_recebedor.Left = 58;
            }
            // Linha do win do jogo
            if (ptb_entregador.Top <= 28)
            {
                timer1.Enabled = false;
                timer_tempo.Enabled = false;
                var resposta2 = MessageBox.Show("Cunha ficará calado!");
                if (resposta2 == DialogResult.OK)
                {
                    ptb_vitoria.Visible = true;
                }
            }
            //Linha de batida caso entre em contato com fora temer
            if (ptb_obstaculo1.Bounds.IntersectsWith(ptb_entregador.Bounds) || ptb_obstaculo2.Bounds.IntersectsWith(ptb_entregador.Bounds) || ptb_obstaculo3.Bounds.IntersectsWith(ptb_entregador.Bounds))
            {
                totalBatidas = totalBatidas + 1;
                lbl_batidas.Text = "Total de Golpes: " + totalBatidas;

                timer1.Enabled = false;
                timer_tempo.Enabled = false;
                var resposta = MessageBox.Show("Fora Temer!");
                if (resposta == DialogResult.OK)
                {
                    ptb_entregador.Left = 138;
                    ptb_entregador.Top = 369;
                    ptb_obstaculo1.Top = 72;

                    ptb_obstaculo3.Top = 30;
                    ptb_obstaculo2.Top = 0;
                    timer_tempo.Enabled = true;

                    timer1.Enabled = true;
                }

                //caso chegue a 1:00 game over
                if (min == 1)
                {
                    ptb_gameOver.Visible = true;
                    totalBatidas = 0;
                    lbl_batidas.Text = "Total de Golpes :0";
                    lbl_tempo.Text = "00:00";
                    ptb_entregador.Left = 138;
                    ptb_entregador.Top = 369;
                    ptb_obstaculo1.Top = 78;
                    timer_tempo.Enabled = false;
                    timer1.Enabled = false;

                }
                //se bater 3 vezes perde
                if (totalBatidas == 3)
                {
                    ptb_gameOver.Visible = true;
                    timer1.Enabled = false;
                    totalBatidas = 0;
                    lbl_batidas.Text = "Total de Golpes :0";
                    lbl_tempo.Text = "00:00";
                    ptb_entregador.Left = 138;
                    ptb_entregador.Top = 369;
                    ptb_obstaculo1.Top = 78;
                    timer_tempo.Enabled = false;

                }
            }
        }



        private void timer_tempo_Tick(object sender, EventArgs e)
        {
            //Codigo do tempo
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                seg++;
                min = 0;
            }
            lbl_tempo.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }

        private void NovoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ptb_gameOver.Visible = false;
            ptb_entregador.ImageLocation = ("../../Resources/temer.png");
            totalBatidas = 0;
            lbl_batidas.Text = "Total de Golpes :0";
            lbl_tempo.Text = "00:00";
            ptb_entregador.Left = RetornaPosicaoRandomica();
            ptb_entregador.Top = RetornaPosicaoRandomica();
            ptb_obstaculo1.Top = RetornaPosicaoRandomica();
            ptb_obstaculo1.Left = RetornaPosicaoRandomica();
            ptb_obstaculo3.Top = RetornaPosicaoRandomica();
            ptb_obstaculo3.Left = RetornaPosicaoRandomica();
            ptb_obstaculo2.Top = RetornaPosicaoRandomica();
            ptb_obstaculo2.Left = RetornaPosicaoRandomica();
            min = 0;
            seg = 0;
            timer_tempo.Stop();
            timer_tempo.Start();
            timer_tempo.Enabled = true;
            var pt = new Point(111, 183);

            this.ptb_item.Location = pt;

            ptb_item.Visible = true;
            ptb_vitoria.Visible = false;
            timer1.Enabled = true;
        }

        private void PausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo botao pausar
            timer1.Enabled = false;
            timer_tempo.Enabled = false;
            pausado = true;
        }

        private void DespausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo botao despausar
            timer1.Enabled = true;
            timer_tempo.Enabled = true;
            pausado = false;
        }

        private void timer_tempo_Tick_1(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            else if (min == 60)
            {
                seg++;
                min = 0;
            }
            lbl_tempo.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }

        public static void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }


}



