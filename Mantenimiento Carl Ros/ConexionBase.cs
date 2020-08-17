using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mantenimiento_Carl_Ros
{
    class ConexionBase
    {
        private static string cnn;

        public static string conectar()
        {
            cnn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=carlros.accdb; Jet OLEDB:Database Password=;";
            return cnn;
        } 
    }
}
