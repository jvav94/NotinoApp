using Microsoft.EntityFrameworkCore;
using NotinoAppka.Models;
using System.Collections.Generic;

namespace NotinoAppka.Data
{
	public class APIcontext : DbContext
	{
		public DbSet<NotinoModel> NotinoData { get; set; }
		public APIcontext(DbContextOptions<APIcontext> options) : base(options)
		{

		}

	}
}
