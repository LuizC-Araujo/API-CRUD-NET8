namespace Person.Routes
{
    public static class PersonRouter
    {
        public static void PersonRoutes(WebApplication app)
        {
            app.MapGet("person", () => "Working...");
        }
    }
}
