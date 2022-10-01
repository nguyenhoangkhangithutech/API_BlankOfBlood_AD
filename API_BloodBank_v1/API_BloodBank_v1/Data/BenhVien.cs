using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class BenhVien
    {
        public int Id_BenhVien { get; set; }
        
        public string TenBenhVien { get; set; }

        public string Dc_BenhVien { get; set; }

        public List<YeuCau> yeuCaus { get; set; }
    
        public List<ChiTietBenhVien > chiTietBenhViens { get; set; }
    }
}
