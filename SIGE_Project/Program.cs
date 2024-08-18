using SIGE_Project.Catalogo;
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
            //Application.Run(new ControlEscolar.Documentacion("prueba"));

            //Application.Run(new  ControlEscolar.FichaSolicitud());

            //Application.Run(new managerforms());
            //Application.Run(new  ControlEscolar.FichaEscolar());

            //Application.Run(new Catalogo.catalogoPeriodos());
            //Application.Run(new Catalogo.catalogoMediosDeDifusion());
            //Application.Run(new Catalogo.catalogoGenero());
            //Application.Run(new Catalogo.catalogoEstadoCivil());
            //Application.Run(new Catalogo.catalogoTipoUsuarios());
            //Application.Run(new catalogoTipoSangre());
            //Application.Run(new catalogoParentesco());
            //Application.Run(new catalogoSemestres());
            //Application.Run(new Catalogo.catalogoLocalidad());
            //Application.Run(new Catalogo.catalogoMes());

            //Application.Run(new Catalogo.catalogoLocalidad());
            //Application.Run(new Catalogo.catalogoMes());

            //Application.Run(new Catalogo.catalogoModalidad());
            //Application.Run(new Catalogo.CatalogoDiscapacidad());
        }
    }
}
