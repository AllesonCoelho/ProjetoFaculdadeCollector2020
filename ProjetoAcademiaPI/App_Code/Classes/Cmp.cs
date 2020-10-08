using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cmp
/// </summary>
public class Cmp
{
    private int cmp_pk;
    private string cmp_comentario;
    private DateTime cmp_dthr;
    private Cmp cmp_pk_comentario;
    private Usuario usr_pk;

    public int Cmp_pk
    {
        get
        {
            return cmp_pk;
        }

        set
        {
            cmp_pk = value;
        }
    }

    public string Cmp_comentario
    {
        get
        {
            return cmp_comentario;
        }

        set
        {
            cmp_comentario = value;
        }
    }

    public DateTime Cmp_dthr
    {
        get
        {
            return cmp_dthr;
        }

        set
        {
            cmp_dthr = value;
        }
    }

    public global::Cmp Cmp_pk_comentario
    {
        get
        {
            return cmp_pk_comentario;
        }

        set
        {
            cmp_pk_comentario = value;
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
}