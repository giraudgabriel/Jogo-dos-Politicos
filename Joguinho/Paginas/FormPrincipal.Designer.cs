namespace Joguinho
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.ptb_entregador = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptb_obstaculo1 = new System.Windows.Forms.PictureBox();
            this.timer_tempo = new System.Windows.Forms.Timer(this.components);
            this.ptb_obstaculo2 = new System.Windows.Forms.PictureBox();
            this.ptb_item = new System.Windows.Forms.PictureBox();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptb_obstaculo3 = new System.Windows.Forms.PictureBox();
            this.ptb_gameOver = new System.Windows.Forms.PictureBox();
            this.ptb_vitoria = new System.Windows.Forms.PictureBox();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.ptb_recebedor = new System.Windows.Forms.PictureBox();
            this.jogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despausarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_batidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_entregador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vitoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_recebedor)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_entregador
            // 
            this.ptb_entregador.BackColor = System.Drawing.Color.Transparent;
            this.ptb_entregador.Image = ((System.Drawing.Image)(resources.GetObject("ptb_entregador.Image")));
            this.ptb_entregador.Location = new System.Drawing.Point(145, 383);
            this.ptb_entregador.Name = "ptb_entregador";
            this.ptb_entregador.Size = new System.Drawing.Size(35, 61);
            this.ptb_entregador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_entregador.TabIndex = 0;
            this.ptb_entregador.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ptb_obstaculo1
            // 
            this.ptb_obstaculo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo1.BackgroundImage")));
            this.ptb_obstaculo1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo1.Image")));
            this.ptb_obstaculo1.Location = new System.Drawing.Point(113, 113);
            this.ptb_obstaculo1.Name = "ptb_obstaculo1";
            this.ptb_obstaculo1.Size = new System.Drawing.Size(45, 32);
            this.ptb_obstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_obstaculo1.TabIndex = 2;
            this.ptb_obstaculo1.TabStop = false;
            // 
            // timer_tempo
            // 
            this.timer_tempo.Enabled = true;
            this.timer_tempo.Interval = 1000;
            this.timer_tempo.Tick += new System.EventHandler(this.timer_tempo_Tick_1);
            // 
            // ptb_obstaculo2
            // 
            this.ptb_obstaculo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo2.BackgroundImage")));
            this.ptb_obstaculo2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo2.Image")));
            this.ptb_obstaculo2.Location = new System.Drawing.Point(58, 237);
            this.ptb_obstaculo2.Name = "ptb_obstaculo2";
            this.ptb_obstaculo2.Size = new System.Drawing.Size(45, 32);
            this.ptb_obstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_obstaculo2.TabIndex = 6;
            this.ptb_obstaculo2.TabStop = false;
            // 
            // ptb_item
            // 
            this.ptb_item.BackColor = System.Drawing.Color.Transparent;
            this.ptb_item.Image = ((System.Drawing.Image)(resources.GetObject("ptb_item.Image")));
            this.ptb_item.Location = new System.Drawing.Point(111, 183);
            this.ptb_item.Name = "ptb_item";
            this.ptb_item.Size = new System.Drawing.Size(45, 32);
            this.ptb_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_item.TabIndex = 7;
            this.ptb_item.TabStop = false;
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
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.NovoJogoToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despausarToolStripMenuItem});
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.PausarToolStripMenuItem_Click);
            // 
            // despausarToolStripMenuItem
            // 
            this.despausarToolStripMenuItem.Name = "despausarToolStripMenuItem";
            this.despausarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.despausarToolStripMenuItem.Text = "Despausar";
            this.despausarToolStripMenuItem.Click += new System.EventHandler(this.DespausarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // ptb_obstaculo3
            // 
            this.ptb_obstaculo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo3.BackgroundImage")));
            this.ptb_obstaculo3.Image = ((System.Drawing.Image)(resources.GetObject("ptb_obstaculo3.Image")));
            this.ptb_obstaculo3.Location = new System.Drawing.Point(207, 97);
            this.ptb_obstaculo3.Name = "ptb_obstaculo3";
            this.ptb_obstaculo3.Size = new System.Drawing.Size(45, 32);
            this.ptb_obstaculo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_obstaculo3.TabIndex = 9;
            this.ptb_obstaculo3.TabStop = false;
            // 
            // ptb_gameOver
            // 
            this.ptb_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.ptb_gameOver.Image = ((System.Drawing.Image)(resources.GetObject("ptb_gameOver.Image")));
            this.ptb_gameOver.Location = new System.Drawing.Point(49, 151);
            this.ptb_gameOver.Name = "ptb_gameOver";
            this.ptb_gameOver.Size = new System.Drawing.Size(219, 80);
            this.ptb_gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_gameOver.TabIndex = 10;
            this.ptb_gameOver.TabStop = false;
            this.ptb_gameOver.Visible = false;
            // 
            // ptb_vitoria
            // 
            this.ptb_vitoria.Image = ((System.Drawing.Image)(resources.GetObject("ptb_vitoria.Image")));
            this.ptb_vitoria.Location = new System.Drawing.Point(60, 271);
            this.ptb_vitoria.Name = "ptb_vitoria";
            this.ptb_vitoria.Size = new System.Drawing.Size(192, 96);
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
            this.lbl_tempo.Location = new System.Drawing.Point(249, 28);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(66, 25);
            this.lbl_tempo.TabIndex = 3;
            this.lbl_tempo.Text = "00:00";
            // 
            // ptb_recebedor
            // 
            this.ptb_recebedor.BackColor = System.Drawing.Color.Transparent;
            this.ptb_recebedor.Image = ((System.Drawing.Image)(resources.GetObject("ptb_recebedor.Image")));
            this.ptb_recebedor.Location = new System.Drawing.Point(126, 28);
            this.ptb_recebedor.Name = "ptb_recebedor";
            this.ptb_recebedor.Size = new System.Drawing.Size(72, 47);
            this.ptb_recebedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_recebedor.TabIndex = 12;
            this.ptb_recebedor.TabStop = false;
            // 
            // jogoToolStripMenuItem1
            // 
            this.jogoToolStripMenuItem1.Name = "jogoToolStripMenuItem1";
            this.jogoToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem1.Text = "Jogo";
            // 
            // novoJogoToolStripMenuItem1
            // 
            this.novoJogoToolStripMenuItem1.Name = "novoJogoToolStripMenuItem1";
            this.novoJogoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novoJogoToolStripMenuItem1.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem1.Click += new System.EventHandler(this.NovoJogoToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem1
            // 
            this.pausarToolStripMenuItem1.Name = "pausarToolStripMenuItem1";
            this.pausarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pausarToolStripMenuItem1.Text = "Pausar";
            this.pausarToolStripMenuItem1.Click += new System.EventHandler(this.PausarToolStripMenuItem_Click);
            // 
            // despausarToolStripMenuItem1
            // 
            this.despausarToolStripMenuItem1.Name = "despausarToolStripMenuItem1";
            this.despausarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.despausarToolStripMenuItem1.Text = "Despausar";
            this.despausarToolStripMenuItem1.Click += new System.EventHandler(this.DespausarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(SairToolStripMenuItem_Click_1);
            // 
            // lbl_batidas
            // 
            this.lbl_batidas.AutoSize = true;
            this.lbl_batidas.BackColor = System.Drawing.Color.White;
            this.lbl_batidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_batidas.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_batidas.Location = new System.Drawing.Point(87, 9);
            this.lbl_batidas.Name = "lbl_batidas";
            this.lbl_batidas.Size = new System.Drawing.Size(136, 16);
            this.lbl_batidas.TabIndex = 0;
            this.lbl_batidas.Text = "Total de Golpes :0";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(313, 446);
            this.Controls.Add(this.ptb_recebedor);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.ptb_vitoria);
            this.Controls.Add(this.ptb_gameOver);
            this.Controls.Add(this.ptb_obstaculo3);
            this.Controls.Add(this.lbl_batidas);
            this.Controls.Add(this.ptb_item);
            this.Controls.Add(this.ptb_obstaculo2);
            this.Controls.Add(this.ptb_obstaculo1);
            this.Controls.Add(this.ptb_entregador);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joguinho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_entregador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_obstaculo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_gameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vitoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_recebedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_entregador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptb_obstaculo1;
        private System.Windows.Forms.Timer timer_tempo;
        private System.Windows.Forms.PictureBox ptb_obstaculo2;
        private System.Windows.Forms.PictureBox ptb_item;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptb_obstaculo3;
        private System.Windows.Forms.PictureBox ptb_gameOver;
        private System.Windows.Forms.PictureBox ptb_vitoria;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.PictureBox ptb_recebedor;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem despausarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_batidas;
    }
}

