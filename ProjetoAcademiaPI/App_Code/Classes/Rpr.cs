using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Rpr
/// </summary>
public class Rpr
{
    private int rpr_pk;
    private DateTime rpr_dthr;
    private Usuario usr_pk_compra;
    private Usuario usr_pk_venda;
    private Produto pdt_pk;
    private double rpr_valor;
    private string rpr_status;
    private string rpr_pagamento;
    private Fpg fpg_pk;

    public int Rpr_pk
    {
        get
        {
            return rpr_pk;
        }

        set
        {
            rpr_pk = value;
        }
    }

    public DateTime Rpr_dthr
    {
        get
        {
            return rpr_dthr;
        }

        set
        {
            rpr_dthr = value;
        }
    }

    public double Rpr_valor
    {
        get
        {
            return rpr_valor;
        }

        set
        {
            rpr_valor = value;
        }
    }

    public string Rpr_status
    {
        get
        {
            return rpr_status;
        }

        set
        {
            rpr_status = value;
        }
    }

    public string Rpr_pagamento
    {
        get
        {
            return rpr_pagamento;
        }

        set
        {
            rpr_pagamento = value;
        }
    }

    public global::Fpg Fpg_pk
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

    public global::Usuario Usr_pk_compra
    {
        get
        {
            return usr_pk_compra;
        }

        set
        {
            usr_pk_compra = value;
        }
    }

    public global::Usuario Usr_pk_venda
    {
        get
        {
            return usr_pk_venda;
        }

        set
        {
            usr_pk_venda = value;
        }
    }
}