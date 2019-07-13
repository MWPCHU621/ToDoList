using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ToDoList.Authorization.Roles;
using ToDoList.Authorization.Users;
using ToDoList.MultiTenancy;

namespace ToDoList.EntityFrameworkCore
{
    public class ToDoListDbContext : AbpZeroDbContext<Tenant, Role, User, ToDoListDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            : base(options)
        {
        }
    }
}
