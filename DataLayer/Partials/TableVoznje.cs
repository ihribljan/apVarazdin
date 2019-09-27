using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APVarazdin.DataLayer
{
    public partial class TableVoznje
    {
        public string P_Vrijeme
        {
            get { return VrijemePolaska.ToString("dd.MM.yyyy HH:mm") + " - " + VrijemeDolaska.ToString("dd.MM.yyyy HH:mm"); }
            set { }
        }
    }
}
