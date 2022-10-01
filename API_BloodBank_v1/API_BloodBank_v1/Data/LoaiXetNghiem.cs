using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class LoaiXetNghiem
    {
        public int ID_LoaiXetNghiem { get; set; }

        public string TenLoai { get; set; }

        public string PathFileChiTiet { get; set; }

        public float ChiPhi { get; set; }

        public List<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }    
    }
}
