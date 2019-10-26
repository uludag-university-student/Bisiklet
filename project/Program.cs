using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{

    public class Bisiklet
    {

        public Color Renk { get; set; }
        public int TekerlekSayisi { get; set; }
        public string TavsiyeEdermisin { get; set; }
        public int BisikletHizi { get; set; }

        public string BisikletInfo()





           static void Main(string[] args)


        {

            Bisiklet bisikletInfo = new Bisiklet();

            bisikletInfo = "Benim " +
            Renk.ToString() + " bisikletim aklima geldi. Bisikletim " +
            TekerlekSayisi.ToString() + " tekerlekliydi." +
            TavsiyeEdermisin.ToString() + "Tavsiye ederim. " +
            BisikletHizi.ToString() + " km hiza kadar ulastigim oluyordu.";




            return bisikletInfo;
        }

        }
    }
}
