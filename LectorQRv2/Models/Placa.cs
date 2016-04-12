using System;
using System.Text.RegularExpressions;

namespace LectorQRv2.Models
{
    public class Placa
    {
        //Clase cuya función primordial es crear una placa válida (dominicana)

        public const string PENDIENTE = "PENDIENTE";

        private string _noSerie;
        public string NoSerie { get { return _noSerie; } }

        public Placa(string serie)
        {
            //Regla para una placa dominicana
            string formato = @"^[AGLFX]{1}\d{6}"; // el primer caracter tiene qe ser una de esaas letras
            Regex regex = new Regex(formato); // objeto que trabaja con expresiones regulares


            //Se hace la verificación de la placa
            if (regex.IsMatch(serie.ToUpper()))
                _noSerie = serie.ToUpper();
            else
                throw new InvalidPlacaException();
        }
    }

    public class InvalidPlacaException : Exception
    {
        public InvalidPlacaException() : base("Placa no válida!") { }
    }
}
