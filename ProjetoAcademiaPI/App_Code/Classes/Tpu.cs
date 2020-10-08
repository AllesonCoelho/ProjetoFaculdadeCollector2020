using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tpu
/// </summary>
public class Tpu
{
    private int tpu_pk;
    private string tpu_descricao;

    public int Tpu_pk
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

    public string Tpu_descricao
    {
        get
        {
            return tpu_descricao;
        }

        set
        {
            tpu_descricao = value;
        }
    }
}