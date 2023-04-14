using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WinFormsApp6
{
    internal class Set : DbContext
    {
        public DbSet<GameBoard> GameBoards { get; set; }
        public Set()
        {
            Database.EnsureCreated();   
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
=> options.UseSqlite(@"Data Source=Games.db");

    }
}
