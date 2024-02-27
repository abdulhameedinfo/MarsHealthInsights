using MarsHealthInsights.DTOs;

namespace MarsHealthInsights.Repository
{
    public interface IDataService
    {
        public Task StoreData(IEnumerable<CDCDataDTO> listCDCDataDTOs);
    }
}
