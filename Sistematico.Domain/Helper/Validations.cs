using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DepreciationDBApp.Domain.Helper
{
    public static class Validations
    {
        public static bool emptyFields(string Cadena1, string Cadena2, string Cadena3, string Cadena4, string Cadena5, string Cadena6, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            if (String.IsNullOrEmpty(Cadena1) || String.IsNullOrEmpty(Cadena2) || String.IsNullOrEmpty(Cadena3) || String.IsNullOrEmpty(Cadena4) || String.IsNullOrEmpty(Cadena5) ||
                 string.IsNullOrEmpty(Cadena6))
            {
                if((nota1 > 100 || nota1 < 0) || (nota2 > 100 || nota2 < 0) || (nota3 > 100 || nota3 < 0) || (nota4 > 100 || nota4 < 0))
                {
                    throw new ArgumentException("Las notas deben de ser menores a 100 y mayores a 0");
                }
                return false;
            }
            return true;
        }

        public static bool ValidationFiels(string correo, string numero, string cedula, string carnet)
        {
            if (!Regex.IsMatch(correo, @"\A(\w+\.?\w*\@\w+\.)(com)\Z"))
            {
                throw new ArgumentException("The format of correo is incorrect");
            }
            if (!Regex.IsMatch(numero, @"\A[0-9]{4}(\-)[0-9]{4}\Z"))
            {
                throw new ArgumentException("the format of numero is incorrect");
            }
            if (!Regex.IsMatch(cedula, @"\A[0-9]{3}(\-)[0-9]{6}(\-)[0-9]{4}[A-Z]\Z"))
            {
                throw new ArgumentException("thr format of cedula is incorrect");
            }
            if(!Regex.IsMatch(carnet, @"\A[0-9]{4}(\-)[0-9]{4}[A-Z]\Z"))
            {
                throw new ArgumentException("thr format of cedula is incorrect");
            }
            return true;
        }
    }
}
