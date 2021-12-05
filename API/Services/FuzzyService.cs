using API.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
	public class FuzzyService : IFuzzyService
	{
		private readonly ILogger<FuzzyService> _logger;

		public FuzzyService(ILogger<FuzzyService> logger)
		{
			_logger = logger;
		}

		public void Mamdani()
		{
			_logger.LogInformation("Mamdani invoked");
		}
	}
}
