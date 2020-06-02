using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CokluKontrol
    {
        public int KontrolEt(string[]hayvanlar,string[] hayvanlarOrginal)
        {
            int sayac = 0;
            for (int i = 0; i < 3; i++)
            {
                if (hayvanlar[i].ToLower() == hayvanlarOrginal[i].ToLower())
                    sayac++;
            }
            return sayac;
        }
    }
}
