using Person.Models;

namespace Person.Routes
{
    public static class PersonRouter
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet("person", () => new Persons("Luiz Araujo"));
        }
    }
}
