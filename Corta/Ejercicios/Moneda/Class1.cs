using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
   
      public class Euro
      {
        private double cantidad;
        private static double cotizRespecDolar = 1.16;

        public Euro()
        {
          cantidad = 0;
          cotizRespecDolar = 1.16;
        }

        public Euro(double cantidad)
        {
          this.cantidad = cantidad;
          cotizRespecDolar = 1.16;
        }

        public Euro(double cantidad, double cotizacion)
        {
          this.cantidad = cantidad;
          cotizRespecDolar = cotizacion;
        }

        public static implicit operator Euro(double d)
        {
          Euro euro = new Euro(d);

          return euro;
        }

        public static explicit operator Dolar(Euro e)
        {
          Dolar dolar;
          double cant = e.GetCantidad();
          double cot = cotizRespecDolar;

          dolar = new Dolar(cant * cot);

          return dolar;

        }

        public static explicit operator Peso(Euro e)
        {
          Peso peso;

          double cant = e.GetCantidad();
          double cot = GetCotizacion();
          double eDolares = cant / cot;
          double pCotDolar = Peso.GetCotizacion();

          peso = new Peso(eDolares * pCotDolar);

          return peso;
        }
        public double GetCantidad()
        {
          return cantidad;
        }

        public static double GetCotizacion()
        {
          return cotizRespecDolar;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
          bool rtnVal = false;
          Dolar eDolar = (Dolar)e;

          if (eDolar.GetCantidad() != d.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
          bool rtnVal = false;
          Dolar eDolar = (Dolar)e;

          if (eDolar.GetCantidad() == d.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator !=(Euro e, Peso p)
        {
          bool rtnVal = false;
          Dolar eDolar = (Dolar)e;
          Dolar pDolar = (Dolar)p;

          if (eDolar.GetCantidad() != pDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Euro e, Peso p)
        {
          bool rtnVal = false;
          Dolar eDolar = (Dolar)e;
          Dolar pDolar = (Dolar)p;

          if (eDolar.GetCantidad() == pDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
          bool rtnVal = false;

          if (e1.GetCantidad() != e2.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
          bool rtnVal = false;

          if (e1.GetCantidad() == e2.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
          Euro euro;
          Euro dEuro = (Euro)d;

          double cant = e.GetCantidad() - dEuro.GetCantidad();

          euro = new Euro(cant);

          return euro;
        }

        public static Euro operator -(Euro e, Peso p)
        {
          Euro euro;
          Euro pEuro = (Euro)p;

          double cant = e.GetCantidad() - pEuro.GetCantidad();

          euro = new Euro(cant);

          return euro;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
          Euro euro;
          Euro dEuro = (Euro)d;

          double cant = e.GetCantidad() + dEuro.GetCantidad();

          euro = new Euro(cant);

          return euro;
        }

        public static Euro operator +(Euro e, Peso p)
        {
          Euro euro;
          Euro pEuro = (Euro)p;

          double cant = e.GetCantidad() + pEuro.GetCantidad();

          euro = new Euro(cant);

          return euro;
        }
      }

      public class Dolar
      {
        private double cantidad;
        private static double cotizRespecDolar;

        public Dolar()
        {

        }

        public Dolar(double cantidad)
        {
          this.cantidad = cantidad;

        }

        public Dolar(double cantidad, double cotiz) : this(cantidad)
    {
      cotizRespecDolar = cotiz;
    }

        public static implicit operator Dolar(double d)
        {
          Dolar dolar = new Dolar(d);

          return dolar;
        }

        public static explicit operator Euro(Dolar d)
        {
          Euro euro;

          double cant = d.GetCantidad();
          double eCotDolar = Euro.GetCotizacion();

          euro = new Euro(cant / eCotDolar);

          return euro;
        }

        public static explicit operator Peso(Dolar d)
        {
          Peso peso;

          double cant = d.GetCantidad();
          double pCotDolar = Peso.GetCotizacion();

          peso = new Peso(pCotDolar * cant);

          return peso;
        }

        public double GetCantidad()
        {
          return cantidad;
        }

        public static double GetCotizacion()
        {
          return cotizRespecDolar;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
          bool rtnVal = false;

          Dolar eDolar = (Dolar)e;

          if (d.GetCantidad() != eDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
          bool rtnVal = false;

          Dolar eDolar = (Dolar)e;

          if (d.GetCantidad() == eDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
          bool rtnVal = false;

          Dolar eDolar = (Dolar)p;

          if (d.GetCantidad() != eDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
          bool rtnVal = false;

          Dolar eDolar = (Dolar)p;

          if (d.GetCantidad() == eDolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
          bool rtnVal = false;

          if (d1.GetCantidad() != d1.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
          bool rtnVal = false;

          if (d1.GetCantidad() == d1.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
          Dolar dolar;
          Dolar eDolar = (Dolar)e;
          double cant;

          cant = d.GetCantidad() - e.GetCantidad();

          dolar = new Dolar(cant);

          return dolar;
        }

        public static Dolar operator -(Dolar d, Peso e)
        {
          Dolar dolar;
          Dolar eDolar = (Dolar)e;
          double cant;

          cant = d.GetCantidad() - e.GetCantidad();

          dolar = new Dolar(cant);

          return dolar;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
          Dolar dolar;
          Dolar eDolar = (Dolar)e;
          double cant;

          cant = d.GetCantidad() + e.GetCantidad();

          dolar = new Dolar(cant);

          return dolar;
        }

        public static Dolar operator +(Dolar d, Peso e)
        {
          Dolar dolar;
          Dolar eDolar = (Dolar)e;
          double cant;

          cant = d.GetCantidad() - e.GetCantidad();

          dolar = new Dolar(cant);

          return dolar;
        }


      }

      public class Peso
      {
        private double cantidad;
    private static double cotizRespecDolar;

        public Peso()
        {

        }

        public Peso(double cantidad)
        {
          this.cantidad = cantidad;

        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {

          cotizRespecDolar = cotizacion;
        }

        public static implicit operator Peso(double d)
        {
          Peso peso = new Peso(d);

          return peso;
        }

        public static explicit operator Dolar(Peso p)
        {
          Dolar dolar;

          double cant = p.GetCantidad();
          double pCotDolar = Peso.GetCotizacion();

          dolar = new Dolar(cant / pCotDolar);

          return dolar;
        }

        public static explicit operator Euro(Peso p)
        {
          Euro euro;

          double cant = p.GetCantidad();
          double cot = GetCotizacion();
          double pDolares = cant / cot;
          double eCotDolar = Euro.GetCotizacion();

          euro = new Euro(pDolares * eCotDolar);

          return euro;
        }

        public double GetCantidad()
        {
          return cantidad;
        }

        public static double GetCotizacion()
        {
          return cotizRespecDolar;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
          Dolar dolar = (Dolar)p;
          bool rtnVal = false;

          if (d.GetCantidad() != dolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;

        }

        public static bool operator ==(Peso p, Dolar d)
        {
          Dolar dolar = (Dolar)p;
          bool rtnVal = false;

          if (d.GetCantidad() == dolar.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;

        }

        public static bool operator !=(Peso p, Euro e)
        {
          Euro euro = (Euro)p;
          bool rtnVal = false;

          if (e.GetCantidad() != euro.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Peso p, Euro e)
        {
          Euro euro = (Euro)p;
          bool rtnVal = false;

          if (e.GetCantidad() == euro.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
          bool rtnVal = false;

          if (p1.GetCantidad() != p2.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
          bool rtnVal = false;

          if (p1.GetCantidad() == p2.GetCantidad())
          {
            rtnVal = true;
          }

          return rtnVal;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
          Peso peso;
          Peso dPeso = (Peso)d;

          double cant = p.GetCantidad() - dPeso.GetCantidad();

          peso = new Peso(cant);

          return peso;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
          Peso peso;
          Peso dPeso = (Peso)d;

          double cant = p.GetCantidad() + dPeso.GetCantidad();

          peso = new Peso(cant);

          return peso;
        }

        public static Peso operator -(Peso p, Euro e)
        {
          Peso peso;
          Peso dPeso = (Peso)e;

          double cant = p.GetCantidad() - dPeso.GetCantidad();

          peso = new Peso(cant);

          return peso;
        }

        public static Peso operator +(Peso p, Euro e)
        {
          Peso peso;
          Peso dPeso = (Peso)e;

          double cant = p.GetCantidad() + dPeso.GetCantidad();

          peso = new Peso(cant);

          return peso;
        }


      }

}

