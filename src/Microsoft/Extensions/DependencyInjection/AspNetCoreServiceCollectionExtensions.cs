using NetFlagr;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NetFlagrServiceCollectionExtensions
	{
		public static IServiceCollection AddNetFlagrClient(this IServiceCollection services, Action<NetFlagrConfiguration> setupAction)
		{
			services.Configure<NetFlagrConfiguration>(setupAction);
			services.AddHttpClient<NetFlagrApiClient>();
			services.AddTransient<IConstraintApiService, ConstraintApiService>();
			services.AddTransient<IDistributionApiService, DistributionApiService>();
			services.AddTransient<IEvaluationApiService, EvaluationApiService>();
			services.AddTransient<IExportApiService, ExportApiService>();
			services.AddTransient<IFlagApiService, FlagApiService>();
			services.AddTransient<IHealthApiService, HealthApiService>();
			services.AddTransient<ISegmentApiService, SegmentApiService>();
			services.AddTransient<ITagApiService, TagApiService>();
			services.AddTransient<IVariantApiService, VariantApiService>();
			return services;
		}
	}
}
