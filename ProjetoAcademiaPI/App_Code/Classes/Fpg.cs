using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Fpg
/// </summary>
public class Fpg
{
    private int fpg_pk;
    private string fpg_tipo;

    public int Fpg_pk
    {
        get
        {
            return fpg_pk;
        }

        set
        {
            fpg_pk = value;
        }
    }

    public string Fpg_tipo
    {
        get
        {
            return fpg_tipo;
        }

        set
        {
            fpg_tipo = value;
        }
    }
}