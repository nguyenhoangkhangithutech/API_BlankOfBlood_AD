using System;
using System.Collections.Generic;

namespace API_BloodBank_v1.Data
{
    public class KetQuaXetNghiem
    {
        public string FileKetQua { get; set; }

        public bool KetQuaHienMau { get; set; }

        public float TheTich { get; set; }

        public bool DaHienMau { get; set; }

        public DateTime ThoiGianTraKetQua { get; set; }

        public DateTime ThoiGianHienMau { get; set; }

        #region Define Key
        public Guid Id_NguoiHienMau { get; set; }

        public int Id_SuKien { get; set; }

        public ChiTietSuKien ChiTietSuKien { get; set; }

        public Guid Id_BacSi { get; set; }

        public int Id_BenhVien { get; set; }

        public ChiTietBenhVien ChiTietBenhVien { get; set; }

        public int Id_LoaiMau { get; set; }

        public LoaiMau LoaiMau { get; set; }

        public int Id_LoaiXetNghiem { get; set; }

        public LoaiXetNghiem LoaiXetNghiem { get; set; }
        #endregion


        public List<ChiTietSuDung> ChiTietSuDungs { get; set; }



    }
}
