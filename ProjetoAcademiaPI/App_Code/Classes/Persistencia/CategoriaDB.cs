using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for CategoriaDB
/// </summary>
public class CategoriaDB
{
    public static int Insert(Categoria ctg)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "insert into ctg_Categoria(ctg_tipo, ctg_info) values (?ctg_tipo, ?ctg_info)";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?ctg_tipo", ctg.Ctg_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?ctg_info", ctg.Ctg_info));

            objCommand.ExecuteNonQuery();

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

    public static int Update(Categoria ctg)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "update ctg_Categoria SET ctg_tipo, ctg_info = ?ctg_tipo, ?ctg_info WHERE ctg_pk = ?ctg_pk";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?ctg_tipo", ctg.Ctg_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?ctg_info", ctg.Ctg_info));
            objCommand.Parameters.Add(Mapped.Parameter("?ctg_pk", ctg.Ctg_pk));

            objCommand.ExecuteNonQuery();

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
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter dataAdapter;

        objConexao = Mapped.Connection();
        string query = "SELECT * from ctg_Categoria";

        objCommand = Mapped.Command(query, objConexao);

        dataAdapter = Mapped.Adapter(objCommand);

        dataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;

    }

    public static DataSet SelectId(int ctg_pk)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter dataAdapter;

        objConexao = Mapped.Connection();
        string query = "SELECT * from ctg_Categoria WHERE ctg_pk = ?ctg_pk";

        objCommand = Mapped.Command(query, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?ctg_pk", ctg_pk));

        dataAdapter = Mapped.Adapter(objCommand);

        dataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;

    }
}