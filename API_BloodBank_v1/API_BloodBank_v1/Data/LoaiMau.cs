using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class LoaiMau
    {
        public int Id_LoaiMau { get; set; }

        public string TenLoai { get; set; }

        public string MoTa { get; set; }

        public float TheTich { get; set; }

        public List<ChiTietYeuCau> ChiTietYeuCaus { get; set; } 
        public List<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }
    }
}
