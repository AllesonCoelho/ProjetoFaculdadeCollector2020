using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    private int usr_pk;
    private string usr_nome;
    private string usr_email;
    private string usr_rg;
    private string usr_cpf;
    private string usr_endereco;
    private string usr_numero;
    private string usr_bairro;
    private string usr_cep;
    private string usr_cidade;
    private string usr_estado;
    private string usr_telefone;
    private string usr_senha;
    private Tpu tpu_pk;

    public int Usr_pk
    {
        get
        {
            return usr_pk;
        }

        set
        {
            usr_pk = value;
        }
    }

    public string Usr_nome
    {
        get
        {
            return usr_nome;
        }

        set
        {
            usr_nome = value;
        }
    }

    public string Usr_email
    {
        get
        {
            return usr_email;
        }

        set
        {
            usr_email = value;
        }
    }

    public string Usr_rg
    {
        get
        {
            return usr_rg;
        }

        set
        {
            usr_rg = value;
        }
    }

    public string Usr_cpf
    {
        get
        {
            return usr_cpf;
        }

        set
        {
            usr_cpf = value;
        }
    }

    public string Usr_endereco
    {
        get
        {
            return usr_endereco;
        }

        set
        {
            usr_endereco = value;
        }
    }

    public string Usr_numero
    {
        get
        {
            return usr_numero;
        }

        set
        {
            usr_numero = value;
        }
    }

    public string Usr_bairro
    {
        get
        {
            return usr_bairro;
        }

        set
        {
            usr_bairro = value;
        }
    }

    public string Usr_cep
    {
        get
        {
            return usr_cep;
        }

        set
        {
            usr_cep = value;
        }
    }

    public string Usr_cidade
    {
        get
        {
            return usr_cidade;
        }

        set
        {
            usr_cidade = value;
        }
    }

    public string Usr_estado
    {
        get
        {
            return usr_estado;
        }

        set
        {
            usr_estado = value;
        }
    }

    public string Usr_telefone
    {
        get
        {
            return usr_telefone;
        }

        set
        {
            usr_telefone = value;
        }
    }

    public string Usr_senha
    {
        get
        {
            return usr_senha;
        }

        set
        {
            usr_senha = value;
        }
    }

    public global::Tpu Tpu_pk
    {
        get
        {
            return tpu_pk;
        }

        set
        {
            tpu_pk = value;
        }

    }
}