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
            do
            {
                Thread.Sleep(400);
                base.duraOrbita--;

            } while (base.DuraOrbita > 0);
            this.Orbitar(); // o base.InvocarEvento(this.Orbitar());
        }

        public void RunEvntRotar()
        {
            do
            {
                this.Rotar();
                Thread.Sleep(800);
                base.DuraRotacion--;

            } while (base.DuraRotacion > 0);
            base.runEvent(Rotar()); // o base.InvocarEvento(this.Rotar());           
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
