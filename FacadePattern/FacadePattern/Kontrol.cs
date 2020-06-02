using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Kontrol
    {
        CokluKontrol cokluKontrol = new CokluKontrol();
        TekliKontrol tekliKontrol = new TekliKontrol();

        public int CokluKontrol(string[] hayvanlar, string[] hayvanlarOrginal)
        {
           return cokluKontrol.KontrolEt(hayvanlar,hayvanlarOrginal);
        }

        public string TekliKontrol(string hayvanAdi, string hayvanAdiOrginal)
        {
            return tekliKontrol.KontrolEt(hayvanAdi,hayvanAdiOrginal);
        }
    }
}
