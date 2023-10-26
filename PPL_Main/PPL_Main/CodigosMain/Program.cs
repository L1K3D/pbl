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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

// 2. Criando a parte/namespace principal do programa
namespace PPL_Main
{
    // 3. Criando a parte da classe executora do programa principal
    static class Program
    {

        // 4. Criando segunda instancia concorrente dentro do programa princal que guarda a conexão com o banco de dados
        static void BancoDeDados(string[] args)
        {
            // 4.1. Declarando o endereçamento do banco de dados
            string enderecamentoDeConexaoBancoDeDados = "Data Source = localhost; Initial Catalog = PBL; Integrated Security = True";

            // 4.2 Conectando ao banco de dados localmente utilizando o endereçamento referenciado anteriormente utilizando a biblioteca
            using (SqlConnection connection = new SqlConnection(enderecamentoDeConexaoBancoDeDados))
            {

                try
                {
                    connection.Open();
                }
                catch
                {
                    Console.WriteLine("Erro na conexão com o banco de dados...");
                    Console.WriteLine();
                    Console.WriteLine("Verifique se o mesmo encontra-se criado, se a tabela existe no seu banco de dados ou acesse 'Microsoft MySQL Server' para mais informações");
                    Console.WriteLine();
                }

            }

        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Telas.TelaEntrar());
        }
    }
}
