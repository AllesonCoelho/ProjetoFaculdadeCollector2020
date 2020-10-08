using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Categoria
/// </summary>
public class Categoria
{
    private int ctg_pk;
    private string ctg_tipo;
    private string ctg_info;

    public int Ctg_pk
    {
        get
        {
            return ctg_pk;
        }

        set
        {
            ctg_pk = value;
        }
    }

    public string Ctg_tipo
    {
        get
        {
            return ctg_tipo;
        }

        set
        {
            ctg_tipo = value;
        }
    }

    public string Ctg_info
    {
        get
        {
            return ctg_info;
        }

        set
        {
            ctg_info = value;
        }
    }
}