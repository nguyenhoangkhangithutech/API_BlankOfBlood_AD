using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class SuKienHienMau
    {
        public int Id_SuKien { get; set; }

        public string TieuDe { get; set; }

        public string MoTa { get; set; }

        public DateTime ThoiGianBatdau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }

        public Guid Id_BacSi { get; set; }
        public int Id_BenhVien { get; set; }

        public ChiTietBenhVien ChiTietBenhVien { get; set; }


        public DiaChi DiaChi{ get; set; }

        public int Id_DiaChi { get; set; }

        public List<ChiTietSuKien> ChiTietSuKiens { get; set; }

    }
}
