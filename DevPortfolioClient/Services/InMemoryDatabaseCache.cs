using DevPortfolioClient.Static;
using DevPortfolioShared.Models;
using System.Net.Http.Json;

namespace DevPortfolioClient.Services
{
    internal sealed class InMemoryDatabaseCache
    {
        private readonly HttpClient _httpClient;

        public InMemoryDatabaseCache(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private List<Category>? _categories = null;
        internal List<Category>? Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
                NotifyCategoriesDataChanged();
            }
        }

        private bool _gettingCategoriesFromDatabaseAndCaching = false;
        internal async Task GetCategoriesFromDatabaseAndCache()
        {
            // Only allow one Get request to run at a time.
            if (_gettingCategoriesFromDatabaseAndCaching == false)
            {
                _gettingCategoriesFromDatabaseAndCaching = true;
                if(_httpClient != null)
                {
                    var result = await _httpClient.GetFromJsonAsync<List<Category>>(APIEndpoints.s_categories);
                    if (result != null)
                    {
                        _categories = result;
                    }
                }
                
                _gettingCategoriesFromDatabaseAndCaching = false;
            }
            return;
        }

        internal event Action OnCategoriesDataChanged;
        private void NotifyCategoriesDataChanged() => OnCategoriesDataChanged?.Invoke();
    }
}
