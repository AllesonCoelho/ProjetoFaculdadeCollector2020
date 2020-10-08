using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Midia
/// </summary>
public class Midia
{
    private int mid_pk;
    private string mid_descricao;
    private Tmd tmd_pk;
    private Produto pdt_pk;

    public int Mid_pk
    {
        get
        {
            return mid_pk;
        }

        set
        {
            mid_pk = value;
        }
    }

    public string Mid_descricao
    {
        get
        {
            return mid_descricao;
        }

        set
        {
            mid_descricao = value;
        }
    }

    public global::Produto Pdt_pk
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

    public global::Tmd Tmd_pk
    {
        get
        {
            return tmd_pk;
        }

        set
        {
            tmd_pk = value;
        }
    }
}