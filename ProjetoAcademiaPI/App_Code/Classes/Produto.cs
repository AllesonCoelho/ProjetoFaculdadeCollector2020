using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Produto
/// </summary>
public class Produto
{
    private int pdt_pk;
    private string pdt_nome;
    private string pdt_categoria;
    private double pdt_preco;
    private string pdt_maiores;
    private string pdt_status;
    private string pdt_descricao;
    private Usuario usr_pk;

    public int Pdt_pk
    {
        get
        {
            return pdt_pk;
        }

        set
        {
            pdt_pk = value;
        }
    }

    public string Pdt_nome
    {
        get
        {
            return pdt_nome;
        }

        set
        {
            pdt_nome = value;
        }
    }

    public string Pdt_categoria
    {
        get
        {
            return pdt_categoria;
        }

        set
        {
            pdt_categoria = value;
        }
    }

    public double Pdt_preco
    {
        get
        {
            return pdt_preco;
        }

        set
        {
            pdt_preco = value;
        }
    }

    public string Pdt_maiores
    {
        get
        {
            return pdt_maiores;
        }

        set
        {
            pdt_maiores = value;
        }
    }

    public string Pdt_status
    {
        get
        {
            return pdt_status;
        }

        set
        {
            pdt_status = value;
        }
    }

    public global::Usuario Usr_pk
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

    public string Pdt_descricao
    {
        get
        {
            return pdt_descricao;
        }

        set
        {
            pdt_descricao = value;
        }
    }
}