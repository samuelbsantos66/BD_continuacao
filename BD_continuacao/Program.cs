using Microsoft.Data.SqlClient;

namespace BD_continuacao
{
    internal class Program
    {

        private static void Salvar(Autor autor, SqlConnection conexao)
        {
            Console.WriteLine("=== Salvando o autor ===");
            var cmd = conexao.CreateCommand();
            cmd.CommandText = ("INSERT INTO AUTOR(Nome) VALUES(@nome)");

            var param = new SqlParameter("nome", autor.Nome);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
        }

        static void Main(string[] args)
        {
            SqlConnection conexao = null;

            string URL = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBAutorLivro1x1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                conexao = new(URL);
                conexao.Open();
                Console.WriteLine("Conexão OK");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexão NOT OK");
            }

            if (conexao != null) {
                Autor autor = new("VINCIUS");
                Salvar(autor, conexao);


            }
        }
    }
}
