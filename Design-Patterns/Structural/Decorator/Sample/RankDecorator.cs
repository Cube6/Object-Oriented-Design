using System;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class RankDecorator : SchoolReportDecorator
	{
		public RankDecorator(SchoolReport report) : base(report)
		{

		}

		public override void Report()
		{
			ReportSort();
			base.Report();
		}

		private void ReportSort()
		{
			Console.WriteLine("My Ranking: 35");
		}
	}
}
