using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Contexts;

public class Datacontext(DbContextOptions<Datacontext> options) : DbContext(options)
{
    public DbSet<CoursesEntity> Courses { get; set; }
    public DbSet<SubscriberEntity> Subscribers { get; set; }
    public DbSet<CategoryEntity> Categories{ get; set; }



}
