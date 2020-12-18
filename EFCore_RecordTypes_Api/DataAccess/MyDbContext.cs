using EFCore_RecordType_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_RecordType_Api.DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
