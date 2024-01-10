using System.Web;
using Newtonsoft.Json;

namespace Nosikov.Wildberries;

public class WildberesClient : IWildberesClient
{
    private readonly HttpClient _httpClient;
    private readonly string _searchUrl = "https://search.wb.ru/exactmatch/ru/common/v4/search";

    public WildberesClient()
    {
        _httpClient = new HttpClient();
    }

    public async Task<WbSearchResult> SearchAsync(SearchWbParameters parameters)
    {
        var values = HttpUtility.ParseQueryString(string.Empty);

        values.Add("TestGroup", HttpUtility.UrlEncode(parameters.TestGroup));
        values.Add("TestID", HttpUtility.UrlEncode(parameters.TestId));
        values.Add("appType", parameters.AppType.ToString());
        values.Add("curr", HttpUtility.UrlEncode(parameters.Curr));
        values.Add("dest", parameters.Dest.ToString());
        values.Add("page", parameters.Page.ToString());
        values.Add("query", parameters.Query);
        values.Add("resultset", HttpUtility.UrlEncode(parameters.Resultset));
        values.Add("sort", HttpUtility.UrlEncode(parameters.Sort));
        values.Add("spp", parameters.Spp.ToString());
        values.Add("suppressSpellcheck", parameters.SuppressSpellcheck.ToString());
        values.Add("uclusters", parameters.Uclusters.ToString());


        var requestUrl = $"{_searchUrl}?{values}";

        var response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();
        var resBody = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<WbSearchResult>(resBody);
    }
}