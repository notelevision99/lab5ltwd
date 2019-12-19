using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Account
    {
        public string soTK { get; set; }
        public string tenKH { get; set; }
        public string diaChiKH { get; set; }
        public double soTienTrongTK { get; set; }

        public Account()
        {

        }
        public Account(string sotk,string tenkh,string diachikh, double sotientrongtk )
        {
            sotk = soTK;
            tenkh = tenKH;
            diachikh = diaChiKH;
            sotientrongtk = soTienTrongTK;
        }
    }
}
