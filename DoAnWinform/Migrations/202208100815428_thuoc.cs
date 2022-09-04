
namespace DoAnWinform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thuoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHoaDon",
                c => new
                    {
                        id = c.Int(nullable: false),
                        idHoaDon = c.Int(),
                        idThuoc = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.HoaDon", t => t.idHoaDon)
                .ForeignKey("dbo.Thuoc", t => t.idThuoc)
                .Index(t => t.idHoaDon)
                .Index(t => t.idThuoc);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NgayMua = c.DateTime(nullable: false, storeType: "date"),
                        TrangThai = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Thuoc",
                c => new
                    {
                        idThuoc = c.Int(nullable: false, identity: true),
                        TenThuoc = c.String(nullable: false, maxLength: 50),
                        LoaiThuoc = c.String(nullable: false, maxLength: 50),
                        DonViTinh = c.String(nullable: false, maxLength: 50),
                        DonGia = c.Double(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idThuoc);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        idTaiKhoan = c.Int(nullable: false, identity: true),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        TaiKhoan = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        MatKhau = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        isAdmin = c.Boolean(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idTaiKhoan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietHoaDon", "idThuoc", "dbo.Thuoc");
            DropForeignKey("dbo.ChiTietHoaDon", "idHoaDon", "dbo.HoaDon");
            DropIndex("dbo.ChiTietHoaDon", new[] { "idThuoc" });
            DropIndex("dbo.ChiTietHoaDon", new[] { "idHoaDon" });
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.Thuoc");
            DropTable("dbo.HoaDon");
            DropTable("dbo.ChiTietHoaDon");
        }
    }
}
