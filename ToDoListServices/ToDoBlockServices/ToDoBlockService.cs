using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListEF.EF;
using ToDoListEF.Models;

namespace ToDoListServices.ToDoBlockServices
{
    public class ToDoBlockService
    {
        private ToDoListDbContext _context;
        public ToDoBlockService(ToDoListDbContext context)
        {
            _context = context;
        }
        public IQueryable<ToDoBlock> ListBLocks()
        {
            return _context.ToDoBlocks.AsNoTracking();
        }
        public ToDoBlock CreateBlock(ToDoBlock block)
        {
            _context.Add(block);
            _context.SaveChanges();
            return block;
        }
        public int DeleteBlock(int blockId)
        {
            var entity = _context.ToDoBlocks.FirstOrDefault(x => x.Id == blockId);
            if (entity == null)
                return 0;
            _context.Remove(entity);
            return _context.SaveChanges();
        }
    }
}
