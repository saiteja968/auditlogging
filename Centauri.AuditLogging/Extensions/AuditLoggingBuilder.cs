using Microsoft.Extensions.DependencyInjection;
using Centauri.AuditLogging.EntityFramework.Extensions;

namespace Centauri.AuditLogging.Extensions
{
    public class AuditLoggingBuilder : IAuditLoggingBuilder
    {
        public AuditLoggingBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}