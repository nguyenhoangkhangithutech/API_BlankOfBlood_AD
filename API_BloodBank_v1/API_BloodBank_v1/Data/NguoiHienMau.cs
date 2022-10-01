using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class NguoiHienMau : Person
    {
        public Guid UID { get; set; }
        public List<ChiTietSuKien> ChiTietSuKiens { get; set; }
    }
}
