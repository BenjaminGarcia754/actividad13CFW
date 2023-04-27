using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Actividad13CFW
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConvertidorDivisas
    {
        [OperationContract]
        double obtenerDolares(float pesos);
        double obtenerPesos(float dolares);
    }

}
