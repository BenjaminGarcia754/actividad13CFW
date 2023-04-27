using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Actividad13CFW
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ConvertidorDivisas : IConvertidorDivisas
    {
        double IConvertidorDivisas.obtenerDolares(float pesos)
        {
            double dolares = pesos / 17.91;
            return dolares;
        }

        double IConvertidorDivisas.obtenerPesos(float dolares)
        {
            double pesos = dolares * 17.91;
            return pesos;
        }
    }
}
