//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena

//Heitor Santos Ferreira - RA: 081230042

//Engenharia de Computação - Terceiro Semestre - EC3
//PBL - Projeto Integrador
//Professores: Leide Vieira, Daniel Gliglio, João Eduardo Lamesa e Flávio Viotti
//Disciplinas: POO - Programação Orientada a Objetos, Calculo Avançado, Física II e Bancos de Dados II

//1. Declarando as bibliotecas que serão utilizadas
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// 2. Declarando nome da "namespace"/"ambiente" no qual o programa se encontra
namespace PPL_Main.Telas
{
    // 3. Declarando a construção da tela incial
    public partial class TelaEntrar : Form
    {

        // 4. Instanciando construtor da TelaEntrar
        public TelaEntrar()
        {

            // 4.1. Inicializando Componentes da TelaEntrar
            InitializeComponent();
        
        }

        // 5. Atribuindo ações para o botão de Entrar
        private void EntrarButton_Click(object sender, EventArgs e)
        {
            // 5.1. Declarando atributos necesários para conexão com o banco de dados local
            //string NomeUsuario = UsuarioTextBox.Text;
            //string SenhaUsuario = SenhaTextBox.Text;

            // 5.2. Declarando o endereçamento para o banco de dados informando o host, DataBase inicial, usuário e senha a ser utilizado na autenticação
            //string EnderecoBancoDeDados = $"Data Source=DESKTOP-44GK92H\\HSF_SQL_SERVER;Initial Catalog=PBL;User ID={NomeUsuario};Password={SenhaUsuario}";

            string EnderecoBancoDeDados = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BancoDeDadosLocal.mdf;Initial Catalog=pbl_simulador_balistica;Integrated Security=True";

            // 5.3. Abrindo o conector SQL com o endereçamento declarado acima
            using (SqlConnection connection = new SqlConnection(EnderecoBancoDeDados))
            {

                // 5.3.1. Criando modelo de 'try' e 'catch' ('tentativa' e 'excessão')
                // 5.3.1.1. Criando modelo de 'try' ('tentativa')
                try
                {
                    // 5.3.1.1.1. Realizando a abertura da conexão
                    connection.Open();

                    // 5.3.1.1.2. Caso a conexão seja bem-sucedida, retorna uma "MessageBox" com um botão e um ícone interativo, informando que a conexão foi realizada com sucesso
                    MessageBox.Show("Conexão bem-sucedida com o banco de dados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5.3.1.1.3. Criando o objeto que se remete a tela de Menu do programa
                    TelaMenu telaMenu = new TelaMenu();

                    // 5.3.1.1.4. Exibindo a tela de Menu Principal do programa
                    telaMenu.Show();

                }

                // 5.3.1.2. Criando modelo de 'catch' ('excessão')
                catch (Exception ex)
                {

                    // 5.3.1.2.1. Caso a conexão com o banco de dados falhe, retorna uma "MessageBox" com o erro e com um ícone interativo
                    MessageBox.Show("Erro durante o teste de conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }


        }

        // 6. Atribuindo ações para o botão de "Sair"
        private void SairButton_Click(object sender, EventArgs e)
        {

            // 6.1. Fechando a aplicação completamente
            Application.Exit();
        
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            TelaCadastrar telaCadastrar = new TelaCadastrar();

            telaCadastrar.Show();
        }
    }
}