using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
	public interface IFuzzyInferenceStagesService
	{
		void Fuzzification();
		void Aggregation();
		void Activation();
		void Accumulation();
		void Defuzzificztion();
	}
}
