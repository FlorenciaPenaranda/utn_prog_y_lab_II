using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
  public class Centralita
  {
    private List<Llamada> llamadas;
    protected string razonSocial;

    public Centralita()
    {
      this.llamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa)
    {
      this.razonSocial = nombreEmpresa;
    }

    public float GananciaLocal
    {
      get { return CalcularGanancia(TipoLlamada.Local); }
    }

    public float GananciaProvincial
    {
      get { return CalcularGanancia(TipoLlamada.Provincial); }
    }

    public float GananciaTodas
    {
      get { return CalcularGanancia(TipoLlamada.Todas); }
    }

    public List<Llamada> Llamadas
    {
      get { return this.llamadas; }
    }

    private float CalcularGanancia(TipoLlamada tipo)
    {
      float ganancia = 0;

      foreach (Llamada item in llamadas)
      {
        if (tipo == TipoLlamada.Local)
        {
          if (item is Local)
          {
            ganancia = +((Local)item).CostoLlamada;
          }
        }
        if (tipo == TipoLlamada.Provincial)
        {
          if (item is Provincial)
          {
            ganancia = +((Provincial)item).CostoLlamada;
          }
        }
        if (tipo == TipoLlamada.Todas)
        {
          ganancia = CalcularGanancia(TipoLlamada.Local) + CalcularGanancia(TipoLlamada.Provincial);
        }
      }
      return ganancia;
    }

    private string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Razon social: " + this.razonSocial);
      sb.AppendLine("Costo total de llamaas: " + this.GananciaTodas);
      sb.AppendLine("Costo total de locales: " + this.GananciaLocal);
      sb.AppendLine("Costo total de provinciales: " + this.GananciaProvincial);
      foreach (Llamada item in llamadas)
      {
        if (item is Local)
        {
          sb.AppendLine("Detalle de llamada" + item.ToString());
        }
        if (item is Provincial)
        {
          sb.AppendLine("Detalle de llamada" + item.ToString());
        }
      }
      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public static bool operator ==(Centralita c, Llamada l)
    {
      foreach (Llamada item in c.llamadas)
      {
        if (l == item)
        {
          return true;
        }
      }
      return false;
    }

    public static bool operator !=(Centralita C, Llamada l)
    {
      return !(C == l);
    }

    private void AgregarLlamada(Llamada llamadaNueva)
    {
      this.llamadas.Add(llamadaNueva);
    }

    public static Centralita operator +(Centralita c, Llamada llamadaNueva)
    {
      if (c != llamadaNueva)
      {
        c.AgregarLlamada(llamadaNueva);
      }
      return c;
    }

    public void OrdenarLlamadas()
    {
      this.llamadas.Sort();
    }

  }

}




