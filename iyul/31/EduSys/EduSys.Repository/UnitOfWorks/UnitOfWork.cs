using EduSys.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Repository.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context= context;
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Commit() 
        {
            _context.SaveChanges();
        }
        //Data Source=USER\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
    }
}
