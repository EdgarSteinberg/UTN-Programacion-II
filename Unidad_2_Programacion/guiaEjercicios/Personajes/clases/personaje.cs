namespace clases
{
    public abstract class Personaje
    {
        private string _nombre;
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

        private double _desplazamiento;
        public double Desplazamiento
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
            double danio = Arma.Danio;

            // habilidades de ATAQUE
            foreach (var habilidad in _habilidades)
            {
                if (habilidad.Tipo == TipoHabilidad.ATAQUE)
                {
                    danio += habilidad.PuntosDeEfecto;
                }
            }

            // CASO ARMADURA MÁGICA
            if (objetivo.Armadura.TipoDeProteccion == TipoAtaque.MAGICO)
            {
                if (Arma.Tipo == TipoAtaque.MAGICO)
                {
                    danio = 0;
                }
                else
                {
                    danio -= objetivo.Armadura.PuntosDeDefensa;

                    foreach (var habilidad in objetivo.Habilidades)
                    {
                        if (habilidad.Tipo == TipoHabilidad.DEFENSA)
                        {
                            danio -= habilidad.PuntosDeEfecto;
                        }
                    }
                }
            }
            else
            {
                if (Arma.Tipo == objetivo.Armadura.TipoDeProteccion)
                {
                    danio -= objetivo.Armadura.PuntosDeDefensa;

                    foreach (var habilidad in objetivo.Habilidades)
                    {
                        if (habilidad.Tipo == TipoHabilidad.DEFENSA)
                        {
                            danio -= habilidad.PuntosDeEfecto;
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
            double metros = this.Desplazamiento - this.Armadura.PenalizacionMovimiento;

            if (metros < 0)
                metros = 0;

            Console.WriteLine($"{this.Nombre} avanza {metros} metros");
        }

        public void Morir()
        {
            PuntosDeVitalidad = 0;
            EstaMuerto = true;

            Console.WriteLine($"{Nombre} ha muerto");
        }

        public void RecibirDanio(double danio)
        {
            this.PuntosDeVitalidad -= danio;

            if (PuntosDeVitalidad <= 0)
            {
                Morir();
            }
        }
    }
}