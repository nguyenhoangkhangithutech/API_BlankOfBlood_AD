using Microsoft.EntityFrameworkCore.Migrations;

namespace API_BloodBank_v1.Migrations
{
    public partial class dbInitStructure_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "ChiTietBenhVien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_BenhVien", "Id_BacSi" },
                principalTable: "ChiTietBenhVien",
                principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ChiTietSuKien_KetQuaXetNghiem",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                principalTable: "ChiTietSuKien",
                principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "LoaiMau_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiMau",
                principalTable: "LoaiMau",
                principalColumn: "Id_LoaiMau",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "LoaiXetNghiem_KetQuaXetNGhiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiXetNghiem",
                principalTable: "LoaiXetNghiem",
                principalColumn: "ID_LoaiXetNghiem",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
