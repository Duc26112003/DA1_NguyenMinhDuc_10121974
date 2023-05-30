//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DTO;
//using DAO;
//namespace BUS
//{
//    public  class BUS_TaiKhoan
//    {
//        DAO_TaiKhoanaAccess tkaccess = new DAO_TaiKhoanaAccess(); 
//        public string CheckLogic(DTO_TaiKhoan taiKhoan)
//        {
//           // Kiem tra nghiep vu 
//           if(taiKhoan.sTaiKhoan=="")
//            {
//                return "repuied_taikhoan";
//            }

//            if (taiKhoan.sMatKhau == "")
//            {
//                return "repuied_password";
//            }

//            string info =tkaccess.CheckLogic(taiKhoan);
//            return info;
//        }

//    }
//}
