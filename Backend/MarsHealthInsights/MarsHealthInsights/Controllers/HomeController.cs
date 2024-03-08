using MarsHealthInsights.DTOs;
using MarsHealthInsights.Logger;
using MarsHealthInsights.Repository;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations; // Add this using statement

namespace MarsHealthInsights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ICustomLogger _logger;
        private readonly IDataRepository _dataRepository;
        private readonly IDataService _dataService;

        public HomeController(ICustomLogger logger, IDataRepository dataRepository, IDataService dataService)
        {
            _logger = logger;
            _dataRepository = dataRepository;
            _dataService = dataService;
        }

        // This function can be called from the UI or we can call _dataRepository.FetchData and _dataService.StoreData from the service to fetch and store data periodically. 
        [HttpGet(Name = "FetchDataAsync")]
        [SwaggerOperation(Summary = "Fetches and stores data from CDC API", Description = "This operation fetches data from CDC API and stores it.")]
        public async Task<ActionResult> FetchDataAsync()
        {
            try
            {
                // Fetching Data
                string cdcDataUrl = "https://data.cdc.gov/api/views/qz99-wyhv/rows.json?accessType=DOWNLOAD";
                IEnumerable<CDCDataDTO> cDCDataDTOs = await _dataRepository.FetchData(cdcDataUrl);

                // Log it
                _logger.Info("Data fetched successfully!");


                // Storing Data
                await _dataService.StoreData(new List<CDCDataDTO>());

                // Log it
                _logger.Info("Data stored successfully!");

                // Return success message
                return Ok("Data fetched and stored successfully."); 

            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in fetching and storing data: " + ex.Message);
            }
        }
    }
}
