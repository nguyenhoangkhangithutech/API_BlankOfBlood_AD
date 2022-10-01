using Microsoft.EntityFrameworkCore.Migrations;

namespace API_BloodBank_v1.Migrations
{
    public partial class dbInitStructure_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "bacsi_lamviec_chitietbenhvien",
                table: "ChiTietBenhVien");

            migrationBuilder.DropForeignKey(
                name: "Benhvien_co_chitietbenhvien",
                table: "ChiTietBenhVien");

            migrationBuilder.DropForeignKey(
                name: "BacSiCuaBenhVien_SuDung",
                table: "ChiTietSuDung");

            migrationBuilder.DropForeignKey(
                name: "KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung",
                table: "ChiTietSuDung");

            migrationBuilder.DropForeignKey(
                name: "NguoiHienMau_thamgia_Sukien",
                table: "ChiTietSuKien");

            migrationBuilder.DropForeignKey(
                name: "SuKienHienMau_Co_ChiTietSuKien",
                table: "ChiTietSuKien");

            migrationBuilder.DropForeignKey(
                name: "LoaiMau_NamTrong_ChiTietYeuCau",
                table: "ChiTietYeuCau");

            migrationBuilder.DropForeignKey(
                name: "YeuCau_Co_ChiTietYeuCau",
                table: "ChiTietYeuCau");

            migrationBuilder.DropForeignKey(
                name: "ChiTietBenhVien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "ChiTietSuKien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "LoaiMau_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "LoaiXetNghiem_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "BacSi_Tochuc_Sukienhienmaus",
                table: "SuKienHienMau");

            migrationBuilder.DropForeignKey(
                name: "Diachi_cua_sukienhienmau",
                table: "SuKienHienMau");

            migrationBuilder.DropForeignKey(
                name: "bacsi_yeucau",
                table: "YeuCau");

            migrationBuilder.DropForeignKey(
                name: "yeuccau_benhvien",
                table: "YeuCau");

            migrationBuilder.AddForeignKey(
                name: "bacsi_lamviec_chitietbenhvien",
                table: "ChiTietBenhVien",
                column: "Id_BacSi",
                principalTable: "BacSi",
                principalColumn: "Id_BacSi",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "Benhvien_co_chitietbenhvien",
                table: "ChiTietBenhVien",
                column: "Id_BenhVien",
                principalTable: "BenhVien",
                principalColumn: "Id_BenhVien",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "BacSiCuaBenhVien_SuDung",
                table: "ChiTietSuDung",
                columns: new[] { "Id_BenhVien_Dung", "Id_BacSi_Dung" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung",
                table: "ChiTietSuDung",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi_Nhap", "Id_BenhVien_Nhap", "Id_LoaiMau", "Id_LoaiXetNghiem" },
                principalTable: "KetQuaXetNghiem",
                principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi", "Id_BenhVien", "Id_LoaiMau", "Id_LoaiXetNghiem" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "NguoiHienMau_thamgia_Sukien",
                table: "ChiTietSuKien",
                column: "Id_NguoiHienMau",
                principalTable: "NguoiHienMau",
                principalColumn: "UID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "SuKienHienMau_Co_ChiTietSuKien",
                table: "ChiTietSuKien",
                column: "Id_SuKien",
                principalTable: "SuKienHienMau",
                principalColumn: "Id_SuKien",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "LoaiMau_NamTrong_ChiTietYeuCau",
                table: "ChiTietYeuCau",
                column: "Id_LoaiMau",
                principalTable: "LoaiMau",
                principalColumn: "Id_LoaiMau",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "YeuCau_Co_ChiTietYeuCau",
                table: "ChiTietYeuCau",
                columns: new[] { "Id_BacSi", "Id_BenhVien" },
                principalTable: "YeuCau",
                principalColumns: new[] { "Id_BacSi", "Id_BenhVien" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "ChiTietBenhVien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_BenhVien", "Id_BacSi" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "ChiTietSuKien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                principalTable: "ChiTietSuKien",
                principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "LoaiMau_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiMau",
                principalTable: "LoaiMau",
                principalColumn: "Id_LoaiMau",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "LoaiXetNghiem_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiXetNghiem",
                principalTable: "LoaiXetNghiem",
                principalColumn: "ID_LoaiXetNghiem",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "BacSi_Tochuc_Sukienhienmaus",
                table: "SuKienHienMau",
                columns: new[] { "Id_BenhVien", "Id_BacSi" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "Diachi_cua_sukienhienmau",
                table: "SuKienHienMau",
                column: "Id_DiaChi",
                principalTable: "DiaChi",
                principalColumn: "Id_DC",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "bacsi_yeucau",
                table: "YeuCau",
                column: "Id_BacSi",
                principalTable: "BacSi",
                principalColumn: "Id_BacSi",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "yeuccau_benhvien",
                table: "YeuCau",
                column: "Id_BenhVien",
                principalTable: "BenhVien",
                principalColumn: "Id_BenhVien",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "bacsi_lamviec_chitietbenhvien",
                table: "ChiTietBenhVien");

            migrationBuilder.DropForeignKey(
                name: "Benhvien_co_chitietbenhvien",
                table: "ChiTietBenhVien");

            migrationBuilder.DropForeignKey(
                name: "BacSiCuaBenhVien_SuDung",
                table: "ChiTietSuDung");

            migrationBuilder.DropForeignKey(
                name: "KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung",
                table: "ChiTietSuDung");

            migrationBuilder.DropForeignKey(
                name: "NguoiHienMau_thamgia_Sukien",
                table: "ChiTietSuKien");

            migrationBuilder.DropForeignKey(
                name: "SuKienHienMau_Co_ChiTietSuKien",
                table: "ChiTietSuKien");

            migrationBuilder.DropForeignKey(
                name: "LoaiMau_NamTrong_ChiTietYeuCau",
                table: "ChiTietYeuCau");

            migrationBuilder.DropForeignKey(
                name: "YeuCau_Co_ChiTietYeuCau",
                table: "ChiTietYeuCau");

            migrationBuilder.DropForeignKey(
                name: "ChiTietBenhVien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "ChiTietSuKien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "LoaiMau_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "LoaiXetNghiem_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem");

            migrationBuilder.DropForeignKey(
                name: "BacSi_Tochuc_Sukienhienmaus",
                table: "SuKienHienMau");

            migrationBuilder.DropForeignKey(
                name: "Diachi_cua_sukienhienmau",
                table: "SuKienHienMau");

            migrationBuilder.DropForeignKey(
                name: "bacsi_yeucau",
                table: "YeuCau");

            migrationBuilder.DropForeignKey(
                name: "yeuccau_benhvien",
                table: "YeuCau");

            migrationBuilder.AddForeignKey(
                name: "bacsi_lamviec_chitietbenhvien",
                table: "ChiTietBenhVien",
                column: "Id_BacSi",
                principalTable: "BacSi",
                principalColumn: "Id_BacSi");

            migrationBuilder.AddForeignKey(
                name: "Benhvien_co_chitietbenhvien",
                table: "ChiTietBenhVien",
                column: "Id_BenhVien",
                principalTable: "BenhVien",
                principalColumn: "Id_BenhVien");

            migrationBuilder.AddForeignKey(
                name: "BacSiCuaBenhVien_SuDung",
                table: "ChiTietSuDung",
                columns: new[] { "Id_BenhVien_Dung", "Id_BacSi_Dung" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" });

            migrationBuilder.AddForeignKey(
                name: "KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung",
                table: "ChiTietSuDung",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi_Nhap", "Id_BenhVien_Nhap", "Id_LoaiMau", "Id_LoaiXetNghiem" },
                principalTable: "KetQuaXetNghiem",
                principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi", "Id_BenhVien", "Id_LoaiMau", "Id_LoaiXetNghiem" });

            migrationBuilder.AddForeignKey(
                name: "NguoiHienMau_thamgia_Sukien",
                table: "ChiTietSuKien",
                column: "Id_NguoiHienMau",
                principalTable: "NguoiHienMau",
                principalColumn: "UID");

            migrationBuilder.AddForeignKey(
                name: "SuKienHienMau_Co_ChiTietSuKien",
                table: "ChiTietSuKien",
                column: "Id_SuKien",
                principalTable: "SuKienHienMau",
                principalColumn: "Id_SuKien");

            migrationBuilder.AddForeignKey(
                name: "LoaiMau_NamTrong_ChiTietYeuCau",
                table: "ChiTietYeuCau",
                column: "Id_LoaiMau",
                principalTable: "LoaiMau",
                principalColumn: "Id_LoaiMau");

            migrationBuilder.AddForeignKey(
                name: "YeuCau_Co_ChiTietYeuCau",
                table: "ChiTietYeuCau",
                columns: new[] { "Id_BacSi", "Id_BenhVien" },
                principalTable: "YeuCau",
                principalColumns: new[] { "Id_BacSi", "Id_BenhVien" });

            migrationBuilder.AddForeignKey(
                name: "ChiTietBenhVien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_BenhVien", "Id_BacSi" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" });

            migrationBuilder.AddForeignKey(
                name: "ChiTietSuKien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                principalTable: "ChiTietSuKien",
                principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien" });

            migrationBuilder.AddForeignKey(
                name: "LoaiMau_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiMau",
                principalTable: "LoaiMau",
                principalColumn: "Id_LoaiMau");

            migrationBuilder.AddForeignKey(
                name: "LoaiXetNghiem_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiXetNghiem",
                principalTable: "LoaiXetNghiem",
                principalColumn: "ID_LoaiXetNghiem");

            migrationBuilder.AddForeignKey(
                name: "BacSi_Tochuc_Sukienhienmaus",
                table: "SuKienHienMau",
                columns: new[] { "Id_BenhVien", "Id_BacSi" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" });

            migrationBuilder.AddForeignKey(
                name: "Diachi_cua_sukienhienmau",
                table: "SuKienHienMau",
                column: "Id_DiaChi",
                principalTable: "DiaChi",
                principalColumn: "Id_DC");

            migrationBuilder.AddForeignKey(
                name: "bacsi_yeucau",
                table: "YeuCau",
                column: "Id_BacSi",
                principalTable: "BacSi",
                principalColumn: "Id_BacSi");

            migrationBuilder.AddForeignKey(
                name: "yeuccau_benhvien",
                table: "YeuCau",
                column: "Id_BenhVien",
                principalTable: "BenhVien",
                principalColumn: "Id_BenhVien");
        }
    }
}
