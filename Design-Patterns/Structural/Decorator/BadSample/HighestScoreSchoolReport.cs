using System;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class HighestScoreSchoolReport : FouthGradeSchoolReport
	{
		private void ReportHighestScore()
		{
			Console.WriteLine("Highest Score：Chinese：75， Mathematics：78， English：80");
		}

		public override void Report()
		{
			ReportHighestScore();
			Console.WriteLine("Chinese：62， Mathematics： 65， English：63");
		}

		public override void Sign(string name)
		{
			Console.WriteLine($"Signature: {name}");
		}
	}
}
