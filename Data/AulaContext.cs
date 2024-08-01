using AulaDeASPNet.Models;
using Microsoft.EntityFrameworkCore;
namespace AulaDeASPNet.Data
{
    public class AulaContext : DbContext
    {
        //public AulaContext(DbContextOptions options) : base(options)
    public AulaContext(DbContextOptions<AulaContext> options) : base(options)
        {
        }
    }
}
