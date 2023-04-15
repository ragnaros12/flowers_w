using Asd.Models;
using Microsoft.EntityFrameworkCore;

namespace Asd
{
	public class Database: DbContext
	{
		public Database(DbContextOptions<Database> options) : base(options)
		{
			Database.EnsureCreated();
			if (Flowers.Count() == 0)
			{
				Flowers.Add(new()
				{
					Price = 100,
					Name = "asdkhasd",
					Height = 100,
					Description = "asdaq",
					Image = "images/pions.jpeg"
				});
				Flowers.Add(new()
				{
					Price = 100,
					Name = "asdkhasd",
					Height = 100,
					Description = "asdaq",
					Image = "images/pions.jpeg"
				});
				Flowers.Add(new()
				{
					Price = 100,
					Name = "asdkhasd",
					Height = 100,
					Description = "asdaq",
					Image = "images/pions.jpeg"
				});
				Flowers.Add(new()
				{
					Price = 100,
					Name = "asdkhasd",
					Height = 100,
					Description = "asdaq",
					Image = "images/pions.jpeg"
				});
				SaveChanges();
			}
		}
		public DbSet<Flower> Flowers { get; set; }
	}
}
