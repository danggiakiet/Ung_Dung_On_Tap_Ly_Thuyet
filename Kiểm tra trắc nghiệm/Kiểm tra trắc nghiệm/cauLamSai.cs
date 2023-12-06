using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiểm_tra_trắc_nghiệm
{
    public class cauLamSai
    {
        public cauLamSai() { }
        
        public string cauHoi { get; set; }
        public string cauTraLoi { get; set;}
        public cauLamSai(string cauHoi, string cauTraLoi)
        {
            this.cauHoi = cauHoi;
            this.cauTraLoi = cauTraLoi;
        }
    }
}
