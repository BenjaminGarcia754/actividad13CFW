using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Actividad13CFW
{
    internal class Divisas
    {
        [DataMember]
        public float pesos { get; set; }
        [DataMember]
        public float dolares { get; set;}
    }
}
