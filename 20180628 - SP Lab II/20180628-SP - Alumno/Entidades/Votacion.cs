﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Votacion
    {
        public delegate void DelegadoVoto(string senador, Votacion.EVoto voto);
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;

        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public string NombreLey
        {
            get
            {
                return this.nombreLey;
            }
        }

        public short Afirmativo
        {
            get
            {
                return this.contadorAfirmativo;
            }

        }

        public short Negativo
        {
            get
            {
                return this.contadorNegativo;
            }

        }

        public short Abstencion
        {
            get
            {
                return this.contadorAbstencion;
            }

        }

        public event DelegadoVoto EventoVotoEfectuado;

        public Votacion()
        {

        }
        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(1);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);


                // Invocar Evento
                this.EventoVotoEfectuado.Invoke(k.Key, this.senadores[k.Key]);

                // Incrementar contadores
                switch (this.senadores[k.Key])
                {
                    case EVoto.Abstencion:
                        contadorAbstencion++;
                        break;
                    case EVoto.Afirmativo:
                        contadorAfirmativo++;
                        break;
                    case EVoto.Negativo:
                        contadorNegativo++;
                        break;
                }

            }
        }
    }
}
