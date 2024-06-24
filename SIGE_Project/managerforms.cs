using SIGE_Project.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGE_Project
{
    internal class managerforms:System.Windows.Forms.ApplicationContext
    {
        public managerforms()
        {

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            LOGIN principal = new LOGIN();
            
            principal.Show();
        }
        
    }

}
