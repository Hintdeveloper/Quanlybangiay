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
	public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
	{
		public void Configure(EntityTypeBuilder<NhanVien> builder)
		{
			builder.ToTable("NhanVien");
			builder.HasKey(x => x.ID);
			builder.Property(x => x.Username).IsRequired().HasMaxLength(10);
			builder.Property(x => x.HoTen).IsRequired().HasMaxLength(100);
			builder.Property(x => x.TrangThai).IsRequired();
			builder.Property(x => x.MatKhau).IsRequired().HasMaxLength(200);
			builder.Property(x => x.GioiTinh);
			builder.Property(x => x.Email);
			builder.Property(x => x.AnhNv);
			builder.Property(x => x.NgaySinh);
			builder.Property(x => x.CCCD).IsRequired();
			builder.Property(x => x.SoDienThoai).IsRequired();
			builder.Property(x => x.DiaChi).IsRequired().HasMaxLength(200);
			builder.Property(x => x.TrangThai);
			builder.Property(x => x.GhiChu).HasMaxLength(200);

			builder.HasOne(x => x.ChucVu).WithMany(x => x.nhanvien).HasForeignKey(x => x.IDCV);
		}
	}
}
