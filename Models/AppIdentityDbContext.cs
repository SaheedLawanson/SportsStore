using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models;

public class AppIdentityDbContext: IdentityDbContext {
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : base(options) {}
}