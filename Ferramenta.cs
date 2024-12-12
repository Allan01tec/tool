using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Tool
{
    public class Ferramenta
    {
        // Propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public decimal? Potencia { get; set; }
        public decimal? Preco { get; set; }
        public int? QuantidadeEstoque { get; set; }
        public string? Status { get; set; }

      
        public Ferramenta() { }

        public Ferramenta(string? nome, string? categoria, string? descricao, decimal? potencia, decimal? preco, int? quantidadeEstoque, string? status)
        {
            Nome = nome;
            Categoria = categoria;
            Descricao = descricao;
            Potencia = potencia;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            Status = status;
        }

        public Ferramenta(int id, string? nome, string? categoria, string? descricao, decimal? potencia, decimal? preco, int? quantidadeEstoque, string? status)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Descricao = descricao;
            Potencia = potencia;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            Status = status;
        }

        // inserir nova ferramenta
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ferramenta_insert"; // Supondo que você tenha esse stored procedure no banco de dados

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcategoria", Categoria);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppotencia", Potencia);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.Parameters.AddWithValue("spquantidadeestoque", QuantidadeEstoque);
            cmd.Parameters.AddWithValue("spstatus", Status);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // consultar ferramenta por ID
        public static Ferramenta ObterPorId(int id)
        {
            Ferramenta ferramenta = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT id, nome, categoria, descricao, potencia, preco, quantidade_estoque, status FROM ferramentas WHERE id = {id}";
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ferramenta = new Ferramenta(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDecimal(4),
                    dr.GetDecimal(5),
                    dr.GetInt32(6),
                    dr.GetString(7)
                );
            }

            cmd.Connection.Close();
            return ferramenta;
        }

        //  obter lista de todas as ferramentas
        public static List<Ferramenta> ObterLista()
        {
            List<Ferramenta> ferramentas = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM ferramentas ORDER BY nome ASC";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ferramentas.Add(new Ferramenta(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDecimal(4),
                    dr.GetDecimal(5),
                    dr.GetInt32(6),
                    dr.GetString(7)
                ));
            }

            cmd.Connection.Close();
            return ferramentas;
        }

        // atualizar as informações da ferramenta
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ferramenta_update"; // Supondo que você tenha esse stored procedure no banco de dados

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcategoria", Categoria);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppotencia", Potencia);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.Parameters.AddWithValue("spquantidadeestoque", QuantidadeEstoque);
            cmd.Parameters.AddWithValue("spstatus", Status);

            if (cmd.ExecuteNonQuery() > 0)
            {
                resposta = true;
            }

            cmd.Connection.Close();
            return resposta;
        }

        // excluir uma ferramenta
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ferramenta_delete"; // Supondo que você tenha esse stored procedure no banco de dados

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }
    }
}
