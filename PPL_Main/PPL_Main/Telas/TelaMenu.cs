using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPL_Main.Telas
{
    public partial class TelaMenu : Form
    {

        string enderecamentoConexao = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\Heitor\\FESA\\PBL\\PPL_Main\\PPL_Main\\PBLDB.mdf; Initial Catalog = PBLDB; Integrated Security=True";

        public TelaMenu()
        {
            InitializeComponent();
        }

        private void motrarQuantidadeDeUsuarios()
        { 

            string queryContagemUsuarios =
                "SELECT COUNT(DISTINCT id_usuario)" +
                "" +
                "FROM logins";

            using(SqlConnection conexao = new SqlConnection(enderecamentoConexao))
            {

                conexao.Open();

                using(SqlCommand comandoASerExecutado = new SqlCommand(queryContagemUsuarios, conexao))
                {
                    int quantidadeUsuarios = (int)comandoASerExecutado.ExecuteScalar();

                    labelQuantidadeUsuarios.Text = "Quantidade de usuários já cadastrados: " + quantidadeUsuarios.ToString();
                }

            }


        }

        private void mostrarQuantidadeDeSimulacoesFeitas()
        {

            string queryQuantidadeDeSimulacoesFeitas = 
                "SELECT COUNT(*)" +
                "" +
                "FROM resultados";

            using (SqlConnection conexao = new SqlConnection(enderecamentoConexao))
            {

                conexao.Open();

                using (SqlCommand comandoASerExecutado = new SqlCommand(queryQuantidadeDeSimulacoesFeitas, conexao))
                {
                    int quantidadeDeSimulacoesFeitas = (int)comandoASerExecutado.ExecuteScalar();

                    labelQuantidadeSimulacoesFeitas.Text = "Quantidade de simulações já feitas é de: " + quantidadeDeSimulacoesFeitas.ToString();
                }

            }


        }

        private void populaListView()
        {

            string querySelecionarTudoTabelaResultados =
                "SELECT *" +
                "FROM resultados";

            using(SqlConnection conexao = new SqlConnection(enderecamentoConexao))
            {

                conexao.Open();

                using(SqlCommand comandoASerExecutado = new SqlCommand(querySelecionarTudoTabelaResultados, conexao))

                using (SqlDataAdapter adaptadorDeDadosNativo = new SqlDataAdapter(comandoASerExecutado))
                {
                    DataTable tabelaResultados = new DataTable();
                    adaptadorDeDadosNativo.Fill(tabelaResultados);

                    listViewTabelaResultados.Items.Clear();

                    foreach(DataRow ocorrencia in tabelaResultados.Rows)
                    {

                        ListViewItem itemTabela = new ListViewItem(ocorrencia["id_resultado"].ToString());
                        itemTabela.SubItems.Add(ocorrencia["angulo"].ToString());
                        itemTabela.SubItems.Add(ocorrencia["velocidade_incial"].ToString());

                        listViewTabelaResultados.Items.Add(itemTabela);

                    }
                }

            }

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
