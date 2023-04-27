using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Actividad13CFW
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ConvertidorClima : IConvertidorClima
    {
        double IConvertidorClima.GradosCentigrados(float gradosFarenheit)
        {
            double gradosCentigrados = ((gradosFarenheit - 32) * .555); 
            return gradosCentigrados;
        }

        double IConvertidorClima.GradosFarenheit(float gradosCentigrados)
        {
            double gradosFarenheit = (((gradosCentigrados * 9) / (5)) + 32);
            return gradosFarenheit;
        }
    }
}
