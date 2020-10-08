using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

/// <summary>
/// Summary description for MidiaDB
/// </summary>
public class MidiaDB
{
    public static int Insert(Midia midia)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "insert into mid_midia(mid_descricao, tmd_pk, pdt_pk) " +
                           "values (?mid_descricao, ?tmd_pk, ?pdt_pk);";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?mid_descricao", midia.Mid_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?tmd_pk", midia.Tmd_pk.Tmd_pk));
            objCommand.Parameters.Add(Mapped.Parameter("?pdt_pk", midia.Pdt_pk.Pdt_pk));

            objCommand.ExecuteScalar();

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

            string query = "select * from mid_midia";
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