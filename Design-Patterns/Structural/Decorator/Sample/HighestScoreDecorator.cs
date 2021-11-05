using System;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class HighestScoreDecorator : SchoolReportDecorator
	{
		public HighestScoreDecorator(SchoolReport report) : base(report)
		{

		}

		public override void Report()
		{
			ReportHighScore();
			base.Report();
		}

		private void ReportHighScore()
		{
			Console.WriteLine("Highest Score：Chinese：75， Mathematics：78， English：80");
		}
	}
}
