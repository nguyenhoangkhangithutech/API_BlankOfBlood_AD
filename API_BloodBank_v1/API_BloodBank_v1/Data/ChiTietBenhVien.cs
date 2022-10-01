using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class ChiTietBenhVien
    {
        public Guid Id_BacSi { get; set; }
        
        public int Id_BenhVien { get; set; }

        public DateTime NgayCap { get; set; }

        public DateTime NgayNghi { get; set; }
   
        public BacSi BacSi { get; set; }

        public BenhVien BenhVien { get; set; }
   
        public List<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }
        public List<ChiTietSuDung> ChiTietSuDungs { get; set; }

        public List<SuKienHienMau> SuKienHienMaus { get; set; }
    }
}
