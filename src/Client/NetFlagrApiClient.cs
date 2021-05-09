
namespace NetFlagr
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public class NetFlagrApiClient
    {
        public IConstraintApiService ConstraintApiService { get; }
        public IDistributionApiService DistributionApiService { get; }
        public IEvaluationApiService EvaluationApiService { get; }
        public IExportApiService ExportApiService { get; }
        public IFlagApiService FlagApiService { get; }
        public IHealthApiService HealthApiService { get; }
        public ISegmentApiService SegmentApiService { get; }
        public ITagApiService TagApiService { get; }
        public IVariantApiService VariantApiService { get; }

        public NetFlagrApiClient(NetFlagrHttpClient httpClient)
        {
            ConstraintApiService = new ConstraintApiService(httpClient);
            DistributionApiService = new DistributionApiService(httpClient);
            EvaluationApiService = new EvaluationApiService(httpClient);
            ExportApiService = new ExportApiService(httpClient);
            FlagApiService = new FlagApiService(httpClient);
            HealthApiService = new HealthApiService(httpClient);
            SegmentApiService = new SegmentApiService(httpClient);
            TagApiService = new TagApiService(httpClient);
            VariantApiService = new VariantApiService(httpClient);
        }
    }
}
