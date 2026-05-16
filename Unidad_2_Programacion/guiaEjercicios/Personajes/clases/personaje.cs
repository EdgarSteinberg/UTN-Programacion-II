namespace clases
{
    public abstract class Personaje
    {

        public Personaje()
        {
            PuntosDeExperiencia = 0;
            PuntosDeVitalidad = 20;
            Nivel = 1;
            EstaMuerto = false;
        }
        private string _nombre = "";
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _nivel;
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        private int _puntosDeExperiencia;
        public int PuntosDeExperiencia
        {
            get { return _puntosDeExperiencia; }
            set { _puntosDeExperiencia = value; }
        }

        private int _puntosDeVitalidad;
        public int PuntosDeVitalidad
        {
            get { return _puntosDeVitalidad; }
            set { _puntosDeVitalidad = value; }
        }

        private int _desplazamiento;
        public int Desplazamiento
        {
            get { return _desplazamiento; }
            set { _desplazamiento = value; }
        }

        private Arma _arma;
        public Arma Arma
        {
            get { return _arma; }
            set { _arma = value; }
        }

        private Armadura _armadura;
        public Armadura Armadura
        {
            get { return _armadura; }
            set { _armadura = value; }
        }

        private List<Habilidad> _habilidades;
        public List<Habilidad> Habilidades
        {
            get { return _habilidades; }
            set { _habilidades = value; }
        }

        private List<object> _inventario;
        public List<object> Inventario
        {
            get { return _inventario; }
            set { _inventario = value; }
        }

        private bool _estaMuerto;
        public bool EstaMuerto
        {
            get { return _estaMuerto; }
            set { _estaMuerto = value; }
        }

        public void Atacar(Personaje objetivo)
        {
            if (EstaMuerto || objetivo.EstaMuerto)
                return;

            int danio = Arma != null ? Arma.Danio : 0;

            // habilidades de ATAQUE
            foreach (var habilidad in _habilidades)
            {
                if (habilidad.Tipo == TipoHabilidad.ATAQUE && habilidad.Desbloqueada)
                {
                    danio += (int)habilidad.PuntosDeEfecto;
                }
            }

            if (objetivo.Armadura != null)
            {
                // CASO ARMADURA MÁGICA
                if (objetivo.Armadura.TipoDeProteccion == TipoAtaque.MAGICO)
                {
                    if (Arma != null && Arma.Tipo == TipoAtaque.MAGICO)
                    {
                        danio = 0;
                    }
                    else
                    {
                        danio -= (int)objetivo.Armadura.PuntosDeDefensa;

                        foreach (var habilidad in objetivo.Habilidades)
                        {
                            if (habilidad.Tipo == TipoHabilidad.DEFENSA && habilidad.Desbloqueada)
                            {
                                danio -= (int)habilidad.PuntosDeEfecto;
                            }
                        }
                    }
                }
                else
                {
                    if (Arma != null && Arma.Tipo == objetivo.Armadura.TipoDeProteccion)
                    {
                        danio -= (int)objetivo.Armadura.PuntosDeDefensa;

                        foreach (var habilidad in objetivo.Habilidades)
                        {
                            if (habilidad.Tipo == TipoHabilidad.DEFENSA && habilidad.Desbloqueada)
                            {
                                danio -= (int)habilidad.PuntosDeEfecto;
                            }
                        }
                    }
                }
            }

            if (danio < 0)
                danio = 0;

            objetivo.RecibirDanio(danio);
        }

        public void Avanzar()
        {
            int penalizacion = Armadura != null ? (int)Armadura.PenalizacionMovimiento : 0;
            int metros = Desplazamiento - penalizacion;

            if (metros < 0)
                metros = 0;

            Console.WriteLine($"{Nombre} avanza {metros} metros");
        }

        public void Morir()
        {
            PuntosDeVitalidad = 0;
            EstaMuerto = true;

            Console.WriteLine($"{Nombre} ha muerto");
        }

        public void RecibirDanio(int danio)
        {
            PuntosDeVitalidad -= danio;

            if (PuntosDeVitalidad <= 0)
            {
                Morir();
            }
        }

        public void ObtenerRecompensa(Personaje enemigo, int energiaQuitada)
        {
            if (enemigo.Arma != null)
            {
                Inventario.Add(enemigo.Arma);
                enemigo.Arma = null;
            }

            if (enemigo.Armadura != null)
            {
                Inventario.Add(enemigo.Armadura);
                enemigo.Armadura = null;
            }

            PuntosDeExperiencia += energiaQuitada;
        }

        public void SubirNivel()
        {
            if (PuntosDeExperiencia >= (Nivel + 1) * (Nivel + 1))
            {
                Nivel++;
                PuntosDeVitalidad = 20 * Nivel;

                foreach (var habilidad in _habilidades)
                {
                    if (habilidad.NivelRequerido == Nivel)
                    {
                        habilidad.Desbloqueada = true;
                    }
                }
            }
        }
    }
}