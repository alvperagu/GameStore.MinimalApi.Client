using GameStore.MinimalApi.Client.Models;

namespace GameStore.MinimalApi.Client.Clients;

public class GenresClient(HttpClient httpClient)
{
    public async Task<Genre[]> GetGenresAsnyc() 
    =>await  httpClient.GetFromJsonAsync<Genre[]>("genres") ?? [];
}
