using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class CaidoServerState : ServerState
    {
        public override void respuesta()
        {
            Console.WriteLine("Respuesta 503");
        }
    }
}
