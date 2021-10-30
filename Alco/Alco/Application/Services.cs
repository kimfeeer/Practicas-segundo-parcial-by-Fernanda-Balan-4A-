using System; 
using System.Collections.Generic;
using System.Linq; 

namespace Alco.Application
{
    public class Services
    {
        public string alcocal (int cant, double peso, string drink )
        {
            int ml = 0;
            double cantdealco = 0;
            double alcsangre = 0;
            double sangrevol = 0;

            //Mensaje final 

            string menssage = "";
//cantidades de bebidas para posteriormente realizar las operaciones: 

        switch(drink.ToLower())
            {
                case "Cerveza":
                ml = 1000;
                cantdealco = 6;
                break;

                case "Vodka":
                ml = 200;
                cantdealco = 40;
                break;

                case "Whisky":
                ml = 700;
                cantdealco = 40;
                break;


            }
//Variable para calcular (Operaciones) calcular Alcoholemia: 

            alcsangre = cant * ml;

            alcsangre = (cantdealco / 100) * alcsangre;
            alcsangre = 0.879 * alcsangre;
            alcsangre = alcsangre / sangrevol;
          //Cantidad minima legal de alcohol en la sangre: 
            sangrevol = 0.08 * peso;
            alcsangre = 0.38 * alcsangre;
            alcsangre = Math.Round(alcsangre, 3);

// Mensaje que mostrara resultado utilizando if & else: 

            if (0.8 < alcsangre)
            {
                menssage = "Limite legal para conducir un vehiculo";
            }
            else
            {
                menssage = "Nivel Seguro";
            }

            string result = "Usted tiene este nivel de Alcohol en la sangre:  " + alcsangre + "g/l" + menssage;
            return result;
        }
    }
}