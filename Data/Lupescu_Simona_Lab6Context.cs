using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lupescu_Simona_Lab6.Models;

namespace Lupescu_Simona_Lab6.Data
{
    public class Lupescu_Simona_Lab6Context : DbContext
    {
        public Lupescu_Simona_Lab6Context (DbContextOptions<Lupescu_Simona_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Lupescu_Simona_Lab6.Models.Book> Book { get; set; }
    }
}
