using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiểm_tra_trắc_nghiệm
{
    public class cauHoi
    {
        public cauHoi() { }

        public string CauHoi { get; set; }
        public string cauA { get; set; }
        public string cauB { get; set;}
        public string cauC { get; set;}
        public string cauD { get; set;}
        public int dapAnDung { get; set; }   
        public cauHoi(string cauHoi, string cauA, string cauB, string cauC, string cauD, int dapAnDung)
        {
            CauHoi = cauHoi;
            this.cauA = cauA;
            this.cauB = cauB;
            this.cauC = cauC;
            this.cauD = cauD;
            this.dapAnDung = dapAnDung;
        }
    }
}
