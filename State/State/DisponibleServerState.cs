using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class DisponibleServerState : ServerState
    {
        public override void respuesta()
        {
            Console.WriteLine("Respuesta 200");
        }
    }
}
