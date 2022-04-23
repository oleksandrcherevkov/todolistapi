using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListEF.Models;


namespace ToDoListEF.EF
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext() { }
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
        : base(options) { } 

        public DbSet<ToDoBlock> ToDoBlocks { get; set; }
    }
}
