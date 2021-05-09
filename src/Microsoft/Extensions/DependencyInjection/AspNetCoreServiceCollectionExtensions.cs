using NetFlagr;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NetFlagrServiceCollectionExtensions
	{
		public static IServiceCollection AddNetFlagrClient(this IServiceCollection services, Action<NetFlagrConfiguration> setupAction)
		{
			services.Configure<NetFlagrConfiguration>(setupAction);
			services.AddHttpClient<NetFlagrHttpClient>();
			services.AddTransient<NetFlagrApiClient>();
			return services;
		}
	}
}
