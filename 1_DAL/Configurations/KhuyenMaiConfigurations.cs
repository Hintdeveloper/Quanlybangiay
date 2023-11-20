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
	public class KhuyenMaiConfigurations : IEntityTypeConfiguration<KhuyenMai>
	{
		public void Configure(EntityTypeBuilder<KhuyenMai> builder)
		{
			builder.ToTable("KhuyenMai");
			builder.HasKey(x => x.ID);
			builder.Property(x => x.Ma);
			builder.Property(x => x.Ten).HasMaxLength(200);
			builder.Property(x => x.TrangThai);
			//builder.Property(x => x.GhiChu);
			builder.Property(x => x.NgayBatDau);
			builder.Property(x => x.NgayKetThuc);
			builder.Property(x => x.HinhThuc);
		}
	}
}
