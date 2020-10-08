using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tmd
/// </summary>
public class Tmd
{
    private int tmd_pk;
    private string tmd_descricao;

    public int Tmd_pk
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

    public string Tmd_descricao
    {
        get
        {
            return tmd_descricao;
        }

        set
        {
            tmd_descricao = value;
        }
    }
}