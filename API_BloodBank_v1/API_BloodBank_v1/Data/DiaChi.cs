using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class DiaChi
    {
        public int Id_DC { get; set; }

        public string ChiTiet { get; set; }

        public List<SuKienHienMau> SuKienHienMaus { get; set; } 
    }
}
