using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGE_Project.ControlEscolar
{
    public partial class FichaEscolar : DevExpress.XtraEditors.XtraForm
    {
        public FichaEscolar()
        {
            InitializeComponent();
        }

        private void FichaEscolar_Load(object sender, EventArgs e)
        {
            llenarLookups();
        }
        private void llenarLookups()
        {
            ////PAIS
            lookUpEdit_pais.Properties.DataSource = Utilerias.llenarlookupeditvalue("select c_Pais,descripcion  from [dbo].[SIGE_Catalogo_Pais]");
            lookUpEdit_pais.Properties.DisplayMember = "descripcion";
            lookUpEdit_pais.Properties.ValueMember = "c_Pais";
            ////GENERO
            lookUpEdit_genero.Properties.DataSource = Utilerias.llenarlookupeditvalue("select cveGenero,descripcion from SIGE_Catalogo_Genero where estado=1");
            lookUpEdit_genero.Properties.DisplayMember = "descripcion";
            lookUpEdit_genero.Properties.ValueMember = "cveGenero";

            ////BACHILLERATO
            lookUpEdit_bachillerato.Properties.DataSource = Utilerias.llenarlookupeditvalue("  select CCT,CONCAT(CCT,' | ',nombreBachillerato) as descripcion, cveEntidad as estado, cveMunicipio from [SIGE_Catalogo_Bachillerato]");
            lookUpEdit_bachillerato.Properties.DisplayMember = "descripcion";
            lookUpEdit_bachillerato.Properties.ValueMember = "CCT";
        }
    }
}