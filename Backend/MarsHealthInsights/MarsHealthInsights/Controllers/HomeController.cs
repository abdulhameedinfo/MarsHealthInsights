using MarsHealthInsights.DTOs;
using MarsHealthInsights.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarsHealthInsights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IDataRepository _dataRepository;
        private readonly IDataService _dataService;

        public HomeController(ILogger<HomeController> logger, IDataRepository dataRepository, IDataService dataService)
        {
            _logger = logger;
            _dataRepository = dataRepository;
            _dataService = dataService;
        }

        // This function can be called from the UI or we can call _dataRepository.FetchData and _dataService.StoreData from the service to fetch and store data periodically. 
        [HttpGet(Name = "FetchDataAsync")]
        public async Task FetchDataAsync()
        {
            try
            {
                // Fetching Data
                string cdcDataUrl = "https://data.cdc.gov/api/views/qz99-wyhv/rows.json?accessType=DOWNLOAD";
                IEnumerable<CDCDataDTO> cDCDataDTOs = await _dataRepository.FetchData(cdcDataUrl);


                // Storing Data
                await _dataService.StoreData(cDCDataDTOs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in fetching data" + ex.Message);
            }
        }
    }
}
