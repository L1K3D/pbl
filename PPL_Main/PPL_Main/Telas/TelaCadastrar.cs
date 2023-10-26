using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PPL_Main.Telas
{
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            senhaTextBox.PasswordChar = '*';
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Heitor\\FESA\\PBL\\PPL_Main\\PPL_Main\\PBLDB.mdf; Initial Catalog = PBLDB; Integrated Security=True");

            //Cria string de inserção SQL
            string sql = "INSERT INTO logins (id_usuario, senha_usuario) VALUES (@id_usuario, @senha_usuario)";

            try
            {

                SqlCommand comando_de_insercao = new SqlCommand(sql, conexao);

                comando_de_insercao.Parameters.Add(new SqlParameter("@id_usuario", this.usuarioTextBox.Text));
                comando_de_insercao.Parameters.Add(new SqlParameter("@senha_usuario", this.senhaTextBox.Text));

                conexao.Open();

                comando_de_insercao.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");


            }

            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro..." + ex);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
