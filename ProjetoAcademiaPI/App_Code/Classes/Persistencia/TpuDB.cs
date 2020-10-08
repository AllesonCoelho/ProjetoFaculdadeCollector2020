using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for TpuDB
/// </summary>
public class TpuDB
{
    public static int Insert(Tpu tpu)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "insert into tpu_Tipo_Usuario(tpu_descricao) values (?tpu_descricao)";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tpu_descricao", tpu.Tpu_descricao));

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

    public static int Update(Tpu tpu)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "update tpu_Tipo_Usuario SET tpu_descricao = ?tpu_descricao WHERE tpu_pk = ?tpu_pk";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tpu_descricao", tpu.Tpu_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?tpu_pk", tpu.Tpu_pk));

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
        string query = "SELECT * from tpu_Tipo_Usuario";

        objCommand = Mapped.Command(query, objConexao);

        dataAdapter = Mapped.Adapter(objCommand);

        dataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;

    }

    public static DataSet SelectId(int tpu_pk)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter dataAdapter;

        objConexao = Mapped.Connection();
        string query = "SELECT * from tpu_Tipo_Usuario WHERE tpu_pk = ?tpu_pk";

        objCommand = Mapped.Command(query, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?tpu_pk", tpu_pk));

        dataAdapter = Mapped.Adapter(objCommand);

        dataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;

    }
}