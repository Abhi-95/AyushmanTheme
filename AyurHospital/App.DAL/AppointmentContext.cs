using App.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DAL
{
 	public class AppointmentContext:DbContext
	{
		private readonly IConfiguration _config;

		public AppointmentContext(IConfiguration config, DbContextOptions<AppointmentContext> options)
			: base(options)
		{
			_config = config ?? throw new System.ArgumentNullException(nameof(config));
		}

		public DbSet<Appointment> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_config["connectionString"], options =>
			{
				options.MigrationsHistoryTable("__UsersMigrationsHistory", "Appointment");
			});
		}
	}
}
