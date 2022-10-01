using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class BacSi : Person
    {
        public Guid Id_BacSi { get; set; }

        public List<YeuCau> yeuCaus { get; set; }
        public List<ChiTietBenhVien> chiTietBenhViens   { get; set; }
    }
}
