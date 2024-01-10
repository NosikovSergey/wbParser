namespace Nosikov.Wildberries
{
    public interface IWildberesClient
    {
        Task<WbSearchResult> SearchAsync(SearchWbParameters parameters);
    }
}