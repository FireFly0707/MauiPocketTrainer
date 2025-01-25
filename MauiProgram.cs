using MauiPocketTrainer.Data;
using MauiPocketTrainer.Model;
using MauiPocketTrainer.ViewModels;
using MauiPocketTrainer.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace MauiPocketTrainer
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "training.db");
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Filename={dbPath}"));

            builder.Services.AddSingleton<MainPage>();
           
            builder.Services.AddSingleton<WeightViewModel>();
            builder.Services.AddSingleton<WeightPage>();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            var app = builder.Build();
            

            // Initialize the database
            InitializeDatabase(app);
            //seedData(app.Services.GetRequiredService<AppDbContext>());

            return app;
        }

        private static void InitializeDatabase(MauiApp app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                
                dbContext.Database.Migrate();
            }
        }
        private static void seedData(AppDbContext dbContext)
        {
            dbContext.Weights.Add(new Weight { Date = DateTime.Now, Value = 80.0 });
            dbContext.SaveChanges();
        }
    }
}
