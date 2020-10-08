using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

/// <summary>
/// Summary description for ProdutoDB
/// </summary>
public class ProdutoDB
{
    public static int Insert(Produto produto)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "insert into pdt_produto(pdt_nome, pdt_categoria, pdt_preco, pdt_maiores, pdt_status, pdt_descricao, usr_pk) " +
                           "values (?pdt_nome, ?pdt_categoria, ?pdt_preco, ?pdt_maiores, ?pdt_status, ?pdt_descricao, ?usr_pk); Select last_insert_id();";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?pdt_nome", produto.Pdt_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_categoria", produto.Pdt_categoria));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_preco", produto.Pdt_preco));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_maiores", produto.Pdt_maiores));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_status", produto.Pdt_status));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_descricao", produto.Pdt_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_pk", produto.Usr_pk.Usr_pk));

            retorno = Convert.ToInt32(objCommand.ExecuteScalar());

            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        }
        catch (Exception ex)
        {
            retorno = -2;
        }

        return retorno;


    }

    public static DataSet SelectAll()
    {
        try
        {
            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommand;
            IDataAdapter dataAdapter;
            objConexao = Mapped.Connection();

            string query = "select * from pdt_Produto";
            objCommand = Mapped.Command(query, objConexao);
            dataAdapter = Mapped.Adapter(objCommand);
            dataAdapter.Fill(ds);

            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();

            return ds;
        }
        catch (Exception error)
        {
            return null;
        }
    }
}