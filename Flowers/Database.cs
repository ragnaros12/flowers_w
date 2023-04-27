using Flowers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
	public class Database : DbContext//наследуемся от DbContext
	{
		public static Database Instance { get; } = new Database();//единственно возможный экземляр бд
		private Database()
		{
			Database.EnsureCreated(); // Обеспечиваем создание база данных
		}
		protected override void OnConfiguring(DbContextOptionsBuilder builder)//Метод для конфигурации
		{
			builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=flowers_db");//говорим используй 
			//Sql server и подключайся по строке 
		}
		public DbSet<User> Users { get; set; }// Список из наших моделей
	}
}
