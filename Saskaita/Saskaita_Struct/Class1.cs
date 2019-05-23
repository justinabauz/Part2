using System;

namespace Saskaita_Struct
{
    public struct Saskaita
    {
        public string _gavejas;
        public string _siuntejas;
        public int _moketiViso;


        public string Gavejas
        {
            get
            {
                return _gavejas;
            }
            private set
            {
                _gavejas = value;
            }
        }
       public string Siuntejas
        {
            get
            {
                return _siuntejas;
            }
            private set
            {
                _siuntejas = value;
            }
        }
        public int MoketiViso
        {
            get
            {
                return _moketiViso;
            }
            private set
            {
                _moketiViso = value;
            }
        }
        public string SaskaitosNumeris
        {
            get
            {
                return string.Format("Nr_2019-05-12(01)");
            }
        }

        public Saskaita(string gavejas, string siuntejas, int moketiViso)
        {
            _gavejas = gavejas;
            _siuntejas = siuntejas;
            _moketiViso = moketiViso;

        }
    }
}