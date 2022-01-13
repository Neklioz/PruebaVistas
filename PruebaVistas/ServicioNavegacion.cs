using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PruebaVistas
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaHija()
        {
            VentanaHija nuevaVentana = new VentanaHija();
            return nuevaVentana.ShowDialog();
        }

        internal UserControl AbrirUC2()
        {
            return new UserControl2();
        }

        internal UserControl AbrirUC1()
        {
            return new UserControl1();
        }
    }
}
