using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Menu.Domain;

namespace Menu.Application.Interfaces
{
    public interface IMenuDbContext
    {
        DbSet<Domain.Menu> Menus { get; set; }
        Task<int> SaveChangesAsync (CancellationToken cancellationToken);
    }
}
