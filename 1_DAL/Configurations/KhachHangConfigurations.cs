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
	public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
	{
		public void Configure(EntityTypeBuilder<KhachHang> builder)
		{
			builder.ToTable("KhachHang");
			builder.HasKey(x => x.ID);
			builder.Property(x => x.HovaTen).IsRequired().HasMaxLength(20);
			builder.Property(x => x.Poin);
			builder.Property(x => x.SDT).IsRequired().HasMaxLength(10);
		}
	}
}
