namespace MarsHealthInsights.Repository
{
    using MarsHealthInsights.DTOs;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;

    public class DataRepository : IDataRepository
    {
        public async Task<IEnumerable<CDCDataDTO>> FetchData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await GetCDCDataDTOList(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task<IEnumerable<CDCDataDTO>> GetCDCDataDTOList(string data)
        {
            var listDTO = new List<CDCDataDTO>();
            Object jsonData = Newtonsoft.Json.Linq.JObject.Parse(data);

            // Parse the Json and return DTO's
            return listDTO;
        }
    }

}
