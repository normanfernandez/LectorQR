using System;
using System.Text.RegularExpressions;

namespace LectorQRv2.Models
{
    public class Placa
    {
        private string _noSerie;
        public string NoSerie { get { return _noSerie; } }

        public Placa(string serie)
        {
            string fomato = @"[AGLF]\d{6}";
            Regex regex = new Regex(fomato);

            if (regex.IsMatch(serie.ToUpper()))
                _noSerie = serie.ToUpper();
            else
                throw new InvalidPlacaException();
        }
    }

    public class InvalidPlacaException : Exception
    {
        public InvalidPlacaException() :base("Placa no valida!") {}
    }
}
