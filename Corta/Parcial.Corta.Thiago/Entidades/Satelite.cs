using System;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Satelite : Astro, IAstro
    {
        public Satelite() { }

        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre) { }

        public string Orbitar()
        {
            return $"Orbitar el satelite: {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Rota el satelite: {this.Nombre}";
        }

        public void RunEvntOrb()
        {
            while (base.duraOrbita != 0)
            {
                Thread.Sleep(50);
                base.duraOrbita--;
            }
            base.InvocarEvento(this.Orbitar());
        }

        public void RunEvntRotar()
        {
            while (base.duraOrbita != 0)
            {
                Thread.Sleep(800);
                base.duraOrbita--;
            }
            base.InvocarEvento(this.Rotar());
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Satelite");
            stringBuilder.AppendLine(Mostrar());

            return stringBuilder.ToString();
        }
    }
}
