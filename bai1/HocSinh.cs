using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class HocSinh
    {
        public string Mahs { get; set; }
        public string Hoten { get; set; }
        public string Phai { get; set; }
        public string diachi { get; set; }
        public float Diemtoan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float Dtb
        {
            get
            {
                return (Diemtoan + DiemLy + DiemHoa) / 2;
            }
        }

        public HocSinh(string Mahs, string Hoten, string Phai, string Diachi, float Diemtoan, float DiemLy, float DiemHoa)
        {
            Mahs = Mahs;
            Hoten = Hoten;
            Phai = Phai;
            diachi = diachi;
            Diemtoan = Diemtoan;
            DiemLy = DiemLy;
            DiemHoa = DiemHoa;
        }
    }
}