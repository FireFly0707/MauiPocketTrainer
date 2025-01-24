using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPocketTrainer.Data;
using MauiPocketTrainer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace MauiPocketTrainer.ViewModels
{
    public partial class WeightViewModel : ObservableObject
    {
        private readonly AppDbContext _dbContext;

        
        public ObservableCollection<Weight> Weights { get; } = new();

        [ObservableProperty]
        private string statusMessage;

        public WeightViewModel()
        {
            Database db = Database.GetInstance();
            _dbContext = db.context;
            LoadWeightsCommand = new AsyncRelayCommand(LoadWeightsAsync);
        }

        public IAsyncRelayCommand LoadWeightsCommand { get; }

        private async Task LoadWeightsAsync()
        {
            try
            {
                var weights = await _dbContext.Weights.ToListAsync();
                Weights.Clear();

                foreach (var weight in weights)
                {
                    Weights.Add(weight);
                }

                StatusMessage = $"Loaded {weights.Count} entries.";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
        }
    }
}