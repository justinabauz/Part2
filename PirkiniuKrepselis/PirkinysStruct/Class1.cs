using System;

namespace PirkinysStruct
{
    public struct Pirkinys
    {
        private string _prekesPavadinimas;
        private int _kiekis;
        private int _kainaVieneto;


        public string PrekesPavadinimas
        {
            get
            {
                return _prekesPavadinimas;
            }
            set
            {
                _prekesPavadinimas = value;
            }
        }
        public int Kiekis
        {
            get
            {
                return _kiekis;
            }
            set
            {
                _kiekis = value;
            }
        }
        public int KainaVieneto
        {
            get
            {
                return _kainaVieneto;
            }
            set
            {
                _kainaVieneto = value;
            }
        }
        public int KainaViso
        {
            get
            {
                return Kiekis * KainaVieneto;
            }
        }

        public Pirkinys(string prekesPavadinimas, int kiekis, int kainaVieneto)
        {
            _prekesPavadinimas = prekesPavadinimas;
            _kiekis = kiekis;
            _kainaVieneto = kainaVieneto;
        }
    }
}