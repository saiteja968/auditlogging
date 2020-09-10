using Microsoft.Extensions.DependencyInjection;

namespace Centauri.AuditLogging.Extensions
{
    public interface IAuditLoggingBuilder
    {
        IServiceCollection Services { get; }
    }
}