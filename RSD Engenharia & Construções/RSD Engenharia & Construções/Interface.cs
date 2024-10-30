namespace RSD_Engenharia___Construções
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        #region Design

        private void pic_Interface_Fechar_MouseEnter(object sender, EventArgs e)
        {
            pic_Interface_Fechar.Image = Properties.Resources.FecharAcao;
        }

        private void pic_Interface_Fechar_MouseLeave(object sender, EventArgs e)
        {
            pic_Interface_Fechar.Image = Properties.Resources.FecharDefault;
        }

        #endregion

        #region Botões

        private void pic_Interface_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
