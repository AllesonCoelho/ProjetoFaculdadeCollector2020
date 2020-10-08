using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UsuarioDB
/// </summary>
public class UsuarioDB
{

    public static int Insert(Usuario usuario)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "insert into usr_Usuario(usr_nome, usr_email, usr_rg, usr_cpf, usr_endereco, usr_numero, usr_bairro," +
                           "usr_cep, usr_cidade, usr_estado, usr_telefone, usr_senha, tpu_pk) " +
                           "values (?usr_nome, ?usr_email, ?usr_rg, ?usr_cpf, ?usr_endereco, ?usr_numero, ?usr_bairro," +
                           "?usr_cep, ?usr_cidade, ?usr_estado, ?usr_telefone, ?usr_senha, ?tpu_pk)";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?usr_nome", usuario.Usr_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_email", usuario.Usr_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_rg", usuario.Usr_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cpf", usuario.Usr_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_endereco", usuario.Usr_endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_numero", usuario.Usr_numero));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_bairro", usuario.Usr_bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cep", usuario.Usr_cep));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cidade", usuario.Usr_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_estado", usuario.Usr_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_telefone", usuario.Usr_telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_senha", usuario.Usr_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?tpu_pk", 2));

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

    public static int Update(Usuario usuario)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConexao;
            IDbCommand objCommand;

            objConexao = Mapped.Connection();
            string query = "update usr_Usuario SET usr_nome, usr_email, usr_rg, usr_cpf, usr_endereco, usr_numero, usr_bairro," +
                           "usr_cep, usr_cidade, usr_estado, usr_telefone, usr_senha, tpu_pk = ?usr_nome, ?usr_email, ?usr_rg, ?usr_cpf, ?usr_endereco, ?usr_numero, ?usr_bairro," +
                           "?usr_cep, ?usr_cidade, ?usr_estado, ?usr_telefone, ?usr_senha, ?tpu_pk WHERE usr_pk = ?usr_pk";
            objCommand = Mapped.Command(query, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?usr_nome", usuario.Usr_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_email", usuario.Usr_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_rg", usuario.Usr_rg));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cpf", usuario.Usr_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_endereco", usuario.Usr_endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_numero", usuario.Usr_numero));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_bairro", usuario.Usr_bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cep", usuario.Usr_cep));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_cidade", usuario.Usr_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_estado", usuario.Usr_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_telefone", usuario.Usr_telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?usr_senha", usuario.Usr_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?tpu_pk", 2));

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
        try
        {
            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommand;
            IDataAdapter dataAdapter;
            objConexao = Mapped.Connection();

            string query = "select * from usr_Usuario";
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

    public static DataSet SelectId(int usr_pk)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter dataAdapter;

        objConexao = Mapped.Connection();
        string query = "SELECT * from usr_Usuario WHERE usr_pk = ?usr_pk";

        objCommand = Mapped.Command(query, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?usr_pk", usr_pk));

        dataAdapter = Mapped.Adapter(objCommand);

        dataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;

    }

    public static DataSet SelectLOGIN(string email, string senha)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;
        IDataAdapter objDataAdapter;
        string sql = "select * from usr_Usuario where usr_email = ?usr_email and usr_senha = ?usr_senha";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?usr_email", email));
        objCommand.Parameters.Add(Mapped.Parameter("?usr_senha", senha));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();
        return ds;
    }

}