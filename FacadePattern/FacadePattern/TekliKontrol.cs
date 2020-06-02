using DevExpress.Utils.Filtering.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class TekliKontrol
    {
        public string KontrolEt(string hayvanAdi,string hayvanAdiOrginal)
        {
            if (hayvanAdi.ToLower()==hayvanAdiOrginal.ToLower())
            {
                return "dogru";
            }
            return "yanlis";
        }
    }
}
