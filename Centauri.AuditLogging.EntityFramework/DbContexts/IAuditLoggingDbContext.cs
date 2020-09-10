using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Centauri.AuditLogging.EntityFramework.Entities;

namespace Centauri.AuditLogging.EntityFramework.DbContexts
{
    public interface IAuditLoggingDbContext<TAuditLog> where TAuditLog : AuditLog
    {
        DbSet<TAuditLog> AuditLog { get; set; }

        Task<int> SaveChangesAsync();
    }
}