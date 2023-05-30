using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongTinLoaiHang
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
        public string Mota { get; set; }
        

        public DTO_ThongTinLoaiHang() 
        { 
        
        }    
        public DTO_ThongTinLoaiHang(string maLoaiHang, string tenLoaiHang, string mota)
        {
            MaLoaiHang = maLoaiHang;
            TenLoaiHang = tenLoaiHang;
            Mota = mota;
        }
    }
}
