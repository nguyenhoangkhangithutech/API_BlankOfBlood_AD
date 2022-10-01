using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class ChiTietSuKien
    {
        public Guid Id_NguoiHienMau { get; set; } 
    
        public int Id_SuKien { get; set; }

        public NguoiHienMau NguoiHienMau { get; set; }

        public SuKienHienMau SuKienHienMau { get; set; }

        public List<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }
    }
}
