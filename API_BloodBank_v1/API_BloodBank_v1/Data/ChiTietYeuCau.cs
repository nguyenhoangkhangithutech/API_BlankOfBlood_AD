using System;

namespace API_BloodBank_v1.Data
{
    public class ChiTietYeuCau
    {
        public int Id_LoaiMau { get; set; }

        public Guid Id_BacSi { get; set; }

        public int Id_BenhVien { get; set; }

        public float TongTheTich { get; set; }
    
        public YeuCau YeuCau { get; set; }

        public LoaiMau LoaiMau { get; set; }
    }
}
