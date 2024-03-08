using MarsHealthInsights.DTOs;
using MarsHealthInsights.Entities;
using MarsHealthInsights.MyContext;
using System.Xml.Linq;

namespace MarsHealthInsights.Repository
{
    public class DataService: IDataService
    {
        private readonly MyDbContext _dbContext;

        public DataService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task StoreData(IEnumerable<CDCDataDTO> listCDCDataDTOs)
        {
            // Insert data

            foreach (var item in listCDCDataDTOs.ToList())
            {
                var cdcDataEntity = EntityConverter.ConvertCDCDTOToEntity(item);
                _dbContext.CDCData.Add(cdcDataEntity);

            }

            _dbContext.CDCData.Add(new CDCDataEntity() { Created_at = DateTime.Now, Estimate = "5"});
            await _dbContext.SaveChangesAsync();
        }
    }
}
