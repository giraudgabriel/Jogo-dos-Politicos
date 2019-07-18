namespace Joguinho
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homem = new System.Windows.Forms.PictureBox();
            this.lbl_batidas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.foratemer = new System.Windows.Forms.PictureBox();
            this.timer_tempo = new System.Windows.Forms.Timer(this.components);
            this.ptb_foratemer2 = new System.Windows.Forms.PictureBox();
            this.dinheiro = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foratemer3 = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.PictureBox();
            this.ptb_vitoria = new System.Windows.Forms.PictureBox();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.eduardo_cunha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.homem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foratemer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foratemer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinheiro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foratemer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vitoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduardo_cunha)).BeginInit();
            this.SuspendLayout();
            // 
            // homem
            // 
            this.homem.BackColor = System.Drawing.Color.Transparent;
            this.homem.Image = global::Joguinho.Properties.Resources.temer;
            this.homem.Location = new System.Drawing.Point(145, 383);
            this.homem.Name = "homem";
            this.homem.Size = new System.Drawing.Size(35, 61);
            this.homem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homem.TabIndex = 0;
            this.homem.TabStop = false;
            // 
            // lbl_batidas
            // 
            this.lbl_batidas.AutoSize = true;
            this.lbl_batidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(185)))), ((int)(((byte)(253)))));
            this.lbl_batidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_batidas.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_batidas.Location = new System.Drawing.Point(68, -3);
            this.lbl_batidas.Name = "lbl_batidas";
            this.lbl_batidas.Size = new System.Drawing.Size(206, 25);
            this.lbl_batidas.TabIndex = 0;
            this.lbl_batidas.Text = "Total de Golpes :0";
            
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // foratemer
            // 
            this.foratemer.BackgroundImage = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.foratemer.Image = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.foratemer.Location = new System.Drawing.Point(113, 113);
            this.foratemer.Name = "foratemer";
            this.foratemer.Size = new System.Drawing.Size(45, 32);
            this.foratemer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foratemer.TabIndex = 2;
            this.foratemer.TabStop = false;
            // 
            // timer_tempo
            // 
            this.timer_tempo.Enabled = true;
            this.timer_tempo.Interval = 1000;
            this.timer_tempo.Tick += new System.EventHandler(this.timer_tempo_Tick_1);
            // 
            // ptb_foratemer2
            // 
            this.ptb_foratemer2.BackgroundImage = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.ptb_foratemer2.Image = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.ptb_foratemer2.Location = new System.Drawing.Point(58, 237);
            this.ptb_foratemer2.Name = "ptb_foratemer2";
            this.ptb_foratemer2.Size = new System.Drawing.Size(45, 32);
            this.ptb_foratemer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_foratemer2.TabIndex = 6;
            this.ptb_foratemer2.TabStop = false;
            // 
            // dinheiro
            // 
            this.dinheiro.BackColor = System.Drawing.Color.Transparent;
            this.dinheiro.Image = global::Joguinho.Properties.Resources._06;
            this.dinheiro.Location = new System.Drawing.Point(111, 183);
            this.dinheiro.Name = "dinheiro";
            this.dinheiro.Size = new System.Drawing.Size(45, 32);
            this.dinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinheiro.TabIndex = 7;
            this.dinheiro.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Joguinho.Properties.Resources.fotografa_brasilia_de_niemeyer_andrew_prokos_02_1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despausarToolStripMenuItem});
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // despausarToolStripMenuItem
            // 
            this.despausarToolStripMenuItem.Name = "despausarToolStripMenuItem";
            this.despausarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.despausarToolStripMenuItem.Text = "Despausar";
            this.despausarToolStripMenuItem.Click += new System.EventHandler(this.despausarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // foratemer3
            // 
            this.foratemer3.BackgroundImage = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.foratemer3.Image = global::Joguinho.Properties.Resources.placa_fora_temer;
            this.foratemer3.Location = new System.Drawing.Point(207, 97);
            this.foratemer3.Name = "foratemer3";
            this.foratemer3.Size = new System.Drawing.Size(45, 32);
            this.foratemer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foratemer3.TabIndex = 9;
            this.foratemer3.TabStop = false;
            // 
            // game_over
            // 
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.Image = global::Joguinho.Properties.Resources.gameover;
            this.game_over.Location = new System.Drawing.Point(-21, 135);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(371, 130);
            this.game_over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_over.TabIndex = 10;
            this.game_over.TabStop = false;
            this.game_over.Visible = false;
            // 
            // ptb_vitoria
            // 
            this.ptb_vitoria.Image = global::Joguinho.Properties.Resources.victory;
            this.ptb_vitoria.Location = new System.Drawing.Point(12, 135);
            this.ptb_vitoria.Name = "ptb_vitoria";
            this.ptb_vitoria.Size = new System.Drawing.Size(309, 154);
            this.ptb_vitoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_vitoria.TabIndex = 11;
            this.ptb_vitoria.TabStop = false;
            this.ptb_vitoria.Visible = false;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.BackColor = System.Drawing.Color.Black;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_tempo.Location = new System.Drawing.Point(261, 24);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(66, 25);
            this.lbl_tempo.TabIndex = 3;
            this.lbl_tempo.Text = "00:00";
            // 
            // eduardo_cunha
            // 
            this.eduardo_cunha.BackColor = System.Drawing.Color.Transparent;
            this.eduardo_cunha.Image = global::Joguinho.Properties.Resources.caricatura_ecunha;
            this.eduardo_cunha.Location = new System.Drawing.Point(126, 28);
            this.eduardo_cunha.Name = "eduardo_cunha";
            this.eduardo_cunha.Size = new System.Drawing.Size(72, 47);
            this.eduardo_cunha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eduardo_cunha.TabIndex = 12;
            this.eduardo_cunha.TabStop = false;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Joguinho.Properties.Resources.layouttemer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(327, 446);
            this.Controls.Add(this.eduardo_cunha);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.ptb_vitoria);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.foratemer3);
            this.Controls.Add(this.lbl_batidas);
            this.Controls.Add(this.dinheiro);
            this.Controls.Add(this.ptb_foratemer2);
            this.Controls.Add(this.foratemer);
            this.Controls.Add(this.homem);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Joguinho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.homem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foratemer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foratemer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinheiro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foratemer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vitoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduardo_cunha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homem;
        private System.Windows.Forms.Label lbl_batidas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox foratemer;
        private System.Windows.Forms.Timer timer_tempo;
        private System.Windows.Forms.PictureBox ptb_foratemer2;
        private System.Windows.Forms.PictureBox dinheiro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox foratemer3;
        private System.Windows.Forms.PictureBox game_over;
        private System.Windows.Forms.PictureBox ptb_vitoria;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.PictureBox eduardo_cunha;
    }
}

