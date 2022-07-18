using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HW_M4L3
{
    public sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                    context.Database.Migrate();
                    var leftJoin = (from p in context.Projects
                                    join c in context.Clients on p.ClientId equals c.ID into projectsClients
                                    from pc in projectsClients.DefaultIfEmpty()
                                    join ep in context.EmployeeProjects on p.ID equals ep.Project into projectsClientsEmployeeProjects
                                    from pcep in projectsClientsEmployeeProjects.DefaultIfEmpty()
                                    select new
                                    {
                                        ClientTitle = pc.Title,
                                        ProjectTitle = p.Name,
                                        pcep.EmployeeId
                                    }).ToList();

                    var dateDiff = context.Employees.Select(e => new
                    {
                        dateDiff = EF.Functions.DateDiffDay(e.HiredDate, DateTime.Now)
                    });
                    foreach (var item in dateDiff)
                    {
                        Console.WriteLine(item.dateDiff);
                    }

                    var projectOne = context.Projects.First(p => p.ID == 1);
                    var projectTwo = context.Projects.First(p => p.ID == 2);
                    projectOne.Name = "Smart Home";
                    projectTwo.Name = "Autopilot";
                    context.Projects.Update(projectOne);
                    context.Projects.Update(projectTwo);

                    var newEmployee = new Employee()
                    {
                        FirstName = "James",
                        LastName = "Bond",
                        HiredDate = new DateTime(2018, 5, 15),
                        DateOfBirth = new DateTime(1990, 10, 31),
                        Office = 2,
                        Title = new Title()
                        {
                            Name = "DevOps"
                        }
                    };
                    var newProject = new Project()
                    {
                        Name = "SpaceX",
                        Budget = 100M,
                        StartedDate = new DateTime(1995, 8, 10),
                        ClientId = 2
                    };
                    context.Employees.Add(newEmployee);
                    context.Projects.Add(newProject);

                    var deleteEmployee = context.Employees.First(e => e.ID == 1);
                    context.Employees.Remove(deleteEmployee);

                    var title = context.Employees
                        .GroupBy(e => e.Title.Name)
                        .Select(e => e.Key)
                        .Where(k => !EF.Functions.Like(k, "%a%"))
                        .ToList();

                    context.SaveChanges();
            }
        }
    }
}
