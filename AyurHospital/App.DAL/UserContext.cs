using App.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DAL
{
	public class UserContext:DbContext
	{
		public DbSet<User> User { get; set; }
	}
}
