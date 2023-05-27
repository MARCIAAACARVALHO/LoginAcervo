namespace LoginAcervo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);

            // Add services to the container.

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            startup.Configure(app, app.Environment);

            app.Run();
        }
    }
}