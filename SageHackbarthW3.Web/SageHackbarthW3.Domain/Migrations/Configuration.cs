namespace SageHackbarthW3.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SageHackbarthW3.Domain.SchoolContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SageHackbarthW3.Domain.SchoolContent context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.

			context.Students.AddOrUpdate(new Entities.Student
			{
				StudentId = Guid.Parse("afb55e42-f193-4437-907c-f44bf8cb4ded"),
				StudentName = "Henry Spencer",
				Height = 6m,
				Weight = 170f,
				DateOfBirth = new DateTime(1964, 3, 16)
			});
        }
    }
}
