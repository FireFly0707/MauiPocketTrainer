using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPocketTrainer.Data
{
    public class Database
    {
        public AppDbContext context;
        private static Database _instance;
        private static readonly object _lock = new object();

        private Database(AppDbContext context)
        {
            this.context = context;
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Database((AppDbContext)Application.Current!.Handler.MauiContext.Services.GetService(typeof(AppDbContext)));
                    }
                }
            }
            return _instance;
        }
    }
}
