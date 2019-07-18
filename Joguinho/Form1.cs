using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Joguinho
{

    public partial class Form1 : Form
    {
        int totalBatidas = 0;
        int seg = 0;
        int min = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer("../../Musica/sonic.wav");

            audio.Play();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer_tempo.Enabled = true;
            playaudio();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Right")
            {
                if (homem.Left <= 217)
                {
                    homem.Left = homem.Left + 5;
                }
            }
            else if (e.KeyCode.ToString() == "Left")
            {
                if (homem.Left >= 62)
                {
                    homem.Left = homem.Left - 5;
                }
            }
            else if (e.KeyCode.ToString() == "Down")
            {
                homem.Top = homem.Top + 5;
            }
            else if (e.KeyCode.ToString() == "Up")
            {
                homem.Top = homem.Top - 5;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Linha que detecta se pegou o dinheiro
            if (homem.Top >= 154 && homem.Top <= 207 && homem.Left >= 98 && homem.Left <= 144 && (dinheiro.Bounds.IntersectsWith(homem.Bounds)))
            {

                timer1.Enabled = false;
                timer_tempo.Enabled = false;
                var resposta = MessageBox.Show("Você pegou a propina,agora à entregue!");
                if (resposta == DialogResult.OK)
                {

                    homem.ImageLocation = ("../../Imagens/temerwithmoney.png");
                    homem.Left = 138;
                    homem.Top = 369;
                    foratemer.Top = 78;
                    foratemer.Left = 50;
                    ptb_foratemer2.Top = 0;
                    ptb_foratemer2.Left = 100;
                    foratemer3.Top = 33;
                    foratemer.Left = 144;
                    timer_tempo.Enabled = true;
                    Point pt = new Point(300, 183);

                    this.dinheiro.Location = pt;


                    timer1.Enabled = true;
                }


            }
            foratemer.Top = foratemer.Top + 2;
            if (foratemer.Top >= 540)
            {
                foratemer.Top = 26;
            }
            ptb_foratemer2.Top = ptb_foratemer2.Top + 2;
            if (ptb_foratemer2.Top >= 540)
            {
                ptb_foratemer2.Top = 26;
            }
            foratemer3.Top = foratemer3.Top + 2;
            if (foratemer3.Top >= 540)
            {
                foratemer3.Top = 26;
            }
            eduardo_cunha.Left = eduardo_cunha.Left + 2;
            if (eduardo_cunha.Left >= 191)
            {
                eduardo_cunha.Left = 58;
            }
            // Linha do win do jogo
            if (homem.Top <= 28)
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
            if (foratemer.Bounds.IntersectsWith(homem.Bounds) || ptb_foratemer2.Bounds.IntersectsWith(homem.Bounds) || foratemer3.Bounds.IntersectsWith(homem.Bounds))
            {
                totalBatidas = totalBatidas + 1;
                lbl_batidas.Text = "Total de Golpes: " + totalBatidas.ToString();

                timer1.Enabled = false;
                timer_tempo.Enabled = false;
                var resposta = MessageBox.Show("Fora Temer!");
                if (resposta == DialogResult.OK)
                {
                    homem.Left = 138;
                    homem.Top = 369;
                    foratemer.Top = 72;

                    foratemer3.Top = 30;
                    ptb_foratemer2.Top = 0;
                    timer_tempo.Enabled = true;

                    timer1.Enabled = true;
                }

                



            //caso chegue a 1:30 game over
                        if (lbl_tempo.Text == "01:00")
                {
                    game_over.Visible = true;
                    totalBatidas = 0;
                    lbl_batidas.Text = "Total de Golpes :0";
                    lbl_tempo.Text = "00:00";
                    homem.Left = 138;
                    homem.Top = 369;
                    foratemer.Top = 78;
                    timer_tempo.Enabled = false;
                    timer1.Enabled = false;

                }
                        //se bater 3 vezes perde
                if (totalBatidas == 3)
                {
                    game_over.Visible = true;
                    timer1.Enabled = false;
                    totalBatidas = 0;
                    lbl_batidas.Text = "Total de Golpes :0";
                    lbl_tempo.Text = "00:00";
                    homem.Left = 138;
                    homem.Top = 369;
                    foratemer.Top = 78;
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

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo botao novo jogo
            game_over.Visible = false;
            homem.ImageLocation = ("../../Resources/temer.png");
            totalBatidas = 0;
            lbl_batidas.Text = "Total de Golpes :0";
            lbl_tempo.Text = "00:00";
            homem.Left = 138;
            homem.Top = 369;
            foratemer.Top = 113;
            foratemer.Left = 113;
            foratemer3.Top = 97;
            foratemer3.Left = 207;
            ptb_foratemer2.Top =58;
            ptb_foratemer2.Left =57;
            timer_tempo.Enabled = true;
            Point pt = new Point(111, 183);

            this.dinheiro.Location = pt;
            
            dinheiro.Visible = true;
            ptb_vitoria.Visible = false;
            timer1.Enabled = true;
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo botao pausar
            timer1.Enabled = false;
            timer_tempo.Enabled = false;
        }

        private void despausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo botao despausar
            timer1.Enabled = true;
            timer_tempo.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo fechar aplicativo
            Application.Exit();
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

       
    }
     
         
    }
    
        
    
