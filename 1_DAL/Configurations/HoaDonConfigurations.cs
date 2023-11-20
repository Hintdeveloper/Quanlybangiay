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
	public class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
	{
		public void Configure(EntityTypeBuilder<HoaDon> builder)
		{
			builder.ToTable("HoaDon");
			builder.HasKey(x => x.ID);
			builder.Property(x => x.Ma);
			builder.Property(x => x.NgayTao).IsRequired();
			builder.Property(x => x.NgayThanhToan).IsRequired();
			builder.Property(x => x.TrangThai);
			builder.HasOne(p => p.nhanvien).WithMany(q => q.hoadon).HasForeignKey(v => v.IDNV);
			builder.HasOne(p => p.khachhang).WithMany(q => q.hoadon).HasForeignKey(v => v.IDKH);
			builder.HasOne(p => p.hinhthucthanhtoan).WithMany(q => q.hoadon).HasForeignKey(v => v.IDHTTT);
		}
	}
}
