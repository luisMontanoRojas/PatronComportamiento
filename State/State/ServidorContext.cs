using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ServidorContext
    {
        private ServerState state;

        public ServerState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void atenderSolicitud()
        {
            state.respuesta();
        }
    }
}
