using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for Mapped
/// </summary>
public class Mapped
{
    //Metodo para abrir a conexão
    public static IDbConnection Connection()
    {
        MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["strConexao"]);
        objConexao.Open();
        return objConexao;
    }

    //Criar o objeto e validar o conteúdo a ser executado
    public static IDbCommand Command(string query, IDbConnection objConexao)
    {
        IDbCommand objCommand = objConexao.CreateCommand();
        objCommand.CommandText = query;
        return objCommand;
    }

    //PONTE entre os dados conexos e desconexos
    public static IDbDataAdapter Adapter(IDbCommand objCommand)
    {
        IDbDataAdapter adap = new MySqlDataAdapter();
        adap.SelectCommand = objCommand;
        return adap;
    }

    //Parametrização
    public static IDbDataParameter Parameter(string nomeDoParametro, object valor)
    {
        return new MySqlParameter(nomeDoParametro, valor);
    }

}