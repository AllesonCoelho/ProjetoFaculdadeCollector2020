using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pxc
/// </summary>
public class Pxc
{
    private Categoria ctg_pk;
    private Produto pdt_pk;

    public global::Categoria Ctg_pk
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
}