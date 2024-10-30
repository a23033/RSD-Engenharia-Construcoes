namespace RSD_Engenharia___Construções
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel_Login_Topo = new Panel();
            pic_Logo = new PictureBox();
            txt_Login_Utilizador = new TextBox();
            txt_Login_PalavraPasse = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btn_Login_IniciarSessao = new Button();
            pic_Login_Fechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Login_Fechar).BeginInit();
            SuspendLayout();
            // 
            // panel_Login_Topo
            // 
            panel_Login_Topo.BackColor = Color.FromArgb(178, 145, 70);
            panel_Login_Topo.Dock = DockStyle.Top;
            panel_Login_Topo.Location = new Point(0, 0);
            panel_Login_Topo.Name = "panel_Login_Topo";
            panel_Login_Topo.Size = new Size(460, 5);
            panel_Login_Topo.TabIndex = 1;
            // 
            // pic_Logo
            // 
            pic_Logo.BackColor = Color.Transparent;
            pic_Logo.Image = Properties.Resources.RSD_Engenharia___Construções;
            pic_Logo.Location = new Point(0, 35);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(460, 233);
            pic_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Logo.TabIndex = 4;
            pic_Logo.TabStop = false;
            // 
            // txt_Login_Utilizador
            // 
            txt_Login_Utilizador.BackColor = Color.White;
            txt_Login_Utilizador.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Login_Utilizador.ForeColor = Color.Black;
            txt_Login_Utilizador.Location = new Point(130, 343);
            txt_Login_Utilizador.Name = "txt_Login_Utilizador";
            txt_Login_Utilizador.PlaceholderText = "Utilizador";
            txt_Login_Utilizador.Size = new Size(203, 27);
            txt_Login_Utilizador.TabIndex = 1;
            // 
            // txt_Login_PalavraPasse
            // 
            txt_Login_PalavraPasse.BackColor = Color.White;
            txt_Login_PalavraPasse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Login_PalavraPasse.ForeColor = Color.Black;
            txt_Login_PalavraPasse.Location = new Point(130, 390);
            txt_Login_PalavraPasse.Name = "txt_Login_PalavraPasse";
            txt_Login_PalavraPasse.PasswordChar = '•';
            txt_Login_PalavraPasse.PlaceholderText = "Palavra Passe";
            txt_Login_PalavraPasse.Size = new Size(203, 27);
            txt_Login_PalavraPasse.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Utilizador;
            pictureBox1.Location = new Point(94, 343);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.PalavraPasse;
            pictureBox2.Location = new Point(94, 390);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 145, 70);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 5);
            panel1.TabIndex = 9;
            // 
            // btn_Login_IniciarSessao
            // 
            btn_Login_IniciarSessao.BackColor = Color.Black;
            btn_Login_IniciarSessao.FlatAppearance.BorderSize = 0;
            btn_Login_IniciarSessao.FlatStyle = FlatStyle.Flat;
            btn_Login_IniciarSessao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login_IniciarSessao.ForeColor = Color.White;
            btn_Login_IniciarSessao.Location = new Point(158, 461);
            btn_Login_IniciarSessao.Name = "btn_Login_IniciarSessao";
            btn_Login_IniciarSessao.Size = new Size(131, 38);
            btn_Login_IniciarSessao.TabIndex = 3;
            btn_Login_IniciarSessao.Text = "Iniciar Sessão";
            btn_Login_IniciarSessao.UseVisualStyleBackColor = false;
            btn_Login_IniciarSessao.Click += btn_Login_IniciarSessao_Click;
            btn_Login_IniciarSessao.MouseEnter += btn_Login_IniciarSessao_MouseEnter;
            btn_Login_IniciarSessao.MouseLeave += btn_Login_IniciarSessao_MouseLeave;
            // 
            // pic_Login_Fechar
            // 
            pic_Login_Fechar.BackColor = Color.Transparent;
            pic_Login_Fechar.Image = Properties.Resources.FecharDefault;
            pic_Login_Fechar.Location = new Point(421, 12);
            pic_Login_Fechar.Name = "pic_Login_Fechar";
            pic_Login_Fechar.Size = new Size(33, 27);
            pic_Login_Fechar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Login_Fechar.TabIndex = 10;
            pic_Login_Fechar.TabStop = false;
            pic_Login_Fechar.Click += pic_Login_Fechar_Click;
            pic_Login_Fechar.MouseEnter += pic_Login_Fechar_MouseEnter;
            pic_Login_Fechar.MouseLeave += pic_Login_Fechar_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(460, 699);
            Controls.Add(pic_Login_Fechar);
            Controls.Add(btn_Login_IniciarSessao);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel_Login_Topo);
            Controls.Add(txt_Login_PalavraPasse);
            Controls.Add(txt_Login_Utilizador);
            Controls.Add(pic_Logo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Login_Fechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Login_Topo;
        private PictureBox pic_Logo;
        private TextBox txt_Login_Utilizador;
        private TextBox txt_Login_PalavraPasse;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button btn_Login_IniciarSessao;
        private PictureBox pic_Login_Fechar;
    }
}