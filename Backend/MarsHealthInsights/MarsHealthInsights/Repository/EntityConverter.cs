using MarsHealthInsights.DTOs;
using MarsHealthInsights.Entities;

namespace MarsHealthInsights.Repository
{
    public class EntityConverter
    {
        public static CDCDataEntity ConvertCDCDTOToEntity(CDCDataDTO dto)
        {
            return new CDCDataEntity
            {
                //SId = dto.SId,
                //DataId = dto.DataId,
                //Position = dto.Position,
                //Created_at = dto.Created_at,
                //Updated_at = dto.Updated_at,
                //Meta = dto.Meta,
                GeographyType = dto.GeographyType,
                Geography = dto.Geography,
                GroupName = dto.GroupName,
                GroupCategory = dto.GroupCategory,
                IndicatorName = dto.IndicatorName,
                IndicatorCategory = dto.IndicatorCategory,
                TimePeriod = dto.TimePeriod,
                Year = dto.Year,
                TimeType = dto.TimeType,
                Estimate = dto.Estimate,
                SampleSize = dto.SampleSize,
                SuppressionFlag = dto.SuppressionFlag
            };
        }
    }
}