using Person.Data;
using Person.Models;

namespace Person.Routes
{
    public static class PersonRouter
    {
        public static void PersonRoutes(this WebApplication app)
        {
            var route = app.MapGroup("person");

            route.MapPost("",
                async (PersonRequest req, PersonContext context) =>
                {
                    var person = new Persons(req.name);
                    await context.AddAsync(person);
                    await context.SaveChangesAsync();
                });
        }
    }
}
