using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace RSD_Engenharia___Construções
{
    public partial class Login : Form
    {

        private SqlConnection conn;
        string sql;

        string ConexaoBD;

        public Login()
        {
            ConexaoBD = @"Data Source=DESKTOP-4A1BBI2\SQLEXPRESS;Initial Catalog=RSD;Integrated Security=True";
            InitializeComponent();
            Design();
        }

        #region Design
        private void Design()
        {
            #region Campos

            txt_Login_Utilizador.Clear();
            txt_Login_PalavraPasse.Clear();

            #endregion
        }

        private void btn_Login_IniciarSessao_MouseEnter(object sender, EventArgs e)
        {
            btn_Login_IniciarSessao.ForeColor = Color.FromArgb(178, 145, 70);
        }

        private void btn_Login_IniciarSessao_MouseLeave(object sender, EventArgs e)
        {
            btn_Login_IniciarSessao.ForeColor = Color.White;
        }
        private void pic_Login_Fechar_MouseEnter(object sender, EventArgs e)
        {
            pic_Login_Fechar.Image = Properties.Resources.FecharAcao;
        }

        private void pic_Login_Fechar_MouseLeave(object sender, EventArgs e)
        {
            pic_Login_Fechar.Image = Properties.Resources.FecharDefault;
        }

        #endregion

        #region Botões
        private void pic_Login_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Iniciar Sessão

        private void btn_Login_IniciarSessao_Click(object sender, EventArgs e)
        {

            if (NetworkInterface.GetIsNetworkAvailable())
            {

                if (txt_Login_Utilizador.Text == "" && txt_Login_PalavraPasse.Text == "")
                {
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Login_Utilizador.Select();
                }
                else
                {

                    string username = txt_Login_Utilizador.Text;
                    string password = txt_Login_PalavraPasse.Text;
                    string usernamevalidacao = string.Empty;
                    string passwordvalidacao = string.Empty;

                    using (SqlConnection conn = new SqlConnection(ConexaoBD))
                    {

                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM APP_Login WHERE Username = @user AND Password = @pass", conn))
                        {

                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@pass", password);

                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {

                                var VariavelUsername = reader.GetValue(reader.GetOrdinal("Username"));
                                usernamevalidacao = VariavelUsername.ToString();

                                var VariavelPassword = reader.GetValue(reader.GetOrdinal("Password"));
                                passwordvalidacao = VariavelPassword.ToString();

                            }

                            reader.Close();

                            if (usernamevalidacao == username && passwordvalidacao == password)
                            {
                                this.Hide();
                                Interface abririnterface = new Interface();
                                abririnterface.Show();
                            }
                            else
                            {
                                MessageBox.Show("Dados de autenticação inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_Login_Utilizador.Select();
                            }

                        }

                        conn.Close();

                    }

                }

            }
            else
            {

                MessageBox.Show("Conecte-se á Internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }

        }

        #endregion

       
    }
}
