namespace MarsHealthInsights.DTOs
{
    public class CDCDataDTOtest
    {
        public string SId { get; set; }
        public string DataId { get; set; }
        public int Position { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public string Meta { get; set; }
        public string GeographyType { get; set; }
        public string Geography { get; set; }
        public string GroupName { get; set; }
        public string GroupCategory { get; set; }
        public string IndicatorName { get; set; }

        public string IndicatorCategory { get; set; }
        public string TimePeriod { get; set; }
        public string Year { get; set; }
        public string TimeType { get; set; }
        public string Estimate { get; set; }
        public string NinetyFivePercentCIPercent { get; set; }
        public string SampleSize { get; set; }
        public string SuppressionFlag { get; set; }
    }

    public class RootObject
    {
        public Meta meta { get; set; }
        public List<List<string>> data { get; set; }
    }

    public class Meta
    {
        // Define properties for meta data if needed
    }

    public class CDCDataDTO
    {
        public string GeographyType { get; set; }
        public string Geography { get; set; }
        public string GroupName { get; set; }
        public string GroupCategory { get; set; }
        public string IndicatorName { get; set; }
        public string IndicatorCategory { get; set; }
        public string TimePeriod { get; set; }
        public string Year { get; set; }
        public string TimeType { get; set; }
        public string Estimate { get; set; }
        public string CI95 { get; set; }
        public string SampleSize { get; set; }
        public string SuppressionFlag { get; set; }
    }
}
