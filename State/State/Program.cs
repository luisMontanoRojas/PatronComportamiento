using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ServidorContext oServior = new ServidorContext();
            oServior.State = new DisponibleServerState();

            oServior.atenderSolicitud();

            oServior.State = new SaturadoServerState();
            oServior.atenderSolicitud();
            oServior.atenderSolicitud();

            oServior.State = new SuperSaturadoServerState();
            oServior.atenderSolicitud();
            oServior.atenderSolicitud();

            oServior.State = new CaidoServerState();
            oServior.atenderSolicitud();
            oServior.atenderSolicitud();

            oServior.State = new DisponibleServerState();
            oServior.atenderSolicitud();
            oServior.atenderSolicitud();
        }
    }
}
