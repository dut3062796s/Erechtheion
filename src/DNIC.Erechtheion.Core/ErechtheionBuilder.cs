using System;
using System.Data.Common;
using DNIC.Erechtheion.Core.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DNIC.Erechtheion.Core
{
	public class ErechtheionBuilder : IErechtheionBuilder
	{
		public ErechtheionBuilder(IServiceCollection services)
		{
			Services = services;
		}

		public IServiceCollection Services { get; }

		public IErechtheionConfiguration Configuration { get; private set; }

		public void UseConfiguration(IConfiguration configuration)
		{
			Configuration = new ErechtheionConfiguration(configuration);
			Services.AddSingleton(Configuration);
		}

		public void UseDbProviderFactory(DbProviderFactory dbProviderFactory)
		{
			Services.AddSingleton(dbProviderFactory);
		}
	}
}