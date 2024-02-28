namespace MarsHealthInsights.Repository
{
    using MarsHealthInsights.DTOs;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class DataRepository : IDataRepository
    {
        public async Task<IEnumerable<CDCDataDTO>> FetchData(string url)
        {
            // Create HttpClient with a longer timeout
            var httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromMinutes(5) // Example: 5 minutes timeout
            };

            try
            {
                // Make the request
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response
                    string content = await response.Content.ReadAsStringAsync();

                    // Process the content as needed
                    return GetCDCDataDTOList(content);
                }
                else
                {
                    throw new Exception($"Request failed with status code {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            finally
            {
                // Dispose of the HttpClient when done
                httpClient.Dispose();
            }
        }

        // Data Transformation and Validation
        // Parse the JSON data, validate it, and transform it as needed
        public IEnumerable<CDCDataDTO> GetCDCDataDTOList(string data)
        {
            var listDTO = new List<CDCDataDTO>();


            // Parse the Json and return DTO's
            RootObject root = JsonConvert.DeserializeObject<RootObject>(data);


            List<List<string>> dataList = root.data;

            foreach (var list in dataList)
            {
                listDTO.Add(new CDCDataDTO()
                {
                    GeographyType = list[8],
                    Geography = list[9],
                    GroupName = list[10],
                    GroupCategory = list[11],
                    IndicatorName = list[12],
                    IndicatorCategory = list[13],
                    TimePeriod = list[14],
                    Year = list[15],
                    TimeType = list[16],
                    Estimate = list[17],
                    CI95 = list[18],
                    SampleSize = list[19],
                    SuppressionFlag = list[20],
                });
            }

            return listDTO;
        }
    }

}
