using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ToDoList.Configuration;
using ToDoList.Web;

namespace ToDoList.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ToDoListDbContextFactory : IDesignTimeDbContextFactory<ToDoListDbContext>
    {
        public ToDoListDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ToDoListDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ToDoListDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ToDoListConsts.ConnectionStringName));

            return new ToDoListDbContext(builder.Options);
        }
    }
}
