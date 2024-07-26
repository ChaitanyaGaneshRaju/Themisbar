using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Reports;

namespace API.Factories
{
	public class PerformanceReportFactory
	{
		public void getReport(string type)
		{
			switch (type)
			{
				case "completion": // 
					// var performanceReport = new PerformanceReport();
					// performanceReport.getQueryBuilder();
					break;
				case "mcq_set_results": // 
					break;
				case "pe_results": // 
					break;
				case "graded_essay_results": // 
					break;
				case "mbe_performance": // 
					break;
				default: //
					break;
			};
		}
	}
}