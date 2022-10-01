using System;

namespace API_BloodBank_v1.Data
{
    public class ChiTietSuDung
    {
        public Guid Id_NguoiHienMau { get; set; }
        public int Id_SuKien { get; set; }

        public int Id_LoaiMau { get; set; }

        public Guid Id_BacSi_Nhap { get; set; }

        public int Id_BenhVien_Nhap { get; set; }

        public int Id_LoaiXetNghiem { get; set; }

        public KetQuaXetNghiem KetQuaXetNghiem { get; set; }


        // chi tiet benh vien

        public Guid Id_BacSi_Dung { get; set; }

        public int Id_BenhVien_Dung { get; set; }

        public ChiTietBenhVien ChiTietBenhVien { get; set; }    
    }
}
