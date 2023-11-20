using _1_DAL.DomainMolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
	public class SanPhamChiTietConfigurations : IEntityTypeConfiguration<SanPhamChiTiet>
	{
		public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
		{
			builder.ToTable("SanPhamChiTiet");
			builder.HasKey(x => x.ID);
			builder.Property(x => x.Ma);
			builder.Property(x => x.GiaBan).IsRequired().HasMaxLength(64);
			builder.Property(x => x.GiaNhap).IsRequired().HasMaxLength(64);
			builder.Property(x => x.TrangThai).IsRequired();
			builder.Property(x => x.HinhAnh);
			builder.Property(x => x.SoLuongTon);
			builder.Property(x => x.MoTa);
			builder.HasOne(c => c.khuyenmai).WithMany(v => v.spct).HasForeignKey(p => p.IDKM);
			builder.HasOne(c => c.sanpham).WithMany(v => v.spct).HasForeignKey(p => p.IDSP);
			builder.HasOne(c => c.loaiSanPham).WithMany(v => v.spct).HasForeignKey(p => p.IDLOAI);
			builder.HasOne(c => c.mausac).WithMany(v => v.spct).HasForeignKey(p => p.IDMS);
			builder.HasOne(c => c.nhacungcap).WithMany(v => v.spct).HasForeignKey(p => p.IDNCC);
			builder.HasOne(c => c.nsx).WithMany(v => v.spct).HasForeignKey(p => p.IDNSX);
			builder.HasOne(c => c.size).WithMany(v => v.spct).HasForeignKey(p => p.IDSZ);
		}
	}
}
