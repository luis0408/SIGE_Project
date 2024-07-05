using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new managerforms());
            //Application.Run(new  ControlEscolar.FichaEscolar());
            //Application.Run(new Catalogo.catalogoPeriodos());
            //Application.Run(new Catalogo.catalogoMediosDeDifusion());
<<<<<<< HEAD
            //Application.Run(new Catalogo.catalogoGenero());
            Application.Run(new Catalogo.catalogoEstadoCivil());
=======
            //Application.Run(new Catalogo.catalogoTipoUsuarios());

>>>>>>> 07d2de3f2eeff72c1142c948f03774c185377135
        }
    }
}
