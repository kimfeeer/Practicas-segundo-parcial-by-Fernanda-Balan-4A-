using System;
using System.Collections.Generic;
using System.Linq;

namespace Resistencia.Application
{
    public class Services
    {
         public string calres(string colorfirst, string colorsecond, string colorthird, string colorfourth)
        {
//Asignamos las variables para que posteriormente se realice la operacion: 

            string valor = "";
            int resistencia = 0;
            double tolerancia = 0;
            string porcentaje = "";

            string Colorfirst = colorfirst.ToLower();
            string Colorsecond = colorsecond.ToLower();
            string Colorthird = colorthird.ToLower();
            string Colorfourth = colorfourth.ToLower();

//Asignamos los detalles y el valor a cada color correspondiente con el mensaje final: 
            switch(Colorfirst)
            {
                case "NEGRO":
                    valor = "0";
                    break;
                case "MARRON":
                    valor = "1";
                    break;
                case "ROJO":
                    valor = "2";
                    break;
                case "NARANJA":
                    valor = "3";
                    break;
                case "AMARILLO":
                    valor = "4";
                    break;
                case "VERDE":
                    valor = "5";
                    break;
                case "AZUL":
                    valor = "6";
                    break;
                case "MORADO":
                    valor = "7";
                    break;
                case "GRIS":
                    valor = "8";
                    break;
                case "BLANCO":
                    valor = "9";
                    break;
                default:
                    return "Este color no es valido para la banda 1";
            }
// Para los siguientes colores utiliamos sus respectivos valores anteriormente buscados: 
            switch(Colorsecond)
            {
                case "NEGRO":
                    valor += "0";
                    break;
                case "MARRON":
                    valor += "1";
                    break;
                case "ROJO":
                    valor += "2";
                    break;
                case "NARANJA":
                    valor += "3";
                    break;
                case "AMARILLO":
                    valor += "4";
                    break;
                case "VERDE":
                    valor += "5";
                    break;
                case "AZUL":
                    valor += "6";
                    break;
                case "MORADO":
                    valor += "7";
                    break;
                case "GRIS":
                    valor += "8";
                    break;
                case "BLANCO":
                    valor += "9";
                    break;
                default:
                    return "Este color no es valido para la banda 2";
            }
//Usamos ToInt32 para darle una conversion general a los valores: 

            switch(Colorthird)
            {
                case "NEGRO":
                    resistencia = Convert.ToInt32(valor) * 1;
                    break;
                case "MARRON":
                    resistencia = Convert.ToInt32(valor) * 10;
                    break;
                case "ROJO":
                    resistencia = Convert.ToInt32(valor) * 100;
                    break;
                case "NARANJA":
                    resistencia = Convert.ToInt32(valor) * 1000;
                    break;
                case "AMARILLO":
                    resistencia = Convert.ToInt32(valor) * 10000;
                    break;
                case "VERDE":
                    resistencia = Convert.ToInt32(valor) * 100000;
                    break;
                case "AZUL":
                    resistencia = Convert.ToInt32(valor) * 1000000;
                    break;
                    default:
                    return "Este color no es valido para la banda 3";
            }
//Operacion para sacar el porcentaje 

            switch(Colorfourth)
            {
                case "ROJO":
                    tolerancia = resistencia * 0.02;
                    porcentaje= "2%";
                    break;
                case "DORADO":
                    tolerancia = resistencia * 0.05;
                    porcentaje = "5%";
                    break;
                case "PLATA":
                    tolerancia = resistencia * 0.1;
                    porcentaje = "10%";
                    break;
                default:
                    return "Este color no es valido para la banda 4";
            }
//Mensajes finales dependiendo del resultado: 

            string result = "La resistencia es: " + resistencia +
             "Posee una tolerancia de: " + porcentaje + 
             "Soporta valores de: "
              + (resistencia + tolerancia) + "Ω y " + (resistencia - tolerancia) + "Ω";

            return result;
        }
    }
}