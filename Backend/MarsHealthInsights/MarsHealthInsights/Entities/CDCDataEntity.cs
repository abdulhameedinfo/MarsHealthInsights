using Microsoft.EntityFrameworkCore;

namespace MarsHealthInsights.Entities
{
    public class CDCDataEntity
    {
        public int Id { get; set; }
        public string? SId { get; set; }
        public string? DataId { get; set; } 
        public int? Position { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public string? Meta { get; set; }
        public string? GeographyType { get; set; }
        public string? Geography { get; set; }
        public string? GroupName { get; set; }
        public string? GroupCategory { get; set; }
        public string? IndicatorName { get; set; }
        public string? IndicatorCategory { get; set; }
        public string? TimePeriod { get; set; }
        public string? Year { get; set; }
        public string? TimeType { get; set; }
        public string? Estimate { get; set; }
        public string? NinetyFivePercentCIPercent { get; set; }
        public string? SampleSize { get; set; }
        public string? SuppressionFlag { get; set; }
    }
}
         