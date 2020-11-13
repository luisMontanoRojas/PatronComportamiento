using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SaturadoServerState : ServerState
    {
        public override void respuesta()
        {
            Task.Delay(500);
            Console.WriteLine("Respuesta 200 con un delaye de 500");
        }
    }
}
