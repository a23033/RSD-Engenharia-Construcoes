namespace RSD_Engenharia___Construções
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            panel_Interface_Topo = new Panel();
            panel_Interface_Esquerdo = new Panel();
            pic_Logo = new PictureBox();
            panel_Interface_Esquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // panel_Interface_Topo
            // 
            panel_Interface_Topo.BackColor = Color.FromArgb(178, 145, 70);
            panel_Interface_Topo.Dock = DockStyle.Top;
            panel_Interface_Topo.Location = new Point(0, 0);
            panel_Interface_Topo.Name = "panel_Interface_Topo";
            panel_Interface_Topo.Size = new Size(1454, 5);
            panel_Interface_Topo.TabIndex = 0;
            // 
            // panel_Interface_Esquerdo
            // 
            panel_Interface_Esquerdo.BackColor = SystemColors.WindowFrame;
            panel_Interface_Esquerdo.Controls.Add(pic_Logo);
            panel_Interface_Esquerdo.Location = new Point(0, 3);
            panel_Interface_Esquerdo.Name = "panel_Interface_Esquerdo";
            panel_Interface_Esquerdo.Size = new Size(185, 824);
            panel_Interface_Esquerdo.TabIndex = 2;
            // 
            // pic_Logo
            // 
            pic_Logo.Dock = DockStyle.Top;
            pic_Logo.Image = Properties.Resources.RSD_Engenharia___Construções;
            pic_Logo.Location = new Point(0, 0);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(185, 177);
            pic_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Logo.TabIndex = 3;
            pic_Logo.TabStop = false;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1454, 825);
            Controls.Add(panel_Interface_Topo);
            Controls.Add(panel_Interface_Esquerdo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interface";
            StartPosition = FormStartPosition.CenterScreen;
            panel_Interface_Esquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Interface_Topo;
        private Panel panel_Interface_Esquerdo;
        private PictureBox pic_Logo;
    }
}
