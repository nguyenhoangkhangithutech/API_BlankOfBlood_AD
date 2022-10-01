using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class YeuCau
    {
        public Guid Id_BacSi { get; set; }

        public int Id_BenhVien { get; set; }

        public DateTime ThoiGianYeuCau { get; set; }

        public bool KetQua { get; set; }

        public string FileKetQua { get; set; }
        
        public List<ChiTietYeuCau> ChiTietYeuCaus   { get; set; }   
   
        public BacSi BacSi { get; set; }

        public BenhVien BenhVien { get; set; }
    }
}
