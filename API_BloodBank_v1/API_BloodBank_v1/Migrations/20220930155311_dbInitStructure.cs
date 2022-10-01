using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_BloodBank_v1.Migrations
{
    public partial class dbInitStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacSi",
                columns: table => new
                {
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSi", x => x.Id_BacSi);
                });

            migrationBuilder.CreateTable(
                name: "BenhVien",
                columns: table => new
                {
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBenhVien = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Dc_BenhVien = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhVien", x => x.Id_BenhVien);
                });

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    Id_DC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiTiet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChi", x => x.Id_DC);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMau",
                columns: table => new
                {
                    Id_LoaiMau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheTich = table.Column<float>(type: "real", nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMau", x => x.Id_LoaiMau);
                });

            migrationBuilder.CreateTable(
                name: "LoaiXetNghiem",
                columns: table => new
                {
                    ID_LoaiXetNghiem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PathFileChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiPhi = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiXetNghiem", x => x.ID_LoaiXetNghiem);
                });

            migrationBuilder.CreateTable(
                name: "NguoiHienMau",
                columns: table => new
                {
                    UID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiHienMau", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBenhVien",
                columns: table => new
                {
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNghi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietBenhVien", x => new { x.Id_BenhVien, x.Id_BacSi });
                    table.ForeignKey(
                        name: "bacsi_lamviec_chitietbenhvien",
                        column: x => x.Id_BacSi,
                        principalTable: "BacSi",
                        principalColumn: "Id_BacSi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Benhvien_co_chitietbenhvien",
                        column: x => x.Id_BenhVien,
                        principalTable: "BenhVien",
                        principalColumn: "Id_BenhVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YeuCau",
                columns: table => new
                {
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false),
                    ThoiGianYeuCau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KetQua = table.Column<bool>(type: "bit", nullable: false),
                    FileKetQua = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeuCau", x => new { x.Id_BacSi, x.Id_BenhVien });
                    table.ForeignKey(
                        name: "bacsi_yeucau",
                        column: x => x.Id_BacSi,
                        principalTable: "BacSi",
                        principalColumn: "Id_BacSi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "yeuccau_benhvien",
                        column: x => x.Id_BenhVien,
                        principalTable: "BenhVien",
                        principalColumn: "Id_BenhVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuKienHienMau",
                columns: table => new
                {
                    Id_SuKien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false),
                    Id_DiaChi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuKienHienMau", x => x.Id_SuKien);
                    table.ForeignKey(
                        name: "BacSi_Tochuc_Sukienhienmaus",
                        columns: x => new { x.Id_BenhVien, x.Id_BacSi },
                        principalTable: "ChiTietBenhVien",
                        principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Diachi_cua_sukienhienmau",
                        column: x => x.Id_DiaChi,
                        principalTable: "DiaChi",
                        principalColumn: "Id_DC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietYeuCau",
                columns: table => new
                {
                    Id_LoaiMau = table.Column<int>(type: "int", nullable: false),
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false),
                    TongTheTich = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietYeuCau", x => new { x.Id_LoaiMau, x.Id_BacSi, x.Id_BenhVien });
                    table.ForeignKey(
                        name: "LoaiMau_NamTrong_ChiTietYeuCau",
                        column: x => x.Id_LoaiMau,
                        principalTable: "LoaiMau",
                        principalColumn: "Id_LoaiMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "YeuCau_Co_ChiTietYeuCau",
                        columns: x => new { x.Id_BacSi, x.Id_BenhVien },
                        principalTable: "YeuCau",
                        principalColumns: new[] { "Id_BacSi", "Id_BenhVien" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSuKien",
                columns: table => new
                {
                    Id_NguoiHienMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_SuKien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSuKien", x => new { x.Id_NguoiHienMau, x.Id_SuKien });
                    table.ForeignKey(
                        name: "NguoiHienMau_thamgia_Sukien",
                        column: x => x.Id_NguoiHienMau,
                        principalTable: "NguoiHienMau",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "SuKienHienMau_Co_ChiTietSuKien",
                        column: x => x.Id_SuKien,
                        principalTable: "SuKienHienMau",
                        principalColumn: "Id_SuKien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KetQuaXetNghiem",
                columns: table => new
                {
                    Id_NguoiHienMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_SuKien = table.Column<int>(type: "int", nullable: false),
                    Id_BacSi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien = table.Column<int>(type: "int", nullable: false),
                    Id_LoaiMau = table.Column<int>(type: "int", nullable: false),
                    Id_LoaiXetNghiem = table.Column<int>(type: "int", nullable: false),
                    FileKetQua = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KetQuaHienMau = table.Column<bool>(type: "bit", nullable: false),
                    TheTich = table.Column<float>(type: "real", nullable: false),
                    DaHienMau = table.Column<bool>(type: "bit", nullable: false),
                    ThoiGianTraKetQua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianHienMau = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KetQuaXetNghiem", x => new { x.Id_NguoiHienMau, x.Id_SuKien, x.Id_BacSi, x.Id_BenhVien, x.Id_LoaiMau, x.Id_LoaiXetNghiem });
                    table.ForeignKey(
                        name: "ChiTietBenhVien_KetQuaXetNghiem",
                        columns: x => new { x.Id_BenhVien, x.Id_BacSi },
                        principalTable: "ChiTietBenhVien",
                        principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ChiTietSuKien_KetQuaXetNghiem",
                        columns: x => new { x.Id_NguoiHienMau, x.Id_SuKien },
                        principalTable: "ChiTietSuKien",
                        principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "LoaiMau_KetQuaXetNGhiem",
                        column: x => x.Id_LoaiMau,
                        principalTable: "LoaiMau",
                        principalColumn: "Id_LoaiMau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "LoaiXetNghiem_KetQuaXetNGhiem",
                        column: x => x.Id_LoaiXetNghiem,
                        principalTable: "LoaiXetNghiem",
                        principalColumn: "ID_LoaiXetNghiem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSuDung",
                columns: table => new
                {
                    Id_NguoiHienMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_SuKien = table.Column<int>(type: "int", nullable: false),
                    Id_LoaiMau = table.Column<int>(type: "int", nullable: false),
                    Id_BacSi_Nhap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien_Nhap = table.Column<int>(type: "int", nullable: false),
                    Id_LoaiXetNghiem = table.Column<int>(type: "int", nullable: false),
                    Id_BacSi_Dung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_BenhVien_Dung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSuDung", x => new { x.Id_BacSi_Nhap, x.Id_BenhVien_Dung, x.Id_BacSi_Dung, x.Id_LoaiMau, x.Id_LoaiXetNghiem, x.Id_BenhVien_Nhap, x.Id_SuKien, x.Id_NguoiHienMau });
                    table.ForeignKey(
                        name: "BacSiCuaBenhVien_SuDung",
                        columns: x => new { x.Id_BenhVien_Dung, x.Id_BacSi_Dung },
                        principalTable: "ChiTietBenhVien",
                        principalColumns: new[] { "Id_BenhVien", "Id_BacSi" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung",
                        columns: x => new { x.Id_NguoiHienMau, x.Id_SuKien, x.Id_BacSi_Nhap, x.Id_BenhVien_Nhap, x.Id_LoaiMau, x.Id_LoaiXetNghiem },
                        principalTable: "KetQuaXetNghiem",
                        principalColumns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi", "Id_BenhVien", "Id_LoaiMau", "Id_LoaiXetNghiem" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BacSi_Sdt",
                table: "BacSi",
                column: "Sdt",
                unique: true,
                filter: "[Sdt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BacSi_Username",
                table: "BacSi",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBenhVien_Id_BacSi",
                table: "ChiTietBenhVien",
                column: "Id_BacSi");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSuDung_Id_BenhVien_Dung_Id_BacSi_Dung",
                table: "ChiTietSuDung",
                columns: new[] { "Id_BenhVien_Dung", "Id_BacSi_Dung" });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSuDung_Id_NguoiHienMau_Id_SuKien_Id_BacSi_Nhap_Id_BenhVien_Nhap_Id_LoaiMau_Id_LoaiXetNghiem",
                table: "ChiTietSuDung",
                columns: new[] { "Id_NguoiHienMau", "Id_SuKien", "Id_BacSi_Nhap", "Id_BenhVien_Nhap", "Id_LoaiMau", "Id_LoaiXetNghiem" });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSuKien_Id_SuKien",
                table: "ChiTietSuKien",
                column: "Id_SuKien");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietYeuCau_Id_BacSi_Id_BenhVien",
                table: "ChiTietYeuCau",
                columns: new[] { "Id_BacSi", "Id_BenhVien" });

            migrationBuilder.CreateIndex(
                name: "IX_KetQuaXetNghiem_Id_BenhVien_Id_BacSi",
                table: "KetQuaXetNghiem",
                columns: new[] { "Id_BenhVien", "Id_BacSi" });

            migrationBuilder.CreateIndex(
                name: "IX_KetQuaXetNghiem_Id_LoaiMau",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiMau");

            migrationBuilder.CreateIndex(
                name: "IX_KetQuaXetNghiem_Id_LoaiXetNghiem",
                table: "KetQuaXetNghiem",
                column: "Id_LoaiXetNghiem");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiHienMau_Sdt",
                table: "NguoiHienMau",
                column: "Sdt",
                unique: true,
                filter: "[Sdt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiHienMau_Username",
                table: "NguoiHienMau",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SuKienHienMau_Id_BenhVien_Id_BacSi",
                table: "SuKienHienMau",
                columns: new[] { "Id_BenhVien", "Id_BacSi" });

            migrationBuilder.CreateIndex(
                name: "IX_SuKienHienMau_Id_DiaChi",
                table: "SuKienHienMau",
                column: "Id_DiaChi");

            migrationBuilder.CreateIndex(
                name: "IX_YeuCau_Id_BenhVien",
                table: "YeuCau",
                column: "Id_BenhVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietSuDung");

            migrationBuilder.DropTable(
                name: "ChiTietYeuCau");

            migrationBuilder.DropTable(
                name: "KetQuaXetNghiem");

            migrationBuilder.DropTable(
                name: "YeuCau");

            migrationBuilder.DropTable(
                name: "ChiTietSuKien");

            migrationBuilder.DropTable(
                name: "LoaiMau");

            migrationBuilder.DropTable(
                name: "LoaiXetNghiem");

            migrationBuilder.DropTable(
                name: "NguoiHienMau");

            migrationBuilder.DropTable(
                name: "SuKienHienMau");

            migrationBuilder.DropTable(
                name: "ChiTietBenhVien");

            migrationBuilder.DropTable(
                name: "DiaChi");

            migrationBuilder.DropTable(
                name: "BacSi");

            migrationBuilder.DropTable(
                name: "BenhVien");
        }
    }
}
