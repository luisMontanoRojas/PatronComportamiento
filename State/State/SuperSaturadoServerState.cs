using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SuperSaturadoServerState : ServerState
    {
        public override void respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("Respuesta 200 con un elaye de 1000");
        }
    }
}
