using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Chat
/// </summary>
public class Chat
{
    private int cht_pk;
    private DateTime cht_dthr;
    private Usuario usu_pk_origem;
    private Usuario usu_pk_destino;

    public int Cht_pk
    {
        get
        {
            return cht_pk;
        }

        set
        {
            cht_pk = value;
        }
    }

    public DateTime Cht_dthr
    {
        get
        {
            return cht_dthr;
        }

        set
        {
            cht_dthr = value;
        }
    }

    public global::Usuario Usu_pk_origem
    {
        get
        {
            return usu_pk_origem;
        }

        set
        {
            usu_pk_origem = value;
        }
    }

    public global::Usuario Usu_pk_destino
    {
        get
        {
            return usu_pk_destino;
        }

        set
        {
            usu_pk_destino = value;
        }
    }
}